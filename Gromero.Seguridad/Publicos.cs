using Csla;
using Gromero.Seguridad.Entidades;
using System;
using System.Configuration;
using System.Linq;
using System.Security.Principal;

namespace Gromero.Seguridad
{
	/// <summary>
	/// Clase que expone Métodos y Propiedades
	/// para usar en el Sistema de Seguridad
	/// </summary>
	[Serializable]
	public partial class Publicos
	{
		/// <summary>
		/// No tiene autorización para agregar!
		/// </summary>
		public const string msgPermisosAgregar = "No tiene autorización para agregar!";
		/// <summary>
		/// No tiene autorización para leer!
		/// </summary>
		public const string msgPermisosLeer = "No tiene autorización para leer!";
		/// <summary>
		/// No tiene autorización para actualizar!
		/// </summary>
		public const string msgPermisosActualizar = "No tiene autorización para actualizar!";
		/// <summary>
		/// No tiene autorización para eliminar!
		/// </summary>
		public const string msgPermisosEliminar = "No tiene autorización para eliminar!";

		/// <summary>
		/// Guarda en el Contexto los Datos del Usuario autenticado
		/// </summary>
		public static void AutenticacionContext()
		{
			ApplicationContext.ClientContext["Usuario"] = ApplicationContext.User.Identity.Name;
			ApplicationContext.ClientContext["Identity"] = ApplicationContext.User.Identity;
			ApplicationContext.ClientContext["Placa"] = Environment.MachineName;

			if (ConfigurationManager.AppSettings["WebService"] == null)
			{
				if (System.Web.HttpContext.Current != null)
					System.Web.HttpContext.Current.Session["Identity"] = ApplicationContext.User.Identity;
			}
		}

		/// <summary>
		/// Permite consultar los Permisos de una Opción especifica de una Aplicación,
		/// devuelve un valor Booleano (True si tiene acceso y False si no lo tiene)
		/// </summary>
		/// <param name="tipo">Tipo de Permiso (si se escoge Otro se usará el parametro OtroPermiso)</param>
		/// <param name="NombreModulo">Literal. Opción del Sistema</param>
		/// <param name="OtroPermiso">Literal. Opcion utilizada cuando en Tipo se establece Otro</param>
		/// <remarks>Erick Orlando © 2008</remarks>
		public static bool ConsultarPermisos(TipoAccion tipo, string NombreModulo, string OtroPermiso = "")
		{
			//Recuperamos el Usuario Autenticado
			if (ApplicationContext.LocalContext["Principal"] != null)
				ApplicationContext.User = ApplicationContext.LocalContext["Principal"] as IPrincipal;
			//Consultamos los Permisos Efectivos
			var coleccion = PermisosEfectivosInfoList.GetPermisosEfectivosInfoList();
			var opcion = OtroPermiso;
			switch (tipo)
			{
				case TipoAccion.PuedeAgregar:
					opcion = "Nuevo";
					break;
				case TipoAccion.PuedeActualizar:
					opcion = "Editar";
					break;
				case TipoAccion.PuedeEliminar:
					opcion = "Eliminar";
					break;
				case TipoAccion.PuedeLeer:
					opcion = "Buscar";
					break;
				default:
					if (String.IsNullOrEmpty(OtroPermiso))
						throw new ArgumentNullException("No se ha especificado un valor para el parámetro OtroPermiso");
					break;
			}

			var permisos = coleccion.Where(p => p.Opcion.Equals(NombreModulo) && p.Conceder.Equals(true) && p.Opcion.Equals(opcion));
			foreach (var item in permisos)
			{
				if (ApplicationContext.User.IsInRole(item.Rol))
					return true;

			}

			//Si termina el recorrido de todos los Roles y ninguno tiene permisos
			return false; //Devolvermos Falso.
		}

		/// <summary>
		/// Limpia por Completo la caché de Permisos
		/// NOTA: No es igual que cerrar sesión
		/// </summary>
		/// <remarks>Erick Orlando © 2010</remarks>
		public static void LimpiarCache()
		{
			PermisosEfectivosInfoList.InvalidateCache();
		}

		/// <summary>
		/// Comprueba si dentro del nombre del usuario existe el Dominio
		/// </summary>
		/// <param name="username">Nombre de usuario, si hay dominio debe separarse con el símbolo (\)</param>
		/// <returns>Una estructura de tipo <see cref="UserDomain"/></returns>
		public static UserDomain ComprobarDominioEnUsuario(string username)
		{
			var result = new UserDomain();
			//Comprobamos que el Nombre de Usuario contiene un Dominio
			var userDomain = username.Split('\\');
			result.Dominio = Environment.UserDomainName;
			result.Usuario = username;

			if (userDomain.Length > 1)
			{
				result.Dominio = userDomain.First();
				result.Usuario = userDomain.Last();
			}

			return result;
		}

		/// <summary>
		/// Devuelve la dirección del Servicio WCF de Seguridad
		/// </summary>
		/// <returns>Un Objeto Uri que contiene la dirección</returns>
		public static Uri GetDireccionServicio()
		{
			if (ConfigurationManager.AppSettings["UriSeguridad"] != null)
				return new Uri(ConfigurationManager.AppSettings["UriSeguridad"] as string);

			throw new ArgumentNullException("No ha especificado un valor para 'UriSeguridad' en la sección AppSettings del Archivo de Configuración");
		}

	}

	/// <summary>
	/// Estructura que contiene el Nombre de Usuario y el Dominio
	/// </summary>
	[Serializable]
	public struct UserDomain
	{
		/// <summary>
		/// Nombre de Usuario
		/// </summary>
		public string Usuario { get; set; }
		/// <summary>
		/// Dominio al que pertenece el usuario
		/// </summary>
		public string Dominio { get; set; }
	}
}
