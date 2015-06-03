using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GR.COMEX.Seguridad.Entidades
{
    public class RequestLogin
    {
        public string CodigoUsuario { get; set; }
        public string Clave { get; set; }
        public string Dominio { get; set; }
        public string AcronimoAplicacion { get; set; }
    }
}