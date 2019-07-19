using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utils.clasesSoporte;
using WebRazor.Models;

namespace WebRazor.Controllers
{
    public class GenericController : Controller
    {
        public bool validarPermiso(Usuario usuario, string pagina)
        {
            if (pagina == "~/")
                return true;

            if (usuario.id_usuario > 0)
            {
                if (esPaginaPermitida(usuario, pagina))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int currentUserId()
        {
            int id = 0;

            if (Session["usuario"] != null)
            {
                Usuario usuario = (Usuario)Session["usuario"];
                id = usuario.id_usuario;
            }

            return id;
        }

        public Usuario currentUser()
        {
            Usuario usuario = new Usuario();

            if (Session["usuario"] != null)//Session["Archivo.Login.CurrentUser"]
            {
                usuario = (Usuario)Session["usuario"];
            }

            return usuario;
        }        

        private bool esPaginaPermitida(Usuario usuario, string pagina)
        {
            var paginasPorPerfil = UsuarioGestor.cargarPermisosPaginaPorUsuario(usuario);

            pagina = pagina.Replace("~/", "");

            //foreach (var pagPerfil in paginasPorPerfil)
            //{
            //    string pagAux = pagPerfil.pagina;

            //    if (pagAux.ToLower().Trim() == pagina.ToLower().Trim())
            //    {
            //        return true;
            //    }
            //}

            return true;
        }

        public List<Permiso_Pagina> cargarPermisosPaginaPorUsuario(Usuario usuario)
        {
            List<Permiso_Pagina> permisos = new List<Permiso_Pagina>();

            try
            {
                permisos = UsuarioGestor.cargarPermisosPaginaPorUsuario(usuario);
            }
            catch (Exception ex)
            {
                //TODO: Loguear excepcion
            }

            return permisos;
        }

    }
}