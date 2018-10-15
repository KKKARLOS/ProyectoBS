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
                getTareas();
            }
        }
        void getTareas()
        {
            try
            {
                Proyecto.Web.Controllers.TareasController oTareasController = new Controllers.TareasController();
                List<Proyecto.Logica.Models.clsTareas> lsTareas = oTareasController.getAllTareas();
                if (lsTareas.Count > 0)
                    gvwDatos.DataSource = lsTareas;
                else
                    gvwDatos.DataSource = null;

                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Error!', '" + ex.Message + "' , 'error');</script>"); ;
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtCodigo.Text)) stMensaje = "Ingrese el código";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje);

                Proyecto.Logica.Models.clsTareas oClsTareas = new Proyecto.Logica.Models.clsTareas
                {
                    inCodigo = int.Parse(txtCodigo.Text),
                    stTitular = txtTitular.Text,
                    stAsunto = txtAsunto.Text,
                    stFechaVencimiento = txtFechaVencimiento.Text,
                    stContacto = txtContacto.Text,
                    stCuenta = txtCuenta.Text,
                    oClsEstado = new Logica.Models.clsEstado { inEstaCodigo = int.Parse(ddlEstado.SelectedValue) },
                    oClsPrioridad = new Logica.Models.clsPrioridad { inCodigo = int.Parse(ddlPrioridad.SelectedValue) },
                    stEnviarMensaje = chkEnviarMensaje.Checked ? "S" : "N",
                    stRepetir =  chkRepetir.Checked ? "S" : "N",
                    stDescripcion = txtDescripcion.Text
                };

                Proyecto.Web.Controllers.TareasController oTareasController = new Controllers.TareasController();

                if (string.IsNullOrEmpty(lblOpcion.Text))  
                    ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Grabación correcta', '" + oTareasController.addTareas(oClsTareas) + "' , 'info');</script>");
                else
                    ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Grabación correcta', '" + oTareasController.updateTareas(oClsTareas) + "' , 'info');</script>");

                getTareas();
                limpiarRegistro();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>alert('Error!  '" + ex.Message + "');</script>");
                //ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Error!', '"+ex.Message+"' , 'error');</script>"); 
            }
        }
        void limpiarRegistro()
        {
            lblOpcion.Text = txtCodigo.Text = txtTitular.Text = txtAsunto.Text = txtFechaVencimiento.Text = txtContacto.Text = txtCuenta.Text = txtDescripcion.Text = String.Empty;
            chkEnviarMensaje.Checked = chkRepetir.Checked = false;
            //ddlEstado.SelectedValue = ddlPrioridad.SelectedValue = "0";
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
        }

        protected void gvwDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int intIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName.Equals("Editar"))
                {
                    lblOpcion.Text = "M";
                    txtCodigo.Text = ((Label)gvwDatos.Rows[intIndice].FindControl("lbCodigo")).Text;
                    txtTitular.Text = gvwDatos.Rows[intIndice].Cells[1].Text;
                    txtAsunto.Text = gvwDatos.Rows[intIndice].Cells[2].Text;
                    txtFechaVencimiento.Text = gvwDatos.Rows[intIndice].Cells[3].Text;
                    txtContacto.Text = gvwDatos.Rows[intIndice].Cells[4].Text;
                    txtCuenta.Text = gvwDatos.Rows[intIndice].Cells[5].Text;
                    ddlEstado.SelectedValue = ((Label)gvwDatos.Rows[intIndice].FindControl("lbCodigoEstado")).Text;
                    ddlPrioridad.SelectedValue = ((Label)gvwDatos.Rows[intIndice].FindControl("lbCodigoPrioridad")).Text;
                    chkEnviarMensaje.Checked = gvwDatos.Rows[intIndice].Cells[8].Text.Equals("S")? true:false;
                    chkRepetir.Checked = gvwDatos.Rows[intIndice].Cells[9].Text.Equals("S") ? true : false;
                    txtDescripcion.Text = gvwDatos.Rows[intIndice].Cells[10].Text;                    
                }
                else if (e.CommandName.Equals("Eliminar"))
                {
                    lblOpcion.Text = "E";
                    Proyecto.Logica.Models.clsTareas oClsTareas = new Proyecto.Logica.Models.clsTareas
                    {
                        inCodigo = int.Parse(((Label)gvwDatos.Rows[intIndice].FindControl("lbCodigo")).Text),
                        stTitular = String.Empty,
                        stAsunto = String.Empty,
                        stFechaVencimiento = String.Empty,
                        stContacto = String.Empty,
                        stCuenta = String.Empty,
                        oClsEstado = null,
                        oClsPrioridad = null,
                        stEnviarMensaje = String.Empty,
                        stRepetir = String.Empty,
                        stDescripcion = String.Empty
                    };
                    Proyecto.Web.Controllers.TareasController oTareasController = new Controllers.TareasController();
                    ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Eliminación realizada', '" + oTareasController.deleteTareas(oClsTareas) + "' , 'info');</script>");
                    limpiarRegistro();
                }
                getTareas();
            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(GetType(), "Error", "<script>swal('Error!', '" + ex.Message + "' , 'error');</script>"); ;
            }
        }
    }
}