using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErickOrlando.Seguridad.Login;

namespace WindowsTestApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                var crypto = new SimpleInteroperableEncryption();

                var resultado = crypto.Encrypt(txtClave.Text);

                Clipboard.SetText(resultado);
                lblResultado.Text = string.Format("Resultado: {0}", resultado);
                MessageBox.Show("Texto copiado al portapapeles");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
