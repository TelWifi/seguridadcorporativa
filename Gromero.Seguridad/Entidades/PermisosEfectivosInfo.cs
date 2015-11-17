using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Data;

namespace Gromero.Seguridad.Entidades
{
    [Serializable]
    internal class PermisosEfectivosInfo : ReadOnlyBase<PermisosEfectivosInfo>
    {
        #region Business Methods

        public string Rol { get; set; }
        public string CodigoOpcion { get; set; }
        public string Opcion { get; set; }
        public int Nivel { get; set; }
        public bool Conceder { get; set; }

        #endregion

        #region Factory Methods

        public static PermisosEfectivosInfo GetPermisosEfectivosInfo(SafeDataReader data)
        {
            return DataPortal.Fetch<PermisosEfectivosInfo>(data);
        }

        private PermisosEfectivosInfo()
        { /* require use of factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(SafeDataReader criteria)
        {
            Rol = criteria.GetString("NombreRol");
            CodigoOpcion = criteria.GetString("CodigoOpcion");
            Opcion = criteria.GetString("NombreOpcion");
            Nivel = criteria.GetInt32("Nivel");
            Conceder = criteria.GetBoolean("Conceder");
        }

        #endregion
    }
}
