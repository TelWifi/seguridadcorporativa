using System;
using System.Linq;
using System.Collections.Generic;
using Csla;
using Gromero.Seguridad.Datos;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
    [Serializable]
    public class CargoInfo : ReadOnlyBase<CargoInfo>
    {
        #region Business Methods

        public string ID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        #endregion

        #region Factory Methods

        public static CargoInfo GetCargoInfo(Cargo data)
        {
            return DataPortal.Fetch<CargoInfo>(data);
        }

        private CargoInfo()
        { /* require use of factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(Cargo criteria)
        {
            ID = criteria.IdCargo;
            Codigo = criteria.CodigoCargo;
            Descripcion = criteria.Descripcion;
            Estado = criteria.Estado;
        }

        #endregion
    }
}
