using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{

	[Serializable]
	public class Permiso : BusinessBase<Permiso>, IEquatable<Permiso>
	{
		#region Business Methods

		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _ID = IdProperty.DefaultValue;
		public string ID
		{
			get { return GetProperty(IdProperty, _ID); }
			set { SetProperty(IdProperty, ref _ID, value); }
		}

		public static readonly PropertyInfo<string> IdRolPerfilProperty = RegisterProperty<string>(c => c.IdRolPerfil);
		public string IdRolPerfil
		{
			get { return GetProperty(IdRolPerfilProperty); }
			set { SetProperty(IdRolPerfilProperty, value); }
		}

		public static readonly PropertyInfo<string> IdRolProperty = RegisterProperty<string>(c => c.IdRol);
		public string IdRol
		{
			get { return GetProperty(IdRolProperty); }
			set { SetProperty(IdRolProperty, value); }
		}

		public static readonly PropertyInfo<string> IdOpcionProperty = RegisterProperty<string>(c => c.IdOpcion);
		public string IdOpcion
		{
			get { return GetProperty(IdOpcionProperty); }
			set { SetProperty(IdOpcionProperty, value); }
		}

		public static readonly PropertyInfo<string> IdUsuarioProperty = RegisterProperty<string>(c => c.IdUsuario);
		public string IdUsuario
		{
			get { return GetProperty(IdUsuarioProperty); }
			set { SetProperty(IdUsuarioProperty, value); }
		}

		public static readonly PropertyInfo<string> IdAplicacionProperty = RegisterProperty<string>(c => c.IdAplicacion);
		public string IdAplicacion
		{
			get { return GetProperty(IdAplicacionProperty); }
			set { SetProperty(IdAplicacionProperty, value); }
		}

		public static readonly PropertyInfo<string> RolProperty = RegisterProperty<string>(c => c.Rol);
		public string Rol
		{
			get { return GetProperty(RolProperty); }
			set { SetProperty(RolProperty, value); }
		}

		public static readonly PropertyInfo<string> AplicacionProperty = RegisterProperty<string>(c => c.Aplicacion);
		public string Aplicacion
		{
			get { return GetProperty(AplicacionProperty); }
			set { SetProperty(AplicacionProperty, value); }
		}

		public static readonly PropertyInfo<string> OpcionPadreProperty = RegisterProperty<string>(c => c.OpcionPadre);
		public string OpcionPadre
		{
			get { return GetProperty(OpcionPadreProperty); }
			set { SetProperty(OpcionPadreProperty, value); }
		}

		public static readonly PropertyInfo<string> OpcionProperty = RegisterProperty<string>(c => c.Opcion);
		public string Opcion
		{
			get { return GetProperty(OpcionProperty); }
			set { SetProperty(OpcionProperty, value); }
		}

		private bool _Conceder;
		public bool Conceder
		{
			get
			{ return _Conceder; }
			set
			{
				_Conceder = value;
				//MarkDirty();
			}
		}

		[Browsable(false)]
		public string Codigo { get; set; }
		[Browsable(false)]
		public string Clase { get; set; }
		[Browsable(false)]
		public string Tipo { get; set; }
		[Browsable(false)]
		public string Url { get; set; }
		[Browsable(false)]
		public int Nivel { get; set; }
		[Browsable(false)]
		public string IdOpcionPadre { get; set; }
		[Browsable(false)]
		public int NroOrden { get; set; }

		#endregion

		#region Factory Methods

		internal static Permiso NewPermiso()
		{
			return DataPortal.CreateChild<Permiso>();
		}

		internal static Permiso GetPermiso(SelectPermiso_Result childData)
		{
			return DataPortal.FetchChild<Permiso>(childData);
		}

		private Permiso()
		{
			/* Require use of factory methods */
			IdUsuario = string.Empty;
			IdOpcion = string.Empty;
			Opcion = string.Empty;
			Rol = string.Empty;
		}

		#endregion

		#region Data Access

		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Conceder = true;
			}

			BusinessRules.CheckRules();
		}

		private void Child_Fetch(SelectPermiso_Result childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdPermiso;
				IdRolPerfil = childData.IdRolPerfil;
				IdOpcion = childData.IdOpcionUI;
				IdRol = childData.IdRol;
				IdUsuario = childData.IdUsuario;
				IdAplicacion = childData.IdAplicacion;
				Rol = childData.NombreRol;
				Opcion = childData.NombreOpcion;
				Conceder = childData.Conceder;
				OpcionPadre = childData.OpcionPadre;
				Clase = childData.Clase;
				Tipo = childData.Tipo;
				Url = childData.Url;
				Nivel = childData.Nivel;
				Codigo = childData.Codigo;
				IdOpcionPadre = childData.IdOpcionPadre;
				NroOrden = childData.NumeroOrden ?? 0;
			}
			MarkOld();
		}

		internal void Child_Insert(RolPerfil parent)
		{
			if (!Conceder) return;
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Datos.Permiso();
				IdRolPerfil = parent.ID;
				DoInsertUpdate(detalle);

				ctx.DbContext.Permiso.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Datos.Permiso dr)
		{
			using (BypassPropertyChecks)
			{
				dr.IdPermiso = ID;
				dr.IdRolPerfil = IdRolPerfil;
				dr.IdRol = IdRol;
				dr.IdAplicacion = IdAplicacion;
				dr.IdUsuario = IdUsuario;
				dr.IdOpcionUI = IdOpcion;
				dr.Conceder = Conceder;
				dr.Placa = Csla.ApplicationContext.GlobalContext["Placa"].ToString();
				dr.Usuario = Csla.ApplicationContext.GlobalContext["Usuario"].ToString();
			}
		}

		internal void Child_Update()
		{
			var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD);
			//{
			//if (IsSelfDirty)
			//{
			var detalle = ctx.DbContext.Permiso.SingleOrDefault(r => r.IdPermiso == ID);
			if (detalle != null)
			{
				DoInsertUpdate(detalle);
				MarkOld();
			}
			//}
			//FieldManager.UpdateChildren(this);
			//}
		}

		private void Child_DeleteSelf()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (!IsNew)
				{
					var detalle = ctx.DbContext.Permiso.Single(r => r.IdPermiso == ID);
					ctx.DbContext.Permiso.Remove(detalle);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion

		#region Miembros de IEquatable<Permiso>

		public bool Equals(Permiso other)
		{
			return other.IdOpcion.Equals(IdOpcion);
		}

		#endregion
	}

}
