using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Utils;
using WebRazor.Models;

namespace WebRazor.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Principal()
        {
            Menu menu = null;

            //IPaginaService PaginaService = new PaginaService();
            Usuario usuario = Session["usuario"] as Usuario;
            try
            {
                //if (Session["CurrentUser"] != null)
                //    Session["CurrentUser"] = Session["CurrentUser"];
                //else
                //{
                //    Session.Clear();
                //    return View("../Sesion/Home");                   
                //}
                if (Session["usuario"] == null)
                {
                    return Redirect("/Error/HomeError?mensaje=Sesion%20Caducada");
                }

                //Response.Redirect("/");

                SimpleLog lg = new SimpleLog();
                

                var lista = (dynamic)null;

                try
                {
                    lista = usuario.Rol_Usuario.FirstOrDefault().Rol.Pagina.OrderBy(x => x.orden).ToList();//.Usuario_sucursal.ToList()[usuario.SucursalActual].Perfil.Pagina.OrderBy(x => x.orden).ToList();
                }
                catch (Exception exLinq)
                {
                    StringBuilder str = new StringBuilder();

                    str.Append(exLinq.Message + ". ");

                    if (exLinq.InnerException != null)
                        str.Append("Inner Exception: " + exLinq.InnerException);

                    lg.GuardarWebLog("Error al Internar Cargar la Lista de Pagina Lista Error en LINQ." + str.ToString(), "Tesoreria", "PrincipalController", "Principal");

                }

                menu = new Menu();

                foreach (Pagina pagina in lista)
                {
                    if (pagina.menu == "Principal")
                    {
                        Menu submenu = new Menu();
                        foreach (Pagina subpagina in lista)
                        {
                            if (subpagina.menu == pagina.nombre)
                            {
                                MenuItem subitem = new MenuItem(subpagina.nombre.ToString().Trim(), subpagina.accion.ToString().Trim(), subpagina.controlador.ToString().Trim(), subpagina.icono.ToString().Trim(), null);
                                submenu.MenuItems.Add(subitem);
                            }
                        }
                        MenuItem item = new MenuItem(pagina.nombre.ToString().Trim(), pagina.accion.ToString().Trim(), pagina.controlador.ToString().Trim(), pagina.icono.ToString().Trim(), submenu);
                        menu.MenuItems.Add(item);
                    }
                }

            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();
                while (ex != null)
                {
                    mensaje.AppendLine("Excepcion: " + ex.Message);
                    mensaje.AppendLine("StackTrace: " + ex.StackTrace);

                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarWebLog(mensaje.ToString(), "WebRazor.Controllers", "MenuController", "MostrarMenu");

                if (Session["usuario"] == null)
                {
                    //bool mantenimiento = Convert.ToBoolean(ConfigurationManager.AppSettings["Mantenimiento"].ToString());
                    if (ConfiguracionWeb.Mantenimiento)
                        return View("../Sesion/Trabajando");
                    return View("../Sesion/Home");
                }
            }

            //page view default 301-Caja:
            if (Session["PAGINA"] == null)
                Session["PAGINA"] = 37;

            if (menu != null)
            {
                ViewBag.usuario = usuario;
                ViewBag.menu = menu;
                return View(new Tuple<Menu, Usuario>(menu, usuario));
            }                
            else
            {
                Session.Clear();
                return View("../Sesion/Home");
            }
        }
    }
}