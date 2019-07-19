using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Utils;
using WebRazor.Models;

namespace WebRazor.Controllers
{
    public class MenuController : GenericController
    {
        //
        // GET: /Menu/
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult MostrarMenu()
        {
            Menu menu = null;

            //IPaginaService PaginaService = new PaginaService();

            try
            {
                //if (Session["CurrentUser"] != null)
                //    Session["CurrentUser"] = Session["CurrentUser"];
                //else
                //{
                //    Session.Clear();
                //    return View("../Sesion/Home");                   
                //}
                if (Session["CurrentUser"] == null)
                {
                    return Redirect("/Error/HomeError?mensaje=Sesion%20Caducada");
                }

                //Response.Redirect("/");

                SimpleLog lg = new SimpleLog();
                UsuarioData usuario = Session["CurrentUser"] as UsuarioData;


                var lista = (dynamic)null;

                try
                {
                    lista = usuario.Usuario_sucursal.ToList()[usuario.SucursalActual].Perfil.Pagina.OrderBy(x => x.orden).ToList();
                }
                catch (Exception exLinq)
                {
                    StringBuilder str = new StringBuilder();

                    str.Append(exLinq.Message + ". ");

                    if (exLinq.InnerException != null)
                        str.Append("Inner Exception: " + exLinq.InnerException);

                    lg.GuardarWebLog("Error al Internar Cargar la Lista de Pagina Lista Error en LINQ." + str.ToString(), "Tesoreria", "PrincipalController", "Principal");
                    EnviarMail("ALERTA TESORERIA", "Error al Internar Cargar la Lista de Pagina Lista Error en LINQ. \n " + exLinq.Message);
                    try
                    {
                        lista = Service.retornarPaginasPorUsuario(usuario.id_usuario);

                    }
                    catch (Exception ex)
                    {

                        lg.GuardarWebLog("Error: " + ex.Message, "Tesoreria", "PrincipalController", "Principal");
                        lg.GuardarWebLog("StackTrace: " + ex.StackTrace, "Tesoreria", "PrincipalController", "Principal");

                        if (ex.InnerException != null)
                            lg.GuardarWebLog("Inner Exception: " + ex.InnerException.Message, "Tesoreria", "PrincipalController", "Principal");

                        Session.Clear();
                        Session.RemoveAll();

                    }

                }

                if (lista == null)
                {
                    lista = Service.retornarPaginasPorUsuario(usuario.id_usuario);
                    EnviarMail("ALERTA TESORERIA", "Error al Internar Cargar la Lista de Pagina Lista Error en LINQ");
                }



                menu = new Menu();

                foreach (PaginaData pagina in lista)
                {
                    if (pagina.menu == "Principal")
                    {
                        Menu submenu = new Menu();
                        foreach (PaginaData subpagina in lista)
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
                SimpleLog lg = new SimpleLog();
                if (ex.InnerException != null)
                {
                    if (ex.InnerException.InnerException != null)
                    {
                        lg.GuardarWebLog("Exepcion: " + ex.Message + " Inner: " + ex.InnerException.Message + " Inner.Inner: " + ex.InnerException.InnerException.Message, "Tesoreria.Controllers", "PrincipalController", "Principal");
                        lg.GuardarWebLog("StackTrace: " + ex.StackTrace, "Tesoreria", "PrincipalController", "Principal");
                    }
                    else
                    {
                        lg.GuardarWebLog("Error: " + ex.Message + " Inner: " + ex.InnerException.Message, "Tesoreria", "PrincipalController", "Principal");
                        lg.GuardarWebLog("StackTrace: " + ex.StackTrace, "Tesoreria", "PrincipalController", "Principal");
                    }
                }
                else
                {
                    lg.GuardarWebLog("Error: " + ex.Message, "Tesoreria", "PrincipalController", "Principal");
                    lg.GuardarWebLog("StackTrace: " + ex.StackTrace, "Tesoreria", "PrincipalController", "Principal");
                }
                if (Session["CurrentUser"] == null)
                {
                    bool mantenimiento = Convert.ToBoolean(ConfigurationManager.AppSettings["Mantenimiento"].ToString());
                    if (mantenimiento)
                        return View("../Sesion/Trabajando");
                    return View("../Sesion/Home");
                }
            }

            //page view default 301-Caja:
            if (Session["PAGINA"] == null)
                Session["PAGINA"] = 37;

            if (menu != null)
                return View(menu);
            else
            {
                Session.Clear();
                return View("../Sesion/Home");
            }

        }

        //Envio de Mail en caso de error
        private void EnviarMail(string asunto, string texto)
        {
            try
            {
                string emisor = ConfigurationManager.AppSettings["MailAlertTesoreria"];

                if (emisor != null || emisor.Trim() != "")
                {
                    string receptor = ConfigurationManager.AppSettings["MailReceptoresAlertTesoreria"];
                    //La cadena "servidor" es el servidor de correo que enviará tu mensaje
                    string servidor = "smtp.gmail.com";
                    // Crea el mensaje estableciendo quién lo manda y quién lo recibe
                    MailMessage mensaje = new MailMessage(
                       emisor,
                       receptor,
                       asunto,
                       texto);

                    //Envía el mensaje.
                    SmtpClient SmtpServer = new SmtpClient(servidor);
                    //Añade credenciales si el servidor lo requiere.
                    SmtpServer.Credentials = CredentialCache.DefaultNetworkCredentials;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(emisor, ConfigurationManager.AppSettings["PassAlertTesoreria"]);
                    SmtpServer.Port = 587;
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.EnableSsl = true;


                    SmtpServer.Send(mensaje);

                }
            }
            catch (Exception)
            {
                //NO MANDA EL EMAIL!              
            }

        }
    }
}