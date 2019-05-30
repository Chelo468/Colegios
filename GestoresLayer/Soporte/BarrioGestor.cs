using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoresLayer
{
    public class BarrioGestor
    {
        public static List<Barrio> getAll()
        {
            ColegiosEntities contexto = new ColegiosEntities();

            return contexto.Barrio.ToList();
        }

        public static List<Barrio> getAllByIdLocalidad(int id_localidad)
        {
            ColegiosEntities contexto = new ColegiosEntities();

            return contexto.Barrio.Where(x => x.id_localidad == id_localidad).ToList();
        }
    }
}
