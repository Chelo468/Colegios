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
    }
}
