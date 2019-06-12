using GestoresLayer;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Pais> paises = PaisGestor.getAll();

            lblTitulo.Text = "PAISES";
            divTitulo.Visible = true;

            if(paises.Count > 0)
            {                
                grilla.DataSource = paises;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }
        }

        protected void btnProvincia_Click(object sender, EventArgs e)
        {
            List<Provincia> provincias = ProvinciaGestor.getAll();

            lblTitulo.Text = "PROVINCIAS";
            divTitulo.Visible = true;

            if(provincias.Count > 0)
            {                
                grilla.DataSource = provincias;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }
            
        }

        protected void btnLocalidad_Click(object sender, EventArgs e)
        {
            List<Localidad> localidades = LocalidadGestor.getAll();

            lblTitulo.Text = "LOCALIDADES";
            divTitulo.Visible = true;

            if(localidades.Count > 0)
            {                
                grilla.DataSource = localidades;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }        
        }

        protected void btnBarrio_Click(object sender, EventArgs e)
        {
            List<Barrio> barrios = BarrioGestor.getAll();

            lblTitulo.Text = "BARRIOS";
            divTitulo.Visible = true;

            if(barrios.Count > 0)
            {                
                grilla.DataSource = barrios;
                grilla.DataBind();
            }
            else
            {
                grilla.DataBind();
            }
        }

    }
}