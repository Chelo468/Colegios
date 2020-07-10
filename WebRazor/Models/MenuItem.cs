using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRazor.Models
{
    public class MenuItem
    {
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Controlador { get; set; }
        public string Icono { get; set; }
        public Menu Items { get; set; }

        public MenuItem(string Nombre, string Accion, string Controlador, string Icono, Menu Items)
        {
            this.Nombre = Nombre;
            this.Accion = Accion;
            this.Controlador = Controlador;
            this.Icono = Icono;
            this.Items = Items;
        }
    }
}