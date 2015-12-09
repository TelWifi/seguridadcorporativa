
namespace Gromero.Seguridad.Negocio
{
	public class BaseDatos
	{

		//static bool cnx = false;
		/// <summary>
		/// Devuelve el nombre de la cadena de Conexion de Entity Framework
		/// </summary>
		public static string ConexionBD
		{
			get
			{
				return "SeguridadEntities";
			}
		}

	}

}
