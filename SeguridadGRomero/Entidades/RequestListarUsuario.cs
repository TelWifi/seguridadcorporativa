using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguridadGRomero.Entidades
{
    public class RequestListarUsuario
    {
        public string Sociedad { get; set; }
        public string Negocio { get; set; }
        public string Sede { get; set; }
        public string CodigoUsuario { get; set; }
        public string Nombres { get; set; }
        public string DNI { get; set; }
    }
}