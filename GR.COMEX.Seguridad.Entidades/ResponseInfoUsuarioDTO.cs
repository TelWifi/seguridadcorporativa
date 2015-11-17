using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GR.COMEX.Seguridad.Entidades
{
    public class ResponseInfoUsuarioDTO
    {
        public string IdUsuario { get; set; }
        public string CodigoUsuario { get; set; }
        public string Alias { get; set; }
        public string NombresCompletos { get; set; }
        public string Dominio { get; set; }
        public string Correo { get; set; }
        public string CodigoCargo { get; set; }
        public string Cargo { get; set; }
        public string TipoUsuario { get; set; }
        public List<ResponseRoles> Roles { get; set; }
        public List<ResponseOpcionUI> OpcionesUI { get; set; }
        public List<ResponseSociedadSAP> Sociedades { get; set; }
        public List<ResponseSedeSAP> Sedes { get; set; }
        public List<ResponseNegocioSAP> Negocios { get; set; }
        public List<ResponseRecursoAdicional> RecursosAdicionales { get; set; }
    }
}