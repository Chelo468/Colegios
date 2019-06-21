using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace GestoresLayer
{
    public class PaisGestor
    {
        public static List<Pais> getAll()
        {
            try
            {

                ColegiosEntities contexto = new ColegiosEntities();
                return contexto.Pais.ToList();
               
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "PaisGestor", "getAll");
                throw ex;
            }

        }

        public static Pais getByDescripcion(string descripcion)
        {
            try
            {

                ColegiosEntities contexto = new ColegiosEntities();
                return contexto.Pais.Where(x => x.descripcion.Trim() == descripcion.Trim()).FirstOrDefault();

            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "PaisGestor", "getByDescripcion");
                throw ex;
            }
        }

        public static bool crear(Pais pais)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                if (!string.IsNullOrEmpty(pais.descripcion))
                {
                    contexto.Pais.Add(pais);
                    contexto.SaveChanges();
                }
                else
                {
                    throw new Exception("La descripción del país no puede estar vacía.");
                }

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

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "PaisGestor", "crear");
                return false;
            }
        }

        public static Pais getById(int id_pais)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();
                
                return contexto.Pais.Where(x => x.id == id_pais).FirstOrDefault();
                
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "PaisGestor", "getById");
                return new Pais();
            }
        }
    }
}
