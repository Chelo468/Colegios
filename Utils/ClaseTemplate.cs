using System;
using System.IO;

namespace Utils
{
    public class ClaseTemplate
    {
        private string _nombreTemplate;
        private string _pathTemplate;

        public string NombreTemplate
        {
            get { return this._nombreTemplate; }
            set { this._nombreTemplate = value; }
        }

        public string PathTemplate
        {
            get { return this._pathTemplate; }
            set { this._pathTemplate = value; }
        }

        public ClaseTemplate(string nombreTemplate)
        {
            this.NombreTemplate = nombreTemplate;
            string pathTemp = AppDomain.CurrentDomain.BaseDirectory;
            switch (nombreTemplate)
            {
                case "GenerarClaves":
                    this.PathTemplate = pathTemp + "Templates\\TempGeneracionClaves.html";
                    break;
                case "RevocarCertificado":
                    this.PathTemplate = pathTemp + "Templates\\TempRevocacionCertificados.html";
                    break;

                case "FirmadoEmpleador":
                    this.PathTemplate = pathTemp + "Templates\\FirmadoEmpleador.html";
                    break;

                default:
                    this.PathTemplate = pathTemp + "Templates\\" + nombreTemplate + ".html";
                    break;
            }
        }

        public string obtenerPlantilla()
        {
            string contenido = "";
            if (File.Exists(this.PathTemplate))
            {
                StreamReader archivo = new StreamReader(this.PathTemplate, false);
                contenido = archivo.ReadToEnd();
                archivo.Close();

                Int32 indice = contenido.IndexOf("<body");
                string body = "";
                body = contenido.Substring(indice);
                body = body.Replace("</html>", "");
                body = body.Replace("<body>", "").Replace("</body>", "");
                contenido = body;
            }
            else
            {
                //No existe el template
            }

            return contenido;
        }
    }
}