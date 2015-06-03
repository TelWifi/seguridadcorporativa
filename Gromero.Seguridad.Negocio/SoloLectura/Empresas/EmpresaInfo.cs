using System;
using Csla;
using Gromero.Seguridad.Datos;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
	[Serializable]
	public class EmpresaInfo : ReadOnlyBase<EmpresaInfo>
	{
		#region Business Methods

		public string ID { get; set; }
		public string Codigo { get; set; }
		public string NombreCorto { get; set; }
		public string RazonSocial { get; set; }
		public string RUC { get; set; }
		#endregion

		#region Factory Methods

		public static EmpresaInfo GetEmpresaInfo(Empresas data)
		{
			return DataPortal.Fetch<EmpresaInfo>(data);
		}

		private EmpresaInfo()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(Empresas criteria)
		{
			ID = criteria.IdEmpresa;
			NombreCorto = criteria.NombreCorto;
			Codigo = criteria.CodigoEmpresa;
			RazonSocial = criteria.RazonSocial;
			RUC = criteria.RUC;
		}

		#endregion
	}
}
