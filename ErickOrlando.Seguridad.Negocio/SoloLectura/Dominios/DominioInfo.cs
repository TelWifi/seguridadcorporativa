using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErickOrlando.Seguridad.Negocio.SoloLectura.Dominios
{
	public class DominioInfo
	{
		public string NombreCorto { get; set; }
		public string NombreLargo { get; set; }

		internal DominioInfo(string _short, string _long)
		{
			NombreCorto = _short;
			NombreLargo = _long;
		}

		private DominioInfo()
		{

		}
	}
}
