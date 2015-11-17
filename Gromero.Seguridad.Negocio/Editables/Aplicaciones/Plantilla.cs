using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{

	[Serializable]
	public class Plantilla : BusinessBase<Plantilla>, IEquatable<Plantilla>
	{
		#region Business Methods

		// TODO: add your own fields, properties and methods

		// example with private backing field
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _ID = IdProperty.DefaultValue;
		public string ID
		{
			get { return GetProperty(IdProperty, _ID); }
			set { SetProperty(IdProperty, ref _ID, value); }
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

		public static readonly PropertyInfo<string> NombreRolProperty = RegisterProperty<string>(c => c.NombreRol);
		public string NombreRol
		{
			get { return GetProperty(NombreRolProperty); }
			set { SetProperty(NombreRolProperty, value); }
		}

		public static readonly PropertyInfo<string> NombreOpcionProperty = RegisterProperty<string>(c => c.NombreOpcion);
		public string NombreOpcion
		{
			get { return GetProperty(NombreOpcionProperty); }
			set { SetProperty(NombreOpcionProperty, value); }
		}

		public static readonly PropertyInfo<bool> ConcederProperty = RegisterProperty<bool>(c => c.Conceder);
		public bool Conceder
		{
			get { return GetProperty(ConcederProperty); }
			set { SetProperty(ConcederProperty, value); }
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

		internal static Plantilla NewPlantilla()
		{
			return DataPortal.CreateChild<Plantilla>();
		}

		internal static Plantilla GetPlantilla(Datos.SelectPlantilla_Result childData)
		{
			return DataPortal.FetchChild<Plantilla>(childData);
		}

		private Plantilla()
		{ /* Require use of factory methods */ }

		#endregion

		#region Data Access

		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Conceder = true;
			}
			MarkNew();
		}

		private void Child_Fetch(Datos.SelectPlantilla_Result childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdPlantilla;
				IdAplicacion = childData.IdAplicacion;
				IdRol = childData.IdRol;
				NombreRol = childData.NombreRol;
				NombreOpcion = childData.NombreOpcion;
				//if (childData.Conceder.HasValue)
				Conceder = childData.Conceder;
			}
			MarkOld();
		}

		private void Child_Insert(Opcion parent)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Datos.Plantilla() { IdOpcionUI = parent.ID };
				DoInsertUpdate(detalle);
				ctx.DbContext.Plantilla.Add(detalle);
				MarkOld();
				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Datos.Plantilla detalle)
		{
			using (BypassPropertyChecks)
			{
				detalle.IdPlantilla = ID;
				detalle.IdAplicacion = IdAplicacion;
				detalle.IdRol = IdRol;
				detalle.Conceder = Conceder;
			}
		}

		private void Child_Update(Opcion parent)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var plantilla = ctx.DbContext.Plantilla.Single(r => r.IdPlantilla == ID);
					DoInsertUpdate(plantilla);
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
					var plantilla = ctx.DbContext.Plantilla.Single(r => r.IdPlantilla == ID);
					ctx.DbContext.Plantilla.Remove(plantilla);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion

		#region Miembros de IEquatable<Plantilla>

		public bool Equals(Plantilla other)
		{
			if (string.IsNullOrEmpty(other.IdRol))
				return false;
			if (string.IsNullOrEmpty(IdRol))
				return false;
			return other.IdRol.Equals(this.IdRol);
		}

		#endregion
	}
}
