using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Proyecto.Logica.BL;
namespace Proyecto.Web.Controllers
{
    public class RecuperarContraseñaController
    {
        public DataSet getConsultaPasswordController(Proyecto.Logica.Models.clsUsuarios oClsUsuarios)
        {
            clsRecuperarPassword oClsRecuperarPassword = new clsRecuperarPassword();
            return oClsRecuperarPassword.getConsultaPassword(oClsUsuarios);
        }
        public void setEmailController(Proyecto.Logica.Models.clsCorreo oClsCorreo)
        {
            clsGeneral oMail = new clsGeneral();
            oMail.setEmail(oClsCorreo);
        }
    }
}