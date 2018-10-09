using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.Web;
using System.Data;
namespace Proyecto.Web.Views.Tareas
{
    public partial class Tareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Controllers.TareasController oTareasController = new Controllers.TareasController();
                DataSet dsEstados = oTareasController.getConsultarEstadoTareasController();
                DataSet dsPrioridad =  oTareasController.getConsultarPrioridadController();

                ddlEstado.DataSource = dsEstados;
                ddlEstado.DataTextField = "estaDescripcion";
                ddlEstado.DataValueField = "estaCodigo";
                ddlEstado.DataBind();

                ddlPrioridad.DataSource = dsPrioridad;
                ddlPrioridad.DataTextField = "prioDescripcion";
                ddlPrioridad.DataValueField = "prioCodigo";
                ddlPrioridad.DataBind();
            }
        }
    }
}