using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.SoloLectura;
using ErickOrlando.Seguridad.Negocio.SoloLectura.Dominios;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Usuarios
{
    public partial class frmPromptUsuariosAD : _PlantillaPrompt
    {

        #region Constructor
        public frmPromptUsuariosAD()
        {
            InitializeComponent();
            dominioInfoListBindingSource.DataSource = DominioInfoList.GetDominioInfoList();
            dominioInfoListBindingSource.ResetBindings(false);
            Load += (s, e) =>
                dominioTextEdit.Text = Environment.UserDomainName;
        }
        #endregion

        #region Buscar
        public override void Buscar()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Validamos que el N° minimo de caracteres haya sido ingresado
                if (dominioTextEdit.EditValue == null)
                    return;
                base.Buscar();

                using (var crit = new UsuarioADInfoList.FiltroAD
                {
                    NombreCampo = CriterioBusqueda,
                    ValorBusqueda = txtFiltro.Text,
                    Dominio = dominioTextEdit.EditValue.ToString()
                })
                {
                    usuarioADInfoListBindingSource.DataSource = UsuarioADInfoList.GetUsuarioADInfoList(crit);
                }
                if (usuarioADInfoListBindingSource.Count > 0)
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

    }
}
