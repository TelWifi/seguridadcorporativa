using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguridad.Entidades
{
    public class ResponseLoginUsuario
    {
        public string IdPerfilUsuario { get; set; }
        public bool ResultadoLogin { get; set; }
        public string MensajeError { get; set; }
    }
}