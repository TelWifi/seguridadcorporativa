using DevExpress.LookAndFeel;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);


			DevExpress.Skins.SkinManager.EnableFormSkins();
			DevExpress.UserSkins.BonusSkins.Register();

			Thread.CurrentThread.CurrentCulture = new CultureInfo("es-PE");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-PE");

			//Cargamos los valores del archivo de Configuración
			Configuracion.GetConfig();

			UserLookAndFeel.Default.SetSkinStyle(Configuracion.Skin);

			Application.Run(new MainForm());
		}
	}
}