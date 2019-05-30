using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoresLayer
{
    public class ProvinciaGestor
    {
        public static List<Provincia> getAll()
        {
            ColegiosEntities contexto = new ColegiosEntities();

            return contexto.Provincia.ToList();
        }

        public static List<Provincia> getAllByIdPais(int id_pais)
        {
            ColegiosEntities contexto = new ColegiosEntities();

            return contexto.Provincia.Where(x => x.id_pais == id_pais).ToList();
        }
    }
}
