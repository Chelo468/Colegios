using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRazor.Controllers
{
    public class InicioController : GenericController
    {
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            if (Session["usuario"] == null)
            {
                return Redirect("/Error/HomeError?mensaje=Sesion%20Caducada");
            }
            //if (Session["CurrentUser"] != null)
            //    Session["CurrentUser"] = Session["CurrentUser"];
            Session["PAGINA"] = 37;
            return View();
        }
    }
}