using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using ErickOrlando.Seguridad.Negocio.SoloLectura;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Aplicaciones
{
    public partial class frmMntAplicacion : _PlantillaMntDeGestor
    {
        #region Declaracion de Variables

        private Aplicacion m_Aplicacion;
        private Opcion m_Opcion;
        private Rol m_Rol;
        private RecursoAplicacion m_RecursoAplicacion;

        private RecursosInfoList ListaRecursos;

        #endregion

        #region Constructores
        public frmMntAplicacion()
        {
            InitializeComponent();
        }

        public frmMntAplicacion(Aplicacion _aplicacion)
        {
            InitializeComponent();

            m_Aplicacion = _aplicacion;
            aplicacionBindingSource.DataSource = _aplicacion;
            opcionesUIBindingSource.DataSource = _aplicacion.OpcionesUI;
            gdvOpciones.BestFitColumns();
            Csla.ApplicationContext.LocalContext["aplicacion"] = _aplicacion;
            //gdvOpciones.MasterRowExpanding += (s, e) => Cursor.Current = Cursors.WaitCursor;
            //gdvOpciones.MasterRowExpanded += (s, e) => Cursor.Current = Cursors.Default;
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Grabar
        public override void Grabar()
        {
            aplicacionBindingSource.RaiseListChangedEvents = false;
            aplicacionBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nombreTextEdit.Focus();
                m_Aplicacion.ChequearReglas();
                m_Aplicacion = m_Aplicacion.Save();
                XtraMessageBox.Show("Registro grabado correctamente!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.Grabar();
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show(ex.Message, "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            aplicacionBindingSource.RaiseListChangedEvents = true;
        }
        #endregion

        #region Cancelar
        public override void Cancelar()
        {
            aplicacionBindingSource.CancelEdit();
            base.Cancelar();
        }
        #endregion

        #region Actualizar
        public override void Actualizar()
        {
            base.Actualizar();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tipoSistemaInfoListBindingSource.DataSource =
                    TipoSistemaInfoList.GetTipoSistemaInfoList();

                RecursosInfoList.BeginGetRecursosInfoList((s, e) =>
                    {
                        if (e.Error != null)
                            throw e.Error;
                        ListaRecursos = e.Object;
                        this.Invoke(new Action(SetDataSource));
                    });

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    ex.Message,
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Metodos Adicionales
        public override void CargaDatosActuales()
        {
            base.CargaDatosActuales();
            bool err = false;
            switch (xtcAplicacion.SelectedTabPage.Name)
            {
                case "tpRoles":
                    m_Rol = rolesBindingSource.Current as Rol;
                    if (m_Rol == null)
                        err = true;
                    break;
                case "tpOpcionesUI":
                    m_Opcion = opcionesUIBindingSource.Current as Opcion;
                    if (m_Opcion == null)
                        err = true;
                    break;
                case "tpRecursos":
                    m_RecursoAplicacion = recursosBindingSource.Current as RecursoAplicacion;
                    if (m_RecursoAplicacion == null)
                        err = true;
                    break;
            }
            if (err)
                throw new InvalidOperationException("Seleccione un registro!");
        }

        public void SetDataSource()
        {
            recursosInfoListBindingSource.DataSource = ListaRecursos;
        }
        #endregion

        #region Detalles
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (xtcAplicacion.SelectedTabPage.Name)
                {
                    case "tpRoles":
                        m_Aplicacion.Roles.AddNew();
                        rolesBindingSource.ResetBindings(false);
                        break;
                    case "tpOpcionesUI":
                        var opcion = m_Aplicacion.OpcionesUI.AddNew();
                        opcion.Codigo = m_Aplicacion.OpcionesUI.CreaCorrelativo();
                        opcionesUIBindingSource.ResetBindings(false);
                        break;
                    case "tpRecursos":
                        m_Aplicacion.Recursos.AddNew();
                        recursosBindingSource.ResetBindings(false);
                        break;
                }

            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Agregar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Agregar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CargaDatosActuales();

                switch (xtcAplicacion.SelectedTabPage.Name)
                {
                    case "tpOpcionesUI":
                        using (var frm = new frmOpcionesUI(m_Opcion))
                        {
                            frm.Nuevo = false;
                            frm.ShowDialog();
                            m_Opcion = frm.m_Opcion;
                            opcionesUIBindingSource.ResetBindings(false);
                        }
                        break;

                }

            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Modificar Objeto de Autorización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Modificar Objeto de Autorización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CargaDatosActuales();
                if (XtraMessageBox.Show("Está seguro que desea eliminar este registro?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                switch (xtcAplicacion.SelectedTabPage.Name)
                {
                    case "tpRoles":
                        m_Aplicacion.Roles.Remove(m_Rol);
                        rolesBindingSource.ResetBindings(false);
                        break;
                    case "tpOpcionesUI":
                        m_Aplicacion.OpcionesUI.Remove(m_Opcion);
                        opcionesUIBindingSource.ResetBindings(false);
                        break;
                    case "tpRecursos":
                        m_Aplicacion.Recursos.Remove(m_RecursoAplicacion);
                        recursosBindingSource.ResetBindings(false);
                        break;
                }

            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void cAplicacion_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            switch (e.Page.Name)
            {
                case "tpRoles":
                    InfoListDataGridView = gdvRoles;
                    ObjetoLista = rolesBindingSource;
                    break;
                case "tpOpcionesUI":
                    InfoListDataGridView = gdvOpciones;
                    ObjetoLista = opcionesUIBindingSource;
                    break;
                case "tpRecursos":
                    InfoListDataGridView = gdvRecursos;
                    ObjetoLista = recursosBindingSource;
                    break;
            }

        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CargaDatosActuales();
                m_Opcion.AgregarRoles(m_Aplicacion);
                opcionesUIBindingSource.ResetBindings(false);
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

        #region Actualizar Opciones
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (MessageBox.Show(Properties.Resources.msgActualizarOpciones,
                            btnOpciones.Text,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return;

                //Recorremos todas las opciones, y las actualizamos con todos los Roles nuevos
                foreach (var opcion in m_Aplicacion.OpcionesUI)
                {
                    foreach (var opcionHija in opcion.ListaOpciones)
                    {
                        opcionHija.AgregarRoles(m_Aplicacion);
                        ActualizarOpcionesAnidadas(opcionHija);
                    }
                    opcion.AgregarRoles(m_Aplicacion);
                }

                MessageBox.Show(Properties.Resources.msgSuccessActualizarOpciones,
                    btnOpciones.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void ActualizarOpcionesAnidadas(Opcion opcionHija)
        {
            foreach (var opcion in opcionHija.ListaOpciones)
            {
                opcion.AgregarRoles(m_Aplicacion);
                ActualizarOpcionesAnidadas(opcion);
            }
        } 
        #endregion

    }
}
