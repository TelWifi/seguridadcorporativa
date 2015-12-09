using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Entidades
{
    public class ResponseUsuarioInsert
    {
        public string IdUsuario { get; set; }

        public string Codigo { get; set; }
        public string Alias { get; set; }
        public string Clave { get; set; }
        public string MensajeError { get; set; }
    }
}
