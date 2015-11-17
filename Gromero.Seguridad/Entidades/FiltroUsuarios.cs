using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gromero.Seguridad.Entidades
{
    /// <summary>
    /// Clase para filtrar a los Usuarios
    /// </summary>
    public class FiltroUsuarios
    {
        /// <summary>
        /// Nombre de Usuario
        /// </summary>
        public string Usuario { get; set; }
        /// <summary>
        /// Dominio al que pertenece
        /// </summary>
        public string Dominio { get; set; }
    }
}
