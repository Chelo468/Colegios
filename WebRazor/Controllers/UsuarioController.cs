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
    public class UsuarioController : GenericController
    {
        // GET: Usuari
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public JsonResult registrarUsuario(Usuario usuario, string codigo_colegio)
        {
            string mensaje = string.Empty;
            if(validarDatosUsuario(ref mensaje, usuario, codigo_colegio))
            {
                Codigo_Colegio codigoColegioObj = new Codigo_Colegio();
                if(!validarCodigoColegio(codigo_colegio, ref codigoColegioObj))
                {
                    return Json(new Respuesta { Error = true, Mensaje = "El código del colegio no es válido." }, JsonRequestBehavior.AllowGet);
                }

                usuario.password = MD5Utilities.GetSHA1(usuario.password);
                string mensaje_error = string.Empty;
                if(UsuarioGestor.crear(usuario, codigoColegioObj, ref mensaje_error)) 
                {
                    return Json(new Respuesta { Error = false, Mensaje = "Usuario creado con éxito" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    if(!string.IsNullOrEmpty(mensaje_error))
                    {
                        return Json(new Respuesta { Error = true, Mensaje = mensaje_error }, JsonRequestBehavior.AllowGet);
                    }
                    return Json(new Respuesta { Error = true, Mensaje = "Ocurrió un error al registrar el usuario" }, JsonRequestBehavior.AllowGet);
                }
            }

            return Json(new Respuesta { Error = true, Mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        private bool validarCodigoColegio(string codigo_colegio, ref Codigo_Colegio codigoColegioObj)
        {
            codigoColegioObj = ColegioGestor.getByCodigo(codigo_colegio);

            return codigoColegioObj != null;
        }

        private bool validarDatosUsuario(ref string mensaje, Usuario pUser, string codigo_colegio)
        {
            if (string.IsNullOrEmpty(pUser.nombre_usuario))
            {
                mensaje = "El usuario no puede estar vacío";
                return false;
            }

            if (string.IsNullOrEmpty(pUser.password))
            {
                mensaje = "El password no puede estar vacío";
                return false;
            }

            if (string.IsNullOrEmpty(pUser.nombre))
            {
                mensaje = "El nombre no puede estar vacío";
                return false;
            }

            if (string.IsNullOrEmpty(pUser.apellido))
            {
                mensaje = "El apellido no puede estar vacío";
                return false;
            }

            if (string.IsNullOrEmpty(pUser.email))
            {
                mensaje = "El email no puede estar vacío";
                return false;
            }

            if (string.IsNullOrEmpty(pUser.celular))
            {
                mensaje = "El celular no puede estar vacío";
                return false;
            }

            if(string.IsNullOrEmpty(codigo_colegio))
            {
                mensaje = "El código del colegio no puede estar vacío";
                return false;
            }

            return true;
        }
    }
}