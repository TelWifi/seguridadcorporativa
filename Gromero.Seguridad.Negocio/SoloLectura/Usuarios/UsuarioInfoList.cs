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
	public class UsuarioInfoList :
	  ReadOnlyListBase<UsuarioInfoList, UsuarioInfo>
	{
		#region Factory Methods

		public static UsuarioInfoList GetUsuarioInfoList()
		{
			return DataPortal.Fetch<UsuarioInfoList>(new FiltroCriteria());
		}

		public static UsuarioInfoList GetUsuarioInfoList(FiltroCriteria crit)
		{
			return DataPortal.Fetch<UsuarioInfoList>(crit);
		}

		private UsuarioInfoList()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(FiltroCriteria criteria)
		{
			RaiseListChangedEvents = false;
			IsReadOnly = false;

			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				IEnumerable<UsuarioComplex> lista;
				switch (criteria.NombreCampo)
				{
					case "Codigo":
						lista = ctx.DbContext.SelectUsuarioByCodigo(criteria.ValorBusqueda).ToList();
						break;
					case "Nombres":
						lista = ctx.DbContext.SelectUsuarioByName(criteria.ValorBusqueda).ToList();
						break;
					case "ApellidoPaterno":
						lista = ctx.DbContext.SelectUsuarioByApePat(criteria.ValorBusqueda).ToList();
						break;
					case "ApellidoMaterno":
						lista = ctx.DbContext.SelectUsuarioByApeMat(criteria.ValorBusqueda).ToList();
						break;
					case "DNI":
						lista = ctx.DbContext.SelectUsuarioByDNI(criteria.ValorBusqueda).ToList();
						break;
					case "Email":
						lista = ctx.DbContext.SelectUsuarioByEmail(criteria.ValorBusqueda).ToList();
						break;
					default:
						lista = ctx.DbContext.SelectAllUsuarios().ToList();
						break;
				}
				foreach (var item in lista)
				{
					Add(UsuarioInfo.GetUsuarioInfo(item));
				}
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
