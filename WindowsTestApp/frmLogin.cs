using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsTestApp.Proxies;
using DevExpress.XtraEditors;
using Gromero.Seguridad;

namespace WindowsTestApp
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			txtUser.Text = Environment.UserName;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

			try
			{
				Cursor.Current = Cursors.WaitCursor;
				//Creamos una instancia de la Clase LoginCredentials
				var credenciales = new LoginCredentials();

				credenciales.UserName = txtUser.Text;
				credenciales.Password = txtPass.Text;
				credenciales.AcronimoSistema = "SEGCORP";

				//Invocamos al Servicio con la API REST
				var result = InformacionREST<LoginCredentials>.EnviarInfo(
					new Uri(Publicos.GetDireccionServicio(), "Login"), credenciales);


				if (result)
				{
					var frm = new Form1();
					frm.ShowDialog();
				}
				else
					throw new System.Security.SecurityException();

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
	}
}
