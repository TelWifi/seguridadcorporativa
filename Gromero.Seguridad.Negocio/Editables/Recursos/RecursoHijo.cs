using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using Gromero.Seguridad.Negocio.Comunes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{

	[Serializable]
	public class RecursoHijo : BusinessBase<RecursoHijo>, IRecursivo, IRecurso
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

		public static readonly PropertyInfo<string> IdRecursoPadreProperty = RegisterProperty<string>(c => c.IdRecursoPadre);
		public string IdRecursoPadre
		{
			get { return GetProperty(IdRecursoPadreProperty); }
			set { SetProperty(IdRecursoPadreProperty, value); }
		}

		public static readonly PropertyInfo<string> DescripcionProperty = RegisterProperty<string>(c => c.Descripcion);
		[Required]
		public string Descripcion
		{
			get { return GetProperty(DescripcionProperty); }
			set { SetProperty(DescripcionProperty, value); }
		}

		public static readonly PropertyInfo<string> RutaRecursoProperty = RegisterProperty<string>(c => c.RutaRecurso);
		public string RutaRecurso
		{
			get { return GetProperty(RutaRecursoProperty); }
			set { SetProperty(RutaRecursoProperty, value); }
		}

		public static readonly PropertyInfo<int> NivelProperty = RegisterProperty<int>(c => c.Nivel);
		public int Nivel
		{
			get { return GetProperty(NivelProperty); }
			set { SetProperty(NivelProperty, value); }
		}

		public static readonly PropertyInfo<RecursosHijos> ListaRecursosProperty = RegisterProperty<RecursosHijos>(c => c.ListaRecursos, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public RecursosHijos ListaRecursos
		{
			get
			{
				if (!FieldManager.FieldExists(ListaRecursosProperty))
				{
					ListaRecursos = RecursosHijos.GetRecursosHijos(ID);
				}
				return GetProperty(ListaRecursosProperty);
			}
			private set
			{
				LoadProperty(ListaRecursosProperty, value);
				OnPropertyChanged(ListaRecursosProperty);
			}
		}

		public static readonly PropertyInfo<RecursoDetalles> DetallesProperty = RegisterProperty<RecursoDetalles>(c => c.Detalles, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public RecursoDetalles Detalles
		{
			get
			{
				if (!FieldManager.FieldExists(DetallesProperty))
				{
					RecursoDetalles.BeginGetRecursoDetalles(ID, (o, e) =>
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

		internal static RecursoHijo NewRecursoHijo()
		{
			return DataPortal.CreateChild<RecursoHijo>();
		}

		internal static RecursoHijo GetRecursoHijo(Recurso childData)
		{
			return DataPortal.FetchChild<RecursoHijo>(childData);
		}

		private RecursoHijo()
		{ /* Require use of factory methods */ }

		#endregion

		#region Data Access

		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Nivel = 2;
			}

			BusinessRules.CheckRules();
		}

		private void Child_Fetch(Recurso childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdRecurso;
				IdRecursoPadre = childData.IdRecursoPadre;
				Descripcion = childData.Descripcion;
				RutaRecurso = childData.RutaRecurso;
				Nivel = childData.Nivel;
			}
			MarkOld();
		}

		private void Child_Insert()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Recurso();
				DoInsertUpdate(detalle);

				ctx.DbContext.Recurso.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Recurso dr)
		{
			using (BypassPropertyChecks)
			{
				dr.IdRecurso = ID;
				dr.IdRecursoPadre = IdRecursoPadre;
				dr.Descripcion = Descripcion;
				dr.RutaRecurso = RutaRecurso;
				dr.Nivel = Nivel;
			}
		}

		private void Child_Update()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var detalle = ctx.DbContext.Recurso.Single(r => r.IdRecurso == ID);
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
					var detalle = ctx.DbContext.Recurso.Single(r => r.IdRecurso == ID);
					ctx.DbContext.Recurso.Remove(detalle);
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
				return IdRecursoPadre;
			}
			set
			{
				IdRecursoPadre = value;
			}
		}
		#endregion

		#region Implementacion de IRecurso
		public string IdRecurso
		{
			get { return ID; }
		}
		#endregion
	}
}
