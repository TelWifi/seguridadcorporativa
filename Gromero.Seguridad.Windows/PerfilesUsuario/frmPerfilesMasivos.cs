using Csla;
using DevExpress.XtraEditors;
using Gromero.Seguridad.Negocio.Editables;
using Gromero.Seguridad.Negocio.SoloLectura;
using Gromero.Seguridad.Windows.Aplicaciones;
using System;
using System.Linq;
using System.Windows.Forms;
using Gromero.Seguridad.Negocio.Comandos;
using Csla.Rules;

namespace Gromero.Seguridad.Windows.PerfilesUsuario
{
    public partial class frmPerfilesMasivos : ErickOrlando.Utilidades.Windows._PlantillaMntDeGestor
    {
        #region Declaracion de Variables
        private AplicacionInfo aplicacionInfo;
        #endregion

        #region Constructor
        public frmPerfilesMasivos()
        {
            InitializeComponent();
            lblMensaje.Text = Properties.Resources.msgPerfilesMasivos;
        }
        #endregion

        #region Eventos del Formulario

        public override void Formulario(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                base.Formulario(sender, e);
                usuarioInfoListBindingSource.DataSource = UsuarioInfoList.GetUsuarioInfoList();
                usuariosListGridView.BestFitColumns();
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
            }
        }

        private void btnBuscarAplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var frm = new frmPromptAplicaciones() { CadenaBusqueda = aplicacionTextEdit.Text })
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        aplicacionInfo = frm.ListaObjetos.First() as AplicacionInfo;
                        aplicacionTextEdit.EditValue = aplicacionInfo.Nombre;
                        aplicacionBindingSource.DataSource = aplicacionInfo;
                        aplicacionBindingSource.ResetBindings(false);
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


        #endregion

        #region Boton Grabar
        public override void Grabar()
        {
            string mensajeError = string.Empty;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Confirmamos la respuesta del usuario.
                if (XtraMessageBox.Show(Properties.Resources.msgConfirmeCreacionMasiva, Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                    return;

                var listaUsuarios = ((BindingSource)usuarioInfoListGridControl.DataSource)
                    .DataSource as UsuarioInfoList;

                if (listaUsuarios == null)
                    return;

                foreach (var usuarioSeleccionado in listaUsuarios.Where(u => u.Seleccionar == true))
                {
                    PerfilUsuario perfilUsuario = PerfilUsuario.NewPerfilUsuario();
                    // Buscamos que el usuario tenga un Perfil ya creado.
                    var idPerfilUsuario = PerfilUsuarioCommand
                        .Execute(usuarioSeleccionado.ID, aplicacionInfo.ID);
                    if (!string.IsNullOrEmpty(idPerfilUsuario))
                        perfilUsuario = PerfilUsuario.GetPerfilUsuario(idPerfilUsuario);
                    else
                    {
                        perfilUsuario.IdUsuario = usuarioSeleccionado.ID;
                        perfilUsuario.IdAplicacion = aplicacionInfo.ID;
                        perfilUsuario.Usuario = usuarioSeleccionado.Nombres;
                        perfilUsuario.Aplicacion = aplicacionInfo.Nombre;
                    }
                    // Obtenemos la lista de los Roles seleccionados.
                    foreach (Rol rol
                        in rolesCheckedListBoxControl.SelectedItems)
                    {
                        var rolPerfil = RolPerfil.NewRolPerfil();
                        rolPerfil.IdAplicacion = aplicacionInfo.ID;
                        rolPerfil.IdRol = rol.Id;
                        rolPerfil.NombreRol = rol.Nombre;
                        // Agregamos los Permisos basados en el Rol.
                        rolPerfil.AgregarPermisos(usuarioSeleccionado.ID);
                        perfilUsuario.RolesPerfiles.Add(rolPerfil);
                    }
                    // Si hubieran errores se coloca en una variable.
                    mensajeError = perfilUsuario.BrokenRulesCollection.ToString();
                    // Una vez que se hayan agregado todos los Roles y Permisos
                    // se procede a guardar la información en la BD.
                    perfilUsuario.Save();
                }

                XtraMessageBox.Show(
                    "Se crearon los perfiles exitosamente!",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                base.Grabar();
            }
            catch (ValidationException)
            {
                XtraMessageBox.Show(mensajeError,
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
            }
        }
        #endregion

    }
}
