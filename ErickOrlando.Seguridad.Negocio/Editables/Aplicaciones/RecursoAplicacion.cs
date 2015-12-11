using Csla;
using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using System;
using System.ComponentModel;
using System.Linq;

namespace ErickOrlando.Seguridad.Negocio.Editables
{

	[Serializable]
	public class RecursoAplicacion : BusinessBase<RecursoAplicacion>
	{
		#region Business Methods

		// TODO: add your own fields, properties and methods

		// example with private backing field
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _ID = IdProperty.DefaultValue;
		[Browsable(false)]
		public string ID
		{
			get { return GetProperty(IdProperty, _ID); }
			set { SetProperty(IdProperty, ref _ID, value); }
		}

		public static readonly PropertyInfo<string> IdAplicacionProperty = RegisterProperty<string>(c => c.IdAplicacion);
		[Browsable(false)]
		public string IdAplicacion
		{
			get { return GetProperty(IdAplicacionProperty); }
			set { SetProperty(IdAplicacionProperty, value); }
		}

		public static readonly PropertyInfo<string> IdRecursoProperty = RegisterProperty<string>(c => c.IdRecurso);
		public string IdRecurso
		{
			get { return GetProperty(IdRecursoProperty); }
			set { SetProperty(IdRecursoProperty, value); }
		}

		public string NombreRecurso { get; set; }

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

		internal static RecursoAplicacion NewRecursoAplicacion()
		{
			return DataPortal.CreateChild<RecursoAplicacion>();
		}

		internal static RecursoAplicacion GetRecursoAplicacion(Datos.SelectRecursoAplicacion_Result childData)
		{
			return DataPortal.FetchChild<RecursoAplicacion>(childData);
		}

		private RecursoAplicacion()
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

			BusinessRules.CheckRules();
		}

		private void Child_Fetch(Datos.SelectRecursoAplicacion_Result childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdRecursoAplicacion;
				IdAplicacion = childData.IdAplicacion;
				IdRecurso = childData.IdRecurso;
				NombreRecurso = childData.DescripcionRecurso;
				Conceder = childData.Conceder;
			}
			MarkOld();
		}

		private void Child_Insert(Aplicacion parent)
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Datos.RecursoAplicacion();
				IdAplicacion = parent.ID;
				DoInsertUpdate(detalle);

				ctx.DbContext.RecursoAplicacion.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Datos.RecursoAplicacion dr)
		{
			using (BypassPropertyChecks)
			{
				dr.IdRecursoAplicacion = ID;
				dr.IdRecurso = IdRecurso;
				dr.IdAplicacion = IdAplicacion;
				dr.Conceder = Conceder;
			}
		}

		private void Child_Update(Aplicacion parent)
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var detalle = ctx.DbContext.RecursoAplicacion.Single(r => r.IdRecursoAplicacion == ID);
					DoInsertUpdate(detalle);
					MarkOld();
				}
				FieldManager.UpdateChildren(this);
			}
		}

		private void Child_DeleteSelf()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (!IsNew)
				{
					var detalle = ctx.DbContext.RecursoAplicacion.Single(r => r.IdRecursoAplicacion == ID);
					ctx.DbContext.RecursoAplicacion.Remove(detalle);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion
	}
}
