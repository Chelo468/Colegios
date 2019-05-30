using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            return Redirect("/Home/Login");
        }

        public ActionResult IniciarSesion(Usuario pUsuario)
        {
            try
            {
                
                Usuario usuario = UsuarioGestor.iniciarSesion(pUsuario);

                if (usuario != null && usuario.id_usuario > 0)
                {
                    return Redirect("/Home/Index");
                }
            }
            catch (Exception ex)
            {
                return Json(new Error {error = true, mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }

            return Json(new Error {error = true, mensaje = "Usuario y/o contraseña incorrectos." }, JsonRequestBehavior.AllowGet);
        }
	}
}