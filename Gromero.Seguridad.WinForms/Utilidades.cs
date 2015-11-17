using GR.COMEX.Seguridad.Entidades;
using Gromero.Seguridad.Login;
using Gromero.Seguridad.WinForms;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Deployment.Application;
using System.Web;

namespace Gromero.Seguridad
{
	/// <summary>
	/// Contiene Metodos Estáticos para usar en la Capa de Seguridad
	/// </summary>
	/// <remarks>Erick Orlando © 2012</remarks>
	[Serializable]
	public class Utilidades
	{

		/// <summary>
		/// Comprueba si la aplicacion esta cargando desde ClickOnce ™
		/// </summary>
		public static bool AplicacionClickOnce()
		{
			return ApplicationDeployment.IsNetworkDeployed;
		}

		/// <summary>
		/// Obtiene los Parametros pasados a traves de ClickOnce
		/// </summary>
		/// <returns>Recupera una propiedad Dictionary de los parámetros de cadena de consulta, indizada por nombre. </returns>
		/// <remarks>Erick Orlando © 2008</remarks>
		public static NameValueCollection ObtenerParametros()
		{
			NameValueCollection NameValueTable = new NameValueCollection();
			if (AplicacionClickOnce())
			{
				string QueryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
				NameValueTable = HttpUtility.ParseQueryString(QueryString);
			}
			return NameValueTable;
		}

		/// <summary>
		/// Carga el Formulario de Autenticacion
		/// </summary>
		public static bool Autenticacion()
		{
			using (var frm = new LoginForm())
			{
				return (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK);
			}
		}

		/// <summary>
		/// Autentica el Usuario en base al ID del Perfil
		/// </summary>
		public static bool Autenticacion(string IdPerfil)
		{
			if (ConfigurationManager.AppSettings["UrlSeguridad"] == null)
			{
				return GRPrincipal.Login(new Guid(IdPerfil));
			}

			using (var proxy = new ProxySeguridad())
			{
				var response = proxy.GetInfoUsuario(new RequestInfoUsuario
				{
					IdPerfilUsuario = IdPerfil
				});

				InfoUsuario.Initialize();
				InfoUsuario.Instancia.IdPerfilUsuario = IdPerfil;
				InfoUsuario.Instancia.NombresCompletos = response.NombresCompletos;
				InfoUsuario.Instancia.CorreoUsuario = response.Correo;
				InfoUsuario.Instancia.Dominio = response.Dominio;
				InfoUsuario.Instancia.FechaUltimoIngreso = DateTime.Today;

				return true;
			}
		}


	}
}
