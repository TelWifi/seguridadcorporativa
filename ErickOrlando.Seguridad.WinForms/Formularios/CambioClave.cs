using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ErickOrlando.Seguridad.Entidades;
using Csla;
using Csla.Rules;

namespace ErickOrlando.Seguridad.WinForms
{
    public partial class CambioClave : XtraForm
    {
        private CambiarClave cambiarClave;

        public CambioClave()
        {
            InitializeComponent();
        }

        public CambioClave(CambiarClave cambiarClave)
        {
            InitializeComponent();
            this.cambiarClave = cambiarClave;
            cambiarClaveBindingSource.DataSource = cambiarClave;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cambiarClaveBindingSource.RaiseListChangedEvents = false;
            cambiarClaveBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cambiarClave.Save();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(cambiarClave.BrokenRulesCollection.ToString(),
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
                cambiarClaveBindingSource.RaiseListChangedEvents = true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
