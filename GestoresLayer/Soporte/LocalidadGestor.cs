using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace GestoresLayer
{
    public class LocalidadGestor
    {
        public static List<Localidad> getAll()
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                return contexto.Localidad.ToList();
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "LocalidadGestor", "getAll");
                throw ex;
            }
            
        }

        public static List<Localidad> getAllByIdProvincia(int id_provincia)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                return contexto.Localidad.Where(x => x.id_provincia == id_provincia).ToList();
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "LocalidadGestor", "getAllByIdProvincia");
                throw ex;
            }
            
        }

    }
}
