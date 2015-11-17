using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Gromero.Seguridad.Login
{
    /// <summary>
    /// http://stackoverflow.com/questions/17113113/interop-encryption-decryption-between-java-net-with-aes-and-specifying-iv-and-ke
    /// </summary>
    internal static class Constantes
    {
        internal static byte[] key = new Byte[] { 112, 64, 36, 36, 87, 48, 114, 68, 67, 48, 82, 80, 48, 82, 52, 67, 49, 48, 78, 83, 51, 114, 118, 49, 99, 49, 48, 115, 71, 82 };//"p@$$W0rDC0RP0R4C10NS3rv1c10sGR";
    }
    public class SimpleInteroperableEncryption
    {
        private byte[] passWord = Constantes.key;// "p@$$W0rDC0RP0R4C10NS3rv1c10sGR";
        private string salt = "";
        public SimpleInteroperableEncryption()
        {
            salt = System.Configuration.ConfigurationManager.AppSettings["GR.Seguridad.Password"].ToString();
        }
        public SimpleInteroperableEncryption(string ClavePublica)
        {
            this.salt = ClavePublica;
        }
        //private static void Main(string[] args)
        //{
        //    string encrypted = Encrypt("Something to decrypt");
        //    Console.Out.WriteLine(encrypted);

        //    string decrypted = Decrypt(encrypted);
        //    Console.Out.WriteLine(decrypted);

        //    Console.Out.WriteLine("Press any key to continue");
        //    Console.ReadKey();
        //}

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







    //JAVA
    //    public class Main {

    //  public static void main(String[] args) throws Exception {
    //      String data = "Something to decrypt";

    //      String encrypt = Encrypt(data);
    //      System.out.println(encrypt);

    //      String decrypt = Decrypt(encrypt);
    //      System.out.println(decrypt);
    //  }

    //  private static String Encrypt(String raw) throws Exception {
    //      Cipher c = getCipher(Cipher.ENCRYPT_MODE);

    //      byte[] encryptedVal = c.doFinal(raw.getBytes("UTF-8"));
    //      return new BASE64Encoder().encode(encryptedVal);
    //  }

    //  private static Cipher getCipher(int mode) throws Exception {
    //      Cipher c = Cipher.getInstance("AES/CBC/PKCS5Padding", new SunJCE());

    //      //a random Init. Vector. just for testing
    //      byte[] iv = "e675f725e675f725".getBytes("UTF-8");

    //      c.init(mode, generateKey(), new IvParameterSpec(iv));
    //      return c;
    //  }

    //  private static String Decrypt(String encrypted) throws Exception {

    //      byte[] decodedValue = new BASE64Decoder().decodeBuffer(encrypted);

    //      Cipher c = getCipher(Cipher.DECRYPT_MODE);
    //      byte[] decValue = c.doFinal(decodedValue);

    //      return new String(decValue);
    //  }

    //  private static Key generateKey() throws Exception {
    //      SecretKeyFactory factory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1");
    //      char[] password = "Pass@word1".toCharArray();
    //      byte[] salt = "S@1tS@1t".getBytes("UTF-8");

    //      KeySpec spec = new PBEKeySpec(password, salt, 65536, 128);
    //      SecretKey tmp = factory.generateSecret(spec);
    //      byte[] encoded = tmp.getEncoded();
    //      return new SecretKeySpec(encoded, "AES");

    //  }
    //}
}
