using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRazor.Models
{
    public class Menu
    {
        public long MenuID { get; set; }
        public string Descripcion { get; set; }
        public string URL { get; set; }
        public string Target { get; set; }
        public Menu MenuPadre { get; set; }
        public Nullable<long> MenuPadreID
        {
            get
            {
                if (MenuPadre != null) return MenuPadre.MenuID;
                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    if (MenuPadre == null) MenuPadre = new Menu();
                    MenuPadre.MenuID = value.Value;
                }
                else
                {
                    MenuPadre = null;
                }
            }
        }
        public int Orden { get; set; }
        public bool EsActivo { get; set; }
    }
}