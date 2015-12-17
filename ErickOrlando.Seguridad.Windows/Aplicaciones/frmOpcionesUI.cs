using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Aplicaciones
{
    public partial class frmOpcionesUI : _PlantillaMntDeGestor
    {
        #region Declaracion de Variables
        internal Opcion m_Opcion;
        #endregion

        #region Constructores
        public frmOpcionesUI()
        {
            InitializeComponent();
        }

        public frmOpcionesUI(Opcion _opcionesUI)
        {
            InitializeComponent();

            m_Opcion = _opcionesUI;
            opcionesUIBindingSource.DataSource = _opcionesUI;
            if (opcionesUIBindingSource.Count > 0)
                gdvOpciones.BestFitColumns();
            if (listaPlantillasBindingSource.Count > 0)
                gdvListaPlantillas.BestFitColumns();
            m_Opcion.ChequearReglas();
            btnRoles.Click += bbiRoles_ItemClick;
            Text = string.Format("Lista de Opciones de {0}", m_Opcion.Nombre);
            Cursor.Current = Cursors.Default;
        }

        void bbiRoles_ItemClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Se llenan las plantillas con todos los Roles
                var aplicacion = Csla.ApplicationContext.LocalContext["aplicacion"] as Aplicacion;
                var seleccionado = listaOpcionesBindingSource.Current as Opcion;
                if (seleccionado == null)
                    return;
                seleccionado.AgregarRoles(aplicacion);
                listaPlantillasBindingSource.ResetBindings(false);
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

        #region Grabar
        public override void Grabar()
        {
            opcionesUIBindingSource.RaiseListChangedEvents = false;
            opcionesUIBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                m_Opcion.ChequearReglas();
                if (!m_Opcion.IsValid)
                    throw new ValidationException();

                codigoTextEdit.Focus();
                base.Grabar();
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(m_Opcion.BrokenRulesCollection.ToString(),
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

            opcionesUIBindingSource.RaiseListChangedEvents = true;
        }
        #endregion

        #region Cancelar
        public override void Cancelar()
        {
            opcionesUIBindingSource.CancelEdit();
            base.Cancelar();
        }
        #endregion

        #region Actualizar
        public override void Actualizar()
        {
            base.Actualizar();
        }
        #endregion

        #region Detalles
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var opcion = m_Opcion.ListaOpciones.Agregar();
                opcion.Codigo = m_Opcion.ListaOpciones.CreaCorrelativo();
                listaOpcionesBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                var seleccionado = listaOpcionesBindingSource.Current as Opcion;
                if (seleccionado == null)
                    return;
                using (var frm = new frmOpcionesUI(seleccionado))
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        listaOpcionesBindingSource.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                var seleccionado = listaOpcionesBindingSource.Current as Opcion;
                if (seleccionado == null)
                    return;
                m_Opcion.ListaOpciones.Remove(seleccionado);
                listaOpcionesBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var seleccionado = listaOpcionesBindingSource.Current as Opcion;
                if (seleccionado == null)
                    return;

                foreach (var plantilla in seleccionado.ListaPlantillas)
                    plantilla.Conceder = false;

                listaPlantillasBindingSource.ResetBindings(false);
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
