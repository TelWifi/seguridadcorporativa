using Csla;
using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using System;
using System.Linq;

namespace ErickOrlando.Seguridad.Negocio.Editables
{
	[Serializable]
	public class Roles :
	  BusinessListBase<Roles, Rol>
	{
		#region Factory Methods

		internal static Roles NewRoles()
		{
			return DataPortal.CreateChild<Roles>();
		}

		internal static Roles GetRoles(string childData)
		{
			return DataPortal.FetchChild<Roles>(childData);
		}

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public Rol GetItem(string IdTtem)
		{
			return this.Where(d => d.Id.Equals(IdTtem)).Single();
		}

		protected override Rol AddNewCore()
		{
			return AddNewExtracted();
		}

		private Rol AddNewExtracted()
		{
			var rol = DataPortal.CreateChild<Rol>();
			Add(rol);
			return rol;
		}
		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new Rol AddNew()
		{
			return AddNewExtracted();
		}

		/// <summary>
		/// Sobrecarga de la función Add
		/// </summary>
		public new void Add(Rol item)
		{
			if (!Contains(item))
				base.Add(item);
			else
				throw new InvalidOperationException("No se puede agregar nuevamente este Rol!");
		}

		private Roles()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectRol(childData))
					this.Add(Rol.GetRol(child));
			}

			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
