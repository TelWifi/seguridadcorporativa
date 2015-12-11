using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ErickOrlando.Seguridad.Login
{
    /// <summary>
    /// http://stackoverflow.com/questions/17113113/interop-encryption-decryption-between-java-net-with-aes-and-specifying-iv-and-ke
    /// </summary>
    internal static class Constantes
    {
        internal static byte[] key = new Byte[] { 112, 64, 36, 36, 87, 48, 114, 68, 67, 48, 82, 80, 48, 82, 52, 67, 49, 48, 78, 83, 51, 114, 118, 49, 99, 49, 48, 115, 71, 82 };//"p@$$W0rDC0RP0R4C10NS3rv1c10sGR";
    }
    /// <summary>
    /// Clase de encriptacion
    /// </summary>
    public class SimpleInteroperableEncryption
    {
        private byte[] passWord = Constantes.key;
        private string salt = "";
        /// <summary>
        /// Inicia una clase SimpleInteroperableEncryption
        /// </summary>
        public SimpleInteroperableEncryption()
        {
            salt = System.Configuration.ConfigurationManager.AppSettings["SeguridadSalt"].ToString();
        }
        /// <summary>
        /// Inicia una clase SimpleInteroperableEncryption
        /// </summary>
        /// <param name="ClavePublica">Clave publica que se usará para encriptar</param>
        public SimpleInteroperableEncryption(string ClavePublica)
        {
            this.salt = ClavePublica;
        }

        /// <summary>
        /// Encriptar
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        public string Encrypt(string raw)
        {
            if (String.IsNullOrEmpty(this.salt))
                throw new Exception("SALT debe tener un valor");
            using (var csp = new AesCryptoServiceProvider())
            {
                ICryptoTransform e = GetCryptoTransform(csp, true);
                byte[] inputBuffer = Encoding.UTF8.GetBytes(raw);
                byte[] output = e.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

                string encrypted = Convert.ToBase64String(output);

                return encrypted;
            }
        }
        /// <summary>
        /// Desencriptar
        /// </summary>
        /// <param name="encrypted"></param>
        /// <returns></returns>
        public string Decrypt(string encrypted)
        {
            if (String.IsNullOrEmpty(this.salt))
                throw new Exception("SALT debe tener un valor");
            using (var csp = new AesCryptoServiceProvider())
            {
                var d = GetCryptoTransform(csp, false);
                byte[] output = Convert.FromBase64String(encrypted);
                byte[] decryptedOutput = d.TransformFinalBlock(output, 0, output.Length);

                string decypted = Encoding.UTF8.GetString(decryptedOutput);
                return decypted;
            }
        }

        private ICryptoTransform GetCryptoTransform(AesCryptoServiceProvider csp, bool encrypting)
        {
            csp.Mode = CipherMode.CBC;
            csp.Padding = PaddingMode.PKCS7;


            //a random Init. Vector. just for testing
            String iv = "e675f725e675f725";
            int iteraciones = 65536;
            byte[] pw = passWord;//Encoding.UTF8.GetBytes(passWord);
            var spec = new Rfc2898DeriveBytes(pw, Encoding.UTF8.GetBytes(salt), iteraciones);
            byte[] key = spec.GetBytes(16);


            csp.IV = Encoding.UTF8.GetBytes(iv);
            csp.Key = key;
            if (encrypting)
            {
                return csp.CreateEncryptor();
            }
            return csp.CreateDecryptor();
        }
    }

}
