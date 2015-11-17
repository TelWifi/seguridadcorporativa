using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class Aplicacion : BusinessBase<Aplicacion>
	{
		#region Business Methods


		public static readonly PropertyInfo<string> IDProperty = RegisterProperty<string>(c => c.ID);
		public string ID
		{
			get { return GetProperty(IDProperty); }
			set { SetProperty(IDProperty, value); }
		}

		public static readonly PropertyInfo<string> NombreProperty = RegisterProperty<string>(c => c.Nombre);
		[Required]
		public string Nombre
		{
			get { return GetProperty(NombreProperty); }
			set { SetProperty(NombreProperty, value); }
		}

		public static readonly PropertyInfo<string> AcronimoProperty = RegisterProperty<string>(c => c.Acronimo);
		[Required]
		public string Acronimo
		{
			get { return GetProperty(AcronimoProperty); }
			set { SetProperty(AcronimoProperty, value); }
		}

		public static readonly PropertyInfo<string> URIProperty = RegisterProperty<string>(c => c.URI);
		[Required]
		public string URI
		{
			get { return GetProperty(URIProperty); }
			set { SetProperty(URIProperty, value); }
		}

		public static readonly PropertyInfo<string> TipoProperty = RegisterProperty<string>(c => c.Tipo);
		[Required]
		public string Tipo
		{
			get { return GetProperty(TipoProperty); }
			set { SetProperty(TipoProperty, value); }
		}

		public static readonly PropertyInfo<Roles> RolesProperty = RegisterProperty<Roles>(c => c.Roles, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public Roles Roles
		{
			get
			{
				if (!FieldManager.FieldExists(RolesProperty))
				{
					Roles = Roles.GetRoles(ID);
				}
				return GetProperty(RolesProperty);
			}
			private set
			{
				LoadProperty(RolesProperty, value);
				OnPropertyChanged(RolesProperty);
			}
		}

		public static readonly PropertyInfo<Opciones> OpcionesUIProperty = RegisterProperty<Opciones>(c => c.OpcionesUI, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public Opciones OpcionesUI
		{
			get
			{
				if (!FieldManager.FieldExists(OpcionesUIProperty))
					OpcionesUI = Opciones.GetOpciones(ID);
				return GetProperty(OpcionesUIProperty);
			}
			private set
			{
				LoadProperty(OpcionesUIProperty, value);
				OnPropertyChanged(OpcionesUIProperty);
			}
		}

		public static readonly PropertyInfo<RecursosAplicacion> RecursosProperty = RegisterProperty<RecursosAplicacion>(c => c.Recursos, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public RecursosAplicacion Recursos
		{
			get
			{
				if (!FieldManager.FieldExists(RecursosProperty))
				{
					Recursos = RecursosAplicacion.GetRecursosAplicacion(ID);
				}
				return GetProperty(RecursosProperty);
			}
			private set
			{
				LoadProperty(RecursosProperty, value);
				OnPropertyChanged(RecursosProperty);
			}
		}

		#endregion

		#region Business Rules

		protected override void AddBusinessRules()
		{
			// TODO: add validation rules
			base.AddBusinessRules();

			//BusinessRules.AddRule(new Rule(IdProperty));
		}

		private static void AddAuthorizationRules()
		{
			// TODO: add authorization rules
			//BusinessRules.AddRule(...);
		}

		#endregion

		#region Factory Methods

		public static Aplicacion NewAplicacion()
		{
			//if (!CanAdd())
			//    throw new SecurityException(Publicos.msgPermisosAgregar);
			return DataPortal.Create<Aplicacion>();
		}

		public static Aplicacion GetAplicacion(string id)
		{
			//if (!CanGet())
			//    throw new SecurityException(Publicos.msgPermisosLeer);
			return DataPortal.Fetch<Aplicacion>(id);
		}

		public static void DeleteAplicacion(string id)
		{
			//if (!CanDelete())
			//    throw new SecurityException(Publicos.msgPermisosEliminar);
			DataPortal.Delete<Aplicacion>(id);
		}

		public new Aplicacion Save()
		{
			//if (!IsNew && !CanUpdate())
			//    throw new SecurityException(Publicos.msgPermisosActualizar);
			return base.Save();
		}

		private Aplicacion()
		{ /* Require use of factory methods */ }

		public void ChequearReglas()
		{
			BusinessRules.CheckRules();
		}

		#endregion

		#region Reglas de Autorizacion
		public static bool CanAdd()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeAgregar, typeof(Aplicacion).Name);
		}

		public static bool CanGet()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeLeer, typeof(Aplicacion).Name);
		}

		public static bool CanDelete()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeEliminar, typeof(Aplicacion).Name);
		}

		public static bool CanUpdate()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeActualizar, typeof(Aplicacion).Name);
		}
		#endregion

		#region Data Access

		[RunLocal]
		protected override void DataPortal_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Tipo = "0";
			}
			BusinessRules.CheckRules();
		}

		private void DataPortal_Fetch(string criteria)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var app = ctx.DbContext.SelectAplicacion(criteria).FirstOrDefault();
				if (app != null)
				{
					ID = app.IdAplicacion;
					Nombre = app.NombreAplicacion;
					Acronimo = app.Acronimo;
					URI = app.Uri;
					Tipo = app.Tipo;
					ApplicationContext.LocalContext["AcronimoApp"] = Acronimo;
				}
				else
					throw new InvalidOperationException("No se encontró el registro");
			}
		}

		protected override void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var app = new Datos.Aplicaciones();
				ApplicationContext.LocalContext["IDPadre"] = ID;
				DoInsertUpdate(app);
				ctx.DbContext.Aplicaciones.Add(app);
				FieldManager.UpdateChildren(this);
				ctx.DbContext.SaveChanges();
			}
		}

		protected override void DataPortal_Update()
		{
			try
			{
				using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
				{
					if (IsSelfDirty)
					{
						var app = ctx.DbContext.SelectAplicacion(ID).FirstOrDefault();
						DoInsertUpdate(app);
					}
					ApplicationContext.LocalContext["IDPadre"] = ID;
					FieldManager.UpdateChildren(this);
					ctx.DbContext.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Trace.Write(ex.ToString());
				throw ex;
			}
		}

		private void DoInsertUpdate(Datos.Aplicaciones cmd)
		{
			using (BypassPropertyChecks)
			{
				ApplicationContext.LocalContext["IdPadre"] = ID;
				cmd.IdAplicacion = ID;
				cmd.NombreAplicacion = Nombre;
				cmd.Acronimo = Acronimo;
				cmd.Tipo = Tipo;
				cmd.Uri = URI;
			}
		}

		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(this.ID);
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(string criteria)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var app = ctx.DbContext.SelectAplicacion(criteria).FirstOrDefault();
				ctx.DbContext.Aplicaciones.Remove(app);
				ctx.DbContext.SaveChanges();
			}
		}

		#endregion
	}
}
