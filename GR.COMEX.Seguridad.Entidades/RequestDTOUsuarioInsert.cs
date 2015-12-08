using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Entidades
{
    public class RequestDTOUsuarioInsert
    {

        public string IdEmpresa { get; set; }
        public string IdEmpresaPertenencia { get; set; }
        public string IdCargo { get; set; }
        public string Nombres { get; set; }
        public string Alias { get; set; }
        public string Dominio { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Codigo { get; set; }
        public string Correo { get; set; }
        public string DNI { get; set; }
        public bool NotificacionConCorreo { get; set; }
        public bool Caduca { get; set; }
        public string Tipo { get; set; }
        public string IdAplicacion { get; set; }
        public string Aplicacion { get; set; }
        public string IdRol { get; set; }
        public string[] ListaRecursos { get; set; }
        public string PreguntaSecreta { get; set; }
        public string RespuestaSecreta { get; set; }
    }
}
