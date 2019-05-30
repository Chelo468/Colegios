using System;
using System.Configuration;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace Utils
{
    public class SimpleLog
    {
        private static SimpleLog _objSimpleLog;
        private static bool _blCreated;

        /// <summary>
        /// Constructor de la clase (Oculto)
        /// </summary>
        public SimpleLog()
        {

        }

        /// <summary>
        /// Implementacion Singleton del Logger
        /// </summary>
        /// <returns></returns>
        public static SimpleLog Instancia()
        {
            if (_blCreated == false)
            {
                _objSimpleLog = new SimpleLog();
                _blCreated = true;
                return _objSimpleLog;
            }
            return _objSimpleLog;
        }

        /// <summary>
        /// Registra una entrada en el log de Presentacion
        /// </summary>
        /// <returns></returns>
        public void GuardarWebLog(string message, string nameSpace, string clase, string metodo)
        {
            string filePath = ConfigurationManager.AppSettings["WebLogFilePath"];

            if (!string.IsNullOrEmpty(filePath))
            {
                //Preparar el mensaje
                var strBuider = new StringBuilder();
                strBuider.Append("FECHA: ");
                strBuider.Append(DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                loguear(strBuider.ToString(), filePath);
            }
        }
        

        /// <summary>
        /// Registra una entrada en el log de Acceso a Datos
        /// </summary>
        /// <returns></returns>
        public void GuardarDataLog(string message, string nameSpace, string clase, string metodo)
        {
            string filePath = ConfigurationManager.AppSettings["DataLogFilePath"];

            if (!string.IsNullOrEmpty(filePath))
            {
                //Preparar el mensaje
                var strBuider = new StringBuilder();
                strBuider.Append("FECHA: ");
                strBuider.Append(DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                loguear(strBuider.ToString(), filePath);
            }

        }

        /// <summary>
        /// Registra una entrada en el log Global
        /// </summary>
        /// <returns></returns>
        public void GuardarGlobalLog(string message, string nameSpace, string clase, string metodo)
        {
            string filePath = ConfigurationManager.AppSettings["GlobalLogFilePath"];

            if (!string.IsNullOrEmpty(filePath))
            {
                //Preparar el mensaje
                var strBuider = new StringBuilder();
                strBuider.Append("FECHA: ");
                strBuider.Append(DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                loguear(strBuider.ToString(), filePath);
            }
            
        }

        public void guardarParamsLog(string metodo, string parametros, int id_usuario)
        {
            string filePath = ConfigurationManager.AppSettings["ParamsLogFilePath"];

            if (!string.IsNullOrEmpty(filePath))
            {                
                //Preparar el mensaje
                var strBuider = new StringBuilder();
                strBuider.Append("FECHA: ");
                strBuider.Append(DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                strBuider.Append("PARAMETROS: " + parametros + ". " + Environment.NewLine);
                strBuider.Append("USUARIO: " + id_usuario + ". " + Environment.NewLine);
                strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                loguear(strBuider.ToString(), filePath);
            }
        }

        public void GuardarGestorLog(string message, string nameSpace, string clase, string metodo)
        {
            string filePath = ConfigurationManager.AppSettings["GestorLogFilePath"];

            if (!string.IsNullOrEmpty(filePath))
            {
                //Preparar el mensaje
                var strBuider = new StringBuilder();
                strBuider.Append("FECHA: ");
                strBuider.Append(DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                loguear(strBuider.ToString(), filePath);
            }
        }

        private void loguear(string mensaje, string filePath)
        {
            StreamWriter sw = null;
            try
            {                
                sw = new StreamWriter(filePath, true, Encoding.UTF8);
                sw.WriteLine(mensaje);
                sw.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                if (sw != null) sw.Dispose();
            }
        }

    }
}
