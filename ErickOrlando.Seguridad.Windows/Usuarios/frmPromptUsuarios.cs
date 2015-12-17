using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.SoloLectura;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Usuarios
{
	public partial class frmPromptUsuarios : _PlantillaPrompt
	{
		#region Constructor
		public frmPromptUsuarios()
		{
			InitializeComponent();
		}
		#endregion

		#region Aceptar
		public override void Aceptar()
		{
			base.Aceptar();
		}
		#endregion

		#region Cancelar
		public override void Cancelar()
		{
			base.Cancelar();
		}

		#endregion

		#region Buscar
		public override void Buscar()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				//Validamos que el N° minimo de caracteres haya sido ingresado
				base.Buscar();

				using (var crit = new FiltroCriteria { NombreCampo = CriterioBusqueda, ValorBusqueda = txtFiltro.Text })
				{
					usuarioInfoListBindingSource.DataSource = UsuarioInfoList.GetUsuarioInfoList(crit);

				}
				if (usuarioInfoListBindingSource.Count > 0)
					InfoListDataGridView.BestFitColumns();
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Buscar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Buscar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}

		}
		#endregion

		#region Actualizar
		public override void Actualizar()
		{
			base.Actualizar();
		}
		#endregion
	}
}
