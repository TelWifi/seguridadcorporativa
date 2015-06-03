using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public partial class Usuario : BusinessBase<Usuario>
	{
		#region Business Methods


		// example with private backing field
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.Id, RelationshipTypes.PrivateField);
		private string _Id = IdProperty.DefaultValue;
		public string Id
		{
			get { return GetProperty(IdProperty, _Id); }
			set { SetProperty(IdProperty, ref _Id, value); }
		}

		// TODO: add your own fields, properties and methods
		public static readonly PropertyInfo<string> IdEmpresaProperty = RegisterProperty<string>(c => c.IdEmpresa, "Empresa donde labora");
		[Required]
		public string IdEmpresa
		{
			get { return GetProperty(IdEmpresaProperty); }
			set { SetProperty(IdEmpresaProperty, value); }
		}

		public static readonly PropertyInfo<string> IdEmpresaPertenenciaProperty = RegisterProperty<string>(c => c.IdEmpresaPertenencia, "Empresa a la que pertenece");
		[Required]
		public string IdEmpresaPertenencia
		{
			get { return GetProperty(IdEmpresaPertenenciaProperty); }
			set { SetProperty(IdEmpresaPertenenciaProperty, value); }
		}

		public static readonly PropertyInfo<string> IdCargoSociedadProperty = RegisterProperty<string>(c => c.IdCargoSociedad);
		public string IdCargoSociedad
		{
			get { return GetProperty(IdCargoSociedadProperty); }
			set { SetProperty(IdCargoSociedadProperty, value); }
		}

		public static readonly PropertyInfo<string> CodigoProperty = RegisterProperty<string>(c => c.Codigo);
		[Required]
		public string Codigo
		{
			get { return GetProperty(CodigoProperty); }
			set { SetProperty(CodigoProperty, value); }
		}

		public static readonly PropertyInfo<string> DominioProperty = RegisterProperty<string>(c => c.Dominio);
		[Required]
		[StringLength(50)]
		public string Dominio
		{
			get { return GetProperty(DominioProperty); }
			set { SetProperty(DominioProperty, value); }
		}

		public static readonly PropertyInfo<string> NombresProperty = RegisterProperty<string>(c => c.Nombres);
		[Required]
		public string Nombres
		{
			get { return GetProperty(NombresProperty); }
			set { SetProperty(NombresProperty, value); }
		}

		public static readonly PropertyInfo<string> ApellidoPaternoProperty = RegisterProperty<string>(c => c.ApellidoPaterno, "Apellido Paterno");
		[Required]
		public string ApellidoPaterno
		{
			get { return GetProperty(ApellidoPaternoProperty); }
			set { SetProperty(ApellidoPaternoProperty, value); }
		}

		public static readonly PropertyInfo<string> ApellidoMaternoProperty = RegisterProperty<string>(c => c.ApellidoMaterno, "Apellido Materno");
		[Required]
		public string ApellidoMaterno
		{
			get { return GetProperty(ApellidoMaternoProperty); }
			set { SetProperty(ApellidoMaternoProperty, value); }
		}

		public static readonly PropertyInfo<string> CorreoProperty = RegisterProperty<string>(c => c.Correo, "Correo Electrónico");
		[Required]
		public string Correo
		{
			get { return GetProperty(CorreoProperty); }
			set { SetProperty(CorreoProperty, value); }
		}

		public static readonly PropertyInfo<string> DNIProperty = RegisterProperty<string>(c => c.DNI);
		[StringLength(8, MinimumLength = 8)]
		public string DNI
		{
			get { return GetProperty(DNIProperty); }
			set { SetProperty(DNIProperty, value); }
		}

		public static readonly PropertyInfo<string> AliasProperty = RegisterProperty<string>(c => c.Alias);
		[StringLength(12)]
		[Required]
		public string Alias
		{
			get { return GetProperty(AliasProperty); }
			set { SetProperty(AliasProperty, value); }
		}

		public static readonly PropertyInfo<string> AliasAlternoProperty = RegisterProperty<string>(c => c.AliasAlterno);
		public string AliasAlterno
		{
			get { return GetProperty(AliasAlternoProperty); }
			set { SetProperty(AliasAlternoProperty, value); }
		}

		public static readonly PropertyInfo<bool> EstadoProperty = RegisterProperty<bool>(c => c.Estado);
		public bool Estado
		{
			get { return GetProperty(EstadoProperty); }
			set { SetProperty(EstadoProperty, value); }
		}

		public static readonly PropertyInfo<string> TipoProperty = RegisterProperty<string>(c => c.Tipo);
		[Required]
		public string Tipo
		{
			get { return GetProperty(TipoProperty); }
			set { SetProperty(TipoProperty, value); }
		}

		public static readonly PropertyInfo<bool> NotificarConCorreoProperty = RegisterProperty<bool>(c => c.NotificarConCorreo);
		public bool NotificarConCorreo
		{
			get { return GetProperty(NotificarConCorreoProperty); }
			set { SetProperty(NotificarConCorreoProperty, value); }
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

		public static Usuario NewUsuario()
		{
			//if (!CanAdd())
			//    throw new SecurityException(Publicos.msgPermisosAgregar);
			return DataPortal.Create<Usuario>();
		}

		public static Usuario GetUsuario(string id)
		{
			//if (!CanGet())
			//    throw new SecurityException(Publicos.msgPermisosLeer);
			return DataPortal.Fetch<Usuario>(id);
		}

		public static void DeleteUsuario(string id)
		{
			DataPortal.Delete<Usuario>(id);
		}

		public new Usuario Save()
		{
			//if (!IsNew && !CanUpdate())
			//    throw new SecurityException(Publicos.msgPermisosActualizar);
			return base.Save();
		}

		private Usuario()
		{ /* Require use of factory methods */ }

		#endregion

		#region Reglas de Autorizacion
		public static bool CanAdd()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeAgregar, typeof(Usuario).Name);
		}

		public static bool CanGet()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeLeer, typeof(Usuario).Name);
		}

		public static bool CanDelete()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeEliminar, typeof(Usuario).Name);
		}

		public static bool CanUpdate()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeActualizar, typeof(Usuario).Name);
		}
		#endregion

		#region Data Access

		[RunLocal]
		protected override void DataPortal_Create()
		{
			using (BypassPropertyChecks)
			{
				Id = Guid.NewGuid().ToString();
				Estado = true;
				Tipo = "E";
			}
			BusinessRules.CheckRules();
		}

		private void DataPortal_Fetch(string criteria)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var usuario = ctx.DbContext.SelectUsuario(criteria).FirstOrDefault();
				if (usuario != null)
				{
					using (BypassPropertyChecks)
					{
						Id = usuario.IdUsuario;
						IdEmpresa = usuario.IdEmpresa;
						IdEmpresaPertenencia = usuario.IdEmpresaPertenencia;
						IdCargoSociedad = usuario.IdCargoSociedad;
						Codigo = usuario.CodigoUsuario;
						Dominio = usuario.Dominio;
						Nombres = usuario.Nombres;
						ApellidoPaterno = usuario.ApellidoPaterno;
						ApellidoMaterno = usuario.ApellidoMaterno;
						Correo = usuario.Correo;
						DNI = usuario.DNI;
						Alias = usuario.Alias;
						AliasAlterno = usuario.AliasAlterno;
						Estado = usuario.Estado;
						Tipo = usuario.Tipo;
					}
				}
			}
			BusinessRules.CheckRules();
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var usuario = new Usuarios();
				DoInsertUpdate(usuario);
				ctx.DbContext.Usuarios.Add(usuario);
				ctx.DbContext.SaveChanges();
			}
			EnviarCorreo();
		}

		private void DoInsertUpdate(Usuarios usuario)
		{
			using (BypassPropertyChecks)
			{
				usuario.IdUsuario = Id;
				usuario.IdEmpresa = IdEmpresa;
				usuario.IdEmpresaPertenencia = IdEmpresaPertenencia;
				usuario.IdCargoSociedad = IdCargoSociedad;
				usuario.CodigoUsuario = Codigo;
				usuario.Dominio = Dominio;
				usuario.Nombres = Nombres;
				usuario.ApellidoPaterno = ApellidoPaterno;
				usuario.ApellidoMaterno = ApellidoMaterno;
				usuario.Correo = Correo;
				usuario.DNI = DNI;
				usuario.Alias = Alias;
				usuario.AliasAlterno = AliasAlterno;
				usuario.Estado = Estado;
				usuario.Tipo = Tipo;
			}
		}

		private void EnviarCorreo()
		{
			if (NotificarConCorreo)
			{
				if (Tipo == "E")
					EnvioCorreo(TipoCorreo.UsuarioNuevoExterno);
				else
					EnvioCorreo(TipoCorreo.UsuarioNuevoInterno);
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var usuario = ctx.DbContext.SelectUsuario(Id).FirstOrDefault();
				DoInsertUpdate(usuario);
				ctx.DbContext.SaveChanges();
			}
			EnviarCorreo();
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(this.Id);
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(string criteria)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var usuario = ctx.DbContext.SelectUsuario(criteria).FirstOrDefault();
				ctx.DbContext.Usuarios.Remove(usuario);
				ctx.DbContext.SaveChanges();
			}
		}

		#endregion
	}

}
