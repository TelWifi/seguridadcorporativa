using Csla;
using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using System;
using System.Linq;

namespace ErickOrlando.Seguridad.Negocio.Editables
{
	[Serializable]
	public class CargoSociedades :
	  BusinessListBase<CargoSociedades, CargoSociedad>
	{
		#region Factory Methods

		internal static CargoSociedades NewCargoSociedades()
		{
			return DataPortal.CreateChild<CargoSociedades>();
		}

		internal static CargoSociedades GetCargoSociedades(string childData)
		{
			return DataPortal.FetchChild<CargoSociedades>(childData);
		}

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public CargoSociedad GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new CargoSociedad AddNew()
		{
			var obj = DataPortal.CreateChild<CargoSociedad>();
			this.Add(obj);
			return obj;
		}

		/// <summary>
		/// Sobrecarga de la función Add
		/// </summary>
		public new void Add(CargoSociedad item)
		{
			if (!Contains(item))
				base.Add(item);
			else
				throw new InvalidOperationException("No se puede agregar nuevamente este CargoSociedad!");
		}

		private CargoSociedades()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectCargoSociedad(childData))
					this.Add(CargoSociedad.GetCargoSociedad(child));
			}
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
