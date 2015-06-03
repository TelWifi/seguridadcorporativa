using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GR.COMEX.Seguridad.Entidades
{
    public class ResponseLoginUsuario
    {
        public string IdPerfilUsuario { get; set; }
        public bool ResultadoLogin { get; set; }
        public string MensajeError { get; set; }
    }
}