using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class RolPerfiles :
	  BusinessListBase<RolPerfiles, RolPerfil>
	{
		#region Factory Methods

		internal static RolPerfiles NewRolPerfiles()
		{
			return DataPortal.CreateChild<RolPerfiles>();
		}

		internal static RolPerfiles GetRolPerfiles(string childData)
		{
			return DataPortal.FetchChild<RolPerfiles>(childData);
		}

		internal static void BeginGetRolPerfiles(string childData,
			EventHandler<DataPortalResult<RolPerfiles>> callback)
		{
			DataPortal.BeginFetch<RolPerfiles>(childData, callback);
		}

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

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public RolPerfil GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public RolPerfil AddNew(string idRol)
		{
			var obj = DataPortal.CreateChild<RolPerfil>();
			obj.IdRol = idRol;
			this.Add(obj);
			return obj;
		}

		/// <summary>
		/// Sobrecarga de la función Add
		/// </summary>
		public new void Add(RolPerfil item)
		{
			if (!Contains(item))
				base.Add(item);
			//else
			//    throw new InvalidOperationException("No se puede agregar nuevamente este Rol!");
		}

		private RolPerfiles()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectRolesPerfil(childData))
					this.Add(RolPerfil.GetRolPerfil(child));
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
