using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace GestoresLayer
{
    public class RolGestor
    {
        public static List<Rol> getAll()
        {
            try
            {

                ColegiosEntities contexto = new ColegiosEntities();
                return contexto.Rol.ToList();

            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(), "GestoresLayer", "RolGestor", "getAll");
                throw ex;
            }
        }
    }
}
