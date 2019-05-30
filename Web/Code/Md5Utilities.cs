using System;
using System.Security.Cryptography;
using System.Text;

namespace Web.Code
{
    public class MD5Utilities
    {
        public static string GenerateMd5Hash(byte[] pFile)
        {
            return GenerateMd5Hash(Convert.ToBase64String(pFile));
        }

        /// <summary>
        /// Metodo que obtiene un hash de una cadena enviada por parametro
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string GenerateMd5Hash(string pString)
        {
            MD5 md5 = MD5.Create();

            var encoding = new ASCIIEncoding();
            var sb = new StringBuilder();

            byte[] stream = null;

            stream = md5.ComputeHash(encoding.GetBytes(pString));

            foreach (byte t in stream)
                sb.AppendFormat("{0:x2}", t);

            return sb.ToString();
        }

        /// <summary>
        /// Metodo que obtiene un hash de una cadena enviada por parametro
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string GetSHA1(string pString)
        {
            SHA1 sha1 = SHA1Managed.Create();

            ASCIIEncoding encoding = new ASCIIEncoding();

            StringBuilder sb = new StringBuilder();

            byte[] stream = null;
            stream = sha1.ComputeHash(encoding.GetBytes(pString));

            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }

        public static string GenerateSha1Hash(byte[] pFile)
        {
            return GetSHA1(Convert.ToBase64String(pFile));
        }
    }
}