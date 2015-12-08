using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ErickOrlando.Utilidades.ServiceModel;
using Seguridad.Entidades;

namespace Gromero.Seguridad.WinForms
{
    internal class ProxySeguridad : UtilitarioRest, IDisposable
    {

        #region Propiedades
        internal static string Url
        {
            get
            {
                if (ConfigurationManager.AppSettings["UrlSeguridad"] == null)
                    throw new
                        ArgumentNullException("UrlSeguridad",
                            Properties.Resources.msgUrlSeguridad);
                return ConfigurationManager.AppSettings["UrlSeguridad"].ToString();
            }
        } 
        #endregion

        #region Metodos del Servicio
        internal ResponseLoginUsuario Login(RequestLogin request)
        {
            return DeserializarJSON<RequestLogin, ResponseLoginUsuario>(request,
                string.Format("{0}/Login", Url));
        }

        internal ResponseInfoUsuarioDTO GetInfoUsuario(RequestInfoUsuario request)
        {
            return DeserializarJSON<RequestInfoUsuario, ResponseInfoUsuarioDTO>(request, string.Format("{0}/GetInfoUsuario", Url));
        }

        internal bool CambiarClave(RequestCambioClave request)
        {
            return DeserializarJSON<RequestCambioClave, bool>(request,
                string.Format("{0}/CambiarClave", Url));
        }

        internal bool CerrarSesion(string request)
        {
            return DeserializarJSON<string, bool>(request, string.Format("{0}/CerrarSesion", Url));
        } 
        #endregion

        #region Implementacion de IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }
        ~ProxySeguridad()
        {
            Dispose(false);
        }

        #endregion
    }
}
