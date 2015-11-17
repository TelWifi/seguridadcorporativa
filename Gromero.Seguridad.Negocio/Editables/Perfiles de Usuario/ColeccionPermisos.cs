using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class ColeccionPermisos :
	  BusinessListBase<ColeccionPermisos, Permiso>
	{
		#region Factory Methods

		internal static ColeccionPermisos NewColeccionPermisos()
		{
			return DataPortal.CreateChild<ColeccionPermisos>();
		}

		internal static ColeccionPermisos GetColeccionPermisos(string childData)
		{
			return DataPortal.FetchChild<ColeccionPermisos>(childData);
		}

		public static void BeginGetColeccionPermisos(string criteria, EventHandler<DataPortalResult<ColeccionPermisos>> callback)
		{
			DataPortal.BeginFetch<ColeccionPermisos>(criteria, callback);
		}
		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public Permiso GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new Permiso AddNew()
		{
			return DataPortal.CreateChild<Permiso>();
		}

		/// <summary>
		/// Sobrecarga de la función Add
		/// </summary>
		public new void Add(Permiso item)
		{
			if (!Contains(item))
				base.Add(item);
			//else
			//    throw new InvalidOperationException("No se puede agregar nuevamente este Permiso!");
		}

		private ColeccionPermisos()
		{ }

		internal new void Save()
		{
			foreach (var item in this)
			{
				if (item.IsNew)
					item.Child_Insert(this.Parent as RolPerfil);
				else
					item.Child_Update();
			}
		}

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectPermiso(childData))
					this.Add(Permiso.GetPermiso(child));
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
