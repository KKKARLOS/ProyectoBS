using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Resources.Templates
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] aEmail = null;
                if (Session["Email"] != null)
                {
                    aEmail = Session["Email"].ToString().Split('@');
                    lblUsuario.Text = aEmail[0];
                }
                else
                {
                    Response.Redirect("../../Views/Login/login.aspx");
                }
            }
        }
    }
}