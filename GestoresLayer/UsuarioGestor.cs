using ModelLayer.Entities;
using NegocioLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Utils.clasesSoporte;

namespace GestoresLayer
{
    public class UsuarioGestor
    {
        public static Usuario validarUsuario(Usuario pUser)
        {
            try
            {
                Usuario usuario = new Usuario();
                var contexto = new ColegiosEntities();
             
                usuario = contexto.Usuario.Where(x => x.nombre_usuario == pUser.nombre_usuario && x.password == pUser.password).FirstOrDefault();
             
                return usuario;
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.Append(ex.Message);

                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarDataLog(mensaje.ToString(), "GestoresLayer", "UsuarioGestor", "validarUsuario");
                throw ex;
            }
        }

        public static bool crear(Usuario usuario, ref string mensaje_error)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                Usuario user = contexto.Usuario.Where(x => x.nombre_usuario == usuario.nombre_usuario).FirstOrDefault();

                if(user == null)
                {
                    contexto.Usuario.Add(usuario);

                    contexto.SaveChanges();

                    return true;
                }
                else
                {
                    mensaje_error = "El usuario ya existe.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.Append(ex.Message);

                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarDataLog(mensaje.ToString(), "GestoresLayer", "UsuarioGestor", "crear");
                throw ex;
            }
            
        }

        public static List<Permiso_Pagina> cargarPermisosPaginaPorUsuario(Usuario usuario)
        {
            List<Permiso_Pagina> permisos = new List<Permiso_Pagina>();

            try
            {
                //permisos = oDALUsuario.cargarPermisosPaginaPorUsuario(usuario);
            }
            catch (Exception ex)
            {
                //TODO: Loguear excepcion
            }

            return permisos;
        }
    }
}
