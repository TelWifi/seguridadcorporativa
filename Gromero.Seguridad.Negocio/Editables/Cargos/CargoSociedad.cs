using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{

	[Serializable]
	public class CargoSociedad : BusinessBase<CargoSociedad>
	{
		#region Business Methods

		// example with private backing field
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _ID = IdProperty.DefaultValue;
		[Browsable(false)]
		public string ID
		{
			get { return GetProperty(IdProperty, _ID); }
			set { SetProperty(IdProperty, ref _ID, value); }
		}

		public static readonly PropertyInfo<string> IdCargoProperty = RegisterProperty<string>(c => c.IdCargo);
		[Browsable(false)]
		public string IdCargo
		{
			get { return GetProperty(IdCargoProperty); }
			set { SetProperty(IdCargoProperty, value); }
		}

		public static readonly PropertyInfo<string> CodigoSociedadProperty = RegisterProperty<string>(c => c.CodigoSociedad);
		[Required]
		public string CodigoSociedad
		{
			get { return GetProperty(CodigoSociedadProperty); }
			set { SetProperty(CodigoSociedadProperty, value); }
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

		internal static CargoSociedad NewCargoSociedad()
		{
			return DataPortal.CreateChild<CargoSociedad>();
		}

		internal static CargoSociedad GetCargoSociedad(Datos.CargoSociedad childData)
		{
			return DataPortal.FetchChild<CargoSociedad>(childData);
		}

		private CargoSociedad()
		{ /* Require use of factory methods */ }

		#endregion

		#region Data Access

		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
			}

			BusinessRules.CheckRules();
		}

		private void Child_Fetch(Datos.CargoSociedad childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdCargoSociedad;
				IdCargo = childData.IdCargo;
				CodigoSociedad = childData.CodSociedadPropietaria;
			}
			MarkOld();
		}

		private void Child_Insert(Cargo parent)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Datos.CargoSociedad();
				IdCargo = parent.ID;
				DoInsertUpdate(detalle);

				ctx.DbContext.CargoSociedad.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Datos.CargoSociedad dr)
		{
			using (BypassPropertyChecks)
			{
				dr.IdCargoSociedad = ID;
				dr.IdCargo = IdCargo;
				dr.CodSociedadPropietaria = CodigoSociedad;
			}
		}

		private void Child_Update()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var detalle = ctx.DbContext.CargoSociedad.Single(r => r.IdCargoSociedad == ID);
					DoInsertUpdate(detalle);
					MarkOld();
				}
				FieldManager.UpdateChildren(this);
			}
		}

		private void Child_DeleteSelf()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (!IsNew)
				{
					var detalle = ctx.DbContext.CargoSociedad.Single(r => r.IdCargoSociedad == ID);
					ctx.DbContext.CargoSociedad.Remove(detalle);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion
	}
}
