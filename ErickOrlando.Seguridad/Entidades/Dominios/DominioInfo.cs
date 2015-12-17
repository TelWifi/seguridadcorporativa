using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErickOrlando.Seguridad.Entidades
{
    /// <summary>
    /// Dominio
    /// </summary>
    public class DominioInfo
    {
        /// <summary>
        /// Nombre Corto
        /// </summary>
        public string NombreCorto { get; set; }
        /// <summary>
        /// Nombre Largo
        /// </summary>
        public string NombreLargo { get; set; }

        internal DominioInfo(string _short, string _long)
        {
            NombreCorto = _short;
            NombreLargo = _long;
        }

        private DominioInfo()
        {

        }
    }
}
