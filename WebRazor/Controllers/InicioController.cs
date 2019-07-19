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
    }
}