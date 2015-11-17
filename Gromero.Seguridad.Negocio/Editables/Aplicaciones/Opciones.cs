using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Linq;


namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class Opciones :
	  BusinessListBase<Opciones, Opcion>
	{

		public int Nivel { get; set; }

		#region Factory Methods

		internal static Opciones NewOpciones()
		{
			return DataPortal.CreateChild<Opciones>();
		}

		internal static Opciones GetOpciones(string childData)
		{
			return DataPortal.FetchChild<Opciones>(childData);
		}

		internal static Opciones GetOpcionesDetalladas(string childData)
		{
			return DataPortal.FetchChild<Opciones>(new SingleCriteria<string>(childData));
		}

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public Opcion GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new Opcion AddNew()
		{
			var obj = DataPortal.CreateChild<Opcion>();
			obj.NroOrden = Count + 1;
			this.Add(obj);
			return obj;
		}

		public Opcion Agregar()
		{
			var obj = DataPortal.CreateChild<Opcion>();
			obj.Nivel = this.EditLevel + 1;
			obj.NroOrden = Count + 1;
			if (this.Parent is Opcion)
			{
				var padre = (this.Parent as Opcion);
				obj.IdOpcionPadre = padre.ID;
				obj.Nivel = padre.Nivel + 1;
			}
			Nivel = obj.Nivel;
			this.Add(obj);
			return obj;
		}

		public string CreaCorrelativo()
		{
			//Generación del Código

			//Obtención del Acronimo de la Aplicación
			string codigoAplicacion = string.Empty;
			if (this.Parent is Aplicacion)
			{
				codigoAplicacion = (this.Parent as Aplicacion).Acronimo;
				ApplicationContext.LocalContext["AcronimoApp"] = codigoAplicacion;
			}
			else
				codigoAplicacion = ApplicationContext.LocalContext["AcronimoApp"].ToString();

			return string.Concat(codigoAplicacion, Nivel.ToString("0###"), (Count + 1).ToString("0###"));
		}


		private Opciones()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectOpcionUI(childData))
					this.Add(Opcion.GetOpcion(child));
			}
			RaiseListChangedEvents = true;
		}

		private void Child_Fetch(SingleCriteria<string> childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectOpcionDetalleUI(childData.Value))
					this.Add(Opcion.GetOpcion(child));
			}
			RaiseListChangedEvents = true;
		}

		#endregion

	}
}
