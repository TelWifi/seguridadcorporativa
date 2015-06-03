using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Security;
using System.Security.Principal;
using System.Web;
using System.Configuration;

namespace Gromero.Seguridad.Login
{
	/// <summary>
	/// Administra la Autenticación de Usuarios en el Sistema de Seguridad
	/// </summary>
	public class GRPrincipal : CslaPrincipal
	{
		/// <summary>
		/// Inicializa una nueva instancia de GRPrincipal
		/// </summary>
		public GRPrincipal()
		{ }

		/// <summary>
		/// Inicializa una nueva instancia de GRPrincipal
		/// con un Objeto IIdentity
		/// </summary>
		protected GRPrincipal(IIdentity identity)
			: base(identity)
		{ }

		/// <summary>
		/// Autentica al Usuario en base al usuario, clave y dominio (INTERNOS)
		/// </summary>
		public static bool Login(string userName, string passWord, string domain)
		{
			var newDomain = string.Empty;
			//Validamos los Dominios
			switch (domain.ToUpper())
			{
				case "TRAMARSA":
					newDomain = "tramarsa.com.pe";
					break;
				case "GRUPOCOGESA":
					newDomain = "grupocogesa.gromero.net";
					break;
				case "GRUPORANSA":
					newDomain = "gruporansa.gromero.net";
					break;
				case "ALICORP":
					newDomain = "grupoalicorp.gromero.net";
					break;
				default:
					newDomain = domain;
					break;
			}
			var identity = GRIdentity.GetIdentity(userName, passWord, newDomain);
			return SetPrincipal(identity);
		}

		/// <summary>
		/// Autentica al Usuario en base al Usuario y Clave (EXTERNOS)
		/// </summary>
		public static bool Login(string username, string password)
		{
			var identity = GRIdentity.GetIdentity(username, password);
			return SetPrincipal(identity);
		}

		/// <summary>
		/// Carga la Info del Usuario en base al nombre de usuario
		/// </summary>
		public static bool Load(string userName, string Dominio)
		{
			var identity = GRIdentity.GetIdentity(new GRIdentity.FiltroUsuario(userName, Dominio));
			return SetPrincipal(identity);
		}

		/// <summary>
		/// Autentica al Usuario en base al Id del Perfil del Usuario
		/// </summary>
		public static bool Login(Guid IdPerfilUsuario)
		{
			Login();
			var identity = GRIdentity.GetIdentity(IdPerfilUsuario);
			return SetPrincipal(identity);
		}

		/// <summary>
		/// Realiza la Autenticación Anónima
		/// </summary>
		/// <returns></returns>
		public static bool Login()
		{
			var identity = GRIdentity.GetIdentity();
			return SetPrincipal(identity);
		}

		private static bool SetPrincipal(GRIdentity identity)
		{
			if (identity.IsAuthenticated)
			{
				var principal = new GRPrincipal(identity);
				Csla.ApplicationContext.User = principal;
				Csla.ApplicationContext.LocalContext["Principal"] = principal;
				if (HttpContext.Current != null)
				{
					HttpContext.Current.User = principal;
				}
			}
			OnNewUser();
			return identity.IsAuthenticated;
		}

		/// <summary>
		/// Cierra Sesión
		/// </summary>
		public static void Logout()
		{
			Csla.ApplicationContext.User = new UnauthenticatedPrincipal();
			OnNewUser();
		}

		/// <summary>
		/// Evento que se produce cuando se autentica el Usuario
		/// </summary>
		public static event Action NewUser = delegate { };
		private static void OnNewUser()
		{
			NewUser();
		}
	}
}
