using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class Cargo : BusinessBase<Cargo>
	{
		#region Business Methods


		// ejemplo con un campo de respaldo
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _Id = IdProperty.DefaultValue;
		public string ID
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

		public static readonly PropertyInfo<string> DescripcionProperty = RegisterProperty<string>(c => c.Descripcion);
		[Required]
		public string Descripcion
		{
			get { return GetProperty(DescripcionProperty); }
			set { SetProperty(DescripcionProperty, value); }
		}

		public static readonly PropertyInfo<bool> EstadoProperty = RegisterProperty<bool>(c => c.Estado);
		public bool Estado
		{
			get { return GetProperty(EstadoProperty); }
			set { SetProperty(EstadoProperty, value); }
		}

		public static readonly PropertyInfo<CargoSociedades> SociedadesProperty = RegisterProperty<CargoSociedades>(c => c.Sociedades, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public CargoSociedades Sociedades
		{
			get
			{
				if (!FieldManager.FieldExists(SociedadesProperty))
				{
					Sociedades = CargoSociedades.GetCargoSociedades(ID);
				}
				return GetProperty(SociedadesProperty);
			}
			private set
			{
				LoadProperty(SociedadesProperty, value);
				OnPropertyChanged(SociedadesProperty);
			}
		}

		#endregion

		#region Business Rules

		protected override void AddBusinessRules()
		{
			// TODO: agregar las reglas de validación personalizadas
			base.AddBusinessRules();

			//BusinessRules.AddRule(new Rule(IdProperty));
		}

		private static void AddAuthorizationRules()
		{
			// TODO: Agregar las reglas de autorización
			//BusinessRules.AddRule(...);
		}

		#endregion

		#region Factory Methods

		public static Cargo NewCargo()
		{
			return DataPortal.Create<Cargo>();
		}

		public static Cargo GetCargo(string id)
		{
			return DataPortal.Fetch<Cargo>(id);
		}

		public static void DeleteCargo(string id)
		{
			DataPortal.Delete<Cargo>(id);
		}

		private Cargo()
		{ /* Requerido para los factory methods */ }

		#endregion

		#region Data Access

		[RunLocal]
		protected override void DataPortal_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Estado = true;
			}
			BusinessRules.CheckRules();
		}

		private void DataPortal_Fetch(string criteria)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var entidad = ctx.DbContext.SelectCargo(criteria).FirstOrDefault();
				if (entidad != null)
				{
					ID = entidad.IdCargo;
					Codigo = entidad.CodigoCargo;
					Descripcion = entidad.Descripcion;
					Estado = entidad.Estado;
				}
				else
					throw new InvalidOperationException("No se encontró el registro!");
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var entidad = new Datos.Cargo();
				DoInsertUpdate(entidad);
				ctx.DbContext.Cargo.Add(entidad);
				FieldManager.UpdateChildren(this);
				ctx.DbContext.SaveChanges();
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var entidad = ctx.DbContext.SelectCargo(ID).FirstOrDefault();
					DoInsertUpdate(entidad);
				}
				FieldManager.UpdateChildren(this);
				ctx.DbContext.SaveChanges();
			}
		}

		private void DoInsertUpdate(Datos.Cargo cmd)
		{
			using (BypassPropertyChecks)
			{
				cmd.IdCargo = ID;
				cmd.CodigoCargo = Codigo;
				cmd.Descripcion = Descripcion;
				cmd.Estado = Estado;
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
				var entidad = ctx.DbContext.SelectCargo(criteria).FirstOrDefault();
				ctx.DbContext.Cargo.Remove(entidad);
				ctx.DbContext.SaveChanges();

			}
		}

		#endregion
	}
}
