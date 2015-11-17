using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GR.COMEX.Seguridad.Entidades
{
    public class ResponseOpcionUI : IEquatable<ResponseOpcionUI>
    {
        [IgnoreDataMember()]
        public string IdOpcion { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Clase { get; set; }
        public string ControlPadre { get; set; }
        public string NombreControl { get; set; }
        public string Url { get; set; }
        public bool Conceder { get; set; }
        public List<ResponseOpcionUI> Opciones { get; set; }
        public int NumeroOrden { get; set; }

        public ResponseOpcionUI()
        {
            IdOpcion = string.Empty;
            Opciones = new List<ResponseOpcionUI>();
        }

        public bool Equals(ResponseOpcionUI other)
        {
            return IdOpcion.Equals(other.IdOpcion);
        }
    }
}
