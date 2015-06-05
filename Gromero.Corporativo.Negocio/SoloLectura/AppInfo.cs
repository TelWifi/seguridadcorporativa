using Csla;
using Csla.Data;
using System;

namespace Gromero.Corporativo.SoloLectura
{
	[Serializable]
	public class AppInfo : ReadOnlyBase<AppInfo>, IEquatable<AppInfo>
	{
		#region Business Methods

		public string IdPerfilUsuario { get; set; }
		public string NombreApp { get; set; }
		public string Ruta { get; set; }
		public string TipoAplicacion { get; set; }

		#endregion

		#region Factory Methods

		public static AppInfo GetAppInfo(SafeDataReader data)
		{
			return DataPortal.Fetch<AppInfo>(data);
		}

		private AppInfo()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(SafeDataReader criteria)
		{
			IdPerfilUsuario = criteria.GetString("IdPerfilUsuario");
			NombreApp = criteria.GetString("NombreAplicacion");
			Ruta = criteria.GetString("Ruta");
			TipoAplicacion = criteria.GetString("TipoAplicacion");
		}

		#endregion

		#region Miembros de IEquatable<AppInfo>

		public bool Equals(AppInfo other)
		{
			return other.NombreApp.Equals(NombreApp);
		}

		#endregion
	}
}
