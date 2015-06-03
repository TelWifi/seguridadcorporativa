using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using Gromero.Seguridad.Negocio.Comandos;
using Gromero.Seguridad.Negocio.Editables;
using Gromero.Seguridad.Negocio.SoloLectura;
using Gromero.Seguridad.Windows.Aplicaciones;
using Gromero.Seguridad.Windows.Usuarios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows.PerfilesUsuario
{
    public partial class frmMntPerfilUsuario : _PlantillaMntDeGestor
    {
        #region Declaracion de Variables

        private PerfilUsuario m_PerfilUsuario;
        private AplicacionInfo m_AplicacionInfo;

        #endregion

        #region Constructores
        public frmMntPerfilUsuario()
        {
            InitializeComponent();
        }

        public frmMntPerfilUsuario(PerfilUsuario _perfilUsuario)
        {
            InitializeComponent();

            m_PerfilUsuario = _perfilUsuario;
            perfilUsuarioBindingSource.DataSource = _perfilUsuario;

            if (!m_PerfilUsuario.IsNew)
            {
                aplicacionBindingSource.DataSource = AplicacionCommand.Execute(m_PerfilUsuario.Aplicacion);
                aplicacionBindingSource.ResetBindings(false);
            }

            Shown += (sender, obj) =>
            {
                gdvRoles.BestFitColumns();
            };

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Grabar
        public override void Grabar()
        {
            perfilUsuarioBindingSource.RaiseListChangedEvents = false;
            perfilUsuarioBindingSource.EndEdit();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                aplicacionTextEdit.Focus();
                m_PerfilUsuario = m_PerfilUsuario.Save();
                XtraMessageBox.Show(
                    "Registro grabado correctamente!",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                base.Grabar();
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(m_PerfilUsuario.BrokenRulesCollection.ToString(),
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

            perfilUsuarioBindingSource.RaiseListChangedEvents = true;
        }
        #endregion

        #region Cancelar
        public override void Cancelar()
        {
            perfilUsuarioBindingSource.CancelEdit();
            base.Cancelar();
        }
        #endregion

        #region Actualizar
        public override void Actualizar()
        {
            base.Actualizar();
        }
        #endregion

        #region Ventanas de Busqueda

        private void btnBuscarAplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var frm = new frmPromptAplicaciones() { CadenaBusqueda = aplicacionTextEdit.Text })
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var result = frm.ListaObjetos.First() as AplicacionInfo;
                        m_PerfilUsuario.IdAplicacion = result.ID;
                        m_PerfilUsuario.Aplicacion = result.Nombre;
                        rolesBindingSource.DataSource = result;
                        perfilUsuarioBindingSource.ResetBindings(false);
                        m_AplicacionInfo = result;
                    }
                }
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Buscar Aplicacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Buscar Aplicacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var frm = new frmPromptUsuarios() { CadenaBusqueda = usuarioTextEdit.Text })
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var result = frm.ListaObjetos.First() as UsuarioInfo;
                        m_PerfilUsuario.IdUsuario = result.ID;
                        m_PerfilUsuario.Usuario = string.Format(
                                      "{0} {1} {2} ({3})",
                                      result.Nombres,
                                      result.ApellidoPaterno,
                                      result.ApellidoMaterno,
                                      result.Codigo);
                        perfilUsuarioBindingSource.ResetBindings(false);
                    }
                }
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Buscar Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Buscar Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Botones Internos
        private void aplicacionTextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            aplicacionTextEdit.Text = string.Empty;
        }

        private void usuarioTextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            usuarioTextEdit.Text = string.Empty;
        }
        #endregion

        #region Asignacion de Roles

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!m_PerfilUsuario.IsValid)
                    return;
                var rolSeleccionado = rolesBindingSource.Current as Rol;
                if (rolSeleccionado == null)
                    return;
                var rol = m_PerfilUsuario.RolesPerfiles.AddNew(rolSeleccionado.Id);
                rol.NombreRol = rolSeleccionado.Nombre;
                rol.IdAplicacion = m_PerfilUsuario.IdAplicacion;
                rol.AgregarPermisos();
                rolesPerfilesBindingSource.ResetBindings(false);
                gdvRoles.BestFitColumns();
                gdvPermisos.BestFitColumns();
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Error al Agregar Permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Error al Agregar Permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnQuitarRol_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var seleccionado = rolesPerfilesBindingSource.Current as RolPerfil;
                if (seleccionado == null)
                    return;
                m_PerfilUsuario.RolesPerfiles.Remove(seleccionado);
                rolesPerfilesBindingSource.ResetBindings(false);
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

        private void btnActualizarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Se implementa la opción de actualizar todos los Roles del perfil
                // en lugar de tener que estar seleccionando un Rol a la vez
                foreach (var rolPerfil in m_PerfilUsuario.RolesPerfiles)
                    rolPerfil.AgregarPermisos();

                rolesPerfilesBindingSource.ResetBindings(false);
                gdvPermisos.BestFitColumns();
            }
            catch (DataPortalException ex)
            {
                MessageBox.Show(ex.BusinessException.Message, 
                    Text, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
                    Text, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region Asignacion de Recursos
        private void btnAsignarRecursos_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!m_PerfilUsuario.IsValid)
                    return;
                m_PerfilUsuario.AgregaRecursos();
                recursosBindingSource.ResetBindings(false);
            }
            catch (DataPortalException ex)
            {
                MessageBox.Show(ex.BusinessException.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
