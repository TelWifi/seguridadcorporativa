using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using Gromero.Seguridad.Negocio.Editables;
using System;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows.RecursosSeguridad
{
    public partial class frmRecursosAnidados : _PlantillaMntDeGestor
    {
        #region Declaracion de Variables
        internal RecursoHijo m_RecursoHijo;
        private RecursoHijo m_Seleccionado;
        private RecursoDetalle m_DetalleSeleccionado;
        #endregion

        #region Constructores
        public frmRecursosAnidados()
        {
            InitializeComponent();
        }

        public frmRecursosAnidados(RecursoHijo _recursoHijo)
        {
            InitializeComponent();

            m_RecursoHijo = _recursoHijo;
            recursoHijoBindingSource.DataSource = _recursoHijo;

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Grabar
        public override void Grabar()
        {
            recursoHijoBindingSource.RaiseListChangedEvents = false;
            recursoHijoBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                descripcionTextEdit.Focus();

                base.Grabar();
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(m_RecursoHijo.BrokenRulesCollection.ToString(),
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

            recursoHijoBindingSource.RaiseListChangedEvents = true;
        }
        #endregion

        #region Cancelar
        public override void Cancelar()
        {
            recursoHijoBindingSource.CancelEdit();
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
            var resultado = true;
            switch (tabRecursos.SelectedTabPage.Name)
            {
                case "tpDetalles":
                    m_DetalleSeleccionado = detallesBindingSource.Current as RecursoDetalle;
                    if (m_DetalleSeleccionado == null)
                        resultado = false;
                    break;
                case "tpRecursos":
                    m_Seleccionado = listaRecursosBindingSource.Current as RecursoHijo;
                    if (m_Seleccionado == null)
                        resultado = false;
                    break;
            }

            if (!resultado)
                throw new InvalidOperationException("Seleccione un registro!");
        }
        #endregion

        #region Detalles
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (tabRecursos.SelectedTabPage.Name)
                {
                    case "tpDetalles":
                        m_RecursoHijo.Detalles.AddNew();
                        detallesBindingSource.ResetBindings(false);
                        break;
                    case "tpRecursos":
                        m_RecursoHijo.ListaRecursos.AddNew();
                        listaRecursosBindingSource.ResetBindings(false);
                        break;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CargaDatosActuales();
                switch (tabRecursos.SelectedTabPage.Name)
                {
                    case "tpDetalles":
                        using (var frm = new frmDetalleRecurso(m_DetalleSeleccionado))
                        {
                            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                m_DetalleSeleccionado = frm.m_RecursoDetalle;
                                detallesBindingSource.ResetBindings(false);
                            }
                        }
                        break;
                    case "tpRecursos":
                        using (var frm = new frmRecursosAnidados(m_Seleccionado))
                        {
                            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                m_Seleccionado = frm.m_RecursoHijo;
                                listaRecursosBindingSource.ResetBindings(false);
                            }
                        }
                        break;
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
                switch (tabRecursos.SelectedTabPage.Name)
                {
                    case "tpDetalles":
                        m_RecursoHijo.Detalles.Remove(m_DetalleSeleccionado);
                        detallesBindingSource.ResetBindings(false);
                        break;
                    case "tpRecursos":
                        m_RecursoHijo.ListaRecursos.Remove(m_Seleccionado);
                        listaRecursosBindingSource.ResetBindings(false);
                        break;
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
        #endregion
    }
}
