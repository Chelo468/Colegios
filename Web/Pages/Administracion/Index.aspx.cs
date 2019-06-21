using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Pages.Administracion
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }       
     
        protected void btnPais_Click(object sender, EventArgs e)
        {
            

            lblTitulo.Text = "PAISES";
            divTitulo.Visible = true;

            cargarGrillaPais();

            btnCrear.Attributes.Add("data-target","#modalPais");
            btnCrear.Visible = true;
        }

        

        protected void btnProvincia_Click(object sender, EventArgs e)
        {
            

            lblTitulo.Text = "PROVINCIAS";
            divTitulo.Visible = true;

            cargarGrillaProvincia();

            cargarComboPaisParaABM(cboPaisEnProvincia);

            btnCrear.Attributes.Add("data-target", "#modalProvincia");
            btnCrear.Visible = true;
        }

        

        protected void btnLocalidad_Click(object sender, EventArgs e)
        {
            

            lblTitulo.Text = "LOCALIDADES";
            divTitulo.Visible = true;
            cargarGrillaLocalidad();

            cargarComboPaisParaABM(cboPaisEnLocalidad);

            if(!string.IsNullOrEmpty(cboPaisEnLocalidad.SelectedValue))
                cargarComboProvinciaParaABM(cboProvinciaEnLocalidad, int.Parse(cboPaisEnLocalidad.SelectedValue));

            btnCrear.Attributes.Add("data-target", "#modalLocalidad");
            btnCrear.Visible = true;
        }
        
        protected void btnBarrio_Click(object sender, EventArgs e)
        {
            

            lblTitulo.Text = "BARRIOS";
            divTitulo.Visible = true;

            cargarGrillaBarrios();

            cargarComboPaisParaABM(cboPaisEnBarrio);

            if (!string.IsNullOrEmpty(cboPaisEnBarrio.SelectedValue))
                cargarComboProvinciaParaABM(cboProvinciaEnBarrio, int.Parse(cboPaisEnBarrio.SelectedValue));

            if (!string.IsNullOrEmpty(cboProvinciaEnBarrio.SelectedValue))
                cargarComboLocalidadParaABM(cboLocalidadEnBarrio, int.Parse(cboProvinciaEnBarrio.SelectedValue));

            btnCrear.Attributes.Add("data-target", "#modalBarrio");
            btnCrear.Visible = true;
        }



        private void cargarGrillaPais()
        {
            List<Pais> paises = PaisGestor.getAll();
            if (paises.Count > 0)
            {
                grilla.DataSource = paises;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }
        }

        private void cargarGrillaProvincia()
        {
            List<Provincia> provincias = ProvinciaGestor.getAll();
            if (provincias.Count > 0)
            {
                grilla.DataSource = provincias;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }
        }

        private void cargarGrillaLocalidad()
        {

            List<Localidad> localidades = LocalidadGestor.getAll();

            if (localidades.Count > 0)
            {
                grilla.DataSource = localidades;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }
        }

        private void cargarGrillaBarrios()
        {
            List<Barrio> barrios = BarrioGestor.getAll();

            if (barrios.Count > 0)
            {
                grilla.DataSource = barrios;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }
        }

        private void cargarComboPaisParaABM(DropDownList comboPais)
        {
            List<Pais> paises = PaisGestor.getAll();

            comboPais.DataSource = "";
            comboPais.DataSource = paises;
            comboPais.DataValueField = "id";
            comboPais.DataTextField = "descripcion";
            comboPais.DataBind();
        }

        private void cargarComboProvinciaParaABM(DropDownList comboProvincia, int id_pais)
        {
            List<Provincia> provincias = ProvinciaGestor.getAllByIdPais(id_pais);

            comboProvincia.DataSource = "";
            comboProvincia.DataSource = provincias;
            comboProvincia.DataValueField = "id";
            comboProvincia.DataTextField = "descripcion";
            comboProvincia.DataBind();
        }

        private void cargarComboLocalidadParaABM(DropDownList comboLocalidad, int id_provincia)
        {
            List<Localidad> localidades = LocalidadGestor.getAllByIdProvincia(id_provincia);

            comboLocalidad.DataSource = "";
            comboLocalidad.DataSource = localidades;
            comboLocalidad.DataValueField = "id";
            comboLocalidad.DataTextField = "descripcion";
            comboLocalidad.DataBind();
        }

        protected void btnCrearPais_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPais.Text.Trim()))
            {
                Pais pais = PaisGestor.getByDescripcion(txtPais.Text);

                if(pais != null && pais.id > 0)
                {
                    //TODO: Mensaje ya existe el pais ingresado
                    return;
                }

                pais = new Pais();

                pais.descripcion = txtPais.Text;
                if(PaisGestor.crear(pais))
                {
                    //TODO: El pais se creo correctamente
                    cargarGrillaPais();
                    txtPais.Text = string.Empty;
                }
                else
                {
                    //TODO: Ocurrió un error al crear el país
                }

            }
            else
            {
                //TODO: Mensaje de falta de contenido
            }
        }

        protected void btnCrearProvincia_Click(object sender, EventArgs e)
        {
            string mensajeError = string.Empty;
            
            if(validarFormularioProvincia(ref mensajeError))
            {
                string nombreProvincia = txtProvincia.Text.Trim();
                Pais paisSeleccionado = PaisGestor.getById(int.Parse(cboPaisEnProvincia.SelectedValue));

                if(paisSeleccionado != null && paisSeleccionado.id > 0)
                {
                    Provincia provincia = ProvinciaGestor.getByDescripcionYPais(paisSeleccionado, nombreProvincia);

                    if(provincia != null && provincia.id > 0)
                    {
                        mostrarError("Ya existe la provincia ingresada para ese país.");
                    }
                    else
                    {
                        provincia = new Provincia();

                        provincia.descripcion = nombreProvincia;
                        provincia.id_pais = paisSeleccionado.id;

                        if(ProvinciaGestor.crear(provincia))
                        {
                            cargarGrillaProvincia();
                        }
                        else
                        {
                            mostrarError("Ocurrió un error al crear la provincia");
                        }
                    }

                }
                else
                {
                    mostrarError("El pais seleccionado no existe");
                }
                
            }
            else
            {
                mostrarError(mensajeError);
            }
        }

        private void mostrarError(string mensajeError)
        {
            StringBuilder script = new StringBuilder();

            script.AppendLine("bootbox.alert('" + mensajeError + "');");

            ClientScript.RegisterClientScriptBlock(this.GetType(), "errorScript", script.ToString(), true);
            //Page.RegisterClientScriptBlock("", script);
            //throw new NotImplementedException();
        }

        private bool validarFormularioProvincia(ref string mensajeError)
        {
            if(string.IsNullOrEmpty(txtProvincia.Text.Trim()))
            {
                mensajeError = "El nombre de la provincia no puede estar vacío";
                return false;
            }

            if(int.Parse(cboPaisEnProvincia.SelectedValue) <= 0)
            {
                mensajeError = "Seleccione un país válido";
                return false;
            }

            

            return true;
        }
    }
}