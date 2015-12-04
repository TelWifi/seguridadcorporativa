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
	public class EmpresaInfoList :
	  ReadOnlyListBase<EmpresaInfoList, EmpresaInfo>
	{
		#region Factory Methods

		public static EmpresaInfoList GetEmpresaInfoList()
		{
			return DataPortal.Fetch<EmpresaInfoList>(new FiltroCriteria());
		}

		public static EmpresaInfoList GetEmpresaInfoList(FiltroCriteria crit)
		{
			return DataPortal.Fetch<EmpresaInfoList>(crit);
		}

		private EmpresaInfoList()
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
				IEnumerable<Empresas> lista;

				switch (criteria.NombreCampo)
				{
					case "RazonSocial":
						lista = ctx.DbContext.SelectEmpresaByRazonSocial(criteria.ValorBusqueda).ToList();
						break;
					case "Codigo":
						lista = ctx.DbContext.SelectEmpresaByCodigo(criteria.ValorBusqueda).ToList();
						break;
					case "NombreCorto":
						lista = ctx.DbContext.SelectEmpresaByNombreCorto(criteria.ValorBusqueda).ToList();
						break;
					case "RUC":
						lista = ctx.DbContext.SelectEmpresaByRUC(criteria.ValorBusqueda).ToList();
						break;
					default:
						lista = ctx.DbContext.SelectAllEmpresas().ToList();
						break;
				}
				foreach (var item in lista)
					Add(EmpresaInfo.GetEmpresaInfo(item));
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
