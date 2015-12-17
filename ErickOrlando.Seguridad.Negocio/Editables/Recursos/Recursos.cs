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
	public class Recursos : BusinessBase<Recursos>, IRecursivo, IRecurso
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

		public static Recursos NewRecursos()
		{
			return DataPortal.Create<Recursos>();
		}

		public static Recursos GetRecursos(string id)
		{
			return DataPortal.Fetch<Recursos>(id);
		}

		public static void DeleteRecursos(string id)
		{
			DataPortal.Delete<Recursos>(id);
		}

		private Recursos()
		{ /* Requerido para los factory methods */ }

		#endregion

		#region Data Access

		[RunLocal]
		protected override void DataPortal_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Nivel = 1;
			}
			BusinessRules.CheckRules();
		}

		private void DataPortal_Fetch(string criteria)
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var recurso = ctx.DbContext.SelectRecurso(criteria).FirstOrDefault();
				if (recurso != null)
				{
					using (BypassPropertyChecks)
					{
						ID = recurso.IdRecurso;
						Descripcion = recurso.Descripcion;
						RutaRecurso = recurso.RutaRecurso;
						Nivel = recurso.Nivel;
						ApplicationContext.LocalContext["IdPadre"] = ID;
					}
				}
				else
					throw new InvalidOperationException("No se encontró el registro!");
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var recurso = new Recurso();
				DoInsertUpdate(recurso);
				ctx.DbContext.Recurso.Add(recurso);
				FieldManager.UpdateChildren(this);
				ctx.DbContext.SaveChanges();
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var recurso = ctx.DbContext.SelectRecurso(ID).FirstOrDefault();
					DoInsertUpdate(recurso);
				}
				FieldManager.UpdateChildren(this);
				ctx.DbContext.SaveChanges();
			}
		}

		private void DoInsertUpdate(Recurso cmd)
		{
			using (BypassPropertyChecks)
			{
				cmd.IdRecurso = ID;
				cmd.Descripcion = Descripcion;
				cmd.RutaRecurso = RutaRecurso;
				cmd.IdRecursoPadre = null;
				cmd.Nivel = Nivel;

				ApplicationContext.LocalContext["IdPadre"] = ID;
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
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{

				var recurso = ctx.DbContext.SelectRecurso(criteria).FirstOrDefault();
				ctx.DbContext.Recurso.Remove(recurso);
				ctx.DbContext.SaveChanges();


			}
		}

		#endregion

		#region Implementacion de IRecursivo
		public string IdPadre
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
		#endregion

		#region Implementacion de IRecurso
		public string IdRecurso
		{
			get
			{
				return ID;
			}
		}
		#endregion
	}
}
