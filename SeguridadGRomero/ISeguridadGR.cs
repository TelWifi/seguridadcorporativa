using SeguridadGRomero.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace SeguridadGRomero
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISeguridadGR" en el código y en el archivo de configuración a la vez.
    [ServiceContract(Namespace="http://www.gruporomero.com.pe/seguridad")]
    public interface ISeguridadGR
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/CambiarClave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool CambiarClave(RequestCambioClave request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Login", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseLoginUsuario Login(RequestLogin request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/GetInfoUsuario", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseInfoUsuarioDTO GetInfoUsuario(RequestInfoUsuario request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/CerrarSesion", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool CerrarSesion(string IdUsuario);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConsultarPermisos", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool ConsultarPermisos(RequestConsultaPermiso request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarUsuarios", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ResponseListaUsuarios> ListarUsuarios(RequestListarUsuario request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarUsuariosPorCargo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargo(string CodigoCargo);
    }
}
