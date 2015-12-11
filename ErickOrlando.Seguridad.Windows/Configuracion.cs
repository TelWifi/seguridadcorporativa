using System;
using System.Configuration;

namespace ErickOrlando.Seguridad.Windows
{
	/// <summary>
	/// Clase que permite modificar el archivo de Configuracion de la aplicacion
	/// </summary>
	/// <remarks>Erick Orlando © 2009</remarks>
	public class Configuracion
	{
		private static Configuration m_cfg;
		/// <summary>
		/// Obtiene el archivo de configuracion actual
		/// </summary>
		public static void GetConfig()
		{
			m_cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
		}

		/// <summary>
		/// Guarda el archivo de configuracion con los nuevos valores
		/// </summary>
		/// <remarks></remarks>
		public static void SaveConfig()
		{
			try
			{
				m_cfg.Save(System.Configuration.ConfigurationSaveMode.Full);
				ConfigurationManager.RefreshSection("appSettings");
			}
			catch
			{ }
		}

		private static string _Skin;
		/// <summary>
		/// Skin
		/// </summary>
		public static string Skin
		{
			get
			{
				_Skin = m_cfg.AppSettings.Settings["SkinAplicacion"].Value;
				if (String.IsNullOrEmpty(_Skin))
					_Skin = "Money Twins";
				return _Skin;
			}
			set
			{
				m_cfg.AppSettings.Settings["SkinAplicacion"].Value = value;
				SaveConfig();
			}
		}
	}
}
