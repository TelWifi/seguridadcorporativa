using Csla.Data.EF6;
using Gromero.Seguridad.Datos;

namespace Gromero.Seguridad.Negocio.SoloLectura.Reportes
{
	public partial class PermisosPorApp : DevExpress.XtraReports.UI.XtraReport
	{
		public PermisosPorApp()
		{
			InitializeComponent();

			CargarDatos();
		}

		private void CargarDatos()
		{
			using (var ctx = DbContextManager<GROMEROEntities>.GetManager(BaseDatos.ConexionBD))
			{
				//PermisoBindingSource.DataSource = ctx.DbContext.GetReportePermisosByApp();
			}
		}

	}
}
