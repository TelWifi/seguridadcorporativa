using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GR.COMEX.Seguridad.Entidades
{
    public class ResponseListaUsuarios
    {
        public string IdUsuario { get; set; }
        public string CodigoUsuario { get; set; }
        public string NombresCompletos { get; set; }
        public string DNI { get; set; }
        public string Correo { get; set; }
        public string CodigoCargo { get; set; }
        public string Cargo { get; set; }
    }
}