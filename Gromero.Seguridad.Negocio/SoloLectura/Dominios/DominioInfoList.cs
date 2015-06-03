using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gromero.Seguridad.Negocio.SoloLectura.Dominios
{
	public class DominioInfoList : List<DominioInfo>
	{
		private DominioInfoList()
		{

		}

		public static DominioInfoList GetDominioInfoList()
		{
			return new DominioInfoList
			{
				new DominioInfo("TRAMARSA", "tramarsa.com.pe"),
				new DominioInfo("GRUPOCOGESA", "grupocogesa.gromero.net"),
				new DominioInfo("GRUPORANSA", "gruporansa.gromero.net"),
				new DominioInfo("ALICORP", "grupoalicorp.gromero.net")
			};
		}
	}
}
