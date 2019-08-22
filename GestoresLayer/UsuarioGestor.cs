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

        public static List<Usuario> getUsuariosByColegio(Colegio colegio)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                List<Colegio_Usuario> colegiosUsuarios = contexto.Colegio_Usuario.Where(x => x.id_colegio == colegio.id_colegio).ToList();

                List<Usuario> usuarios = new List<Usuario>();

                foreach (var colegioUsuario in colegiosUsuarios)
                {
                    usuarios.Add(colegioUsuario.Usuario);
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while (ex != null)
                {
                    mensaje.Append(ex.Message);

                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarDataLog(mensaje.ToString(), "GestoresLayer", "UsuarioGestor", "getUsuariosByColegio");
                throw;
            }
        }

        public static bool crear(Usuario usuario, Codigo_Colegio codigoColegioObj, ref string mensaje_error)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                Usuario user = contexto.Usuario.Where(x => x.nombre_usuario == usuario.nombre_usuario).FirstOrDefault();

                if(user == null)
                {
                    contexto.Usuario.Add(usuario);
                    
                    Rol_Usuario rolUsuario = new Rol_Usuario();

                    rolUsuario.Rol = codigoColegioObj.Rol;
                    rolUsuario.Usuario = usuario;
                    rolUsuario.fecha_alta = DateTime.Now;

                    usuario.Colegio.Add(codigoColegioObj.Colegio);

                    contexto.Rol_Usuario.Add(rolUsuario);

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
