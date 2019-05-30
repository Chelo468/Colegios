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
        public static Usuario iniciarSesion(Usuario pUser)
        {
            try
            {
                if (pUser != null && !string.IsNullOrEmpty(pUser.nombre_usuario) && !string.IsNullOrEmpty(pUser.password))
                {
                    return UsuarioService.getByUserPassword(pUser.nombre_usuario, pUser.password);
                }
                else
                {
                    return new Usuario();
                }
            }
            catch (Exception ex)
            {
                StringBuilder mensaje = new StringBuilder();

                while(ex != null)
                {
                    mensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                SimpleLog.Instancia().GuardarGestorLog(mensaje.ToString(),"GestoresLayer", "UsuarioGestor", "iniciarSesion");
                throw ex;
            }
        }
    }
}
