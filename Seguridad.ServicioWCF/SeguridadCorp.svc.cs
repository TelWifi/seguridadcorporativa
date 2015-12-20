using System;
using System.Collections.Generic;
using Seguridad.Entidades;
using Seguridad.ServicioBL;

namespace Seguridad.ServicioWCF
{
    [AiLogException]
    public class SeguridadCorp : ISeguridadCorp
    {
        public ResponseCambioClave CambiarClaveWeb(RequestCambioClave request)
        {

            var response = new ResponseCambioClave();
            try
            {
                response = SeguridadBL.CambiarClaveWeb(request);
                response.Resultado.Success = true;
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;

        }

        public ResponseLoginUsuario Login(RequestLogin request)
        {
            var response = new ResponseLoginUsuario();
            try
            {
                response = SeguridadBL.Login(request);
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public ResponseInfoUsuarioDTO GetInfoUsuario(RequestInfoUsuario request)
        {

            var response = new ResponseInfoUsuarioDTO();
            try
            {
                response = SeguridadBL.GetInfoUsuario(request);
                response.Resultado.Success = true;
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public BaseResponse CerrarSesion(RequestInfoUsuario request)
        {

            var response = new BaseResponse();
            try
            {
                response.Resultado.Success = SeguridadBL.CerrarSesion(request);
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public bool ConsultarPermisos(RequestConsultaPermiso request)
        {
            return SeguridadBL.ConsultarPermisos(request);
        }

        public ResponseDTOListaUsuario ListarUsuarios(RequestListarUsuario request)
        {

            var response = new ResponseDTOListaUsuario();
            try
            {
                response.ListaUsuarios = SeguridadBL.ListarUsuarios(request);
                response.Resultado.Success = true;
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public ResponseDTOCargoUsuario ListarUsuariosPorCargo(RequestDTOUsuarioPorCargo request)
        {

            var response = new ResponseDTOCargoUsuario();
            try
            {
                response.ListaUsuarioCargo = SeguridadBL.ListarUsuariosPorCargo(request);
                response.Resultado.Success = true;
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuarios(RequestInfoBasicaUsuarioDTO request)
        {

            var response = new ResponseInfoBasicaUsuarioDTO();
            try
            {
                response = SeguridadBL.GetInfoBasicaUsuarios(request);
                response.Resultado.Success = true;
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuariosByCodigo(RequestInfoBasicaUsuarioDTO request)
        {

            var response = new ResponseInfoBasicaUsuarioDTO();
            try
            {
                response = SeguridadBL.GetInfoBasicaUsuariosByCodigo(request);
                response.Resultado.Success = true;
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public ResponseUsuarioInsert InsertUsuario(RequestDTOUsuarioInsert request)
        {

            var response = new ResponseUsuarioInsert();
            try
            {
                response = SeguridadBL.InsertUsuario(request);
                response.Resultado.Success = true;
            }
            catch (Exception ex)
            {
                response.Resultado.Message = ex.Message;
                response.Resultado.ErrCode = ex.GetHashCode().ToString();
                response.Resultado.Messages.Add(new Result { Message = ex.InnerException.Message });
            }
            return response;
        }

        public List<ResponseUsuarioInsert> InsertUsuarios(List<RequestDTOUsuarioInsert> lstRequest)
        {
            return SeguridadBL.InsertUsuarios(lstRequest);
        }

    }
}
