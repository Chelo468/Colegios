using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ConfiguracionWeb
    {
        public static bool Mantenimiento = Convert.ToBoolean(ConfigurationManager.AppSettings["Mantenimiento"].ToString());

        //EMAIL
        public static string EmailAccount = ConfigurationManager.AppSettings["EmailAccount"];
        public static string EmailPassword = ConfigurationManager.AppSettings["EmailPassword"];
        public static string EmailPort = ConfigurationManager.AppSettings["EmailPort"];
        public static string EnableSSL = ConfigurationManager.AppSettings["EnableSSL"];
        public static string EmailUser = ConfigurationManager.AppSettings["EmailUser"];
        public static string EmailSmtpServer = ConfigurationManager.AppSettings["EmailSmtpServer"];
        

        //LOG
        public static string WebLogFilePath = ConfigurationManager.AppSettings["WebLogFilePath"];
        public static string DataLogFilePath = ConfigurationManager.AppSettings["DataLogFilePath"];
        public static string GlobalLogFilePath = ConfigurationManager.AppSettings["GlobalLogFilePath"];
        public static string ParamsLogFilePath = ConfigurationManager.AppSettings["ParamsLogFilePath"];
        public static string GestorLogFilePath = ConfigurationManager.AppSettings["GestorLogFilePath"];
    }
}
