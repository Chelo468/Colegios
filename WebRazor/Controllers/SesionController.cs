using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utils;
using WebRazor.Models;

namespace WebRazor.Controllers
{
    public class SesionController : GenericController
    {
        // GET: Sesion
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult iniciarSesion(Usuario usuario)
        {
            try
            {
                usuario.password = MD5Utilities.GetSHA1(usuario.password);

                Usuario usuarioLogin = UsuarioGestor.validarUsuario(usuario);

                if (usuarioLogin != null && usuarioLogin.id_usuario > 0)
                {
                    //Session["idUsuario"] = usuarioLogin.id_usuario;
                    //Session["nombreUsuario"] = usuarioLogin.nombre_usuario;
                    if(usuarioLogin.Rol_Usuario != null && usuarioLogin.Rol_Usuario.Count > 0)
                    {
                        Session["usuario"] = usuarioLogin;
                        return Json(new Respuesta { Error = false, Mensaje = "Sesión válida" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new Respuesta { Error = true, Mensaje = "Usted no tiene un perfil asignado." }, JsonRequestBehavior.AllowGet);
                    }
                }

                return Json(new Respuesta { Error = true, Mensaje = "Usuario y/o contraseña incorrectos." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new Respuesta { Error = true, Mensaje = "Ocurrió un error inesperado." }, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}