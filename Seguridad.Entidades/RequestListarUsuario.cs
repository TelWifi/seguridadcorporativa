using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguridad.Entidades
{
    public class RequestListarUsuario
    {
        public string Dominio { get; set; }
        public string CodigoUsuario { get; set; }
        public string Nombres { get; set; }
        public string DNI { get; set; }
        public string Sociedad { get; set; }
        public string Acronimo { get; set; }
        public string TipoUsuario { get; set; }
    }
}