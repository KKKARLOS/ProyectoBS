using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// EVENTO CLICK AL PULSAR EL BOTON DE LOGIN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Value)) stMensaje += "Email, ";
                if (string.IsNullOrEmpty(txtPassword.Value)) stMensaje += "Password, ";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception("Indica el " + stMensaje.TrimEnd(','));
                Proyecto.Logica.Models.clsUsuarios olsUsuarios = new Logica.Models.clsUsuarios();
                olsUsuarios.stLogin = txtEmail.Value;
                olsUsuarios.stPassword = txtPassword.Value;

                Proyecto.Web.Controllers.LoginController oLoginController = new Controllers.LoginController();
                bool bandera = oLoginController.getValidarUsuarioController(olsUsuarios);
                if (bandera) Response.Redirect("../Index/Index.aspx");
                else throw new Exception("Usuario o password incorrectos");
            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Error!', '" + ex.Message + "' , 'error');</script>");
            }
        }
    }
}