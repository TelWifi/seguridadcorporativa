using Csla;
using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ErickOrlando.Seguridad.Negocio.Editables
{

	[Serializable]
	public class Rol : BusinessBase<Rol>
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
		[StringLength(20)]
		public string Codigo
		{
			get { return GetProperty(CodigoProperty); }
			set { SetProperty(CodigoProperty, value); }
		}

		public static readonly PropertyInfo<string> NombreProperty = RegisterProperty<string>(c => c.Nombre);
		[Required]
		[StringLength(20)]
		public string Nombre
		{
			get { return GetProperty(NombreProperty); }
			set { SetProperty(NombreProperty, value); }
		}

		public override string ToString()
		{
			return Nombre;
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

		internal static Rol NewRol()
		{
			return DataPortal.CreateChild<Rol>();
		}

		internal static Rol GetRol(Datos.Roles childData)
		{
			return DataPortal.FetchChild<Rol>(childData);
		}

		public Rol()
		{ /* Require use of factory methods */
		}

		#endregion

		#region Data Access

		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				Id = Guid.NewGuid().ToString();
			}

			BusinessRules.CheckRules();
		}

		private void Child_Fetch(Datos.Roles childData)
		{
			using (BypassPropertyChecks)
			{
				Id = childData.IdRol;
				Codigo = childData.CodigoRol;
				Nombre = childData.NombreRol;
			}

			MarkOld();
		}

		private void Child_Insert(Aplicacion parent)
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new Datos.Roles();
				detalle.IdAplicacion = parent.ID;
				DoInsertUpdate(detalle);

				ctx.DbContext.Roles.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(Datos.Roles dr)
		{
			using (BypassPropertyChecks)
			{
				dr.IdRol = Id;
				dr.CodigoRol = Codigo;
				dr.NombreRol = Nombre;
			}
		}

		private void Child_Update(Aplicacion parent)
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var rol = ctx.DbContext.Roles.Single(r => r.IdRol == Id);
					DoInsertUpdate(rol);
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
					var rol = ctx.DbContext.Roles.Single(r => r.IdRol == Id);
					ctx.DbContext.Roles.Remove(rol);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion
	}
}
