using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Cargos
{
    public partial class frmMntCargo : _PlantillaMntDeGestor
    {
        #region Declaracion de Variables
        private Cargo m_Cargo;
        #endregion

        #region Constructores
        public frmMntCargo()
        {
            InitializeComponent();
        }

        public frmMntCargo(Cargo _cargo)
        {
            InitializeComponent();

            m_Cargo = _cargo;
            cargoBindingSource.DataSource = _cargo;

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Grabar
        public override void Grabar()
        {
            cargoBindingSource.RaiseListChangedEvents = false;
            cargoBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                m_Cargo = m_Cargo.Save();
                XtraMessageBox.Show("Registro grabado correctamente!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.Grabar();
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(m_Cargo.BrokenRulesCollection.ToString(),
                                    "Grabar",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
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

            cargoBindingSource.RaiseListChangedEvents = true;
        }
        #endregion

        #region Cancelar
        public override void Cancelar()
        {
            cargoBindingSource.CancelEdit();
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
