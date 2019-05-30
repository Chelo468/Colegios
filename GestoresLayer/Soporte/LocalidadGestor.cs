using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoresLayer
{
    public class LocalidadGestor
    {
        public static List<Localidad> getAll()
        {
            ColegiosEntities contexto = new ColegiosEntities();

            return contexto.Localidad.ToList();
        }

        public static List<Localidad> getAllByIdProvincia(int id_provincia)
        {
            ColegiosEntities contexto = new ColegiosEntities();

            return contexto.Localidad.Where(x => x.id_provincia == id_provincia).ToList();
        }

    }
}
