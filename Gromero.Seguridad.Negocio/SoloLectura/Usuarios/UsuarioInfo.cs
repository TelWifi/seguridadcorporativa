using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Gromero.Seguridad.Datos;
using Csla.Data;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
    [Serializable]
    public class UsuarioInfo : ReadOnlyBase<UsuarioInfo>
    {
        #region Business Methods

        public string ID { get; set; }
        public string Codigo { get; set; }
        public string Dominio { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string DNI { get; set; }
        public string Alias { get; set; }
        public string Estado { get; set; }
        public string EmpresaLabora { get; set; }
        public string EmpresaPertenencia { get; set; }
        public string Cargo { get; set; }
        public string Tipo { get; set; }

        public bool Seleccionar { get; set; }
        #endregion

        #region Factory Methods

        public static UsuarioInfo GetUsuarioInfo(UsuarioComplex data)
        {
            return DataPortal.Fetch<UsuarioInfo>(data);
        }

        private UsuarioInfo()
        { /* require use of factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(UsuarioComplex criteria)
        {
            ID = criteria.IdUsuario;
            Codigo = criteria.CodigoUsuario;
            Dominio = criteria.Dominio;
            Nombres = criteria.Nombres;
            ApellidoPaterno = criteria.ApellidoPaterno;
            ApellidoMaterno = criteria.ApellidoMaterno;
            Correo = criteria.Correo;
            DNI = criteria.DNI;
            Alias = criteria.Alias;
            Estado = criteria.Estado ? "Activo" : "Inactivo";
            Tipo = criteria.Tipo == "E" ? "Externo" : "Interno";
            EmpresaLabora = criteria.EmpresaLabora;
            EmpresaPertenencia = criteria.EmpresaDePertenencia;
            Cargo = criteria.DescripcionCargo;
        }

        #endregion
    }
}
