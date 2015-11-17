using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguridadGRomero.Entidades
{
    public class RequestCambioClave
    {
        public string IdUsuario { get; set; }
        public string ClaveNueva { get; set; }
    }
}