using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Empresas
{
	public partial class frmMntEmpresas : _PlantillaMntDeGestor
	{
		#region Declaracion de Variables
		private Empresa m_Empresa;
		#endregion

		#region Constructores
		public frmMntEmpresas()
		{
			InitializeComponent();
		}

		public frmMntEmpresas(Empresa _empresa)
		{
			InitializeComponent();

			m_Empresa = _empresa;
			empresaBindingSource.DataSource = _empresa;

			Cursor.Current = Cursors.Default;
		}
		#endregion

		#region Grabar
		public override void Grabar()
		{
			empresaBindingSource.RaiseListChangedEvents = false;
			empresaBindingSource.EndEdit();

			try
			{
				Cursor.Current = Cursors.WaitCursor;
				m_Empresa = m_Empresa.Save();
				XtraMessageBox.Show("Registro grabado correctamente!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

				base.Grabar();
			}
			catch (Csla.Rules.ValidationException)
			{
				MessageBox.Show(m_Empresa.BrokenRulesCollection.ToString());
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Grabar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Grabar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}

			empresaBindingSource.RaiseListChangedEvents = true;
		}
		#endregion

		#region Cancelar
		public override void Cancelar()
		{
			empresaBindingSource.CancelEdit();
			base.Cancelar();
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
