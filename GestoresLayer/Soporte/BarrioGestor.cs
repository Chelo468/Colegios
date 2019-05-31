using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace GestoresLayer
{
    public class BarrioGestor
    {
        public static List<Barrio> getAll()
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                return contexto.Barrio.ToList();
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "BarrioGestor", "getAll");
                throw ex;
            }
            
        }

        public static List<Barrio> getAllByIdLocalidad(int id_localidad)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                return contexto.Barrio.Where(x => x.id_localidad == id_localidad).ToList();
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "BarrioGestor", "getAllByIdLocalidad");
                throw ex;
            }
            
        }
    }
}
