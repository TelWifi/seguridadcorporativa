using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.RecursosSeguridad
{
    public partial class frmRecursos : _PlantillaMntDeGestor
    {
        #region Declaracion de Variables
        private Recursos m_Recursos;
        private RecursoHijo m_RecursoHijo;
        private RecursoDetalle m_RecursoDetalle;
        #endregion

        #region Constructores
        public frmRecursos()
        {
            InitializeComponent();
        }

        public frmRecursos(Recursos _recursos)
        {
            InitializeComponent();

            m_Recursos = _recursos;
            recursosBindingSource.DataSource = _recursos;

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Grabar
        public override void Grabar()
        {
            recursosBindingSource.RaiseListChangedEvents = false;
            recursosBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                m_Recursos = m_Recursos.Save();
                XtraMessageBox.Show("Registro grabado correctamente!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.Grabar();
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(m_Recursos.BrokenRulesCollection.ToString(),
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

            recursosBindingSource.RaiseListChangedEvents = true;
        }
        #endregion

        #region Cancelar
        public override void Cancelar()
        {
            recursosBindingSource.CancelEdit();
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
                    var seleccionado = detallesBindingSource.Current as RecursoDetalle;
                    if (seleccionado == null)
                        resultado = false;
                    m_RecursoDetalle = seleccionado;
                    break;
                case "tpRecursosAnidados":
                    var recurso = listaRecursosBindingSource.Current as RecursoHijo;
                    if (recurso == null)
                        resultado = false;
                    m_RecursoHijo = recurso;
                    break;
            }

            if (!resultado)
                throw new InvalidOperationException("Seleccione un registro primero");

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
                        m_Recursos.Detalles.AddNew();
                        detallesBindingSource.ResetBindings(false);
                        break;
                    case "tpRecursosAnidados":
                        m_Recursos.ListaRecursos.AddNew();
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
                        using (var frm = new frmDetalleRecurso(m_RecursoDetalle))
                        {
                            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                m_RecursoDetalle = frm.m_RecursoDetalle;
                                detallesBindingSource.ResetBindings(false);
                            }
                        }
                        break;
                    case "tpRecursosAnidados":
                        using (var frm = new frmRecursosAnidados(m_RecursoHijo))
                        {
                            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                listaRecursosBindingSource.ResetBindings(false);
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
                        m_Recursos.Detalles.Remove(m_RecursoDetalle);
                        detallesBindingSource.ResetBindings(false);
                        break;
                    case "tpRecursosAnidados":
                        m_Recursos.ListaRecursos.Remove(m_RecursoHijo);
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