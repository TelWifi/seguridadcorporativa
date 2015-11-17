using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class RecursosAplicacion :
	  BusinessListBase<RecursosAplicacion, RecursoAplicacion>
	{
		#region Factory Methods

		internal static RecursosAplicacion NewRecursosAplicacion()
		{
			return DataPortal.CreateChild<RecursosAplicacion>();
		}

		internal static RecursosAplicacion GetRecursosAplicacion(string childData)
		{
			return DataPortal.FetchChild<RecursosAplicacion>(childData);
		}

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public RecursoAplicacion GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new RecursoAplicacion AddNew()
		{
			var obj = DataPortal.CreateChild<RecursoAplicacion>();
			this.Add(obj);
			return obj;
		}

		/// <summary>
		/// Sobrecarga de la función Add
		/// </summary>
		public new void Add(RecursoAplicacion item)
		{
			if (!Contains(item))
				base.Add(item);
			else
				throw new InvalidOperationException("No se puede agregar nuevamente este RecursoAplicacion!");
		}

		private RecursosAplicacion()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectRecursoAplicacion(childData))
					this.Add(RecursoAplicacion.GetRecursoAplicacion(child));
			}
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
