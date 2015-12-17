using Csla;
using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using ErickOrlando.Seguridad.Negocio.Comunes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ErickOrlando.Seguridad.Negocio.Editables
{

	[Serializable]
	public class RecursoDetalle : BusinessBase<RecursoDetalle>, IRecursivo
	{
		#region Business Methods

		// example with private backing field
		public static readonly PropertyInfo<string> IdProperty = RegisterProperty<string>(p => p.ID, RelationshipTypes.PrivateField);
		private string _ID = IdProperty.DefaultValue;
		public string ID
		{
			get { return GetProperty(IdProperty, _ID); }
			set { SetProperty(IdProperty, ref _ID, value); }
		}

		public static readonly PropertyInfo<string> IdRecursoProperty = RegisterProperty<string>(c => c.IdRecurso);
		public string IdRecurso
		{
			get { return GetProperty(IdRecursoProperty); }
			set { SetProperty(IdRecursoProperty, value); }
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

		public static readonly PropertyInfo<string> IdRecursoDetallePadreProperty = RegisterProperty<string>(c => c.IdRecursoDetallePadre);
		public string IdRecursoDetallePadre
		{
			get { return GetProperty(IdRecursoDetallePadreProperty); }
			set { SetProperty(IdRecursoDetallePadreProperty, value); }
		}

		public static readonly PropertyInfo<int> NivelProperty = RegisterProperty<int>(c => c.Nivel);
		public int Nivel
		{
			get { return GetProperty(NivelProperty); }
			set { SetProperty(NivelProperty, value); }
		}

		public static readonly PropertyInfo<RecursoDetalles> DetallesProperty = RegisterProperty<RecursoDetalles>(c => c.Detalles, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public RecursoDetalles Detalles
		{
			get
			{
				if (!FieldManager.FieldExists(DetallesProperty))
				{
					RecursoDetalles.BeginGetRecursoDetalles(new SingleCriteria<string>(ID), (o, e) =>
					  {
						  if (e.Error != null)
							  throw e.Error;
						  if (!FieldManager.FieldExists(DetallesProperty))
						  {
							  Detalles = e.Object;
						  }
					  });
					return null;
				}
				return GetProperty(DetallesProperty);
			}
			private set
			{
				LoadProperty(DetallesProperty, value);
				OnPropertyChanged(DetallesProperty);
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

		internal static RecursoDetalle NewRecursoDetalle()
		{
			return DataPortal.CreateChild<RecursoDetalle>();
		}

		internal static RecursoDetalle GetRecursoDetalle(Datos.RecursoDetalle childData)
		{
			return DataPortal.FetchChild<RecursoDetalle>(childData);
		}

		private RecursoDetalle()
		{ /* Require use of factory methods */ }

		#endregion

		#region Data Access

		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				IdRecursoDetallePadre = string.Empty;
				Nivel = 1;
			}

			BusinessRules.CheckRules();
		}

		private void Child_Fetch(Datos.RecursoDetalle childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdRecursoDetalle;
				IdRecurso = childData.IdRecurso;
				IdRecursoDetallePadre = childData.IdRecursoDetallePadre;
				Codigo = childData.Codigo;
				Descripcion = childData.Descripcion;
				Nivel = childData.Nivel;
			}
			MarkOld();
		}

		private void Child_Insert(IRecurso parent)
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Datos.RecursoDetalle();
				IdRecurso = parent.IdRecurso;
				DoInsertUpdate(detalle);

				ctx.DbContext.RecursoDetalle.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Datos.RecursoDetalle dr)
		{
			using (BypassPropertyChecks)
			{
				dr.IdRecursoDetalle = ID;
				dr.IdRecurso = IdRecurso;
				if (string.IsNullOrEmpty(IdRecursoDetallePadre))
					dr.IdRecursoDetallePadre = null;
				else
					dr.IdRecursoDetallePadre = IdRecursoDetallePadre;
				dr.Codigo = Codigo;
				dr.Descripcion = Descripcion;
				dr.Nivel = Nivel;
			}
		}

		private void Child_Update()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var detalle = ctx.DbContext.RecursoDetalle.Single(r => r.IdRecursoDetalle == ID);
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
					var detalle = ctx.DbContext.RecursoDetalle.Single(r => r.IdRecursoDetalle == ID);
					ctx.DbContext.RecursoDetalle.Remove(detalle);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion

		#region Implementacion de IRecursivo
		public string IdPadre
		{
			get
			{
				return IdRecursoDetallePadre;
			}
			set
			{
				IdRecursoDetallePadre = value;
			}
		}
		#endregion
	}
}
