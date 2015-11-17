using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{

	[Serializable]
	public class RecursoPerfil : BusinessBase<RecursoPerfil>, IEquatable<RecursoPerfil>
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

		public static readonly PropertyInfo<string> IdPerfilUsuarioProperty = RegisterProperty<string>(c => c.IdPerfilUsuario);
		[Browsable(false)]
		public string IdPerfilUsuario
		{
			get { return GetProperty(IdPerfilUsuarioProperty); }
			set { SetProperty(IdPerfilUsuarioProperty, value); }
		}

		public static readonly PropertyInfo<string> IdRecursoDetalleProperty = RegisterProperty<string>(c => c.IdRecursoDetalle);
		public string IdRecursoDetalle
		{
			get { return GetProperty(IdRecursoDetalleProperty); }
			set { SetProperty(IdRecursoDetalleProperty, value); }
		}

		public static readonly PropertyInfo<string> CodigoProperty = RegisterProperty<string>(c => c.Codigo);
		public string Codigo
		{
			get { return GetProperty(CodigoProperty); }
			set { SetProperty(CodigoProperty, value); }
		}

		public static readonly PropertyInfo<string> DescripcionProperty = RegisterProperty<string>(c => c.Descripcion);
		public string Descripcion
		{
			get { return GetProperty(DescripcionProperty); }
			set { SetProperty(DescripcionProperty, value); }
		}

		public static readonly PropertyInfo<string> RecursoPadreProperty = RegisterProperty<string>(c => c.RecursoPadre);
		public string RecursoPadre
		{
			get { return GetProperty(RecursoPadreProperty); }
			set { SetProperty(RecursoPadreProperty, value); }
		}

		public static readonly PropertyInfo<int> NivelProperty = RegisterProperty<int>(c => c.Nivel);
		public int Nivel
		{
			get { return GetProperty(NivelProperty); }
			set { SetProperty(NivelProperty, value); }
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

		internal static RecursoPerfil NewRecursoPerfil()
		{
			return DataPortal.CreateChild<RecursoPerfil>();
		}

		internal static RecursoPerfil GetRecursoPerfil(SelectRecursoPerfil_Result childData)
		{
			return DataPortal.FetchChild<RecursoPerfil>(childData);
		}

		private RecursoPerfil()
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

		private void Child_Fetch(SelectRecursoPerfil_Result childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdRecursoPerfil;
				IdPerfilUsuario = childData.IdPerfilUsuario;
				IdRecursoDetalle = childData.IdRecursoDetalle;
				Codigo = childData.Codigo;
				Descripcion = childData.Descripcion;
				RecursoPadre = childData.RecursoPadre;
				Nivel = childData.Nivel;
				Conceder = childData.Conceder;
			}
			MarkOld();
		}

		internal void Child_Insert(PerfilUsuario parent)
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Datos.RecursoPerfil();
				IdPerfilUsuario = parent.ID;
				DoInsertUpdate(detalle);

				ctx.DbContext.RecursoPerfil.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Datos.RecursoPerfil dr)
		{
			using (BypassPropertyChecks)
			{
				dr.IdRecursoPerfil = ID;
				dr.IdRecursoDetalle = IdRecursoDetalle;
				dr.IdPerfilUsuario = IdPerfilUsuario;
				dr.Conceder = Conceder;
			}
		}

		internal void Child_Update()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var detalle = ctx.DbContext.RecursoPerfil.Single(r => r.IdRecursoPerfil == ID);
					DoInsertUpdate(detalle);
					MarkOld();
				}
				FieldManager.UpdateChildren(this);
			}
		}

		internal void Child_DeleteSelf()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (!IsNew)
				{
					var detalle = ctx.DbContext.RecursoPerfil.Single(r => r.IdRecursoPerfil == ID);
					ctx.DbContext.RecursoPerfil.Remove(detalle);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion

		#region Implementacion de IEquatable
		public bool Equals(RecursoPerfil other)
		{
			return (other.IdRecursoDetalle == this.IdRecursoDetalle);
		}
		#endregion
	}
}
