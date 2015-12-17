using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.WinForms.HelperWin
{
    public class HelperValidaciones
    {
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private Control txtfocus;
        private string MensajeTamañoCaracteres = "Ingrese como mínimo {0} Caracteres ";
        private string MensajeObligatoriedad = "Ingrese {0}";
        public HelperValidaciones(System.Windows.Forms.ErrorProvider ErrorProvider1)
        {
            this.ErrorProvider1 = ErrorProvider1;
            this.ErrorProvider1 = new ErrorProvider();
            this.ErrorProvider1.Clear();
            txtfocus = null;
        }

        private void PonerFoco(Control txt)
        {
            if (txtfocus == null)
                txtfocus = txt;
        }
        private void PonerError(Control txt, string mensaje)
        {
            ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider1.SetError(txt, mensaje);
        }
        public void ValidarTamañoMínimoCaracteres(Control txt, int tamaño, string mensaje = null)
        {
            if (txt.Text.Trim().Length < tamaño)
            {
                if (txtfocus == null)
                    PonerFoco(txt);
                if (mensaje == null)
                    mensaje = String.Format(MensajeTamañoCaracteres, tamaño);
                PonerError(txt, mensaje);
            }
        }
        public void ValidarCampoObligatorio(Control txt, String labelControl = null, string mensaje = null)
        {
            if (txt.Text.Trim().Length == 0)
            {
                if (txtfocus == null)
                    PonerFoco(txt);

                if (mensaje == null)
                    if (labelControl == null)
                        mensaje = "Campo Obligatorio";
                    else
                        mensaje = String.Format(MensajeObligatoriedad, labelControl.Replace(":", "").Trim());
                PonerError(txt, mensaje);
            }
        }
        public bool EsValido()
        {
            bool valido = true;
            if (txtfocus != null)
            {
                txtfocus.Focus();
                valido = false;
            }
            return valido;
        }
    }
}
