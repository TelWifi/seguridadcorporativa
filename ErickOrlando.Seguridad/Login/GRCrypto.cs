using System;

namespace ErickOrlando.Seguridad.Login
{
	using System.Text;
	using System.Security.Cryptography;

	/// <summary>
	/// Encriptador de Contraseñas para COMEX Suite
	/// </summary>
	/// <remarks>Erick Orlando © 2012</remarks>
	public class GRCrypto
	{

		/// <summary>
		/// Encripta una Cadena con el Método Hash
		/// </summary>
		/// <param name="cadena">Cadena a encriptar</param>
		public static string Encriptar(string cadena)
		{

			HashAlgorithm hashValue = new SHA1CryptoServiceProvider();
			byte[] byteValue = Encoding.UTF8.GetBytes(cadena);

			byte[] byteHash = hashValue.ComputeHash(byteValue);

			hashValue.Clear();

			return Convert.ToBase64String(byteHash);

		}


	}
}
