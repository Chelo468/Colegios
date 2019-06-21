using GestoresLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Pages.Usuarios
{
    public partial class registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cargarComboPais();
                cargarComboProvincia(int.Parse(cboPais.SelectedValue));
                cargarComboLocalidad(int.Parse(cboProvincia.SelectedValue));
                cargarComboBarrio(int.Parse(cboLocalidad.SelectedValue));

            }
            catch (Exception ex)
            {
                hdfError.Value = ex.Message;
            }
        }

        private void cargarComboPais()
        {
            cboPais.DataSource = PaisGestor.getAll();
            cboPais.DataValueField = "id";
            cboPais.DataTextField = "descripcion";
            cboPais.DataBind();
        }

        private void cargarComboProvincia(int id_pais)
        {
            cboProvincia.DataSource = ProvinciaGestor.getAllByIdPais(id_pais);
            cboProvincia.DataValueField = "id";
            cboProvincia.DataTextField = "descripcion";
            cboProvincia.DataBind();
        }

        private void cargarComboLocalidad(int id_provincia)
        {
            cboLocalidad.DataSource = LocalidadGestor.getAllByIdProvincia(id_provincia);
            cboLocalidad.DataValueField = "id";
            cboLocalidad.DataTextField = "descripcion";
            cboLocalidad.DataBind();
        }

        private void cargarComboBarrio(int id_localidad)
        {
            cboBarrio.DataSource = BarrioGestor.getAllByIdLocalidad(id_localidad);
            cboBarrio.DataValueField = "id";
            cboBarrio.DataTextField = "descripcion";
            cboBarrio.DataBind();
        }

        

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(validarFormulario())
            {
                int a = 0;
                a = a + 1;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Sesion/Inicio.aspx");
        }

        private bool validarFormulario()
        {
            if(string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text.Trim()))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtCelular.Text.Trim()))
            {
                return false;
            }
            if(cboPais.SelectedValue == "-1")
            {
                return false;
            }
            if (cboProvincia.SelectedValue == "-1")
            {
                return false;
            }
            if (cboLocalidad.SelectedValue == "-1")
            {
                return false;
            }
            if (cboBarrio.SelectedValue == "-1")
            {
                return false;
            }

            return true;
        }
    }
}