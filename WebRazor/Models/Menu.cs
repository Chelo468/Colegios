using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRazor.Models
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }
    }
}