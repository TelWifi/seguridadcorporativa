using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Data;

namespace Gromero.Corporativo.SoloLectura
{
	[Serializable]
	public class PerfilInfo : ReadOnlyBase<PerfilInfo>
	{
		#region Business Methods

		public string ID { get; set; }
		public string NombrePerfil { get; set; }

		#endregion

		#region Factory Methods

		public static PerfilInfo GetPerfilInfo(SafeDataReader data)
		{
			return DataPortal.Fetch<PerfilInfo>(data);
		}

		private PerfilInfo()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(SafeDataReader criteria)
		{
			ID = criteria.GetString("IdPerfilUsuario");
			NombrePerfil = criteria.GetString("NombrePerfil");
		}

		#endregion
	}
}
