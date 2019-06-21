using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRazor.Controllers
{
    public class AdministracionController : Controller
    {
        // GET: Administracion
        public ActionResult Index()
        {
            return View();
        }

        #region paises
        public JsonResult paisesGetAll()
        {
            List<Pais> paises = PaisGestor.getAll();

            return Json(paises, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region provincias
        public JsonResult provinciasGetAllByIdPais(int id_pais)
        {
            List<Provincia> provincias = ProvinciaGestor.getAllByIdPais(id_pais);

            return Json(provincias, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region localidades
        public JsonResult localidadesGetAllByIdProvincia(int id_provincia)
        {
            List<Localidad> localidades = LocalidadGestor.getAllByIdProvincia(id_provincia);

            return Json(localidades, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region barrios
        public JsonResult barriosGetAllByIdLocalidad(int id_localidad)
        {
            List<Barrio> barrios = BarrioGestor.getAllByIdLocalidad(id_localidad);

            return Json(barrios, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}