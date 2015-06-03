using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Csla;
using Gromero.Seguridad;
using Gromero.Corporativo.SoloLectura;
using System.Diagnostics;
using DevExpress.XtraBars.Helpers;
using Gromero.Seguridad.Windows;

namespace Gromero.Corporativo
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private string Tema = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(rgbSkins);
            Program.DoLogin();
            if (InfoUsuario.Instancia == null)
            {
                Application.Exit();
                return;
            }
            CargaInfoUsuario();
            Shown += (s, e) => CargarTreeView();
            //WindowState = FormWindowState.Maximized;
            AllowFormSkin = true;
            rgbSkins.GalleryItemClick += (s, e) => Tema = e.Item.Caption;
            FormClosed += (s, e) => Configuracion.Skin = Tema;
            BarraEstado.ItemLinks.Add(lblUltimoIngreso);
        }

        public void CargarTreeView()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var listaApp = AppInfoList.GetAppInfoList(InfoUsuario.Instancia.IdUsuario);
                treePerfiles.Nodes[0].Nodes.Clear();
                foreach (var item in listaApp)
                {
                    //Agregamos al nodo de Aplicación
                    var nodo = new TreeNode(item.NombreApp, 0, 0);
                    nodo.Name = item.IdPerfilUsuario;
                    nodo.Tag = item.Ruta;
                    treePerfiles.Nodes[0].Nodes.Add(nodo);
                }
                treePerfiles.ExpandAll();
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

        public void CargaInfoUsuario()
        {

            //if (!Csla.ApplicationContext.User.Identity.IsAuthenticated)
            //    return;
            lblUsuario.Caption = string.Format("Autenticado como: {0}",
                InfoUsuario.Instancia.NombresCompletos);
            lblCorreo.Caption = string.Format("Correo: {0}", InfoUsuario.Instancia.CorreoUsuario);
            lblDominio.Caption = string.Format("Dominio:{0}", InfoUsuario.Instancia.Dominio);
            lblUltimoIngreso.Caption = string.Format("Ultimo Ingreso: {0:g}",
                InfoUsuario.Instancia.FechaUltimoIngreso);
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Gromero.Seguridad.WinForms.LoginForm.FormAlone = false;
            Program.DoLogin();
            CargarTreeView();
            CargaInfoUsuario();
        }

        private void treePerfiles_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var nodo = treePerfiles.SelectedNode;
                if (nodo.Level == 1)
                {
                    var ruta = nodo.Tag as string;
                    var urlFinal = string.Format("{0}?IdPerfilUsuario={1}", ruta, nodo.Name);

                    if (!ruta.EndsWith("application"))
                        urlFinal = ruta;

                    var process = new ProcessStartInfo("iexplore", urlFinal) { WindowStyle = ProcessWindowStyle.Hidden };
                    Process.Start(process);
                }
            }
            catch (Win32Exception)
            {
                XtraMessageBox.Show(
                    "No se puede iniciar la Aplicación, asegúrese de que haya implementado. Consulte con el Administrador",
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
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarTreeView();
        }
    }
}