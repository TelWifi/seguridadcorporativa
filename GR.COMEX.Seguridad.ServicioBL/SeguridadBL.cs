using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using ErickOrlando.Utilidades.Data;
using GR.COMEX.Seguridad.Entidades;
using Gromero.Seguridad;
using Gromero.Seguridad.Datos;
using Gromero.Seguridad.Login;
using Gromero.Seguridad.Negocio.SoloLectura;
using Gromero.Seguridad.Negocio.SoloLectura.Dominios;
using Csla;
//using Gromero.Seguridad.WinForms.HelperWin;
using Gromero.Seguridad.Entidades;
using Gromero.Seguridad.WinForms.HelperWin;
using System.Configuration;
using Gromero.Seguridad.WinForms;
using Gromero.Seguridad.Negocio.Editables;

namespace GR.COMEX.Seguridad.ServicioBL
{

    public class SeguridadBL
    {

        #region Login de Usuarios

        public static bool CerrarSesion(string IdUsuario)
        {
            return true;
        }

        public static bool CambiarClave(RequestCambioClave request)
        {
            return true;
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

            //SI SE HA SOLICITADO CONTRASEÑA, SE VALIDA LA CONTRASEÑA ANTIGUA
            if (request.TipoCambioClave == TipoCambioClave.Ui)
            {
                ResponseLoginUsuario responseLogin = Login(new RequestLogin
                                                   {
                                                       CodigoUsuario = request.CodigoUsuario,
                                                       Clave = request.ClaveAntigua,
                                                       Dominio = request.Dominio,
                                                       AcronimoAplicacion = request.Acronimo
                                                   });

                if (responseLogin.ResultadoLogin == false)
                    throw new Exception("La contraseña es incorrecta.");
            }
            SimpleInteroperableEncryption publicCrypter = new SimpleInteroperableEncryption();

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
            
            string codigoUsuario = "";
            string correo = "";
            string nombres = "";

            // VALIDAR SI EL USUARIO EXISTE
            using (var contexto = new SeguridadEntities())
            {
                var query = (from c in contexto.Usuarios
                             where c.CodigoUsuario == request.CodigoUsuario
                                && c.Estado == true
                             select c);

                if (!query.Any())
                    throw new Exception(string.Format("No se pudo encontrar el usuario {0}", request.CodigoUsuario));

                
                codigoUsuario = query.First().CodigoUsuario;
                correo = query.First().Correo;
                nombres = string.Format("{0} {1} {2}", query.First().Nombres, query.First().ApellidoPaterno, query.First().ApellidoMaterno);
            }
            
            try
            {
                //ESTA LINEA VALIDA SI EL USUARIO TIENE CLAVE REGISTRADA
                bool r = GRPrincipal.Load(codigoUsuario, request.Dominio);
            }
            catch (DataPortalException ex)
            {
                if (ex.BusinessException != null)
                { 
                    if (ex.BusinessException.GetType() == typeof(UsuarioSinClaveException))
                    {   //SI LA EXCEPCION ES USUARIOSINCLAVE SE LE CREA UNA CLAVE
                        ActivarUsuario activarUsuario = ActivarUsuario.GetActivarUsuario(new FiltroUsuarios { Usuario = codigoUsuario, Dominio = request.Dominio });
                        activarUsuario.PreguntaSecreta = activarUsuario.RespuestaSecreta = codigoUsuario;
                        activarUsuario.ClaveSecreta = activarUsuario.ConfirmarClave = request.ClaveNueva;

                        activarUsuario.Save();
                    }
                }
            }

            // OBTENEMOS LOS DATOS
            CambiarClave cambiarClave = Gromero.Seguridad.Entidades.CambiarClave.GetCambiarClave(new FiltroUsuarios { Usuario = codigoUsuario, Dominio = request.Dominio });
            cambiarClave.ClaveNueva = cambiarClave.ConfirmarClave = request.ClaveNueva;
            cambiarClave.RespuestaSecreta = cambiarClave.SecretAnswer;
            cambiarClave.Save(false);

            response.Correo = correo;
            response.Nombres = nombres;
            response.CodigoUsuario = codigoUsuario;

            return response;
        }
        
      
        public static ResponseLoginUsuario LoginInterno(RequestLogin request, Boolean validarContraseña)
        {
            var response = new ResponseLoginUsuario();
            try
            {
                var cryptocon = new SimpleInteroperableEncryption();
                if (String.IsNullOrEmpty(request.Clave))
                    request.Clave = "";
                else
                    request.Clave = cryptocon.Decrypt(request.Clave);

                //Comprobamos que el Nombre de Usuario contiene un Dominio
                var infoUser = Publicos.ComprobarDominioEnUsuario(request.CodigoUsuario);
                //Guardamos en el GlobalContext el valor que se reciba del Acrónimo
                Csla.ApplicationContext.GlobalContext["Acronimo"] = request.AcronimoAplicacion;
                var dominio = string.IsNullOrEmpty(request.Dominio) ? infoUser.Dominio : request.Dominio;
                if (string.IsNullOrEmpty(request.Dominio))
                    throw new InvalidOperationException("El dominio es obligatorio.");

                //switch (dominio)
                //{
                //    case "GRUPORANSA":
                //        infoUser.Dominio = "gruporansa.gromero.net";
                //        break;
                //    case "GRUPOCOGESA":
                //        infoUser.Dominio = "grupocogesa.gromero.net";
                //        break;
                //    case "TRAMARSA":
                //        infoUser.Dominio = "tramarsa.com.pe";
                //        break;
                //    case "ALICORP":
                //        infoUser.Dominio = "grupoalicorp.gromero.net";
                //        break;
                //    default:
                //        throw new InvalidOperationException("El dominio no es válido.");
                //    //infoUser.Dominio = "grupocogesa.gromero.net";
                //    //break;
                //}
                var result = false;

                if (validarContraseña)
                {
                    if (string.IsNullOrEmpty(request.Clave) || string.IsNullOrEmpty(request.CodigoUsuario))
                        throw new InvalidOperationException("El usuario y clave son obligatorios.");
                }
                if (string.IsNullOrEmpty(request.AcronimoAplicacion))
                    throw new InvalidOperationException("El acrónimo es obligatorio.");

                //Comprobamos primero el tipo de Usuario
                if (GRPrincipal.Load(infoUser.Usuario, infoUser.Dominio))
                {
                    InfoUsuario.Initialize();
                    if (InfoUsuario.Instancia.Tipo)
                    {
                        //Si el usuario interno ya ha sido validado previamente
                        //y la Clave está en blanco, no es necesario loguearlo
                        if (string.IsNullOrEmpty(request.Clave))
                            result = true;
                        else
                            result = GRPrincipal.Login(infoUser.Usuario, request.Clave, request.Dominio);
                    }
                    else
                        result = GRPrincipal.Login(infoUser.Usuario, GRCrypto.Encriptar(request.Clave));
                }
                else
                    throw new InvalidOperationException("El usuario no está inscrito para este Sistema");

                if (!result)
                    throw new SecurityException("El usuario o clave no son válidos!");

                response.ResultadoLogin = result;
                response.IdPerfilUsuario = InfoUsuario.Instancia.IdPerfilUsuario;

            }
            catch (DataPortalException ex)
            {
                response.MensajeError = ex.BusinessException.Message;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null)
                    msg = ex.InnerException.Message;
                response.MensajeError = msg;
            }

            return response;
        }

        public static ResponseLoginUsuario Login(RequestLogin request)
        {
            return LoginInterno(request, true);
        }
        
        public static ResponseLoginUsuario LoginApp(RequestLogin request)
        {
            return LoginInterno(request, false);
        }

        #endregion

        #region Información del Usuario

        public static ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuariosByCodigo(RequestInfoBasicaUsuarioDTO request)
        {
            var response = new ResponseInfoBasicaUsuarioDTO();
            var listaUsuarios = new List<ResponseListaUsuarios>();

            using (var contexto = new SeguridadEntities())
            {
                var query = contexto.Usuarios
                    .Where(u => request.CodigosUsuario.Contains(u.CodigoUsuario))
                    .Select(u =>
                        new
                        {
                            IdUsuario = u.IdUsuario,
                            CodigoUsuario = u.CodigoUsuario,
                            Correo = u.Correo,
                            DNI = u.DNI,
                            Nombres = u.Nombres,
                            ApellidoPaterno = u.ApellidoPaterno,
                            ApellidoMaterno = u.ApellidoMaterno
                        });

                foreach (var item in query)
                {
                    listaUsuarios.Add(new ResponseListaUsuarios
                    {
                        IdUsuario = item.IdUsuario,
                        CodigoUsuario = item.CodigoUsuario,
                        Correo = item.Correo,
                        DNI = item.DNI,
                        NombresCompletos = string.Format("{0} {1} {2}",
                            item.Nombres, item.ApellidoPaterno, item.ApellidoMaterno)
                    });
                }

                response.ListaInfoBasicaUsuarios = listaUsuarios.ToList().AsEnumerable();
            }

            return response;
        }

        public static ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuarios(RequestInfoBasicaUsuarioDTO request)
        {
            var response = new ResponseInfoBasicaUsuarioDTO();
            var listaUsuarios = new List<ResponseListaUsuarios>();

            using (var contexto = new SeguridadEntities())
            {
                var query = contexto.Usuarios
                    .Where(u => request.CodigosUsuario.Contains(u.IdUsuario))
                    .Select(u =>
                        new
                        {
                            IdUsuario = u.IdUsuario,
                            CodigoUsuario = u.CodigoUsuario,
                            Correo = u.Correo,
                            DNI = u.DNI,
                            Nombres = u.Nombres,
                            ApellidoPaterno = u.ApellidoPaterno,
                            ApellidoMaterno = u.ApellidoMaterno
                        });

                foreach (var item in query)
                {
                    listaUsuarios.Add(new ResponseListaUsuarios
                    {
                        IdUsuario = item.IdUsuario,
                        CodigoUsuario = item.CodigoUsuario,
                        Correo = item.Correo,
                        DNI = item.DNI,
                        NombresCompletos = string.Format("{0} {1} {2}",
                            item.Nombres, item.ApellidoPaterno, item.ApellidoMaterno)
                    });
                }

                response.ListaInfoBasicaUsuarios = listaUsuarios.ToList().AsEnumerable();
            }

            return response;
        }

        public static string GetNombreUsuarioByCodigoUsuario(string request)
        {
            var resultado = string.Empty;
            using (var contexto = new SeguridadEntities())
            {
                var query = (from c in contexto.Usuarios
                             where c.Correo == request
                             select c).ToList();

                foreach (var item in query)
                {
                    resultado = string.Format("{0} {1} {2}",
                                    item.Nombres,
                                    item.ApellidoPaterno,
                                    item.ApellidoMaterno);
                }
            }

            return resultado;
        }

        public static string GetNombreUsuario(string request)
        {
            var resultado = string.Empty;
            using (var contexto = new SeguridadEntities())
            {

                var query = contexto.SelectUsuario(request);

                foreach (var item in query)
                {
                    resultado = string.Format("{0} {1} {2}",
                                    item.Nombres,
                                    item.ApellidoPaterno,
                                    item.ApellidoMaterno);
                }
            }

            return resultado;
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

                var dominios = DominioInfoList.GetDominioInfoList();

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
                result.Sociedades = new List<ResponseSociedadSAP>();
                result.Negocios = new List<ResponseNegocioSAP>();
                result.Sedes = new List<ResponseSedeSAP>();
                result.RecursosAdicionales = new List<ResponseRecursoAdicional>();

                foreach (var recurso in perfilNegocio.Recursos)
                {
                    if (recurso.Conceder)
                        switch (recurso.RecursoPadre)
                        {
                            case "Sociedades":
                                result.Sociedades.Add(new ResponseSociedadSAP
                                {
                                    Codigo = recurso.Codigo,
                                    Descripcion = recurso.Descripcion
                                });
                                break;
                            case "Negocios":
                                result.Negocios.Add(new ResponseNegocioSAP
                                {
                                    Codigo = recurso.Codigo,
                                    Descripcion = recurso.Descripcion
                                });
                                break;
                            case "Sedes":
                                result.Sedes.Add(new ResponseSedeSAP
                                {
                                    Codigo = recurso.Codigo,
                                    Descripcion = recurso.Descripcion
                                });
                                break;
                            default:
                                result.RecursosAdicionales.Add(new ResponseRecursoAdicional
                                {
                                    Codigo = recurso.Codigo,
                                    Descripcion = recurso.Descripcion
                                });
                                break;
                        }
                }
                #endregion
            }
            return result;
        }


        public static ResponseUsuarioInsert  InsertUsuario(RequestDTOUsuarioInsert request)
        {
            ResponseUsuarioInsert result = new ResponseUsuarioInsert();
            var perfil = Gromero.Seguridad.Negocio.Editables.PerfilUsuario.NewPerfilUsuario();
            var usuario = Usuario.NewUsuario();

            try
            {
            if (String.IsNullOrEmpty(request.Codigo))
                return result;

            


            //Creacion de nuevo usuario


            usuario.IdEmpresa = request.IdEmpresa;
            usuario.IdEmpresaPertenencia = request.IdEmpresaPertenencia;
            usuario.IdCargoSociedad = request.IdCargo;
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
            usuario.Save();

            




            //Recuperando usuario creado
            FiltroCriteria crit = new FiltroCriteria { NombreCampo = "Codigo", ValorBusqueda = request.Codigo };
            var listaUsuarios = UsuarioInfoList.GetUsuarioInfoList(crit);
            var usuarioCreado = listaUsuarios.Where(x => x.Dominio ==
                request.Dominio).SingleOrDefault();

            //Estableciendo variables de entorno
            Csla.ApplicationContext.GlobalContext["Placa"] = Environment.MachineName;
            Csla.ApplicationContext.GlobalContext["Usuario"] = Environment.UserName;

                

            //Creacion de perfil

            perfil.IdAplicacion = request.IdAplicacion;
            perfil.IdUsuario = usuarioCreado.ID;

            perfil.Usuario = usuarioCreado.Nombres;
            perfil.Aplicacion = request.Aplicacion;
            perfil.Caduca = request.Caduca;
            perfil.VigenciaInicio = DateTime.Now;
            perfil.VigenciaFin = DateTime.Now.AddYears(1);

            //Asignando rol
            var rolPerfil = perfil.RolesPerfiles.AddNew();

            rolPerfil.IdRol = request.IdRol;
            rolPerfil.IdAplicacion = request.IdAplicacion;

            //Agregando permisos
            rolPerfil.AgregarPermisos();

            //Estableciendo recursos
            var recursosList = RecursosInfoList.GetRecursosInfoList();


            foreach (var recurso in request.ListaRecursos)
            {
                string recursoact = recurso.Substring(0, recurso.IndexOf(":")).Trim();
                string[] recursodetalle = recurso.Substring(recurso.IndexOf(":")+1).Trim().Split(',');

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

            perfil.Save();

            string Clave = "";

            if (usuario.Tipo == "E")
            {

                //Creacion de contraseña
                Clave = GenerarContrasenia();
                //Hay que intentar el Login para identificar si se debe crear la contraseña.

                try
                {
                    Csla.ApplicationContext.GlobalContext["Acronimo"] = request.Aplicacion;

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

                        activacion.PreguntaSecreta = request.PreguntaSecreta;
                        activacion.RespuestaSecreta = request.RespuestaSecreta;
                        activacion.ClaveSecreta = Clave;
                        activacion.ConfirmarClave = Clave;

                        activacion.Save();
                    }
                }
            }
            result.IdUsuario = usuarioCreado.ID;
            result.Clave = Clave;
            result.Codigo = request.Codigo;
            result.Alias = request.Alias;
            result.MensajeError = "";

            }
            catch (DataPortalException ex)
            {
                result.MensajeError = ex.BusinessException.Message;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null)
                    msg = ex.InnerException.Message;
                result.MensajeError = msg;
            }
            return result;


        }

        public static List<ResponseUsuarioInsert> InsertUsuarios(List<RequestDTOUsuarioInsert> lstRequest)
        {
            ResponseUsuarioInsert result;
            List<ResponseUsuarioInsert> lstResult = new List<ResponseUsuarioInsert>() ;

            foreach (var request in lstRequest)
            {
                result = new ResponseUsuarioInsert();
                try
                {
                
                var perfil = Gromero.Seguridad.Negocio.Editables.PerfilUsuario.NewPerfilUsuario();
                var usuario = Usuario.NewUsuario();

                //Creacion de nuevo usuario


                usuario.IdEmpresa = request.IdEmpresa;
                usuario.IdEmpresaPertenencia = request.IdEmpresaPertenencia;
                usuario.IdCargoSociedad = request.IdCargo;
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
                usuario.Save();

                //Recuperando usuario creado
                FiltroCriteria crit = new FiltroCriteria { NombreCampo = "Codigo", ValorBusqueda = request.Codigo };
                var listaUsuarios = UsuarioInfoList.GetUsuarioInfoList(crit);
                var usuarioCreado = listaUsuarios.Where(x => x.Dominio ==
                    request.Dominio).SingleOrDefault();

                //Estableciendo variables de entorno
                Csla.ApplicationContext.GlobalContext["Placa"] = Environment.MachineName;
                Csla.ApplicationContext.GlobalContext["Usuario"] = Environment.UserName;

                //Creacion de perfil

                perfil.IdAplicacion = request.IdAplicacion;
                perfil.IdUsuario = usuarioCreado.ID;

                perfil.Usuario = usuarioCreado.Nombres;
                perfil.Aplicacion = request.Aplicacion;
                perfil.Caduca = false;
                perfil.VigenciaInicio = DateTime.Now;
                perfil.VigenciaFin = DateTime.Now.AddYears(1);

                //Asignando rol
                var rolPerfil = perfil.RolesPerfiles.AddNew();

                rolPerfil.IdRol = request.IdRol;
                rolPerfil.IdAplicacion = request.IdAplicacion;

                //Agregando permisos
                rolPerfil.AgregarPermisos();

                //Estableciendo recursos
                var recursosList = RecursosInfoList.GetRecursosInfoList();


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

                perfil.Save();

                string Clave = "";
                
                if (usuario.Tipo == "E")
                {

                    //Creacion de contraseña
                    Clave = GenerarContrasenia();
                    //Hay que intentar el Login para identificar si se debe crear la contraseña.

                    try
                    {
                        Csla.ApplicationContext.GlobalContext["Acronimo"] = request.Aplicacion;

                        GRPrincipal.Load(usuario.Codigo, usuario.Dominio);

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

                            activacion.PreguntaSecreta = request.PreguntaSecreta;
                            activacion.RespuestaSecreta = request.RespuestaSecreta;
                            activacion.ClaveSecreta = Clave;
                            activacion.ConfirmarClave = Clave;

                            activacion.Save();
                        }
                    }
                }
                result.IdUsuario = usuarioCreado.ID;
                result.Clave = Clave;
                result.Codigo = request.Codigo;
                result.Alias = request.Alias;
                result.MensajeError = "";
                }
                catch (DataPortalException ex)
                {
                    result.MensajeError = request.Alias + " :" + ex.BusinessException.Message;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    if (ex.InnerException != null)
                        msg = ex.InnerException.Message;
                    result.MensajeError = request.Alias+" :"+ msg;
                }

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
        public static IEnumerable<ResponseListaUsuarios> ListarUsuarios(RequestListarUsuario request)
        {

            using (var contexto = new SeguridadEntities())
            {
                var resultado = new List<ResponseListaUsuarios>();
                var query = contexto.SelectAllUsuarios();

                foreach (var item in query)
                {
                    resultado.Add(new ResponseListaUsuarios
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

        //public static IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargo(RequestDTOUsuarioPorCargo request)
        //{
        //    var resultado = new List<ResponseUsuarioCargo>();
        //    using (var ctx = new SeguridadEntities())
        //    {
        //        var query = ctx.SelectAllUsuarios();
        //        foreach (var item in query)
        //        {
        //            foreach (var codCargo in request.CodigosCargo)
        //            {
        //                if (item.Cargo == codCargo)
        //                    resultado.Add(new ResponseUsuarioCargo
        //                    {
        //                        CodigoUsuario = item.CodigoUsuario,
        //                        IdUsuario = item.IdUsuario,
        //                        NombresCompletos = string.Format("{0} {1} {2}",
        //                            item.Nombres, item.ApellidoPaterno, item.ApellidoMaterno),
        //                        CorreoUsuario = item.Correo
        //                    });
        //            }

        //        }

        //    }
        //    return resultado;
        //}

        //public static IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargo(RequestDTOUsuarioPorCargo request)
        //{

        //    var resultado = new List<ResponseUsuarioCargo>();
        //    using (var ctx = new SeguridadEntities())
        //    {
        //        var query = ctx.SelectListarUsuariosCOMEX(request.CodigoUsuario, request.Nombre, request.DNI, request.Dominio,
        //            request.Sociedad, request.Acronimo, request.TipoUsuario);


        //        foreach (var item in query.ToList())
        //        {
        //            bool tieneSede = false;

        //            if (!string.IsNullOrEmpty(request.Sede))
        //            {
        //                string perfilUsuarioId = ctx.SelectObtenerPerfilUsuarioComex(item.CodigoUsuario, item.Dominio, request.Acronimo).FirstOrDefault();

        //                RequestInfoUsuario requestInfoUsuario = new RequestInfoUsuario();
        //                requestInfoUsuario.IdPerfilUsuario = perfilUsuarioId;

        //                List<ResponseSedeSAP> sedes = ListarSedes(requestInfoUsuario).ToList();

        //                foreach (ResponseSedeSAP sede in sedes)
        //                {
        //                    if (sede.Codigo.ToString().Trim() == request.Sede.ToString().Trim())
        //                    {
        //                        tieneSede = true;
        //                        break;
        //                    }
        //                }

        //                if (tieneSede)
        //                {
        //                    foreach (var codCargo in request.CodigosCargo)
        //                    {
        //                        if (item.CodigoCargo == codCargo)
        //                            resultado.Add(new ResponseUsuarioCargo
        //                            {
        //                                CodigoUsuario = item.CodigoUsuario,
        //                                IdUsuario = item.IdUsuario,
        //                                NombresCompletos = item.NombresCompletos.Split('(')[0].Trim(),
        //                                CorreoUsuario = item.Correo,
        //                                DNI = item.DNI
        //                            });
        //                    }
        //                }

        //            }
        //            else
        //            {
        //                if (!string.IsNullOrEmpty(request.CodigosCargo.ToString()))
        //                {
        //                    foreach (var codCargo in request.CodigosCargo)
        //                    {
        //                        if (item.CodigoCargo == codCargo)
        //                            resultado.Add(new ResponseUsuarioCargo
        //                            {
        //                                CodigoUsuario = item.CodigoUsuario,
        //                                IdUsuario = item.IdUsuario,
        //                                NombresCompletos = item.NombresCompletos.Split('(')[0].Trim(),
        //                                CorreoUsuario = item.Correo,
        //                                DNI = item.DNI

        //                            });
        //                    }
        //                }
        //            }



        //        }

        //    }
        //    return resultado;
        //}

        #endregion

        #region Listas

        public static IEnumerable<ResponseCargo> ListarCargoPorSociedad(RequestListaCargo request)
        {
            var response = new List<ResponseCargo>();
            using (var contexto = new SeguridadEntities())
            {
                var query = contexto.SelectCargoSociedadBySociedad(request.CodSociedadPropietaria);
                foreach (var item in query)
                {
                    response.Add(new ResponseCargo
                    {
                        Codigo = item.CodigoCargo,
                        Descripcion = item.Descripcion
                    });
                }
            }
            return response;
        }

        public static IEnumerable<ResponseSociedadSAP> ListarSociedades(RequestInfoUsuario request)
        {
            var response = new List<ResponseSociedadSAP>();
            var perfilNegocio = PerfilUsuarioInfoList.GetPerfilUsuarioInfoList(
                   new FiltroCriteria
                   {
                       NombreCampo = "IdPerfilUsuario",
                       ValorBusqueda = request.IdPerfilUsuario
                   }).FirstOrDefault();

            foreach (var recurso in perfilNegocio.Recursos)
            {
                if (recurso.Conceder && recurso.RecursoPadre == "Sociedades")
                {
                    response.Add(new ResponseSociedadSAP
                    {
                        Codigo = recurso.Codigo,
                        Descripcion = recurso.Descripcion
                    });
                }
            }

            return response;
        }

        public static IEnumerable<ResponseNegocioSAP> ListarNegocios(RequestInfoUsuario request)
        {
            var response = new List<ResponseNegocioSAP>();
            var perfilNegocio = PerfilUsuarioInfoList.GetPerfilUsuarioInfoList(
                   new FiltroCriteria
                   {
                       NombreCampo = "IdPerfilUsuario",
                       ValorBusqueda = request.IdPerfilUsuario
                   }).FirstOrDefault();
            foreach (var recurso in perfilNegocio.Recursos)
            {
                if (recurso.Conceder && recurso.RecursoPadre == "Negocios")
                {
                    response.Add(new ResponseNegocioSAP
                    {
                        Codigo = recurso.Codigo,
                        Descripcion = recurso.Descripcion
                    });
                }
            }

            return response;
        }

        public static IEnumerable<ResponseSedeSAP> ListarSedes(RequestInfoUsuario request)
        {
            var response = new List<ResponseSedeSAP>();
            var perfilNegocio = PerfilUsuarioInfoList.GetPerfilUsuarioInfoList(
                   new FiltroCriteria
                   {
                       NombreCampo = "IdPerfilUsuario",
                       ValorBusqueda = request.IdPerfilUsuario
                   }).FirstOrDefault();
            foreach (var recurso in perfilNegocio.Recursos)
            {
                if (recurso.Conceder && recurso.RecursoPadre == "Sedes")
                {
                    response.Add(new ResponseSedeSAP
                    {
                        Codigo = recurso.Codigo,
                        Descripcion = recurso.Descripcion
                    });
                }
            }

            return response;
        }

        #endregion

        #region Metodos Privados

        public static string insert(ResponseOpcionUI respuestaPermiso, List<ResponseOpcionUI> response)
        {
            //response.Add(respuestaPermiso);         
            return null;
        }

        public static List<string> getPermisos(List<ResponseOpcionUI> menu)
        {
            List<string> permisos = new List<string>();
            List<ResponseOpcionUI> res = (from xx in menu where xx.Codigo != "" select xx).ToList();
            foreach (var item in res)
            {
                if (item.Codigo != "")
                    permisos.Add(item.Codigo);
                if (item.Opciones != null && item.Opciones.Count > 0)
                {
                    permisos.AddRange(getPermisos(item.Opciones));
                }
            }
            return permisos;
        }

        public static string InsertNivel(List<ResponseOpcionUI> response, ResponseOpcionUI opcion, int count1, int count2, int nivel)
        {
            if (nivel == 1)
                response[count1].Opciones.Add(opcion);
            else
                if (nivel == 2)
                    response[count1].Opciones[count2].Opciones.Add(opcion);
            return null;
        }

        public static IEnumerable<ResponseOpcionUI> ListarOpciones(PerfilUsuarioInfo perfilNegocio, IEnumerable<string> roles)
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

        private static void AgregarOpcionesAnidadas(ResponseOpcionUI respuestaPermiso, IEnumerable<Gromero.Seguridad.Negocio.Editables.Permiso> lista)
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


        public static string GenerarContrasenia()
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

        
        #endregion

    }
}
