using Csla;
using Csla.Data.EF6;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Seguridad.Datos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ErickOrlando.Seguridad.Negocio.SoloLectura
{
	[Serializable]
	public class RecursosInfoList :
	  ReadOnlyListBase<RecursosInfoList, RecursosInfo>
	{
		#region Factory Methods

		public static RecursosInfoList GetRecursosInfoList()
		{
			return DataPortal.Fetch<RecursosInfoList>(new FiltroCriteria());
		}

		public static RecursosInfoList GetRecursosInfoList(FiltroCriteria filtro)
		{
			return DataPortal.Fetch<RecursosInfoList>(filtro);
		}

		public static void BeginGetRecursosInfoList(EventHandler<DataPortalResult<RecursosInfoList>> callback)
		{
			DataPortal.BeginFetch<RecursosInfoList>(new FiltroCriteria(), callback);
		}

		private RecursosInfoList()
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
				IEnumerable<Recurso> query;

				bool condicion = (string.IsNullOrEmpty(criteria.ValorBusqueda) && !string.IsNullOrEmpty(criteria.NombreCampo));

				if (condicion)
					query = ctx.DbContext.SelectAllRecurso();
				else
				{
					//En caso de que no hay ningun campo devolvemos todos los Niveles
					if (string.IsNullOrEmpty(criteria.NombreCampo))
						query = ctx.DbContext.SelectRecursoForApp().ToList();
					else
						query = ctx.DbContext.SelectRecursoByDescripcion(criteria.ValorBusqueda).ToList();
				}

				foreach (var item in query)
					Add(RecursosInfo.GetRecursosInfo(item));
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
