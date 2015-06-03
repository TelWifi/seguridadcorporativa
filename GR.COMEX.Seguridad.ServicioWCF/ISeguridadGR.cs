using GR.COMEX.Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace GR.COMEX.Seguridad.ServicioWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISeguridadGR" en el código y en el archivo de configuración a la vez.
    [ServiceContract(Namespace="http://www.gruporomero.com.pe/COMEX/Seguridad")]
    public interface ISeguridadGR
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/CambiarClave", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool CambiarClave(RequestCambioClave request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Login", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseLoginUsuario Login(RequestLogin request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/LoginApp", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseLoginUsuario LoginApp(RequestLogin request);

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
        IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargo(RequestDTOUsuarioPorCargo request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/GetNombreUsuario", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetNombreUsuario(string request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/GetInfoBasicaUsuarios", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ResponseInfoBasicaUsuarioDTO GetInfoBasicaUsuarios(RequestInfoBasicaUsuarioDTO request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarCargosPorSociedad", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ResponseCargo> ListarCargosPorSociedad(RequestListaCargo request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarSociedades", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ResponseSociedadSAP> ListarSociedades(RequestInfoUsuario request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarNegocios", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ResponseNegocioSAP> ListarNegocios(RequestInfoUsuario request);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ListarSedes", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ResponseSedeSAP> ListarSedes(RequestInfoUsuario request);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "/ListarUsuariosPorCargoComex", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //IEnumerable<ResponseUsuarioCargo> ListarUsuariosPorCargoComex(RequestDTOUsuarioPorCargo request);

    }
}
