using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Utils;
using WebRazor.Models;

namespace WebRazor.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            Session["PAGINA"] = 11;
            List<Rol> roles = RolGestor.getAll();
            return View(roles);
        }

        public ActionResult verPaginas(int idRol)
        {
            List<Pagina> paginasByRol = PaginaGestor.paginasGetByRol(idRol);
            List<Pagina> todasLasPaginas = PaginaGestor.getAll();
            return View("Modales/verPaginas", new Tuple<List<Pagina>, List<Pagina>, int>(todasLasPaginas, paginasByRol, idRol));
        }

        public JsonResult agregarPagina(int id_rol, int id_pagina)
        {
            bool error = true;
            string mensaje = "Ocurrió un error inesperado";
            try
            {
                if(PaginaGestor.agregarPaginaARol(id_rol, id_pagina, ref mensaje))
                {
                    error = false;
                    mensaje = "Página agregada correctamente";
                }
            }
            catch (Exception ex)
            {
                StringBuilder mensajeEx = new StringBuilder();

                while(ex != null)
                {
                    mensajeEx.AppendLine("Excepcion: " + ex.Message);
                    mensajeEx.AppendLine("StackTrace: " + ex.StackTrace);

                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarWebLog(mensajeEx.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Namespace, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

            }

            return Json(new Respuesta { Error = error, Mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult quitarPagina(int id_rol, int id_pagina)
        {
            bool error = true;
            string mensaje = "Ocurrió un error inesperado";
            try
            {
                if (PaginaGestor.quitarPaginaARol(id_rol, id_pagina, ref mensaje))
                {
                    error = false;
                    mensaje = "Página quitada correctamente";
                }
            }
            catch (Exception ex)
            {
                StringBuilder mensajeEx = new StringBuilder();

                while (ex != null)
                {
                    mensajeEx.AppendLine("Excepcion: " + ex.Message);
                    mensajeEx.AppendLine("StackTrace: " + ex.StackTrace);

                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarWebLog(mensajeEx.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Namespace, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

            }

            return Json(new Respuesta { Error = error, Mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

    }
}