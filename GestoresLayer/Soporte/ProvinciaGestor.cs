using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace GestoresLayer
{
    public class ProvinciaGestor
    {
        public static List<Provincia> getAll()
        {
            try
            {

                ColegiosEntities contexto = new ColegiosEntities();
                return contexto.Provincia.ToList();

            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "ProvinciaGestor", "getAll");
                throw ex;
            }
            
        }

        public static List<Provincia> getAllByIdPais(int id_pais)
        {
            try
            {

                ColegiosEntities contexto = new ColegiosEntities();
                return contexto.Provincia.Where(x => x.id_pais == id_pais).ToList();
                      
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "ProvinciaGestor", "getAllByIdPais");
                throw ex;
            }
        }

        public static Provincia getByDescripcionYPais(Pais pais, string descripcionProvincia)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();
                return contexto.Provincia.Where(x => x.id_pais == pais.id && x.descripcion == descripcionProvincia).FirstOrDefault();

            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "ProvinciaGestor", "getByDescripcionYPais");
                return new Provincia();
            }
        }

        public static bool crear(Provincia provincia)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                Pais pais = contexto.Pais.Where(x => x.id == provincia.id_pais).FirstOrDefault();

                provincia.Pais = pais;

                contexto.Provincia.Add(provincia);

                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "ProvinciaGestor", "crear");
                return false;
            }
        }
    }
}
