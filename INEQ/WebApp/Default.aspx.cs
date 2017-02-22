using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = BusinessLogicLayer.UserBLL.iniciarSesion(txtUsuario.Text, txtContrasenia.Text);

            if (string.IsNullOrEmpty(mensaje))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Message", "alert('Bienvenido');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Message", "alert('" + mensaje + "');", true);
            }
        }
    }
}