using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class Empresa : BusinessBase<Empresa>
	{
		#region Business Methods

		// TODO: add your own fields, properties and methods

		// example with private backing field
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.Id, RelationshipTypes.PrivateField);
		private string _Id = IdProperty.DefaultValue;
		public string Id
		{
			get { return GetProperty(IdProperty, _Id); }
			set { SetProperty(IdProperty, ref _Id, value); }
		}

		public static readonly PropertyInfo<string> CodigoProperty = RegisterProperty<string>(c => c.Codigo);
		[Required]
		public string Codigo
		{
			get { return GetProperty(CodigoProperty); }
			set { SetProperty(CodigoProperty, value); }
		}

		public static readonly PropertyInfo<string> RazonSocialProperty = RegisterProperty<string>(c => c.RazonSocial, "Razón Social");
		[Required]
		public string RazonSocial
		{
			get { return GetProperty(RazonSocialProperty); }
			set { SetProperty(RazonSocialProperty, value); }
		}

		public static readonly PropertyInfo<string> NombreCortoProperty = RegisterProperty<string>(c => c.NombreCorto);
		[Required]
		public string NombreCorto
		{
			get { return GetProperty(NombreCortoProperty); }
			set { SetProperty(NombreCortoProperty, value); }
		}

		public static readonly PropertyInfo<string> RUCProperty = RegisterProperty<string>(c => c.RUC);
		[Required]
		[StringLength(11)]
		public string RUC
		{
			get { return GetProperty(RUCProperty); }
			set { SetProperty(RUCProperty, value); }
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

		public static Empresa NewEmpresa()
		{
			//if (!CanAdd())
			//    throw new SecurityException(Publicos.msgPermisosAgregar);
			return DataPortal.Create<Empresa>();
		}

		public static Empresa GetEmpresa(string id)
		{
			//if (!CanGet())
			//    throw new SecurityException(Publicos.msgPermisosLeer);
			return DataPortal.Fetch<Empresa>(id);
		}

		public static void DeleteEmpresa(string id)
		{
			//if (!CanDelete())
			//    throw new SecurityException(Publicos.msgPermisosEliminar);
			DataPortal.Delete<Empresa>(id);
		}

		public new Empresa Save()
		{
			if (!IsNew && !CanUpdate())
				throw new SecurityException(Publicos.msgPermisosActualizar);
			return base.Save();
		}

		private Empresa()
		{ /* Require use of factory methods */ }

		#endregion

		#region Reglas de Autorizacion
		public static bool CanAdd()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeAgregar, typeof(Empresa).Name);
		}

		public static bool CanGet()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeLeer, typeof(Empresa).Name);
		}

		public static bool CanDelete()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeEliminar, typeof(Empresa).Name);
		}

		public static bool CanUpdate()
		{
			return Publicos.ConsultarPermisos(TipoAccion.PuedeActualizar, typeof(Empresa).Name);
		}
		#endregion

		#region Data Access

		[RunLocal]
		protected override void DataPortal_Create()
		{
			// TODO: load default values
			// omit this override if you have no defaults to set
			using (BypassPropertyChecks)
			{
				Id = Guid.NewGuid().ToString();
			}
			BusinessRules.CheckRules();
		}

		private void DataPortal_Fetch(string criteria)
		{
			// TODO: load values
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var q = ctx.DbContext.SelectEmpresa(criteria).FirstOrDefault();
				if (q != null)
				{
					Id = q.IdEmpresa;
					Codigo = q.CodigoEmpresa;
					RazonSocial = q.RazonSocial;
					NombreCorto = q.NombreCorto;
					RUC = q.RUC;
				}
				else
					throw new InvalidOperationException("No se encontró el registro");
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var empresa = new Empresas();
				DoInsertUpdate(empresa);
				ctx.DbContext.Empresas.Add(empresa);
				ctx.DbContext.SaveChanges(); //Commit
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var empresa = ctx.DbContext.SelectEmpresa(Id).FirstOrDefault();
				DoInsertUpdate(empresa);
				ctx.DbContext.SaveChanges(); //Commit
			}
		}

		private void DoInsertUpdate(Empresas empresa)
		{
			empresa.IdEmpresa = Id;
			empresa.CodigoEmpresa = Codigo;
			empresa.RazonSocial = RazonSocial;
			empresa.NombreCorto = NombreCorto;
			empresa.RUC = RUC;
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
				var entidad = ctx.DbContext.Empresas.Single(r => r.IdEmpresa.Equals(criteria));
				ctx.DbContext.Empresas.Remove(entidad);
				ctx.DbContext.SaveChanges();
			}
		}

		#endregion
	}
}
