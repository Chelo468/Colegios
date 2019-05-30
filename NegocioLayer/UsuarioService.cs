using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace NegocioLayer
{
    public static class UsuarioService
    {
        public static Usuario getByUserPassword(string nombre_usuario, string password)
        {
            try
            {
                Usuario usuario = new Usuario();
                using (var contexto = new ColegiosEntities())
                {
                    usuario = contexto.Usuario.Where(x => x.nombre_usuario == nombre_usuario && x.password == password).FirstOrDefault();
                }

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

                SimpleLog.Instancia().GuardarDataLog(mensaje.ToString(), "NegocioLayer", "UsuarioService", "getByUserPassword");
                throw ex;
            }
            
        }
    }
}
