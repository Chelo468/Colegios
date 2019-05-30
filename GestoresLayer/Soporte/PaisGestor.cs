using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoresLayer
{
    public class PaisGestor
    {
        public static List<Pais> getAll()
        {
            ColegiosEntities contexto = new ColegiosEntities();

            return contexto.Pais.ToList();
        }
    }
}
