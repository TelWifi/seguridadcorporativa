using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeguridadGRomero.Entidades
{
    public class ResponseOpcionUI
    {
        public string Codigo { get; set; }
        public string Clase { get; set; }
        public string ControlPadre { get; set; }
        public string NombreControl { get; set; }
        public bool Conceder { get; set; }
    }
}
