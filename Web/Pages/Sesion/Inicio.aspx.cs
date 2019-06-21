using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Code;

namespace Web.Pages.Sesion
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario pUser = new Usuario();

            pUser.nombre_usuario = txtUsuario.Text;
            pUser.password = txtPassword.Text;
            pUser.password = MD5Utilities.GetSHA1(pUser.password);
            
            Usuario usuarioRegistrado = UsuarioGestor.validarUsuario(pUser);

            if(usuarioRegistrado != null && usuarioRegistrado.id_usuario > 0)
            {

            }
            else
            {
                lblRespuesta.Text = "Usuario y/o contraseña incorrectos";
                lblRespuesta.Style.Add("display", "block");
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Usuarios/registrar.aspx");
        }
    }
}