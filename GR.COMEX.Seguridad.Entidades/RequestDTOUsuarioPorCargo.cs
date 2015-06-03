using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GR.COMEX.Seguridad.Entidades
{
    public class RequestDTOUsuarioPorCargo
    {
        public List<string> CodigosCargo { get; set; }
        public string Sociedad { get; set; }
        public string Sede { get; set; }
        public string Acronimo { get; set; }
        public string Dominio { get; set; }
        public string TipoUsuario { get; set; }
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
    } 
}