using Csla;
using Csla.Data.EF6;
using ErickOrlando.Utilidades.Data;
using Gromero.Seguridad.Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
	[Serializable]
	public class CargoInfoList :
	  ReadOnlyListBase<CargoInfoList, CargoInfo>
	{
		#region Factory Methods

		public static CargoInfoList GetCargoInfoList()
		{
			return DataPortal.Fetch<CargoInfoList>(new FiltroCriteria());
		}

		public static CargoInfoList GetCargoInfoList(FiltroCriteria filtro)
		{
			return DataPortal.Fetch<CargoInfoList>(filtro);
		}

		private CargoInfoList()
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
				IEnumerable<Cargo> query;

				switch (criteria.NombreCampo)
				{
					case "Codigo":
						query = ctx.DbContext.SelectCargoByCodigo(criteria.ValorBusqueda).ToList();
						break;
					case "Descripcion":
						query = ctx.DbContext.SelectCargoByDescripcion(criteria.ValorBusqueda).ToList();
						break;
					default:
						query = ctx.DbContext.SelectAllCargo().ToList();
						break;
				}

				foreach (var item in query)
					Add(CargoInfo.GetCargoInfo(item));
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
