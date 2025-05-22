using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEjemplo.Paginas
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad;
            if (int.TryParse(txtEdad.Text, out edad))
            {
                lblMensaje.Text = "Se Comvirtio la edad";
                if (edad < 0)
                {
                    lblMensaje.Text = "Edad No valida,Ingrese una Edad Positiva";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (edad < 18)
                    {
                        lblMensaje.Text = "No Cumple con la Edad requerida";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        lblMensaje.Text = "Ya Cumple con la Edad requerida";
                        lblMensaje.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                lblMensaje.Text = "Ingrese Una Edad Valida";
            }
            }
        }
    }
}