using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace GestoresLayer
{
    public class ColegioGestor
    {
        public static Codigo_Colegio getByCodigo(string codigo_colegio)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                var colegioPorCodigo = contexto.Codigo_Colegio.Where(x => x.codigo == codigo_colegio).FirstOrDefault();

                return colegioPorCodigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<Codigo_Colegio> codigosGetAllByColegio(Colegio colegio)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                return contexto.Codigo_Colegio.Where(x => x.id_colegio == colegio.id_colegio).ToList();
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.Append(ex.Message);

                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarDataLog(mensaje.ToString(), "GestoresLayer", "ColegioGestor", "codigosGetAllByColegio");
                
            }

            return new List<Codigo_Colegio>();
        }
    }
}
