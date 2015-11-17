using System;
using System.Collections.Generic;
using System.Linq;
using GR.COMEX.Seguridad.Entidades;
using GR.COMEX.Seguridad.ServicioBL;

namespace GR.COMEX.Seguridad.ServicioWCF
{
    public class SeguridadGR : ISeguridadGR
    {

        public bool CambiarClave(RequestCambioClave request)
        {
            return SeguridadBL.CambiarClave(request);
        }

        public ResponseCambioClave CambiarClaveWeb(RequestCambioClave request)
        {
            ResponseCambioClave response = new ResponseCambioClave();
            try
            {
                response = SeguridadBL.CambiarClaveWeb(request);
                response.Result = new Result { Success = true };

                return response;
            }
            catch (Exception ex)
            {
                return new ResponseCambioClave { Result = new Result { Success = false, Message = ex.Message } } ;
            }
        }

        public ResponseLoginUsuario Login(RequestLogin request)
        {
            return SeguridadBL.Login(request);
        }

        public ResponseLoginUsuario LoginApp(RequestLogin request)
        {
            return SeguridadBL.LoginApp(request);
        }

        public ResponseInfoUsuarioDTO GetInfoUsuario(RequestInfoUsuario request)
        {
            return SeguridadBL.GetInfoUsuario(request);
        }

        public bool CerrarSesion(string IdUsuario)
        {
            return SeguridadBL.CerrarSesion(IdUsuario);
        }

        public bool ConsultarPermisos(RequestConsultaPermiso request)
        {
            return SeguridadBL.ConsultarPermisos(request);
        }

        public IEnumerable<ResponseListaUsuarios> ListarUsuarios(RequestListarUsuario request)
        {
            return SeguridadBL.ListarUsuarios(request);
        }

        public IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargo(RequestDTOUsuarioPorCargo request)
        {
            return SeguridadBL.ListarUsuariosPorCargo(request);
        }

        public string GetNombreUsuarioByCodigoUsuario(string request)
        {
            return SeguridadBL.GetNombreUsuarioByCodigoUsuario(request);
        }

        public string GetNombreUsuario(string request)
        {
            return SeguridadBL.GetNombreUsuario(request);
        }

        public ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuarios(RequestInfoBasicaUsuarioDTO request)
        {
            return SeguridadBL.GetInfoBasicaUsuarios(request);
        }

        public IEnumerable<ResponseCargo> ListarCargosPorSociedad(RequestListaCargo request)
        {
            return SeguridadBL.ListarCargoPorSociedad(request);
        }

        public IEnumerable<ResponseSociedadSAP> ListarSociedades(RequestInfoUsuario request)
        {
            return SeguridadBL.ListarSociedades(request);
        }

        public IEnumerable<ResponseNegocioSAP> ListarNegocios(RequestInfoUsuario request)
        {
            return SeguridadBL.ListarNegocios(request);
        }

        public IEnumerable<ResponseSedeSAP> ListarSedes(RequestInfoUsuario request)
        {
            return SeguridadBL.ListarSedes(request);
        }

        public ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuariosByCodigo(RequestInfoBasicaUsuarioDTO request)
        {
            return SeguridadBL.GetInfoBasicaUsuariosByCodigo(request);
        }

        //public IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargoComex(RequestDTOUsuarioPorCargo request)
        //{
        //    return SeguridadBL.ListarUsuariosPorCargoComex(request);
        //}


        public ResponseUsuarioInsert InsertUsuario(RequestDTOUsuarioInsert request)
        {
            //return new ResponseUsuarioInsert();
           return SeguridadBL.InsertUsuario(request);
        }

        public List<ResponseUsuarioInsert> InsertUsuarios(List<RequestDTOUsuarioInsert> lstRequest)
        {
            return SeguridadBL.InsertUsuarios(lstRequest);
        }

    }
}
