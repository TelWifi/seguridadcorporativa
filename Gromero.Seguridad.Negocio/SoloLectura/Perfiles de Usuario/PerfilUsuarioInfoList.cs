using Csla;
using Csla.Data.EF6;
using ErickOrlando.Utilidades.Data;
using Gromero.Seguridad.Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
	[Serializable]
	public class PerfilUsuarioInfoList :
	  ReadOnlyListBase<PerfilUsuarioInfoList, PerfilUsuarioInfo>
	{
		#region Factory Methods

		public static PerfilUsuarioInfoList GetPerfilUsuarioInfoList()
		{
			return DataPortal.Fetch<PerfilUsuarioInfoList>(new FiltroCriteria());
		}

		public static PerfilUsuarioInfoList GetPerfilUsuarioInfoList(FiltroCriteria filtro)
		{
			return DataPortal.Fetch<PerfilUsuarioInfoList>(filtro);
		}

		public static void BeginGetPerfilUsuarioInfoList(FiltroCriteria filtro, EventHandler<DataPortalResult<PerfilUsuarioInfoList>> callback)
		{
			DataPortal.BeginFetch<PerfilUsuarioInfoList>(filtro, callback);
		}

		private PerfilUsuarioInfoList()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(FiltroCriteria criteria)
		{
			RaiseListChangedEvents = false;
			IsReadOnly = false;

			using (var ctx = DbContextManager<SeguridadEntities>
				.GetManager(BaseDatos.ConexionBD))
			{
				var lista = new List<PerfilUsuarioComplex>();
				switch (criteria.NombreCampo)
				{
					case "Aplicacion":
						lista = ctx.DbContext.SelectPerfilUsuarioByApp(criteria.ValorBusqueda).ToList();
						break;
					case "CodigoUsuario":
						lista = ctx.DbContext.SelectPerfilUsuarioByUser(criteria.ValorBusqueda).ToList();
						break;
					case "IdPerfilUsuario":
						lista = ctx.DbContext.SelectPerfilUsuarioById(criteria.ValorBusqueda).ToList();
						break;
					default:
						lista = ctx.DbContext.SelectAllPerfilUsuario().ToList();
						break;
				}

				foreach (var item in lista)
					Add(PerfilUsuarioInfo.GetPerfilUsuarioInfo(item));
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}

	public class PerfilesDistinct : IEqualityComparer<PerfilUsuarioInfo>
	{

		#region Miembros de IEqualityComparer<PerfilUsuarioInfo>

		public bool Equals(PerfilUsuarioInfo x, PerfilUsuarioInfo y)
		{
			return x.IdAplicacion.Equals(y.IdAplicacion) && x.IdUsuario.Equals(y.IdUsuario);
		}

		public int GetHashCode(PerfilUsuarioInfo obj)
		{
			return string.Concat(obj.IdAplicacion.GetHashCode(), obj.IdUsuario.GetHashCode()).GetHashCode();
		}

		#endregion
	}

	public class AplicacionesDistinct : IEqualityComparer<PerfilUsuarioInfo>
	{

		#region Miembros de IEqualityComparer<PerfilUsuarioInfo>

		public bool Equals(PerfilUsuarioInfo x, PerfilUsuarioInfo y)
		{
			return x.Aplicacion.Equals(y.Aplicacion);
		}

		public int GetHashCode(PerfilUsuarioInfo obj)
		{
			return obj.Aplicacion.GetHashCode();
		}

		#endregion
	}

}
