using Csla;
using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using System;
using System.Linq;

namespace ErickOrlando.Seguridad.Negocio.Editables
{

	[Serializable]
	public class RolPerfil : BusinessBase<RolPerfil>, IEquatable<RolPerfil>
	{
		#region Business Methods

		// TODO: add your own fields, properties and methods

		// example with private backing field
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _Id = IdProperty.DefaultValue;
		public string ID
		{
			get { return GetProperty(IdProperty, _Id); }
			set { SetProperty(IdProperty, ref _Id, value); }
		}

		public static readonly PropertyInfo<string> IdAplicacionProperty = RegisterProperty<string>(c => c.IdAplicacion);
		public string IdAplicacion
		{
			get { return GetProperty(IdAplicacionProperty); }
			set { SetProperty(IdAplicacionProperty, value); }
		}

		public static readonly PropertyInfo<string> IdRolProperty = RegisterProperty<string>(c => c.IdRol);
		public string IdRol
		{
			get { return GetProperty(IdRolProperty); }
			set { SetProperty(IdRolProperty, value); }
		}

		public static readonly PropertyInfo<string> IdPerfilUsuarioProperty = RegisterProperty<string>(c => c.IdPerfilUsuario);
		public string IdPerfilUsuario
		{
			get { return GetProperty(IdPerfilUsuarioProperty); }
			set { SetProperty(IdPerfilUsuarioProperty, value); }
		}

		[System.ComponentModel.Browsable(false)]
		public string CodigoRol { get; set; }

		public static readonly PropertyInfo<string> NombreRolProperty = RegisterProperty<string>(c => c.NombreRol);
		public string NombreRol
		{
			get { return GetProperty(NombreRolProperty); }
			set { SetProperty(NombreRolProperty, value); }
		}

		public static readonly PropertyInfo<ColeccionPermisos> PermisosProperty = RegisterProperty<ColeccionPermisos>(c => c.Permisos, RelationshipTypes.Child);
		public ColeccionPermisos Permisos
		{
			get
			{
				if (!FieldManager.FieldExists(PermisosProperty))
					Permisos = ColeccionPermisos.GetColeccionPermisos(ID);
				return GetProperty(PermisosProperty);
			}
			private set
			{
				LoadProperty(PermisosProperty, value);
				OnPropertyChanged(PermisosProperty);
			}
		}

		#endregion

		#region Business Rules

		protected override void AddBusinessRules()
		{
			// TODO: add validation rules
			//BusinessRules.AddRule(new Rule(), IdProperty);
		}

		private static void AddAuthorizationRules()
		{
			// TODO: add authorization rules
			//BusinessRules.AddRule(...);
		}

		#endregion

		#region Factory Methods

		public static RolPerfil NewRolPerfil()
		{
			return DataPortal.CreateChild<RolPerfil>();
		}

		internal static RolPerfil GetRolPerfil(SelectRolesPerfil_Result childData)
		{
			return DataPortal.FetchChild<RolPerfil>(childData);
		}

		private RolPerfil()
		{ /* Require use of factory methods */ }

		public void AgregarPermisos(string idUsuario = "")
		{
			string IdUsuario = string.IsNullOrEmpty(idUsuario)
				? ((Parent as RolPerfiles).Parent as PerfilUsuario).IdUsuario
				: idUsuario;

			// Invocamos al Comando que devuelve las plantillas.
			var plantillas = Comandos.PlantillasCommand.Execute(IdAplicacion, IdRol);
			foreach (var item in plantillas)
			{
				var permiso = Permiso.NewPermiso();
				permiso.IdAplicacion = IdAplicacion;
				permiso.IdOpcion = item.IdOpcion;
				permiso.IdRolPerfil = ID;
				permiso.IdRol = IdRol;
				permiso.IdUsuario = IdUsuario;
				permiso.Rol = item.NombreRol;
				permiso.OpcionPadre = item.OpcionPadre;
				permiso.Opcion = item.NombreOpcion;
				permiso.Conceder = item.Conceder;

				if (!Permisos.Contains(permiso))
					Permisos.Add(permiso);
				else
				{
					var indice = Permisos.IndexOf(permiso);
					Permisos[indice].Conceder = permiso.Conceder;
				}
			}
		}
		#endregion

		#region Data Access

		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
			}
		}

		private void Child_Fetch(SelectRolesPerfil_Result childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdRolPerfil;
				IdAplicacion = childData.IdAplicacion;
				IdPerfilUsuario = childData.IdPerfilUsuario;
				IdRol = childData.IdRol;
				CodigoRol = childData.CodigoRol;
				NombreRol = childData.NombreRol;
			}
			MarkOld();
		}

		internal void Child_Insert(PerfilUsuario parent)
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new RolesPerfiles();
				IdPerfilUsuario = parent.ID;
				DoInsertUpdate(detalle);
				ctx.DbContext.RolesPerfiles.Add(detalle);
				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(RolesPerfiles detalle)
		{
			using (BypassPropertyChecks)
			{
				detalle.IdRolPerfil = ID;
				detalle.IdAplicacion = IdAplicacion;
				detalle.IdPerfilUsuario = IdPerfilUsuario;
				detalle.IdRol = IdRol;
			}
		}

		internal void Child_Update()
		{
			var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD);
			//{
			if (IsSelfDirty)
			{
				var detalle = ctx.DbContext.RolesPerfiles.SingleOrDefault(r => r.IdRolPerfil == ID);
				if (detalle != null)
				{
					DoInsertUpdate(detalle);
					MarkOld();
				}
			}
			Permisos.Save();
			//FieldManager.UpdateChildren(this);
			//}
		}

		internal void Child_DeleteSelf()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (!IsNew)
				{
					var detalle = ctx.DbContext.RolesPerfiles.Single(r => r.IdRolPerfil == ID);
					ctx.DbContext.RolesPerfiles.Remove(detalle);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion

		#region Miembros de IEquatable<RolPerfil>

		public bool Equals(RolPerfil other)
		{
			if (string.IsNullOrEmpty(other.IdRol))
				return false;
			return other.IdRol.Equals(IdRol);
		}

		#endregion
	}
}
