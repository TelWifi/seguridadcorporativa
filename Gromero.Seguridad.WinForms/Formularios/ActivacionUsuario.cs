using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Csla;
using Csla.Rules;

namespace Gromero.Seguridad.WinForms
{
	public partial class ActivacionUsuario : XtraForm
	{
		private Entidades.ActivarUsuario activarUsuario;

		public ActivacionUsuario()
		{
			InitializeComponent();
		}

		public ActivacionUsuario(Entidades.ActivarUsuario activarUsuario)
		{
			InitializeComponent();
			this.activarUsuario = activarUsuario;
			activarUsuarioBindingSource.DataSource = activarUsuario;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			activarUsuarioBindingSource.RaiseListChangedEvents = false;
			activarUsuarioBindingSource.EndEdit();
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				activarUsuario = activarUsuario.Save();
				XtraMessageBox.Show(string.Format("Se activó el usuario {0} con éxito!", 
					activarUsuario.NombreUsuario), 
					Text, 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Information);

				DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (ValidationException)
			{
				XtraMessageBox.Show(activarUsuario.BrokenRulesCollection.ToString(),
									Text,
									MessageBoxButtons.OK,
									MessageBoxIcon.Exclamation);
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					Text,
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					Text,
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
				activarUsuarioBindingSource.RaiseListChangedEvents = true;
			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}
	}
}
