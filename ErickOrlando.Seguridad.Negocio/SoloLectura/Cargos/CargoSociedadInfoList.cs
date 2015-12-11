using Csla;
using Csla.Data.EF6;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Seguridad.Datos;
using System;

namespace ErickOrlando.Seguridad.Negocio.SoloLectura
{
	[Serializable]
	public class CargoSociedadInfoList :
	  ReadOnlyListBase<CargoSociedadInfoList, CargoSociedadInfo>
	{
		#region Factory Methods

		public static CargoSociedadInfoList GetCargoSociedadInfoList()
		{
			return DataPortal.Fetch<CargoSociedadInfoList>(new FiltroCriteria());
		}

		public static CargoSociedadInfoList GetCargoSociedadInfoList(FiltroCriteria filtro)
		{
			return DataPortal.Fetch<CargoSociedadInfoList>(filtro);
		}

		private CargoSociedadInfoList()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(FiltroCriteria criteria)
		{
			RaiseListChangedEvents = false;
			IsReadOnly = false;

			using (var ctx = DbContextManager<SeguridadEntities>
				.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var item in ctx.DbContext.SelectAllCargoSociedad())
					Add(CargoSociedadInfo.GetCargoSociedadInfo(item));
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
