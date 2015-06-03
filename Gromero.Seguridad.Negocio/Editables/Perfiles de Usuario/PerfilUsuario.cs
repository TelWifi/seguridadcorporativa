using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using Gromero.Seguridad.Negocio.Comandos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class PerfilUsuario : BusinessBase<PerfilUsuario>
	{
		#region Business Methods


		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _Id = IdProperty.DefaultValue;
		public string ID
		{
			get { return GetProperty(IdProperty, _Id); }
			set { SetProperty(IdProperty, ref _Id, value); }
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

		public static readonly PropertyInfo<string> UsuarioProperty = RegisterProperty<string>(c => c.Usuario);
		[Required]
		public string Usuario
		{
			get { return GetProperty(UsuarioProperty); }
			set { SetProperty(UsuarioProperty, value); }
		}

		public static readonly PropertyInfo<string> AplicacionProperty = RegisterProperty<string>(c => c.Aplicacion);
		[Required]
		public string Aplicacion
		{
			get { return GetProperty(AplicacionProperty); }
			set { SetProperty(AplicacionProperty, value); }
		}

		public static readonly PropertyInfo<DateTime> UltimoIngresoProperty = RegisterProperty<DateTime>(c => c.UltimoIngreso);
		public DateTime UltimoIngreso
		{
			get { return GetProperty(UltimoIngresoProperty); }
			set { SetProperty(UltimoIngresoProperty, value); }
		}

		public static readonly PropertyInfo<bool> CaducaProperty = RegisterProperty<bool>(c => c.Caduca);
		public bool Caduca
		{
			get { return GetProperty(CaducaProperty); }
			set { SetProperty(CaducaProperty, value); }
		}

		public static readonly PropertyInfo<DateTime> VigenciaInicioProperty = RegisterProperty<DateTime>(c => c.VigenciaInicio);
		public DateTime VigenciaInicio
		{
			get { return GetProperty(VigenciaInicioProperty); }
			set { SetProperty(VigenciaInicioProperty, value); }
		}

		public static readonly PropertyInfo<DateTime> VigenciaFinProperty = RegisterProperty<DateTime>(c => c.VigenciaFin);
		public DateTime VigenciaFin
		{
			get { return GetProperty(VigenciaFinProperty); }
			set { SetProperty(VigenciaFinProperty, value); }
		}

		public static readonly PropertyInfo<RolPerfiles> RolesPerfilesProperty = RegisterProperty<RolPerfiles>(c => c.RolesPerfiles, RelationshipTypes.Child | RelationshipTypes.LazyLoad);

		public RolPerfiles RolesPerfiles
		{
			get
			{
				if (!FieldManager.FieldExists(RolesPerfilesProperty))
				{
					RolesPerfiles = RolPerfiles.GetRolPerfiles(ID);
				}
				return GetProperty(RolesPerfilesProperty);
			}
			private set
			{
				LoadProperty(RolesPerfilesProperty, value);
				OnPropertyChanged(RolesPerfilesProperty);
			}
		}

		public static readonly PropertyInfo<RecursosPerfil> RecursosProperty = RegisterProperty<RecursosPerfil>(c => c.Recursos, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public RecursosPerfil Recursos
		{
			get
			{
				if (!FieldManager.FieldExists(RecursosProperty))
				{
					RecursosPerfil.BeginGetRecursosPerfil(ID, (o, e) =>
					  {
						  if (e.Error != null)
							  throw e.Error;
						  if (!FieldManager.FieldExists(RecursosProperty))
						  {
							  Recursos = e.Object;
						  }
					  });
					return null;
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

		public static PerfilUsuario NewPerfilUsuario()
		{
			//if (!CanAdd())
			//    throw new SecurityException(Publicos.msgPermisosAgregar);
			return DataPortal.Create<PerfilUsuario>();
		}

		public static PerfilUsuario GetPerfilUsuario(string id)
		{
			//if (!CanGet())
			//    throw new SecurityException(Publicos.msgPermisosLeer);
			return DataPortal.Fetch<PerfilUsuario>(id);
		}

		public static void DeletePerfilUsuario(string id)
		{
			//if (!CanDelete())
			//    throw new SecurityException(Publicos.msgPermisosEliminar);
			DataPortal.Delete<PerfilUsuario>(id);
		}

		public new PerfilUsuario Save()
		{
			//if (!IsNew && !CanUpdate())
			//    throw new SecurityException(Publicos.msgPermisosActualizar);
			return base.Save();
		}

		private PerfilUsuario()
		{ /* Require use of factory methods */ }

		#endregion

		#region Reglas de Autorizacion
		public static bool CanAdd()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeAgregar, typeof(PerfilUsuario).Name);
		}

		public static bool CanGet()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeLeer, typeof(PerfilUsuario).Name);
		}

		public static bool CanDelete()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeEliminar, typeof(PerfilUsuario).Name);
		}

		public static bool CanUpdate()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeActualizar, typeof(PerfilUsuario).Name);
		}

		#endregion

		#region Metodos de Instancia

		/// <summary>
		/// Agregar Recursos de la Aplicacion
		/// </summary>
		public void AgregaRecursos()
		{
			var app = Editables.Aplicacion.GetAplicacion(IdAplicacion);
			foreach (var item in app.Recursos)
			{
				foreach (var recurso in RecursosDetalleCommand.Execute(item.IdRecurso))
				{
					RecursoPerfil recursoPerfil = RecursoPerfil.NewRecursoPerfil();
					recursoPerfil.IdPerfilUsuario = ID;
					recursoPerfil.IdRecursoDetalle = recurso.IdRecursoDetalle;
					recursoPerfil.Codigo = recurso.Codigo;
					recursoPerfil.Descripcion = recurso.Descripcion;
					recursoPerfil.Nivel = recurso.Nivel;
					if (!Recursos.Contains(recursoPerfil))
						this.Recursos.Add(recursoPerfil);
				}
			}
		}


		#endregion

		#region Data Access

		[RunLocal]
		protected override void DataPortal_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Caduca = true;
				UltimoIngreso = DateTime.Now;
				VigenciaInicio = DateTime.Now;
				VigenciaFin = DateTime.Now.AddYears(1);
			}
			BusinessRules.CheckRules();
		}

		private void DataPortal_Fetch(string criteria)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var entidad = ctx.DbContext.SelectPerfilUsuarioInfo(criteria).FirstOrDefault();
				if (entidad == null)
					throw new InvalidOperationException("No se encontró el registro!");

				ID = entidad.IdPerfilUsuario;
				IdUsuario = entidad.IdUsuario;
				IdAplicacion = entidad.IdAplicacion;
				Usuario = string.Format(
							  "{0} {1} {2} ({3})",
							  entidad.Nombres,
							  entidad.ApellidoPaterno,
							  entidad.ApellidoMaterno,
							  entidad.CodigoUsuario);
				Aplicacion = entidad.NombreAplicacion;
				UltimoIngreso = entidad.UltimoIngreso;
				Caduca = entidad.Caduca;
				VigenciaInicio = entidad.VigenciaInicio;
				VigenciaFin = entidad.VigenciaFin; // ?? entidad.VigenciaFin.Value;
			}
			BusinessRules.CheckRules();
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			try
			{
				using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
				{
					var entidad = new Datos.PerfilUsuario();
					DoInsertUpdate(entidad);
					ctx.DbContext.PerfilUsuario.Add(entidad);
					FieldManager.UpdateChildren(this);
					ctx.DbContext.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Trace.Write(ex.ToString());
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
						var entidad = ctx.DbContext.SelectPerfilUsuario(ID).FirstOrDefault();
						DoInsertUpdate(entidad);
					}
					RolesPerfiles.Save();
					if (Recursos != null)
						Recursos.Save();
					ctx.DbContext.SaveChanges();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		private void DoInsertUpdate(Datos.PerfilUsuario cmd)
		{
			using (BypassPropertyChecks)
			{
				cmd.IdPerfilUsuario = ID;
				cmd.IdAplicacion = IdAplicacion;
				cmd.IdUsuario = IdUsuario;
				cmd.Logueado = false;
				cmd.Caduca = Caduca;
				cmd.UltimoIngreso = UltimoIngreso;
				cmd.VigenciaInicio = VigenciaInicio;
				cmd.VigenciaFin = VigenciaFin;
				cmd.Placa = Csla.ApplicationContext.GlobalContext["Placa"].ToString();
				cmd.Usuario = Csla.ApplicationContext.GlobalContext["Usuario"].ToString();
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(this.ID);
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(string criteria)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var entidad = ctx.DbContext.SelectPerfilUsuario(criteria).FirstOrDefault();
				ctx.DbContext.PerfilUsuario.Remove(entidad);
				ctx.DbContext.SaveChanges();
			}
		}


		#endregion

	}

}
