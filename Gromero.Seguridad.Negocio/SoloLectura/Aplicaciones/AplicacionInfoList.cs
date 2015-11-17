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
	public class AplicacionInfoList :
	  ReadOnlyListBase<AplicacionInfoList, AplicacionInfo>
	{
		#region Factory Methods

		public static AplicacionInfoList GetAplicacionInfoList()
		{
			return DataPortal.Fetch<AplicacionInfoList>(new FiltroCriteria());
		}

		public static AplicacionInfoList GetAplicacionInfoList(FiltroCriteria crit)
		{
			return DataPortal.Fetch<AplicacionInfoList>(crit);
		}

		private AplicacionInfoList()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(FiltroCriteria criteria)
		{
			RaiseListChangedEvents = false;
			IsReadOnly = false;
			try
			{
				using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
				{
					IEnumerable<Aplicaciones> lista;
					switch (criteria.NombreCampo)
					{
						case "Nombre":
							lista = ctx.DbContext.SelectAplicacionByName(criteria.ValorBusqueda).ToList();
							break;
						case "Acronimo":
							lista = ctx.DbContext.SelectAplicacionByTag(criteria.ValorBusqueda).ToList();
							break;
						case "Ruta":
							lista = ctx.DbContext.SelectAplicacionByUri(criteria.ValorBusqueda).ToList();
							break;
						default:
							lista = ctx.DbContext.SelectAllAplicacion().ToList();
							break;
					}
					foreach (var item in lista)
						Add(AplicacionInfo.GetAplicacionInfo(item));
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Trace.Write(ex.ToString());
				throw;
			}
			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
