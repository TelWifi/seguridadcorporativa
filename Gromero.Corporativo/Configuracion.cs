using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gromero.Seguridad.Windows
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
            m_cfg.Save(System.Configuration.ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("appSettings");

        }

        /// <summary>
        /// Skin
        /// </summary>
        public static string Skin
        {
            get { return m_cfg.AppSettings.Settings["SkinAplicacion"].Value; }
            set
            {
                m_cfg.AppSettings.Settings["SkinAplicacion"].Value = value;
                SaveConfig();
            }
        }
    }
}
