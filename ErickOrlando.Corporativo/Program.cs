using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gromero.Seguridad;
using DevExpress.LookAndFeel;
using Gromero.Seguridad.Windows;
using System.Threading;

namespace Gromero.Corporativo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool mutexCreado = false;
            Mutex miMutex = new Mutex(true, "InicioDeSessionCorporativo", out mutexCreado);
            if (mutexCreado)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.UserSkins.BonusSkins.Register();
                Configuracion.GetConfig();
                UserLookAndFeel.Default.SetSkinStyle(Configuracion.Skin);

                Application.Run(new MainForm());
                miMutex.ReleaseMutex();
            }
        }

        internal static void DoLogin()
        {
            Utilidades.Autenticacion();
        }
    }
}
