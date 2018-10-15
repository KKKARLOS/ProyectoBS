using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Logica.Models;

namespace Proyecto.Web.Controllers
{
    public class CrearCuentaController
    {
        public string setAdministrarUsuarioController(Proyecto.Logica.Models.clsUsuarios oClsUsuarios, int iOpcion)
        {
            try
            {
                Proyecto.Logica.BL.clsUsuario oclsUsuarios = new Logica.BL.clsUsuario();
                return oclsUsuarios.setAdministrarUsuario(oClsUsuarios, iOpcion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}