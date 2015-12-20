using Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace Seguridad.ServicioWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISeguridadCorp" en el código y en el archivo de configuración a la vez.
    [ServiceContract(Namespace = "http://www.erickorlando.com/contracts/Seguridad")]
    public interface ISeguridadCorp
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/CambiarClave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseCambioClave CambiarClave(RequestCambioClave request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Login", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseLoginUsuario Login(RequestLogin request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/GetInfoUsuario", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseInfoUsuarioDTO GetInfoUsuario(RequestInfoUsuario request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/CerrarSesion", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        BaseResponse CerrarSesion(RequestInfoUsuario request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarPermisos", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool ConsultarPermisos(RequestConsultaPermiso request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarUsuarios", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseDTOListaUsuario ListarUsuarios(RequestListarUsuario request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarUsuariosPorCargo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseDTOCargoUsuario ListarUsuariosPorCargo(RequestDTOUsuarioPorCargo request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/GetInfoBasicaUsuarios", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuarios(RequestInfoBasicaUsuarioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/InsertUsuario", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseUsuarioInsert InsertUsuario(RequestDTOUsuarioInsert request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/InsertUsuarios", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ResponseUsuarioInsert> InsertUsuarios(List<RequestDTOUsuarioInsert> lstRequest);

        [OperationContract]
        [WebInvoke(UriTemplate = "/GetInfoBasicaUsuariosByCodigo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuariosByCodigo(RequestInfoBasicaUsuarioDTO request);

    }
}
