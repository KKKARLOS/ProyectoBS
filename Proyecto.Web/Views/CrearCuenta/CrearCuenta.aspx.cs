using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.CrearCuenta
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fuImagen.HasFile)
                {
                    //if (!Path.GetExtension(fuImagen.FileName).Equals("jpg"))
                    //    throw new Exception("Sólo se admiten formatos jpg");
                    //alt 126 es ~
                    string stFichero_RutaTemporal = Server.MapPath(@"~\temp\") + fuImagen.FileName;
                    fuImagen.PostedFile.SaveAs(stFichero_RutaTemporal);

                    string stFichero_RutaDestino = Server.MapPath(@"~\images\") + txtLogin.Text + Path.GetExtension(fuImagen.FileName);

                    if (File.Exists(stFichero_RutaDestino))
                    {
                        File.SetAttributes(stFichero_RutaDestino, FileAttributes.Normal);
                        File.Delete(stFichero_RutaDestino);
                    }
                    File.Copy(stFichero_RutaTemporal, stFichero_RutaDestino);
                    File.SetAttributes(stFichero_RutaTemporal, FileAttributes.Normal);
                    File.Delete(stFichero_RutaTemporal);


                    Proyecto.Logica.Models.clsUsuarios oClsUsuarios = new Proyecto.Logica.Models.clsUsuarios
                    {
                        stLogin = txtLogin.Text,
                        stPassword = txtPassword.Text,
                        stImagen = stFichero_RutaDestino
                    };

                    Proyecto.Web.Controllers.CrearCuentaController oCrearCuentaController = new Controllers.CrearCuentaController();
                    ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Grabación correcta', '" + oCrearCuentaController.setAdministrarUsuarioController(oClsUsuarios, 1) + "' , 'info');</script>");
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "Mensaje", "<script>swal('Error!', '" + ex.Message + "' , 'error');</script>");
            }

        }
    }
}