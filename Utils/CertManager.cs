using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Utils
{
    public class CertManager
    {
        /// <summary>
        /// Funcion que retorna la clave publica del certificado indicado por path
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        public string getPublicKey(string _path)
        {
            X509Certificate2 certificate = new X509Certificate2(_path);
            return certificate.GetPublicKeyString();
        }

        /// <summary>
        /// Funcion que retorna un certificado
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        public X509Certificate2 getCertificado(string _path)
        {
            X509Certificate2 certificate = new X509Certificate2(_path);
            return certificate;
        }

        /// <summary>
        /// Funcion que retorna un certificado
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        public X509Certificate2 getCertificado(string _path, string _clave)
        {
            SecureString ss = new System.Security.SecureString();
            foreach (var keyChar in _clave.ToCharArray())
            {
                ss.AppendChar(keyChar);
            }

            X509Certificate2 cert = new X509Certificate2(_path, ss, X509KeyStorageFlags.Exportable);
            return cert;
        }
    }
}