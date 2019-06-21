using ModelLayer.Entities;
using NegocioLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

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

        public static bool crear(Usuario usuario)
        {
            try
            {
                ColegiosEntities contexto = new ColegiosEntities();

                contexto.Usuario.Add(usuario);

                contexto.SaveChanges();

                return true;
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
    }
}
