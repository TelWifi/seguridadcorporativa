using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
	public class TipoSistemaInfoList : List<TipoSistemaInfo>
	{

		private TipoSistemaInfoList()
		{

		}

		public static TipoSistemaInfoList GetTipoSistemaInfoList()
		{
			var obj = new TipoSistemaInfoList();
			obj.Add(new TipoSistemaInfo { Codigo = "0", Descripcion = "Windows" });
			obj.Add(new TipoSistemaInfo { Codigo = "1", Descripcion = "Web" });
			obj.Add(new TipoSistemaInfo { Codigo = "2", Descripcion = "Mobile" });
			obj.Add(new TipoSistemaInfo { Codigo = "3", Descripcion = "Web Service" });
			obj.Add(new TipoSistemaInfo { Codigo = "4", Descripcion = "Windows Service" });
			return obj;
		}

	}
}
