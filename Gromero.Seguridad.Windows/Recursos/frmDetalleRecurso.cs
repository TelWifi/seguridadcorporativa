using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using Gromero.Seguridad.Negocio.Editables;
using System;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows.RecursosSeguridad
{
    public partial class frmDetalleRecurso : _PlantillaMntDeGestor
    {
        #region Declaracion de Variables
        internal RecursoDetalle m_RecursoDetalle;
        private RecursoDetalle m_Seleccionado;
        #endregion

        #region Constructores
        public frmDetalleRecurso()
        {
            InitializeComponent();
        }

        public frmDetalleRecurso(RecursoDetalle _recursoDetalle)
        {
            InitializeComponent();

            m_RecursoDetalle = _recursoDetalle;
            recursoDetalleBindingSource.DataSource = _recursoDetalle;

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Grabar
        public override void Grabar()
        {
            recursoDetalleBindingSource.RaiseListChangedEvents = false;
            recursoDetalleBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                
                base.Grabar();
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(m_RecursoDetalle.BrokenRulesCollection.ToString(),
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

            recursoDetalleBindingSource.RaiseListChangedEvents = true;
        }
        #endregion

        #region Cancelar
        public override void Cancelar()
        {
            recursoDetalleBindingSource.CancelEdit();
            base.Cancelar();
        }
        #endregion

        #region Actualizar
        public override void Actualizar()
        {
            base.Actualizar();
        }
        public override void CargaDatosActuales()
        {
            m_Seleccionado = detallesBindingSource.Current as RecursoDetalle;
            if (m_Seleccionado == null)
                throw new InvalidOperationException("Seleccione un registro!");
        }
        #endregion

        #region Detalles de Recurso
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                m_RecursoDetalle.Detalles.AddNew();
                detallesBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CargaDatosActuales();
                using (var frm = new frmDetalleRecurso(m_Seleccionado))
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        m_Seleccionado = frm.m_RecursoDetalle;
                        detallesBindingSource.ResetBindings(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CargaDatosActuales();
                m_RecursoDetalle.Detalles.Remove(m_Seleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        } 
        #endregion


    }
}
