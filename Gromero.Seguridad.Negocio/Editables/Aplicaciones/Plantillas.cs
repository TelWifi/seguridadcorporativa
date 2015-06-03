using Csla;
using Csla.Data.EF6;
using Gromero.Seguridad.Datos;
using System;
using System.Linq;

namespace Gromero.Seguridad.Negocio.Editables
{
	[Serializable]
	public class Plantillas :
	  BusinessListBase<Plantillas, Plantilla>
	{
		#region Factory Methods

		internal static Plantillas NewPlantillas()
		{
			return DataPortal.CreateChild<Plantillas>();
		}

		internal static Plantillas GetPlantillas(string childData)
		{
			return DataPortal.FetchChild<Plantillas>(childData);
		}

		/// <summary>
		/// Ubica un unico elemento en la colección
		/// </summary>
		public Plantilla GetItem(string IdTtem)
		{
			return this.Where(d => d.ID.Equals(IdTtem)).Single();
		}

		/// <summary>
		/// Sobrecarga de la funcion AddNew
		/// </summary>
		public new Plantilla AddNew()
		{
			var obj = DataPortal.CreateChild<Plantilla>();
			this.Add(obj);
			return obj;
		}

		/// <summary>
		/// Sobrecarga de la función Add
		/// </summary>
		public new void Add(Plantilla item)
		{
			if (!Contains(item))
				base.Add(item);
			else
				throw new InvalidOperationException("No se puede agregar nuevamente esta Plantilla!");
		}

		private Plantillas()
		{ }

		#endregion

		#region Data Access

		private void Child_Fetch(string childData)
		{
			RaiseListChangedEvents = false;
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				foreach (var child in ctx.DbContext.SelectPlantilla(childData))
					this.Add(Plantilla.GetPlantilla(child));
			}
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
