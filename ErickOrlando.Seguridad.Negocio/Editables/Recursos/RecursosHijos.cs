using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using Gromero.Seguridad.Negocio.Comunes;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class RecursosHijos :
	  BusinessListBase<RecursosHijos, RecursoHijo>
	{
		#region Factory Methods

		internal static RecursosHijos NewRecursosHijos()
		{
			return DataPortal.CreateChild<RecursosHijos>();
		}

		internal static RecursosHijos GetRecursosHijos(string childData)
		{
			return DataPortal.FetchChild<RecursosHijos>(childData);
		}

		internal static void BeginGetRecursosHijos(string childData, EventHandler<DataPortalResult<RecursosHijos>> callback)
		{
			DataPortal.BeginFetch<RecursosHijos>(childData, callback);
		}

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public RecursoHijo GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new RecursoHijo AddNew()
		{
			var obj = DataPortal.CreateChild<RecursoHijo>();
			obj.Nivel = this.EditLevel + 1;
			if (this.Parent is IRecursivo)
			{
				var padre = (this.Parent as IRecursivo);
				obj.IdRecursoPadre = padre.ID;
				obj.Nivel = padre.Nivel + 1;
			}
			this.Add(obj);
			return obj;
		}

		private RecursosHijos()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectRecursoDetallado(childData))
					this.Add(RecursoHijo.GetRecursoHijo(child));
			}
			RaiseListChangedEvents = true;
		}

		private void DataPortal_Fetch(string childData)
		{
			Child_Fetch(childData);
		}

		#endregion
	}
}
