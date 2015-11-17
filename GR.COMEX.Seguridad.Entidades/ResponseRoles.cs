using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GR.COMEX.Seguridad.Entidades
{
    public class ResponseRoles
    {
        [IgnoreDataMember()]
        public string IdRol { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
