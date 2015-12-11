using Csla.Data.EF6;
using ErickOrlando.Seguridad.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErickOrlando.Seguridad.Negocio.SoloLectura.Dominios
{
	public class DominioInfoList : List<DominioInfo>
	{
		private DominioInfoList()
		{

		}

		public static DominioInfoList GetDominioInfoList()
		{
			var lista = new DominioInfoList();
			using (var ctx = DbContextManager<SeguridadEntities>.GetManager(BaseDatos.ConexionBD))
			{
				var query = ctx.DbContext.SelectAllDominios().ToList();

				foreach (var item in query)
				{
					var dominio = new DominioInfo(item.NombreCorto, item.RutaDominio);
					lista.Add(dominio);
				}
			}

			return lista;
		}
	}
}
