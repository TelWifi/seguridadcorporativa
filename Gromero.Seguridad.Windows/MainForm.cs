using Csla;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ErickOrlando.Utilidades.Data;
using Gromero.Seguridad.Negocio.Editables;
using Gromero.Seguridad.Negocio.SoloLectura;
using Gromero.Seguridad.Windows.Aplicaciones;
using Gromero.Seguridad.Windows.Cargos;
using Gromero.Seguridad.Windows.Empresas;
using Gromero.Seguridad.Windows.PerfilesUsuario;
using Gromero.Seguridad.Windows.RecursosSeguridad;
using Gromero.Seguridad.Windows.Usuarios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows
{
    public partial class MainForm : RibbonForm
    {

        #region Declaración de Variables
        private string Tema = string.Empty;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            InitSkinGallery();
            Visible = false;
            Shown += (s, e) =>
                {
                    DoLogin();
                    LlenaTreeView();
                    //ApplyAuthorizationRules();
                };
            tvwAplicaciones.AfterSelect += tvwAplicaciones_AfterSelect;
            rgbiSkins.GalleryItemClick += (s, e) =>
                {
                    Tema = e.Item.Caption;
                };
            FormClosed += (s, e) => Configuracion.Skin = Tema;

        }
        #endregion

        #region TreeView de Aplicaciones
        void tvwAplicaciones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (e.Node.Name == "MainNode")
                    return;
                switch (e.Node.Level)
                {
                    case 1:
                        //Llenar los Perfiles de Usuario en base a la Aplicacion Seleccionada
                        CargarPerfiles(e.Node.Name);
                        gdvPerfiles.Focus();
                        break;
                    case 2:
                        var TextoOriginal = e.Node.Text;
                        e.Node.Text = string.Format("(Cargando {0} ...)", e.Node.Text);
                        tvwAplicaciones.Refresh();
                        switch (TextoOriginal)
                        {
                            case "Roles":
                                LlenaRoles(e.Node);
                                break;
                            case "Opciones":
                                LlenaOpciones(e.Node);
                                break;
                            case "Recursos":
                                LlenaRecursos(e.Node);
                                break;
                        }
                        e.Node.Expand();
                        e.Node.Text = TextoOriginal;
                        break;
                }
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
        private void CargarPerfiles(string Acronimo)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                perfilUsuarioInfoListBindingSource.DataSource =
                    PerfilUsuarioInfoList.GetPerfilUsuarioInfoList(new FiltroCriteria
                    {
                        NombreCampo = "Aplicacion",
                        ValorBusqueda = Acronimo
                    });
                if (perfilUsuarioInfoListBindingSource.Count > 0)
                    gdvPerfiles.BestFitColumns();
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(
                    ex.BusinessException.Message,
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    ex.Message,
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void LlenaTreeView()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Llenamos el tvwAplicaciones
                var listaAplicaciones = AplicacionInfoList.GetAplicacionInfoList();
                tvwAplicaciones.Nodes[0].Nodes.Clear();
                foreach (var rowSistema in listaAplicaciones)
                {
                    var nodo = new TreeNode(rowSistema.Nombre, 0, 0) { Name = rowSistema.Acronimo };
                    //Carpeta Roles
                    var rolesFolder = new TreeNode("Roles", 7, 8) { Tag = rowSistema };
                    //Carpeta Opciones UI
                    var opcionesFolder = new TreeNode("Opciones", 7, 8) { Tag = rowSistema };
                    //Carpeta Recursos
                    var recursosFolder = new TreeNode("Recursos", 7, 8) { Tag = rowSistema };

                    //Agregamos los nodos al nodo del Sistema
                    nodo.Nodes.Add(rolesFolder);
                    nodo.Nodes.Add(opcionesFolder);
                    nodo.Nodes.Add(recursosFolder);

                    tvwAplicaciones.Nodes[0].Nodes.Add(nodo);
                }

                tvwAplicaciones.ShowNodeToolTips = true;
                tvwAplicaciones.Nodes[0].Text =
                       String.Format("Lista de Aplicaciones (Total: {0})", listaAplicaciones.Count);
                tvwAplicaciones.Nodes[0].Expand();
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Lista de Aplicaciones",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Lista de Aplicaciones",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void LlenaRoles(TreeNode Nodo)
        {
            Nodo.Nodes.Clear();
            var app = Nodo.Tag as AplicacionInfo;
            if (app == null)
                return;
            foreach (var rol in app.Roles)
                Nodo.Nodes.Add(new TreeNode(rol.Nombre, 1, 1));
        }
        private void LlenaOpciones(TreeNode NodoAplicacion)
        {
            NodoAplicacion.Nodes.Clear();
            var app = NodoAplicacion.Tag as AplicacionInfo;
            if (app == null)
                return;
            foreach (var opcionUI in app.Opciones)
            {
                var nodoOpcionPadre = new TreeNode(opcionUI.Nombre, 2, 2) { ToolTipText = opcionUI.Codigo };
                foreach (var opcionHijo in opcionUI.ListaOpciones)
                {
                    var nodoOpcionHijo = new TreeNode(opcionHijo.Nombre, 2, 2) { ToolTipText = opcionHijo.Codigo };
                    //Agregamos Carpeta de Roles
                    var rolesFolder = new TreeNode("Roles", 7, 8);
                    foreach (var item in opcionHijo.ListaPlantillas.Where(p => p.Conceder == true))
                        rolesFolder.Nodes.Add(new TreeNode(item.NombreRol, 1, 1));
                    nodoOpcionHijo.Nodes.Add(rolesFolder);
                    LLenaOpcionesAdicionales(nodoOpcionHijo, opcionHijo);
                    nodoOpcionPadre.Nodes.Add(nodoOpcionHijo);
                }
                NodoAplicacion.Nodes.Add(nodoOpcionPadre);
            }
        }
        private void LLenaOpcionesAdicionales(TreeNode nodoPadre, Opcion opcion)
        {
            foreach (var opcionHijo in opcion.ListaOpciones)
            {
                var nodoHijo = new TreeNode(opcionHijo.Nombre, 2, 2) { ToolTipText = opcionHijo.Codigo };
                var rolesFolder = new TreeNode("Roles", 7, 8);
                foreach (var item in opcionHijo.ListaPlantillas.Where(p => p.Conceder == true))
                    rolesFolder.Nodes.Add(new TreeNode(item.NombreRol, 1, 1));
                nodoHijo.Nodes.Add(rolesFolder);
                LLenaOpcionesAdicionales(nodoHijo, opcionHijo);
                nodoPadre.Nodes.Add(nodoHijo);
            }
        }
        private void LlenaRecursos(TreeNode Nodo)
        {
            Nodo.Nodes.Clear();
            var app = Nodo.Tag as AplicacionInfo;
            if (app == null)
                return;
            foreach (var recurso in app.Recursos)
            {
                var nodo = new TreeNode(recurso.NombreRecurso, 3, 3);
                Nodo.Nodes.Add(nodo);
            }
        }
        private void toolActualizar_Click(object sender, EventArgs e)
        {
            LlenaTreeView();
        }
        #endregion

        #region Apariencia
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        #endregion

        #region Barra de Botones

        private void bbiCargos_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var frm = new frmLstCargos())
                {
                    frm.ShowDialog();
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

        private void bbiRecursos_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var frm = new frmLstRecursos())
                {
                    frm.ShowDialog();
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

        private void bbiPermisosPorApp_ItemClick(object sender, ItemClickEventArgs e)
        {

        }


        private void bbiEmpresas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (var frm = new frmLstEmpresas())
                frm.ShowDialog();
        }

        private void bbiUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (var frm = new frmLstUsuarios())
                frm.ShowDialog();
        }

        private void bbiAplicaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (var frm = new frmLstAplicacion())
                frm.ShowDialog();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiPerfiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var frm = new frmLstPerfilUsuario())
                    frm.ShowDialog();
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

        private void bbiActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Publicos.LimpiarCache();
                ApplyAuthorizationRules();
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

        #region Perfiles de Usuario
        private void nuevoPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var frm = new frmMntPerfilUsuario(PerfilUsuario.NewPerfilUsuario()))
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        CargarPerfiles(tvwAplicaciones.SelectedNode.Name);
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Nuevo Perfil de Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Nuevo Perfil de Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var current = perfilUsuarioInfoListBindingSource.Current as PerfilUsuarioInfo;
                if (current == null)
                    return;
                Clipboard.SetText(current.ID);
                using (var frm = new frmMntPerfilUsuario(PerfilUsuario.GetPerfilUsuario(current.ID)))
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        CargarPerfiles(tvwAplicaciones.SelectedNode.Name);
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Editar Perfil de Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Editar Perfil de Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void eliminarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var current = perfilUsuarioInfoListBindingSource.Current as PerfilUsuarioInfo;
                if (current == null)
                    return;
                if (XtraMessageBox.Show("Desea eliminar el registro?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return;
                PerfilUsuario.DeletePerfilUsuario(current.ID);
                CargarPerfiles(tvwAplicaciones.SelectedNode.Name);
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Eliminar Perfil de Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Eliminar Perfil de Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void asignarPerfilesDeFormaMasivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var f = new frmPerfilesMasivos())
                {
                    if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        CargarPerfiles(tvwAplicaciones.SelectedNode.Name);
                }
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

        private void actualizarPermisosDeTodosLosPerfilesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Con esta opción el sistema buscará que todos los perfiles involucrados
            // de una aplicación determinada tengan todos los permisos efectivos
            // actualizados en base a las plantillas cargadas en el mantenimiento
            // de una aplicación.

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Obtenemos la lista de todos los perfiles cargados en la Grilla.
                var listaPerfiles = ((BindingSource)perfilUsuarioInfoListGridControl.DataSource).DataSource as PerfilUsuarioInfoList;
                if (listaPerfiles == null)
                    return;

                // Como este procedo puede tardar dependiendo de la conexión de Red del Usuario
                // hacemos la pregunta.

                var rpta = XtraMessageBox.Show(Properties.Resources.msgActualizarPerfiles,
                               Text,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.No)
                    return;

                foreach (var perfilUsuario in listaPerfiles)
                {
                    // Cargamos el Objeto Editable del Perfil de Usuario.
                    var perfilEditable = PerfilUsuario.GetPerfilUsuario(perfilUsuario.ID);
                    // Ahora recorremos todos los Roles asignados a este Perfil de Usuario.
                    foreach (var rolPerfil in perfilEditable.RolesPerfiles)
                        // Actualizamos los Permisos del Rol.
                        rolPerfil.AgregarPermisos();
                    // Una vez terminado el bucle, procedemos con el guardado en la BD.
                    perfilEditable.Save();
                }

                XtraMessageBox.Show(Properties.Resources.msgSuccessActualizarPerfiles,
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message,
                    "Error al actualizar los Perfiles",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    "Error al actualizar los Perfiles",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region Inicio de Sesión

        private void bsiUsuario_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            DoLogin();
        }

        private void ApplyAuthorizationRules()
        {
            bbiAplicaciones.Enabled = Aplicacion.CanGet();
            bbiEmpresas.Enabled = Empresa.CanGet();
            bbiUsuarios.Enabled = Usuario.CanGet();
            bbiPerfiles.Enabled = PerfilUsuario.CanGet();
        }

        private void DoLogin()
        {
            try
            {
                Csla.ApplicationContext.GlobalContext["Placa"] = Environment.MachineName;
                Csla.ApplicationContext.GlobalContext["Usuario"] = Environment.UserName;

                if (Utilidades.AplicacionClickOnce())
                    Utilidades.Autenticacion(Utilidades.ObtenerParametros()["IdPerfilUsuario"]);
                else
                    Utilidades.Autenticacion();

                CargaInfoUsuario();
                Visible = true;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Application.Exit();
            }
        }

        private void CargaInfoUsuario()
        {
            InfoUsuario.Initialize();
            if (String.IsNullOrEmpty(InfoUsuario.Instancia.NombresCompletos))
                return;
            bsiUsuario.Caption = string.Format("Usuario: {0}", InfoUsuario.Instancia.NombresCompletos);
            bsiCorreo.Caption = string.Format("Correo: {0}", InfoUsuario.Instancia.CorreoUsuario);
            bsiDominio.Caption = string.Format("Dominio: {0}", InfoUsuario.Instancia.Dominio);
            bsiLastSession.Caption = string.Format("Ultimo Ingreso: {0}", InfoUsuario.Instancia.FechaUltimoIngreso);

        }

        #endregion

    }
}