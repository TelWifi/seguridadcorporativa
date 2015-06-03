using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using System.Runtime.Serialization;
using System.Web;

[assembly: ContractNamespace("SeguridadGRomero.Services", ClrNamespace = "SeguridadGRomero.Services")]

namespace Gromero.Seguridad
{
    /// <summary>
    /// Devuelve información del Usuario Autenticado
    /// </summary>
    [Serializable]
    [DataContract]
    public class InfoUsuario
    {
        /// <summary>
        /// Fecha del Último Ingreso del Usuario
        /// </summary>
        [DataMember]
        public DateTime FechaUltimoIngreso
        {
            get
            {
                if (Parametros.ContainsKey("FechaUltimoIngreso"))
                    _FechaUltimoIngreso = (DateTime)Parametros["FechaUltimoIngreso"];
                return _FechaUltimoIngreso;
            }
            set
            {
                _FechaUltimoIngreso = value;
                if (!Parametros.ContainsKey("FechaUltimoIngreso"))
                    Parametros.Add("FechaUltimoIngreso", value);
                else
                    Parametros["FechaUltimoIngreso"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Id del Perfil de Usuario
        /// </summary>
        [DataMember]
        public string IdPerfilUsuario
        {
            get
            {
                if (Parametros.ContainsKey("IdPerfilUsuario"))
                    _IdPerfilUsuario = Parametros["IdPerfilUsuario"] as string;
                return _IdPerfilUsuario;
            }
            set
            {
                _IdPerfilUsuario = value;
                if (!Parametros.ContainsKey("IdPerfilUsuario"))
                    Parametros.Add("IdPerfilUsuario", value);
                else
                    Parametros["IdPerfilUsuario"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Acrónimo de la Aplicación
        /// </summary>
        [DataMember]
        public string Acronimo
        {
            get
            {
                if (Parametros.ContainsKey("Acronimo"))
                    _Acronimo = Parametros["Acronimo"] as string;
                return _Acronimo;
            }
            set
            {
                _Acronimo = value;
                if (!Parametros.ContainsKey("Acronimo"))
                    Parametros.Add("Acronimo", value);
                else
                    Parametros["Acronimo"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Lista de los Roles que tiene asignado el Usuario
        /// </summary>
        [DataMember]
        public List<string> Roles
        {
            get
            {
                if (Parametros.ContainsKey("Roles"))
                    _Roles = Parametros["Roles"] as List<String>;
                return _Roles;
            }
            set
            {
                _Roles = value;
                if (!Parametros.ContainsKey("Roles"))
                    Parametros.Add("Roles", value);
                else
                    Parametros["Roles"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Id del Usuario
        /// </summary>
        [DataMember]
        public string IdUsuario
        {
            get
            {
                if (Parametros.ContainsKey("IdUsuario"))
                    _IdUsuario = Parametros["IdUsuario"] as string;
                return _IdUsuario;
            }
            set
            {
                _IdUsuario = value;
                if (!Parametros.ContainsKey("IdUsuario"))
                    Parametros.Add("IdUsuario", value);
                else
                    Parametros["IdUsuario"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Nombres Completos del Usuario Autenticado
        /// </summary>
        [DataMember]
        public string NombresCompletos
        {
            get
            {
                if (Parametros.ContainsKey("NombresCompletos"))
                    _NombresCompletos = Parametros["NombresCompletos"] as string;
                return _NombresCompletos;
            }
            set
            {
                _NombresCompletos = value;
                if (!Parametros.ContainsKey("NombresCompletos"))
                    Parametros.Add("NombresCompletos", value);
                else
                    Parametros["NombresCompletos"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Correo Electrónico del Usuario
        /// </summary>
        [DataMember]
        public string CorreoUsuario
        {
            get
            {
                if (Parametros.ContainsKey("CorreoUsuario"))
                    _CorreoUsuario = Parametros["CorreoUsuario"] as string;
                return _CorreoUsuario;
            }
            set
            {
                _CorreoUsuario = value;
                if (!Parametros.ContainsKey("CorreoUsuario"))
                    Parametros.Add("CorreoUsuario", value);
                else
                    Parametros["CorreoUsuario"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Dominio al que pertenece el usuario
        /// </summary>
        [DataMember]
        public string Dominio
        {
            get
            {
                if (Parametros.ContainsKey("Dominio"))
                    _Dominio = Parametros["Dominio"] as string;
                return _Dominio;
            }
            set
            {
                _Dominio = value;
                if (!Parametros.ContainsKey("Dominio"))
                    Parametros.Add("Dominio", value);
                else
                    Parametros["Dominio"] = value;
                SaveParametros();
            }
        }
        /// <summary>
        /// Tipo de Usuario (Externo o Interno)
        /// Externo = false
        /// Interno = true (Cuando pertenece a un Dominio)
        /// </summary>
        [DataMember]
        public bool Tipo
        {
            get
            {
                if (Parametros.ContainsKey("Tipo"))
                    _Tipo = (bool)Parametros["Tipo"];
                return _Tipo;
            }
            set
            {
                _Tipo = value;
                if (!Parametros.ContainsKey("Tipo"))
                    Parametros.Add("Tipo", value);
                else
                    Parametros["Tipo"] = value;
                SaveParametros();
            }
        }

        private string _CorreoUsuario;
        private bool _Tipo;
        private string _Dominio;
        private string _NombresCompletos;
        private string _IdUsuario;
        private List<string> _Roles;
        private string _Acronimo;
        private string _IdPerfilUsuario;
        private DateTime _FechaUltimoIngreso;
        private Dictionary<string, object> _Parametros = new Dictionary<string, object>();

        /// <summary>
        /// Instancia de InfoUsuario
        /// </summary>
        [DataMember]
        public static InfoUsuario Instancia { get; set; }
        /// <summary>
        /// Diccionario que aculuma todos los valores para InfoUsuario
        /// </summary>
        public Dictionary<string, object> Parametros
        {
            get
            {
                if (HttpContext.Current != null && HttpContext.Current.Session["Parametros"] != null)
                {
                    _Parametros = HttpContext.Current.Session["Parametros"] as Dictionary<string, object>;
                }
                else
                    if (_Parametros != null && ApplicationContext.GlobalContext["Parametros"] != null)
                        _Parametros = ApplicationContext.GlobalContext["Parametros"] as Dictionary<string, object>;

                //Si aún asi no se ha obtenido ninguna instancia válida para los Parametros
                //le creamos una instancia nueva
                if (_Parametros == null)
                    _Parametros = new Dictionary<string, object>();
                return _Parametros;
            }
        }

        /// <summary>
        /// Guarda los parámetros en el Contexto de la Aplicación
        /// </summary>
        public void SaveParametros()
        {
            ApplicationContext.GlobalContext["Parametros"] = Parametros;
            if (HttpContext.Current != null)
            {
                HttpContext.Current.Session["Parametros"] = Parametros;
            }
        }

        /// <summary>
        /// Inicializa una nueva Instancia de InfoUsuario
        /// </summary>
        public static void Initialize()
        {
            if (Instancia == null)
                Instancia = new InfoUsuario();
        }

    }
}
