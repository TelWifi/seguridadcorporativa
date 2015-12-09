using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class RecursosPerfil :
	  BusinessListBase<RecursosPerfil, RecursoPerfil>
	{
		#region Factory Methods

		internal static RecursosPerfil NewRecursosPerfil()
		{
			return DataPortal.CreateChild<RecursosPerfil>();
		}

		internal static RecursosPerfil GetRecursosPerfil(string childData)
		{
			return DataPortal.FetchChild<RecursosPerfil>(childData);
		}

		public static void BeginGetRecursosPerfil(string childData, EventHandler<DataPortalResult<RecursosPerfil>> callback)
		{
			DataPortal.BeginFetch<RecursosPerfil>(childData, callback);
		}
		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public RecursoPerfil GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new RecursoPerfil AddNew()
		{
			return DataPortal.CreateChild<RecursoPerfil>();
		}

		/// <summary>
		/// Sobrecarga de la función Add
		/// </summary>
		public new void Add(RecursoPerfil item)
		{
			if (!Contains(item))
				base.Add(item);
			else
				throw new InvalidOperationException("No se puede agregar nuevamente este RecursoPerfil!");
		}

		private RecursosPerfil()
		{ }

		internal new void Save()
		{
			foreach (var item in DeletedList)
			{
				item.Child_DeleteSelf();
			}

			DeletedList.Clear();

			foreach (var item in this)
			{
				if (item.IsNew)
					item.Child_Insert(this.Parent as PerfilUsuario);
				else
					item.Child_Update();

			}
		}

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectRecursoPerfil(childData))
					this.Add(RecursoPerfil.GetRecursoPerfil(child));
			}
			RaiseListChangedEvents = true;
		}

		public void DataPortal_Fetch(string childData)
		{
			Child_Fetch(childData);
		}

		#endregion
	}
}
