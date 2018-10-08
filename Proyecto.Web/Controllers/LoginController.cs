using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Web.Controllers
{
    public class LoginController
    {
        public bool getValidarUsuarioController(Logica.Models.clsUsuarios oUsuarios)
        {
            try
            {
                Logica.BL.clsUsuario oUsuario = new Logica.BL.clsUsuario();
                return oUsuario.getValidarUsuario(oUsuarios);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}