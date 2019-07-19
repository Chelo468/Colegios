using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Utils
{
    public class EmailUtilities
    {
        /// <summary>
        /// Envía mail con password reseteada al usuario especificado.
        /// </summary>
        /// <param name="pToEmail">Email del usuario cuya contraseña ha cambiado.</param>
        /// <param name="pEmployee"></param>
        /// <param name="pUserPassword">Nueva contraseña del usuario.</param>
        /// <param name="pMessage"></param>
        public static void SendNewUserEmail(string pToEmail, string pUserName, string pUserPassword, ref string pMessage)
        {
            //TODO Ver posibilidad de incluir el HTML del mensaje en un template que pueda ser obtenido como un recurso
            const string pSubject = "Bandeja de Documentos | Nueva cuenta de usuario";//Recibo Digital

            string urlBDDO = ConfigurationManager.AppSettings["UrlWebService"];
            urlBDDO = urlBDDO.Substring(0, urlBDDO.Length - 1);

            const string pBodyHtml =
                @"<html>
                        <head></head>
                        <body>
                            <p><i>Se ha realizado con éxito la generación de claves para el acceso a la Bandeja de Documentos</i><p>
                            <p><i><b>Link de Acceso:</b> {2}</i><p>
                            <p><i><b>Usuario:</b> {0}</i></p>
                            <p><i><b>Contraseña:</b> {1}</i></p>
                        </body>
                  </html>";//para el acceso al recibo digital

            SendEmail(pToEmail, pSubject, string.Format(pBodyHtml, pUserName, pUserPassword, urlBDDO), ref pMessage);
        }

        public static void SendResetPasswordEmail(string pToEmail, string pUserName, string pUserPassword, ref string pMessage)
        {
            //TODO Ver posibilidad de incluir el HTML del mensaje en un template que pueda ser obtenido como un recurso
            const string pSubject = "Bandeja de Documentos | Nueva cuenta de usuario";//Recibo Digital | 

            string urlBDDO = ConfigurationManager.AppSettings["UrlWebService"];
            urlBDDO = urlBDDO.Substring(0, urlBDDO.Length - 1);

            const string pBodyHtml =
                @"<html>
                        <head></head>
                        <body>
                            <p><i>Estimado</i><p>
                            <p><i>Para visualizar y firmar su recibo debe primero generar sus contraseñas de acceso.</i><p>
                            <p><i>Para ello se generó un código de seguridad que le permite ingresar al sistema. Deberá acceder al siguiente link: <a> {2}</a> con estos datos:</i></p>
                            <p><i><b>Usuario:</b> {0}</i></p>
                            <p><i><b>Código de seguridad:</b> {1}</i></p>
                            <p><i>Gracias.</i></p>
                        </body>
                  </html>";

            SendEmail(pToEmail, pSubject, string.Format(pBodyHtml, pUserName, pUserPassword, urlBDDO), ref pMessage);
        }

        ///// <summary>
        ///// Envio de correo de generación de claves al empleado.
        ///// </summary>
        ///// <param name="pToEmail"></param>
        ///// <param name="pUserName"></param>
        ///// <param name="pUserPassword"></param>
        ///// <param name="pMessage"></param>
        //public static void enviarNotificacionGeneracionClaves(Employee emp, string tradename, string cuit, ref string pMessage)
        //{
        //    const string pSubject = "Bandeja de Documentos | Generar Claves";//Recibo Digital

        //    //Seteamos la plantilla que queremos utilizar.
        //    ClaseTemplate _template = new ClaseTemplate("GenerarClaves");

        //    CertManager _cm = new CertManager();
        //    string pathCert = AppDomain.CurrentDomain.BaseDirectory;
        //    X509Certificate2 _certificado = _cm.getCertificado(pathCert + "Cert\\certificadoBDDO.pfx", "1234");
        //    CriptoUtilAES _aes = new CriptoUtilAES();

        //    string contenido = string.Empty;
        //    contenido = _template.obtenerPlantilla();
        //    contenido = contenido.Replace("#urlWebService", ConfigurationManager.AppSettings["urlWebService"]);
        //    //reemplazo tag datos employee.
        //    contenido = contenido.Replace("#nombre", emp.FirstName.Trim());
        //    contenido = contenido.Replace("#apellido", emp.LastName.Trim());
        //    contenido = contenido.Replace("#cuil", emp.Cuil.Trim());
        //    contenido = contenido.Replace("#email", _aes.DesencriptaAsimetrica(emp.Email, _certificado));
        //    //reemplazo tags datos company.
        //    contenido = contenido.Replace("#razon", tradename);
        //    contenido = contenido.Replace("#cuit", cuit);

        //    SendEmail(_aes.DesencriptaAsimetrica(emp.Email, _certificado), pSubject, contenido, ref pMessage);
        //}

        public static void enviarNotificacionKeystoreEliminado(string cuil, string empleado, string emailDestino, ref string pMessage)
        {
            const string pSubject = "Bandeja de Documentos | Revocacion de Certificado";//Recibo Digital

            //Seteamos la plantilla que queremos utilizar.
            ClaseTemplate _template = new ClaseTemplate("RevocarCertificado");

            string contenido = string.Empty;
            contenido = _template.obtenerPlantilla();
            contenido = contenido.Replace("#empleado", empleado);
            contenido = contenido.Replace("#cuil", cuil);

            SendEmail(emailDestino, pSubject, contenido, ref pMessage);
        }

        //public static void enviarNotificacionFirmadoEmpleador(Employee employee, Company company, int idInbox, ref string pMessage)
        //{
        //    const string pSubject = "Notificación de Recibo en Bandeja";

        //    ClaseTemplate _template = new ClaseTemplate("FirmadoEmpleador" + company.Cuit);

        //    CertManager _cm = new CertManager();
        //    X509Certificate2 _certificado = _cm.getCertificado(System.Web.HttpContext.Current.Server.MapPath("~/Cert/certificadoBDDO.pfx"), "1234");
        //    CriptoUtilAES _aes = new CriptoUtilAES();

        //    string templateMail = "Su recibo ya fue firmado por el Empleador. Inicie sesión en su  Bandeja de Documentos para acceder al mismo. Gracias!";

        //    string templateMailAux = _template.obtenerPlantilla();

        //    if (!string.IsNullOrEmpty(templateMailAux.Trim()))
        //        templateMail = templateMailAux;

        //    string emailEmployee = _aes.DesencriptaAsimetrica(employee.Email, _certificado);
        //    string token = emailEmployee + " - " + idInbox;

        //    SendEmailAsync(emailEmployee, pSubject, templateMail, token, ref pMessage);
        //}

        private static void SendEmail(string pToEmail, string pSubject, string pBody, ref string pMessage)
        {
            try
            {
                string pFromEmail = ConfigurationManager.AppSettings["EmailAccount"];
                string pFromPassword = ConfigurationManager.AppSettings["EmailPassword"];
                string pPort = ConfigurationManager.AppSettings["EmailPort"];
                int pEnable = int.Parse(ConfigurationManager.AppSettings["EnableSSL"].ToString());
                string pUserEmail = ConfigurationManager.AppSettings["EmailUser"];
                bool b = false;

                if (pEnable == 1)
                {
                    b = true;
                }
                //TODO: estos seteos son importantes y obligatorios, sino estan se debe enviar un error
                int pEmailPort = (!string.IsNullOrEmpty(pPort)) ? Convert.ToInt32(pPort) : 587;

                var message = new MailMessage(pFromEmail, pToEmail, pSubject, pBody);
                message.IsBodyHtml = true;

                var smtp = new SmtpClient
                {
                    Host = ConfigurationManager.AppSettings["EmailSmtpServer"],
                    Port = pEmailPort,
                    EnableSsl = b,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(pUserEmail, pFromPassword)
                };

                //TODO: PAT, solucion1 de esta forma funciona
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                    System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                    X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

                //TODO: PAT, solucion2 de esta forma funciona.
                //ServicePointManager.ServerCertificateValidationCallback =
                //    new RemoteCertificateValidationCallback(ValidateServerCertificate);

                smtp.Send(message);

            }
            catch (SmtpException e)
            {
                //pMessage = UserMessages.SMTPError + "|" + e.Message;
            }
            catch (Exception e)
            {
                //TODO: ERROR AQUI, si ocurre algo el mensaje no se muestra en la interface
                //pMessage = UserMessages.EmailError + "|" + e.Message;
            }
        }

        private static void SendEmailAsync(string pToEmail, string pSubject, string pBody, string tokenMail, ref string pMessage)
        {
            try
            {
                string pFromEmail = ConfigurationManager.AppSettings["EmailAccount"];
                string pFromPassword = ConfigurationManager.AppSettings["EmailPassword"];
                string pPort = ConfigurationManager.AppSettings["EmailPort"];
                int pEnable = int.Parse(ConfigurationManager.AppSettings["EnableSSL"].ToString());
                string pUserEmail = ConfigurationManager.AppSettings["EmailUser"];
                bool b = false;

                if (pEnable == 1)
                {
                    b = true;
                }
                //TODO: estos seteos son importantes y obligatorios, sino estan se debe enviar un error
                int pEmailPort = (!string.IsNullOrEmpty(pPort)) ? Convert.ToInt32(pPort) : 587;

                var message = new MailMessage(pFromEmail, pToEmail, pSubject, pBody);
                message.IsBodyHtml = true;

                var smtp = new SmtpClient
                {
                    Host = ConfigurationManager.AppSettings["EmailSmtpServer"],
                    Port = pEmailPort,
                    EnableSsl = b,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(pUserEmail, pFromPassword)
                };

                //TODO: PAT, solucion1 de esta forma funciona
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                    System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                    X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

                //TODO: PAT, solucion2 de esta forma funciona.
                //ServicePointManager.ServerCertificateValidationCallback =
                //    new RemoteCertificateValidationCallback(ValidateServerCertificate);


                smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userState = "send_To" + pToEmail;

                Thread email = new Thread(delegate ()
                {
                    smtp.SendAsync(message, userState);
                });
                email.IsBackground = true;
                email.Start();

            }
            catch (SmtpException e)
            {
                //pMessage = UserMessages.SMTPError + "|" + e.Message;
            }
            catch (Exception e)
            {
                //TODO: ERROR AQUI, si ocurre algo el mensaje no se muestra en la interface
                //pMessage = UserMessages.EmailError + "|" + e.Message;
            }
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            //Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                SimpleLog.Instancia().GuardarSMTPLog("Email cancelado: ", token);
                //Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                SimpleLog.Instancia().GuardarSMTPLog("Error al enviar el email: " + e.Error.ToString(), token);
                //Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                //Console.WriteLine("Message sent.");
            }

        }

        public static bool ValidateServerCertificate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
            X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;
            else
            {
                //if (System.Windows.Forms.MessageBox.Show("The server certificate is not valid.\nAccept?", 
                //    "Certificate Validation", System.Windows.Forms.MessageBoxButtons.YesNo, 
                //    System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                //    return true;
                //else
                return true;
            }
        }
    }
}
