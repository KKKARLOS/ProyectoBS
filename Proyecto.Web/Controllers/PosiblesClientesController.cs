using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Proyecto.Web.Controllers
{
    public class PosiblesClientesController
    {
        /// <summary>
        /// Obtiene registros Posibles clientes
        /// </summary>
        /// <returns>
        /// Registros Posibles clientes
        /// </returns>
        public DataSet getConsultarPosiblesClientesController()
        {
            try
            {
                Proyecto.Logica.BL.clsPosiblesClientes oPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return oPosiblesClientes.getPosiblesCLientes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string setAdministrarConsultarPosiblesClientesController(Proyecto.Logica.Models.clsPosibleClientes oClsPosibleClientes, int iOpcion)
        {
            try
            {
                Proyecto.Logica.BL.clsPosiblesClientes oPosiblesClientes = new Logica.BL.clsPosiblesClientes();
                return oPosiblesClientes.setAdministrarPosiblesCLientes(oClsPosibleClientes,iOpcion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}