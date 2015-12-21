using Csla;
using Csla.Rules;
using ErickOrlando.Seguridad;
using ErickOrlando.Seguridad.Datos;
using ErickOrlando.Seguridad.Entidades;
using ErickOrlando.Seguridad.Login;
using ErickOrlando.Seguridad.Negocio.Editables;
using ErickOrlando.Seguridad.Negocio.SoloLectura;
using ErickOrlando.Seguridad.Negocio.SoloLectura.Dominios;
using ErickOrlando.Utilidades.Data;
using Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Seguridad.ServicioBL
{

    public class SeguridadBL
    {

        #region Login de Usuarios

        public static bool CerrarSesion(RequestInfoUsuario request)
        {
            using (var context = new SeguridadEntities())
            {
                var perfilUsuario = (from perf in context.PerfilUsuario
                                     where perf.IdPerfilUsuario == request.IdPerfilUsuario
                                     select perf).SingleOrDefault();
                if (perfilUsuario != null)
                {
                    perfilUsuario.Logueado = false;
                }
                var result = context.SaveChanges();

                return (result > 0);
            }
        }

        private static Result ValidacionCambiarClaveWeb(RequestCambioClave request)
        {
            try
            {
                switch (request.TipoCambioClave)
                {
                    case TipoCambioClave.Sys:
                        break;

                    case TipoCambioClave.Ui:

                        if (string.IsNullOrEmpty(request.ClaveAntigua) || string.IsNullOrEmpty(request.ClaveNueva) || string.IsNullOrEmpty(request.ClaveNuevaConfirmada))
                            throw new Exception("La contraseña no puede estar vacia.");

                        if (request.ClaveNueva != request.ClaveNuevaConfirmada)
                            throw new Exception("Contraseña nueva no coincide.");

                        break;
                }

                return new Result { Success = true };
            }
            catch (Exception ex)
            {
                return new Result { Success = false, Message = ex.Message };

            }

        }

        /// <summary>
        /// Cambia la contraseña de un usuario externo, si el campo es vacio se crea una contraseña, de lo contrario registra al constraseña enviada.
        /// </summary>
        /// <param name="request">Constraseña a registrar</param>
        /// <returns>Contraseña generada</returns>
        public static ResponseCambioClave CambiarClaveWeb(RequestCambioClave request)
        {
            ResponseCambioClave response = new ResponseCambioClave();
            var publicCrypter = new SimpleInteroperableEncryption();

            var info = GetInfoBasicaUsuariosByCodigo(new RequestInfoBasicaUsuarioDTO
            {
                CodigoUsuario = request.CodigoUsuario,
                Dominio = request.Dominio
            });

            if (!info.Resultado.Success)
                throw new InvalidOperationException("El usuario no existe!");

            if (info.InfoBasica.Tipo != "E")
                throw new InvalidOperationException("Sólo los usuarios externos pueden cambiar su contraseña");

            //SI SE HA SOLICITADO CONTRASEÑA, SE VALIDA LA CONTRASEÑA ANTIGUA
            if (request.TipoCambioClave == TipoCambioClave.Ui)
            {

                // Comprobamos si el campo de Respuesta Secreta se encuentra lleno para validar 
                // que el usuario se olvidó se contraseña y posteriormente hacer el cambio.
                if (string.IsNullOrEmpty(request.RespuestaSecreta))
                {
                    ResponseLoginUsuario responseLogin = Login(new RequestLogin
                    {
                        CodigoUsuario = request.CodigoUsuario,
                        Clave = publicCrypter.Decrypt(request.ClaveAntigua),
                        Dominio = request.Dominio,
                        AcronimoAplicacion = request.Acronimo
                    });

                    if (!responseLogin.Resultado.Success)
                        throw new Exception("La contraseña es incorrecta.");
                }
                else
                {
                    // Comprobamos que la respuesta a la pregunta Secreta sea válida.
                    using (var ctx = new SeguridadEntities())
                    {
                        var clave = (from clav in ctx.Claves
                                     where clav.IdUsuario == info.InfoBasica.IdUsuario
                                     && clav.Ultimo
                                     select new { RespuestaSecreta = clav.Respuesta }).FirstOrDefault();
                        if (clave != null)
                        {
                            if (clave.RespuestaSecreta != GRCrypto.Encriptar(request.RespuestaSecreta))
                                throw new SecurityException("La respuesta secreta no coincide!");
                        }
                    }
                }
            }

            // En caso sea un reseteo de clave
            if (request.TipoCambioClave == TipoCambioClave.Sys)
                request.ClaveAntigua = request.ClaveNuevaConfirmada = request.ClaveNueva = publicCrypter.Decrypt(request.ClaveNueva);
            else
            {
                //DESENCRIPTAR LA CONTRASENIA
                request.ClaveAntigua = publicCrypter.Decrypt(request.ClaveAntigua);
                request.ClaveNueva = publicCrypter.Decrypt(request.ClaveNueva);
                request.ClaveNuevaConfirmada = publicCrypter.Decrypt(request.ClaveNuevaConfirmada);
            }

            Result result = ValidacionCambiarClaveWeb(request);
            if (result.Success == false)
                throw new Exception(result.Message);

            bool primeraClave = false;
            try
            {
                //Validamos si tiene Clave registrada.
                GRPrincipal.Load(request.CodigoUsuario, request.Dominio);
            }
            catch (DataPortalException ex)
            {
                if (ex.BusinessException != null)
                {
                    if (ex.BusinessException.GetType() == typeof(UsuarioSinClaveException))
                    {   //SI LA EXCEPCION ES USUARIOSINCLAVE SE LE CREA UNA CLAVE
                        ActivarUsuario activarUsuario = ActivarUsuario.GetActivarUsuario(new FiltroUsuarios
                        { Usuario = request.CodigoUsuario, Dominio = request.Dominio });

                        activarUsuario.PreguntaSecreta = activarUsuario.RespuestaSecreta = request.CodigoUsuario;
                        activarUsuario.ClaveSecreta = activarUsuario.ConfirmarClave = request.ClaveNueva;

                        activarUsuario.Save();
                        primeraClave = true;
                    }
                }
            }

            if (!primeraClave)
            {
                var cambiarClave = CambiarClave.GetCambiarClave(new FiltroUsuarios
                { Usuario = request.CodigoUsuario, Dominio = request.Dominio });
                cambiarClave.ClaveNueva = cambiarClave.ConfirmarClave = request.ClaveNueva;
                cambiarClave.RespuestaSecreta = string.IsNullOrEmpty(request.RespuestaSecreta)
                        ? cambiarClave.SecretAnswer : request.RespuestaSecreta;
                CambiarClave.ByPassClave = true;
                cambiarClave.Save();
            }

            response.Correo = info.InfoBasica.Correo;
            response.Nombres = info.InfoBasica.NombresCompletos;
            response.CodigoUsuario = request.CodigoUsuario;

            return response;
        }

        public static ResponseLoginUsuario Login(RequestLogin request)
        {
            var response = new ResponseLoginUsuario();
            try
            {
                if (string.IsNullOrEmpty(request.Clave) || string.IsNullOrEmpty(request.CodigoUsuario))
                    throw new InvalidOperationException("El usuario y clave son obligatorios.");
                if (string.IsNullOrEmpty(request.AcronimoAplicacion))
                    throw new InvalidOperationException("El acrónimo es obligatorio.");

                // Desencriptamos el mensaje recibido.
                var cryptocon = new SimpleInteroperableEncryption();
                request.Clave = cryptocon.Decrypt(request.Clave);

                //Comprobamos que el Nombre de Usuario contiene un Dominio
                var infoUser = new UserDomain { Usuario = request.CodigoUsuario, Dominio = request.Dominio };
                //Guardamos en el GlobalContext el valor que se reciba del Acrónimo
                Csla.ApplicationContext.GlobalContext["Acronimo"] = request.AcronimoAplicacion;
                if (string.IsNullOrEmpty(request.Dominio))
                    throw new InvalidOperationException("El dominio es obligatorio.");

                var result = false;

                //Comprobamos primero el tipo de Usuario
                if (GRPrincipal.Load(infoUser.Usuario, infoUser.Dominio))
                {
                    InfoUsuario.Initialize();
                    if (InfoUsuario.Instancia.Tipo) // Si es interno
                        result = GRPrincipal.Login(infoUser.Usuario, request.Clave, request.Dominio);
                    else // Si es externo
                        result = GRPrincipal.Login(infoUser.Usuario, GRCrypto.Encriptar(request.Clave));
                }
                else
                    throw new InvalidOperationException("El usuario no está inscrito para este Sistema");

                if (!result)
                    throw new SecurityException("El usuario o clave no son válidos!");

                response.Resultado.Success = result;
                response.IdPerfilUsuario = InfoUsuario.Instancia.IdPerfilUsuario;

            }
            catch (DataPortalException ex)
            {
                response.Resultado.Message = ex.BusinessException.Message;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null)
                    msg = ex.InnerException.Message;
                response.Resultado.Message = msg;
            }

            return response;
        }

        #endregion

        #region Información del Usuario

        public static ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuariosByCodigo(RequestInfoBasicaUsuarioDTO request)
        {
            var response = new ResponseInfoBasicaUsuarioDTO();
            using (var ctx = new SeguridadEntities())
            {
                var query = ReturnInfoUsuario(ctx)
                    .Where(u => u.CodigoUsuario == request.CodigoUsuario
                    && u.Dominio == request.Dominio);
                response.InfoBasica = query.FirstOrDefault();
                response.Resultado.Success = (response.InfoBasica != null);
            }

            return response;
        }

        public static ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuarios(RequestInfoBasicaUsuarioDTO request)
        {
            var response = new ResponseInfoBasicaUsuarioDTO();

            using (var ctx = new SeguridadEntities())
            {
                var query = ReturnInfoUsuario(ctx).Where(u => u.IdUsuario == request.CodigoUsuario);

                response.InfoBasica = query.FirstOrDefault();
                response.Resultado.Success = (response.InfoBasica != null);
            }

            return response;
        }

        public static ResponseInfoUsuarioDTO GetInfoUsuario(RequestInfoUsuario request)
        {
            ResponseInfoUsuarioDTO result = new ResponseInfoUsuarioDTO();
            if (String.IsNullOrEmpty(request.IdPerfilUsuario))
                return result;

            using (var contexto = new SeguridadEntities())
            {
                var perfilNegocio = PerfilUsuarioInfoList.GetPerfilUsuarioInfoList(
                    new FiltroCriteria
                    {
                        NombreCampo = "IdPerfilUsuario",
                        ValorBusqueda = request.IdPerfilUsuario
                    }).FirstOrDefault();

                var dominios = ErickOrlando.Seguridad.Entidades.DominioInfoList.GetDominioInfoList();

                foreach (var dominio in dominios)
                {
                    if (dominio.NombreLargo == perfilNegocio.Dominio)
                        perfilNegocio.Dominio = dominio.NombreCorto;
                }

                #region Informacion Basica
                result.IdUsuario = perfilNegocio.IdUsuario;
                result.CodigoUsuario = string.Format(@"{0}\{1}",
                    perfilNegocio.Dominio, perfilNegocio.CodigoUsuario);
                result.NombresCompletos = perfilNegocio.NombresCompletos;
                result.Dominio = perfilNegocio.Dominio;
                result.Correo = perfilNegocio.Correo;
                result.CodigoCargo = perfilNegocio.CodigoCargo;
                result.Cargo = perfilNegocio.Cargo;
                result.Alias = perfilNegocio.Alias;
                result.TipoUsuario = perfilNegocio.TipoUsuario;

                #endregion

                #region Roles del PerfilUsuario
                result.Roles = new List<ResponseRoles>();

                foreach (var rolPerfil in perfilNegocio.Roles)
                {
                    result.Roles.Add(new ResponseRoles
                    {
                        IdRol = rolPerfil.IdRol,
                        Codigo = rolPerfil.CodigoRol,
                        Descripcion = rolPerfil.NombreRol
                    });
                }
                #endregion

                #region OpcionesUI
                result.OpcionesUI = ListarOpciones(perfilNegocio,
                     result.Roles.Select(r => r.IdRol).ToList()).ToList();
                #endregion

                #region Recursos
                result.RecursosAdicionales = new List<ResponseRecursoAdicional>();

                foreach (var recurso in perfilNegocio.Recursos)
                {
                    if (recurso.Conceder)

                        result.RecursosAdicionales.Add(new ResponseRecursoAdicional
                        {
                            Codigo = recurso.Codigo,
                            Descripcion = recurso.Descripcion
                        });
                }
                #endregion
            }
            return result;
        }

        public static ResponseUsuarioInsert InsertUsuario(RequestDTOUsuarioInsert request)
        {
            ResponseUsuarioInsert result = new ResponseUsuarioInsert();
            var perfil = ErickOrlando.Seguridad.Negocio.Editables.PerfilUsuario.NewPerfilUsuario();
            var usuario = Usuario.NewUsuario();

            try
            {
                if (String.IsNullOrEmpty(request.Codigo))
                    return result;


                string IdAplicacion = string.Empty;
                string IdEmpresa = string.Empty;
                string IdEmpresaPertenencia = string.Empty;
                string IdRol = string.Empty;
                string IdCargo = string.Empty;

                using (var ctx = new SeguridadEntities())
                {
                    // Buscamos el ID de la Aplicacion.
                    IdAplicacion = (from app in ctx.Aplicaciones
                                    where app.Acronimo == request.Acronimo
                                    select app.IdAplicacion).SingleOrDefault();

                    if (string.IsNullOrEmpty(IdAplicacion))
                        throw new ApplicationException(string.Format("La Aplicación {0} no existe!", request.Acronimo));

                    // Buscamos el ID de la Empresa.
                    IdEmpresa = (from emp in ctx.Empresas
                                 where emp.RUC == request.RUCEmpresa
                                 select emp.IdEmpresa).SingleOrDefault();

                    if (string.IsNullOrEmpty(IdEmpresa))
                        throw new ApplicationException(string.Format("La Empresa con el RUC {0} no existe!", request.RUCEmpresa));

                    if (request.RUCEmpresa != request.RUCEmpresaPertenencia)
                    {
                        // Buscamos el ID de la Empresa Pertenencia.
                        IdEmpresaPertenencia = (from emp in ctx.Empresas
                                                where emp.RUC == request.RUCEmpresaPertenencia
                                                select emp.IdEmpresa).SingleOrDefault();

                        if (string.IsNullOrEmpty(IdEmpresaPertenencia))
                            throw new ApplicationException(string.Format("La Empresa con el RUC {0} no existe!", request.RUCEmpresaPertenencia));

                    }
                    else
                        IdEmpresaPertenencia = IdEmpresa;

                    // Buscamos el ID del Rol.
                    IdRol = (from roles in ctx.Roles
                             where roles.IdAplicacion == IdAplicacion
                             && roles.NombreRol == request.Rol
                             select roles.IdRol).SingleOrDefault();

                    if (string.IsNullOrEmpty(IdRol))
                        throw new ApplicationException(string.Format("No se encuentra el Rol {0}", request.Rol));

                    // Buscamos el ID del Cargo.
                    IdCargo = (from cargo in ctx.Cargo
                               where cargo.Descripcion == request.Cargo
                               select cargo.IdCargo).SingleOrDefault();

                    if (string.IsNullOrEmpty(IdCargo))
                        throw new ApplicationException(string.Format("No se encuentra el cargo {0}", request.Cargo));


                    ctx.Database.Connection.Close();
                }

                //Creacion de nuevo usuario
                usuario.IdEmpresa = IdEmpresa;
                usuario.IdEmpresaPertenencia = IdEmpresaPertenencia;
                usuario.IdCargo = IdCargo;
                usuario.Nombres = request.Nombres;
                usuario.Alias = request.Alias;
                usuario.Dominio = request.Dominio;
                usuario.ApellidoMaterno = request.ApellidoMaterno;
                usuario.ApellidoPaterno = request.ApellidoPaterno;
                usuario.Codigo = request.Codigo;
                usuario.Correo = request.Correo;
                usuario.DNI = request.DNI;
                usuario.Estado = true;
                usuario.NotificarConCorreo = request.NotificacionConCorreo;
                usuario.Tipo = request.Tipo;
                usuario = usuario.Save();


                //Recuperando usuario creado
                var usuarioCreado = usuario;

                //Estableciendo variables de entorno
                Csla.ApplicationContext.GlobalContext["Placa"] = Environment.MachineName;
                Csla.ApplicationContext.GlobalContext["Usuario"] = Environment.UserName;



                //Creacion de perfil


                perfil.IdAplicacion = IdAplicacion;
                perfil.IdUsuario = usuarioCreado.Id;
                perfil.Usuario = usuarioCreado.Nombres;
                perfil.Aplicacion = IdAplicacion;
                perfil.Caduca = request.Caduca;
                perfil.VigenciaInicio = DateTime.Now;
                perfil.VigenciaFin = DateTime.Now.AddYears(1);

                //Asignando rol
                var rolPerfil = perfil.RolesPerfiles.AddNew();

                rolPerfil.IdRol = IdRol;
                rolPerfil.IdAplicacion = IdAplicacion;

                //Agregando permisos
                rolPerfil.AgregarPermisos();

                //Estableciendo recursos
                var recursosList = RecursosInfoList.GetRecursosInfoList();

                if (request.ListaRecursos != null)
                {
                    foreach (var recurso in request.ListaRecursos)
                    {
                        string recursoact = recurso.Substring(0, recurso.IndexOf(":")).Trim();
                        string[] recursodetalle = recurso.Substring(recurso.IndexOf(":") + 1).Trim().Split(',');

                        foreach (var itemrecurso in recursosList.Where(x => x.Descripcion == recursoact))
                        {
                            var recursodetalles = from p in itemrecurso.Detalles
                                                  where recursodetalle.Contains(p.Descripcion)
                                                  select p;

                            foreach (var itemrecursodetalle in recursodetalles)
                            {
                                var recursoitem = perfil.Recursos.AddNew();
                                recursoitem.Conceder = true;
                                recursoitem.IdRecursoDetalle = itemrecursodetalle.ID;
                                perfil.Recursos.Add(recursoitem);
                            }
                        }

                    }
                }

                perfil.Save();

                string Clave = string.Empty;

                if (usuario.Tipo == "E")
                {

                    //Creacion de contraseña
                    if (String.IsNullOrEmpty(request.Clave))
                        Clave = GenerarClaveAleatoria();
                    else
                    {
                        var crypto = new SimpleInteroperableEncryption();
                        Clave = crypto.Decrypt(request.Clave);
                    }
                    //Hay que intentar el Login para identificar si se debe crear la contraseña.

                    try
                    {
                        Csla.ApplicationContext.GlobalContext["Acronimo"] = request.Acronimo;

                        GRPrincipal.Load(usuario.Codigo, usuario.Dominio);

                        //GRPrincipal.Login(usuario.Codigo, GRCrypto.Encriptar( "clave"));
                    }
                    catch (DataPortalException ex)
                    {
                        if (ex.BusinessException.GetType() == typeof(UsuarioNoActivoException)
                           || ex.BusinessException.GetType() == typeof(UsuarioSinClaveException))
                        {
                            var activacion = ActivarUsuario.GetActivarUsuario(new FiltroUsuarios
                            {
                                Usuario = usuario.Codigo,
                                Dominio = usuario.Dominio
                            });

                            activacion.NombreUsuario = request.Codigo;
                            activacion.PreguntaSecreta = request.PreguntaSecreta;
                            activacion.RespuestaSecreta = request.RespuestaSecreta;
                            activacion.ClaveSecreta = Clave;
                            activacion.ConfirmarClave = Clave;

                            try
                            {
                                activacion.Save();
                            }
                            catch (ValidationException)
                            {
                                throw new InvalidOperationException(activacion.BrokenRulesCollection.ToString());
                            }
                        }
                    }
                }
                result.IdUsuario = usuarioCreado.Id;
                result.Clave = (string.IsNullOrEmpty(request.Clave)) ? Clave : string.Empty;
                result.Codigo = request.Codigo;
                result.Alias = request.Alias;
                result.Resultado.Success = true;
                result.Resultado.Message = string.Empty;

            }
            catch (ValidationException)
            {
                var msg1 = usuario.BrokenRulesCollection.ToString();
                var msg2 = perfil.BrokenRulesCollection.ToString();
                if (string.IsNullOrEmpty(msg1))
                    result.Resultado.Message = msg2;
                else if (string.IsNullOrEmpty(msg2))
                    result.Resultado.Message = msg1;
                else
                    result.Resultado.Message = string.Format("{0} {1}", msg1, msg2);
            }
            catch (DataPortalException ex)
            {
                result.Resultado.Message = ex.BusinessException.Message;
                if (ex.BusinessException.InnerException != null)
                {
                    result.Resultado.Messages.Add(new Result { Message = ex.BusinessException.InnerException.Message });
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null)
                    msg = ex.InnerException.Message;
                result.Resultado.Message = msg;
            }
            return result;


        }

        public static List<ResponseUsuarioInsert> InsertUsuarios(List<RequestDTOUsuarioInsert> lstRequest)
        {
            ResponseUsuarioInsert result;
            List<ResponseUsuarioInsert> lstResult = new List<ResponseUsuarioInsert>();

            foreach (var request in lstRequest)
            {
                result = InsertUsuario(request);

                lstResult.Add(result);
            }

            return lstResult;

        }


        #endregion

        #region Consulta de Perfiles
        public static bool ConsultarPermisos(RequestConsultaPermiso request)
        {
            return true;
        }
        #endregion

        #region Listas de Usuario
        public static IEnumerable<ResponseInfoUsuarios> ListarUsuarios(RequestListarUsuario request)
        {

            using (var contexto = new SeguridadEntities())
            {
                var resultado = new List<ResponseInfoUsuarios>();
                var query = contexto.SelectAllUsuarios();

                foreach (var item in query)
                {
                    resultado.Add(new ResponseInfoUsuarios
                    {
                        IdUsuario = item.IdUsuario,
                        CodigoUsuario = item.CodigoUsuario,
                        DNI = item.DNI,
                        NombresCompletos = string.Format("{0} {1} {2}", item.Nombres, item.ApellidoPaterno, item.ApellidoMaterno),
                        Correo = item.Correo,
                        CodigoCargo = item.Cargo,
                        Cargo = item.Cargo
                    });
                }

                return resultado;
            }
        }

        public static IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargo(RequestDTOUsuarioPorCargo request)
        {
            var resultado = new List<ResponseUsuarioCargo>();
            using (var ctx = new SeguridadEntities())
            {
                var query = ctx.SelectAllUsuarios();
                foreach (var item in query)
                {
                    foreach (var codCargo in request.CodigosCargo)
                    {
                        if (item.Cargo == codCargo)
                            resultado.Add(new ResponseUsuarioCargo
                            {
                                CodigoUsuario = item.CodigoUsuario,
                                IdUsuario = item.IdUsuario,
                                NombresCompletos = string.Format("{0} {1} {2}",
                                    item.Nombres, item.ApellidoPaterno, item.ApellidoMaterno),
                                CorreoUsuario = item.Correo
                            });
                    }

                }

            }
            return resultado;
        }

        #endregion

        #region Metodos Privados

        private static List<string> GetPermisos(List<ResponseOpcionUI> menu)
        {
            List<string> permisos = new List<string>();
            List<ResponseOpcionUI> res = (from xx in menu where xx.Codigo != string.Empty select xx).ToList();
            foreach (var item in res)
            {
                if (item.Codigo != string.Empty)
                    permisos.Add(item.Codigo);
                if (item.Opciones != null && item.Opciones.Count > 0)
                {
                    permisos.AddRange(GetPermisos(item.Opciones));
                }
            }
            return permisos;
        }

        private static IEnumerable<ResponseOpcionUI> ListarOpciones(PerfilUsuarioInfo perfilNegocio, IEnumerable<string> roles)
        {
            var response = new List<ResponseOpcionUI>();
            //var lis = new List<ResponseOpcionUI>();
            //var Opcion = new ResponseOpcionUI();
            //int count1 = 0;
            //int count2 = 0;
            //List<string> ListString;

            var RolesPermisos = new List<List<ResponseOpcionUI>>();

            foreach (var rolPerfil in perfilNegocio.Roles.Where(r => roles.Contains(r.IdRol)))
            {
                var RolPerfil = new List<ResponseOpcionUI>();

                var lista = rolPerfil.Permisos.Where(p => p.Conceder.Equals(true));
                foreach (var permiso in lista.Where(p => p.Nivel == 1))
                {
                    var respuestaPermiso = new ResponseOpcionUI
                    {
                        IdOpcion = permiso.IdOpcion,
                        Codigo = permiso.Codigo,
                        Clase = permiso.Clase,
                        Tipo = permiso.Tipo,
                        Url = permiso.Url,
                        NombreControl = permiso.Opcion,
                        ControlPadre = permiso.OpcionPadre,
                        Conceder = true,
                        NumeroOrden = permiso.NroOrden
                    };
                    AgregarOpcionesAnidadas(respuestaPermiso, lista);
                    if (!RolPerfil.Contains(respuestaPermiso))
                        RolPerfil.Add(respuestaPermiso);
                    #region "Código Version Anterior"
                    //else
                    //{
                    //    count1 = 0;
                    //    foreach (var rsp in response)
                    //    {
                    //        if (rsp.NombreControl == respuestaPermiso.NombreControl)
                    //        {
                    //            foreach (var nivel1 in respuestaPermiso.Opciones)
                    //            {
                    //                if (!rsp.Opciones.Contains(nivel1))
                    //                {
                    //                    Opcion = nivel1;
                    //                    InsertNivel(response, Opcion, count1, count2, 1);                                       
                    //                }

                    //                count2 = 0;
                    //                foreach (var nivel2 in respuestaPermiso.Opciones[count1].Opciones)
                    //                {
                    //                    if (!rsp.Opciones[count2].Opciones[count2].Codigo.Contains(nivel2.Codigo))
                    //                    {
                    //                        Opcion = nivel2;
                    //                        InsertNivel(response, Opcion, count1, count2, 2);
                    //                    }
                    //                }
                    //                count2++;
                    //            }
                    //        }
                    //        count1++;
                    //    }
                    //}



                    //lis = response;

                    //AgregarOpcionesAnidadas(respuestaPermiso, lista);
                    //if (!response.Contains(respuestaPermiso))
                    //{
                    //    response.Add(respuestaPermiso);
                    //    lis.Add(respuestaPermiso);
                    //}
                    //else
                    //{

                    //    int nivel1 = 0;
                    //    foreach (var rsp in response)
                    //    {
                    //        if (rsp.NombreControl == respuestaPermiso.NombreControl)
                    //        {
                    //            foreach (var op in rsp.Opciones)
                    //            {

                    //                if (respuestaPermiso.Opciones.Count > 0)
                    //                {

                    //                    foreach (var RspOp in respuestaPermiso.Opciones)
                    //                    {
                    //                        if (!op.IdOpcion.Contains(RspOp.IdOpcion))
                    //                        {
                    //                            var clonado = RspOp.cl;

                    //                            lis[nivel1].Opciones.Add(clonado);

                    //                            //rsp.Opciones.Add(respuestaPermiso.Opciones[count]);
                    //                            break;
                    //                        }
                    //                    }
                    //                }
                    //            }
                    //        }


                    //        nivel1 += 1;
                    //    }
                    //}
                    #endregion

                }

                RolesPermisos.Add(RolPerfil);
            }

            var ultimorol = RolesPermisos[0];
            for (int i = 1; i < RolesPermisos.Count; i++)
            {
                ultimorol = MergePermisos(ultimorol, RolesPermisos[i]);
            }

            response.AddRange(ultimorol);

            //ListString = getPermisos(response);

            return response;
        }

        private static List<ResponseOpcionUI> MergePermisos(List<ResponseOpcionUI> l1, List<ResponseOpcionUI> l2)
        {
            if (l1 == null && l2 == null)
                return null;
            else
            {
                if (l1 == null)
                    return l2;
                if (l2 == null)
                    return l1;
            }

            List<ResponseOpcionUI> primero = l1;
            List<ResponseOpcionUI> segundo = l2;
            if (l2.Count > l1.Count)
            {
                primero = l2;
                segundo = l1;
            }
            //falta validar si alguno de ellos es null o no tiene hijos
            foreach (var item in segundo)
            {
                //si no existe, agrego todo el arbol
                if (primero.Where(x => x.Codigo == item.Codigo).Count() == 0)
                {
                    primero.Add(item);
                }//si ya existe entonces hago el merge
                else
                {
                    var objprimero = primero.Find(p => p.Codigo == item.Codigo);
                    objprimero.Opciones = MergePermisos(objprimero.Opciones, item.Opciones);
                }
            }
            return primero;
        }

        private static void AgregarOpcionesAnidadas(ResponseOpcionUI respuestaPermiso, IEnumerable<ErickOrlando.Seguridad.Negocio.Editables.Permiso> lista)
        {
            //Filtramos los ítems de esta opcion
            var listaFiltrada = lista.Where(l => l.IdOpcionPadre == respuestaPermiso.IdOpcion);
            foreach (var permiso in listaFiltrada)
            {
                var permisoOpcion = new ResponseOpcionUI
                {
                    IdOpcion = permiso.IdOpcion,
                    Codigo = permiso.Codigo,
                    NombreControl = permiso.Opcion,
                    ControlPadre = permiso.OpcionPadre,
                    Tipo = permiso.Tipo,
                    Clase = permiso.Clase,
                    Url = permiso.Url,
                    Conceder = true,
                    NumeroOrden = permiso.NroOrden
                };
                AgregarOpcionesAnidadas(permisoOpcion, lista);
                if (!respuestaPermiso.Opciones.Contains(permisoOpcion))
                    respuestaPermiso.Opciones.Add(permisoOpcion);
            }
        }

        private static string GenerarClaveAleatoria()
        {
            string generado = string.Empty;

            Random r = new Random((int)DateTime.Now.Ticks);

            while (generado.Length < 8)
            {
                int numero = r.Next(48, 57);
                int mayus = r.Next(65, 90);
                int minus = r.Next(97, 122);

                if (numero % 2 == 0)
                    generado += string.Format("{0}", (char)numero);

                if (mayus % 2 != 0)
                    generado += string.Format("{0}", (char)mayus);

                if (minus % 2 != 0)
                    generado += string.Format("{0}", (char)minus);
            }
            return generado;
        }

        private static IQueryable<ResponseInfoUsuarios> ReturnInfoUsuario(SeguridadEntities contexto)
        {
            var query = from u in contexto.Usuarios
                        join c in contexto.Claves on u.IdUsuario equals c.IdUsuario into gp
                        from userexterno in gp.DefaultIfEmpty()
                        join cargo in contexto.Cargo on u.IdCargo equals cargo.IdCargo
                        where userexterno.Ultimo == true
                        select new ResponseInfoUsuarios
                        {
                            IdUsuario = u.IdUsuario,
                            CodigoCargo = cargo.CodigoCargo,
                            Cargo = cargo.Descripcion,
                            CodigoUsuario = u.CodigoUsuario,
                            Correo = u.Correo,
                            Tipo = u.Tipo,
                            DNI = u.DNI,
                            NombresCompletos = u.Nombres + " " + u.ApellidoPaterno + " " + u.ApellidoMaterno,
                            Dominio = u.Dominio,
                            PreguntaSecreta = (userexterno == null) ? string.Empty : userexterno.Pregunta,
                        };
            return query;
        }


        #endregion

    }
}
