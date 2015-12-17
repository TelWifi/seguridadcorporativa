using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace ErickOrlando.Seguridad
{
    /// <summary>
    /// Clase estática que devuelve información de la Base de Datos
    /// </summary>
    static class BaseDatos
    {
        static string cnx = string.Empty;
        /// <summary>
        /// Devuelve la Cadena de Conexión
        /// </summary>
        public static string ConexionBD
        {
            get
            {
                if (string.IsNullOrEmpty(cnx))
                {
                    cnx = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
                }
                return cnx;
            }
        }

    }
}
