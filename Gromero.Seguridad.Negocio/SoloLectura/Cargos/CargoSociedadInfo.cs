using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using Csla.Data;
using Gromero.Seguridad.Datos;
using System.ComponentModel;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
    [Serializable]
    public class CargoSociedadInfo : ReadOnlyBase<CargoSociedadInfo>
    {
        #region Business Methods

        public string ID { get; set; }
        public string CodigoCargo { get; set; }
        public string Descripcion { get; set; }
        public string CodigoSociedadPropietaria { get; set; }

        #endregion

        #region Factory Methods

        public static CargoSociedadInfo GetCargoSociedadInfo(CargoSociedadComplex data)
        {
            return DataPortal.Fetch<CargoSociedadInfo>(data);
        }

        private CargoSociedadInfo()
        { /* require use of factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(CargoSociedadComplex criteria)
        {
            ID = criteria.IdCargo;
            CodigoCargo = criteria.CodigoCargo;
            Descripcion = criteria.Descripcion;
            CodigoSociedadPropietaria = criteria.CodSociedadPropietaria;
        }

        #endregion
    }
}
