using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Utils
{
    public class CriptoUtilAES
    {
        private AesCryptoServiceProvider _aes = new AesCryptoServiceProvider();

        byte[] _key;
        byte[] _iv;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public CriptoUtilAES()
        {
            int keySize = 32;
            int ivSize = 16;
            Array.Resize(ref _key, keySize);
            Array.Resize(ref _iv, ivSize);
        }

        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="_clave"></param>
        public CriptoUtilAES(string _clave)
        {
            _key = Encoding.ASCII.GetBytes(_clave);
            _iv = Encoding.ASCII.GetBytes("ENCODE*123456");

            int keySize = 32;
            int ivSize = 16;
            Array.Resize(ref _key, keySize);
            Array.Resize(ref _iv, ivSize);
        }

        public string Encript(string inputText)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(inputText);
            byte[] encripted;

            //Deprecado
            //RijndaelManaged cripto = new RijndaelManaged();

            AesCryptoServiceProvider cripto = new AesCryptoServiceProvider();

            using (MemoryStream ms = new MemoryStream(inputBytes.Length))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(_key, _iv), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                    objCryptoStream.FlushFinalBlock();
                    objCryptoStream.Close();
                }

                encripted = ms.ToArray();
            }

            return Convert.ToBase64String(encripted);
        }

        /// <summary>
        /// Encriptamos usando el algoritmo AES.
        /// </summary>
        /// <param name="inputPdf">array de bytes con el pdf a encriptar para ser guardado.</param>
        /// <returns></returns>
        public byte[] EncriptarAES(byte[] inputPdf)
        {
            byte[] encripted;

            //Deprecado
            //RijndaelManaged cripto = new RijndaelManaged();

            AesCryptoServiceProvider cripto = new AesCryptoServiceProvider();

            using (MemoryStream ms = new MemoryStream(inputPdf.Length))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(_key, _iv), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputPdf, 0, inputPdf.Length);
                    objCryptoStream.FlushFinalBlock();
                    objCryptoStream.Close();
                }

                encripted = ms.ToArray();
            }

            return encripted;
        }

        /// <summary>
        /// Desencriptamos utilizado el algoritmo AES.
        /// </summary>
        /// <param name="inputpdf">arrays de bytes con el pdf a desencriptar.</param>
        /// <returns></returns>
        public byte[] DesencriptarAES(byte[] inputpdf)
        {
            //Deprecado
            //RijndaelManaged cripto = new RijndaelManaged();

            AesCryptoServiceProvider cripto = new AesCryptoServiceProvider();

            using (MemoryStream ms = new MemoryStream(inputpdf))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(_key, _iv), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputpdf, 0, inputpdf.Length);
                    objCryptoStream.FlushFinalBlock();

                    return ms.ToArray();
                }
            }
        }

        public string Desencript(string inputText)
        {
            byte[] inputBytes = Convert.FromBase64String(inputText);
            byte[] resultBytes = new byte[inputBytes.Length];
            string textoLimpio = String.Empty;

            //Deprecado
            //RijndaelManaged cripto = new RijndaelManaged();

            AesCryptoServiceProvider cripto = new AesCryptoServiceProvider();

            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(_key, _iv), CryptoStreamMode.Read))
                {

                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }

            return textoLimpio;
        }

        /// <summary>
        /// Encriptamos la clave aleatoria utilizando el certificado .cer.
        /// </summary>
        /// <param name="_mensaje"></param>
        /// <param name="_certificado"></param>
        /// <returns></returns>
        public string EncriptaAsimetrica(string _mensaje, X509Certificate2 _certificado)
        {
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(_mensaje);

            RSACryptoServiceProvider cert = (RSACryptoServiceProvider)_certificado.PublicKey.Key;
            return Convert.ToBase64String(cert.Encrypt(dataToEncrypt, true));
        }

        /// <summary>
        /// Desencriptamos la clave aleatoria utilizando el certificado .pfx.
        /// </summary>
        /// <param name="_mensaje"></param>
        /// <param name="_certificado"></param>
        /// <returns></returns>
        public string DesencriptaAsimetrica(string _mensaje, X509Certificate2 _certificado)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(_certificado.PrivateKey.ToXmlString(true));
            byte[] dataToDecrypt = Convert.FromBase64String(_mensaje);
            return Encoding.UTF8.GetString(rsa.Decrypt(dataToDecrypt, true));
        }
    }
}