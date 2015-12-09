using Csla;
using Csla.Data.EF6;
using Csla.Rules;
using Gromero.Seguridad.Datos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{


	[Serializable]
	public class Opcion : BusinessBase<Opcion>
	{
		#region Business Methods

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

		public static readonly PropertyInfo<string> IdOpcionPadreProperty = RegisterProperty<string>(c => c.IdOpcionPadre);
		public string IdOpcionPadre
		{
			get { return GetProperty(IdOpcionPadreProperty); }
			set { SetProperty(IdOpcionPadreProperty, value); }
		}

		public static readonly PropertyInfo<string> CodigoProperty = RegisterProperty<string>(c => c.Codigo);
		[Required]
		public string Codigo
		{
			get { return GetProperty(CodigoProperty); }
			set { SetProperty(CodigoProperty, value); }
		}

		public static readonly PropertyInfo<string> NombreProperty = RegisterProperty<string>(c => c.Nombre);
		[Required]
		public string Nombre
		{
			get { return GetProperty(NombreProperty); }
			set { SetProperty(NombreProperty, value); }
		}

		public static readonly PropertyInfo<int> NivelProperty = RegisterProperty<int>(c => c.Nivel);
		public int Nivel
		{
			get { return GetProperty(NivelProperty); }
			set { SetProperty(NivelProperty, value); }
		}

		public static readonly PropertyInfo<string> TipoProperty = RegisterProperty<string>(c => c.Tipo);
		[Required]
		public string Tipo
		{
			get { return GetProperty(TipoProperty); }
			set { SetProperty(TipoProperty, value); }
		}

		public static readonly PropertyInfo<string> ClaseProperty = RegisterProperty<string>(c => c.Clase);
		[Required]
		public string Clase
		{
			get { return GetProperty(ClaseProperty); }
			set { SetProperty(ClaseProperty, value); }
		}

		public static readonly PropertyInfo<int> NroOrdenProperty = RegisterProperty<int>(c => c.NroOrden);
		public int NroOrden
		{
			get { return GetProperty(NroOrdenProperty); }
			set { SetProperty(NroOrdenProperty, value); }
		}

		public static readonly PropertyInfo<string> UrlProperty = RegisterProperty<string>(c => c.Url);
		public string Url
		{
			get { return GetProperty(UrlProperty); }
			set { SetProperty(UrlProperty, value); }
		}

		public static readonly PropertyInfo<bool> EstadoProperty = RegisterProperty<bool>(c => c.Estado);
		public bool Estado
		{
			get { return GetProperty(EstadoProperty); }
			set { SetProperty(EstadoProperty, value); }
		}

		public static readonly PropertyInfo<Opciones> ListaOpcionesProperty = RegisterProperty<Opciones>(c => c.ListaOpciones, RelationshipTypes.Child);
		public Opciones ListaOpciones
		{
			get
			{
				if (!FieldManager.FieldExists(ListaOpcionesProperty))
				{
					ListaOpciones = Opciones.GetOpcionesDetalladas(ID);
				}
				return GetProperty(ListaOpcionesProperty);
			}
			private set
			{
				LoadProperty(ListaOpcionesProperty, value);
				OnPropertyChanged(ListaOpcionesProperty);
			}
		}

		public static readonly PropertyInfo<Plantillas> ListaPlantillasProperty = RegisterProperty<Plantillas>(c => c.ListaPlantillas, RelationshipTypes.Child);
		public Plantillas ListaPlantillas
		{
			get
			{
				if (!FieldManager.FieldExists(ListaPlantillasProperty))
				{
					ListaPlantillas = Plantillas.GetPlantillas(ID);
				}
				return GetProperty(ListaPlantillasProperty);
			}
			private set
			{
				LoadProperty(ListaPlantillasProperty, value);
				OnPropertyChanged(ListaPlantillasProperty);
			}
		}

		#endregion

		#region Business Rules

		protected override void AddBusinessRules()
		{
			base.AddBusinessRules();
			//BusinessRules.AddRule(new PlantillaObligatoriaRule(ListaPlantillasProperty));
		}

		//protected override void OnChildChanged(Csla.Core.ChildChangedEventArgs e)
		//{
		//    base.OnChildChanged(e);
		//    if (e.ChildObject.GetType() == typeof(Opciones) && e.CollectionChangedArgs != null)
		//        PropertyHasChanged(ListaPlantillasProperty);
		//}

		public void ChequearReglas()
		{
			BusinessRules.CheckRules();
		}

		private static void AddAuthorizationRules()
		{
			// TODO: add authorization rules
			//BusinessRules.AddRule(...);
		}

		#endregion

		#region Factory Methods

		internal static Opcion NewOpcion()
		{
			return DataPortal.CreateChild<Opcion>();
		}

		internal static Opcion GetOpcion(OpcionUI childData)
		{
			return DataPortal.FetchChild<Opcion>(childData);
		}

		private Opcion()
		{ /* Require use of factory methods */ }

		public void AgregarRoles(Aplicacion app)
		{
			//Leemos todos los Roles contenidos en esta instancia de Aplicacion
			foreach (var rol in app.Roles)
			{
				var plantilla = Plantilla.NewPlantilla();
				plantilla.IdAplicacion = app.ID;
				plantilla.IdRol = rol.Id;
				plantilla.NombreRol = rol.Nombre;
				plantilla.NombreOpcion = Nombre;
				plantilla.Conceder = false;
				if (!ListaPlantillas.Contains(plantilla)) //Si no contiene dicho Rol en la Plantilla lo agregamos
					ListaPlantillas.Add(plantilla);
			}
		}
		#endregion

		#region Data Access
		[RunLocal]
		protected override void Child_Create()
		{
			using (BypassPropertyChecks)
			{
				ID = Guid.NewGuid().ToString();
				Nivel = 1;
				IdOpcionPadre = string.Empty;
				Estado = true;
			}

			BusinessRules.CheckRules();
		}

		private void Child_Fetch(OpcionUI childData)
		{
			using (BypassPropertyChecks)
			{
				ID = childData.IdOpcionUI;
				IdAplicacion = childData.IdAplicacion;
				IdOpcionPadre = childData.IdOpcionPadre ?? string.Empty;
				Codigo = childData.Codigo;
				Nombre = childData.Nombre;
				Nivel = childData.Nivel;
				Tipo = childData.Tipo;
				Clase = childData.Clase;
				Url = childData.Url;
				NroOrden = childData.NroOrden.HasValue ? childData.NroOrden.Value : 0;
				Estado = childData.Estado;
			}
			MarkOld();
		}

		private void Child_Insert()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var detalle = new OpcionUI();
				IdAplicacion = ApplicationContext.LocalContext["IDPadre"].ToString();
				DoInsertUpdate(detalle);

				ctx.DbContext.OpcionUI.Add(detalle);

				FieldManager.UpdateChildren(this);
			}
		}

		private void DoInsertUpdate(OpcionUI dr)
		{
			using (BypassPropertyChecks)
			{
				//Establecer las propiedades del Objeto Entity
				dr.IdOpcionUI = ID;
				dr.IdAplicacion = IdAplicacion;
				dr.Codigo = Codigo;
				dr.Nombre = Nombre;
				if (string.IsNullOrEmpty(IdOpcionPadre))
					dr.IdOpcionPadre = null;
				else
					dr.IdOpcionPadre = IdOpcionPadre;
				dr.Nivel = Nivel;
				dr.Tipo = Tipo;
				dr.Clase = Clase;
				dr.Url = Url;
				dr.NroOrden = NroOrden;
				dr.Estado = Estado;
			}
		}

		private void Child_Update()
		{
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				if (IsSelfDirty)
				{
					var detalle = ctx.DbContext.OpcionUI.Single(r => r.IdOpcionUI == ID);
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
					var detalle = ctx.DbContext.OpcionUI.Single(r => r.IdOpcionUI == ID);
					ctx.DbContext.OpcionUI.Remove(detalle);
				}
				FieldManager.UpdateChildren(this);
			}
		}

		#endregion

	}
}
