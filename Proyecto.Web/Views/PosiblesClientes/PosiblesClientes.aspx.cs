using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.PosiblesClientes
{
    public partial class PosiblesClientes : System.Web.UI.Page
    {
        void limpiarRegistro()
        {
            txtIdentificacion.Text = "";
            txtEmpresa.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            lblOpcion.Text = String.Empty;
        }
        void getPosiblesClientes()
        {
            try
            {
                Proyecto.Web.Controllers.PosiblesClientesController oPosiblesClientesController = new Controllers.PosiblesClientesController();
                DataSet dsConsultas = oPosiblesClientesController.getConsultarPosiblesClientesController();
                if (dsConsultas.Tables[0].Rows.Count > 0)
                    gvwDatos.DataSource = dsConsultas;
                else
                    gvwDatos.DataSource = null;

                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Error!', '" + ex.Message + "' , 'error');</script>"); ;
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getPosiblesClientes();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtIdentificacion.Text)) stMensaje += "Ingrese identificación";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje);

                Proyecto.Logica.Models.clsPosibleClientes oClsPosibleClientes = new Proyecto.Logica.Models.clsPosibleClientes
                {
                    inIdentificacion = int.Parse(txtIdentificacion.Text),
                    stEmpresa = txtEmpresa.Text,
                    stPrimerNombre = txtPrimerNombre.Text,
                    stSegundoNombre = txtSegundoNombre.Text,
                    stPrimerApellido = txtPrimerApellido.Text,
                    stSegundoApellido = txtSegundoApellido.Text,
                    stDireccion = txtDireccion.Text,
                    stTelefono = txtTelefono.Text,
                    stCorreo = txtCorreo.Text
                };

                Proyecto.Web.Controllers.PosiblesClientesController oPosiblesClientesController = new Controllers.PosiblesClientesController();
                if (string.IsNullOrEmpty(lblOpcion.Text))
                    lblOpcion.Text = "1";

                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Grabación correcta', '" + oPosiblesClientesController.setAdministrarConsultarPosiblesClientesController(oClsPosibleClientes, int.Parse(lblOpcion.Text)) + "' , 'info');</script>");
                lblOpcion.Text = String.Empty;
                getPosiblesClientes();
                limpiarRegistro();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>alert('Error!  '" + ex.Message + "');</script>");
                //ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Error!', '"+ex.Message+"' , 'error');</script>"); 
            }
        }

        protected void gvwDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {
                int intIndice = Convert.ToInt32(e.CommandArgument);

                if  (e.CommandName.Equals("Editar"))
                {
                    lblOpcion.Text = "2";
                    txtIdentificacion.Text = ((Label)gvwDatos.Rows[intIndice].FindControl("lbIdentificacion")).Text;
                    txtEmpresa.Text = gvwDatos.Rows[intIndice].Cells[1].Text;
                    txtPrimerNombre.Text = gvwDatos.Rows[intIndice].Cells[2].Text;
                    txtSegundoNombre.Text = gvwDatos.Rows[intIndice].Cells[3].Text;
                    txtPrimerApellido.Text = gvwDatos.Rows[intIndice].Cells[4].Text;
                    txtSegundoApellido.Text = gvwDatos.Rows[intIndice].Cells[5].Text;
                    txtDireccion.Text = gvwDatos.Rows[intIndice].Cells[6].Text;
                    txtTelefono.Text = gvwDatos.Rows[intIndice].Cells[7].Text;
                    txtCorreo.Text = gvwDatos.Rows[intIndice].Cells[8].Text;
                }
                else if(e.CommandName.Equals("Eliminar"))
                {
                    lblOpcion.Text = "3";
                    Proyecto.Logica.Models.clsPosibleClientes oClsPosibleClientes = new Proyecto.Logica.Models.clsPosibleClientes
                    {
                        inIdentificacion = int.Parse(((Label)gvwDatos.Rows[intIndice].FindControl("lbIdentificacion")).Text),
                        stEmpresa = String.Empty,
                        stPrimerNombre = String.Empty,
                        stSegundoNombre = String.Empty,
                        stPrimerApellido = String.Empty,
                        stSegundoApellido = String.Empty,
                        stDireccion = String.Empty,
                        stTelefono = String.Empty,
                        stCorreo = String.Empty
                   };
                   Proyecto.Web.Controllers.PosiblesClientesController oPosiblesClientesController = new Controllers.PosiblesClientesController();
                   ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Eliminación realizada', '" + oPosiblesClientesController.setAdministrarConsultarPosiblesClientesController(oClsPosibleClientes, int.Parse(lblOpcion.Text)) + "' , 'info');</script>");
                   limpiarRegistro();
                }
                getPosiblesClientes();
            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Error!', '"+ex.Message+"' , 'error');</script>"); ;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
        }
    }
}