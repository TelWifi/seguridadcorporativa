using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using Gromero.Seguridad.Negocio.Comunes;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class RecursoDetalles :
	  BusinessListBase<RecursoDetalles, RecursoDetalle>
	{
		#region Factory Methods

		internal static RecursoDetalles NewRecursoDetalles()
		{
			return DataPortal.CreateChild<RecursoDetalles>();
		}

		internal static RecursoDetalles GetRecursoDetalles(string childData)
		{
			return DataPortal.FetchChild<RecursoDetalles>(childData);
		}

		public static void BeginGetRecursoDetalles(string childData, EventHandler<DataPortalResult<RecursoDetalles>> callback)
		{
			DataPortal.BeginFetch<RecursoDetalles>(childData, callback);
		}

		public static void BeginGetRecursoDetalles(SingleCriteria<string> childData, EventHandler<DataPortalResult<RecursoDetalles>> callback)
		{
			DataPortal.BeginFetch<RecursoDetalles>(childData, callback);
		}

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public RecursoDetalle GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new RecursoDetalle AddNew()
		{
			var obj = DataPortal.CreateChild<RecursoDetalle>();
			obj.Nivel = this.EditLevel + 1;
			if (this.Parent is IRecursivo)
			{
				var padre = (this.Parent as IRecursivo);
				obj.IdRecursoDetallePadre = padre.ID;
				obj.Nivel = padre.Nivel + 1;
			}
			if (this.Parent is Recursos || this.Parent is RecursoHijo)
			{
				obj.Nivel = 1;
				obj.IdRecursoDetallePadre = string.Empty;
			}
			this.Add(obj);
			return obj;
		}

		private RecursoDetalles()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectRecursoDetalle(childData))
					this.Add(RecursoDetalle.GetRecursoDetalle(child));
			}
			RaiseListChangedEvents = true;
		}

		private void Child_Fetch(SingleCriteria<string> childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectRecursoDetalleDetallado(childData.Value))
					this.Add(RecursoDetalle.GetRecursoDetalle(child));
			}
			RaiseListChangedEvents = true;
		}

		private void DataPortal_Fetch(string childData)
		{
			Child_Fetch(childData);
		}

		private void DataPortal_Fetch(SingleCriteria<string> childData)
		{
			Child_Fetch(childData);
		}

		#endregion
	}
}
