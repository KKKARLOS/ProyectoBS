using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace Proyecto.Web.Controllers
{
    public class TareasController
    {
        /// <summary>
        /// Obtiene registros Estado Tareas
        /// </summary>
        /// <returns>
        /// Registros Estados
        /// </returns>
        public DataSet getConsultarEstadoTareasController()
        {
            try
            {
                Proyecto.Logica.BL.clsEstado oClsEstado = new Logica.BL.clsEstado();
                return oClsEstado.getConsultarEstados();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Obtiene registros Prioridad Tareas
        /// </summary>
        /// <returns>
        /// Registros Prioridades
        /// </returns>
        public DataSet getConsultarPrioridadController()
        {
            try
            {
                Proyecto.Logica.BL.clsPrioridad oClsPrioridad = new Logica.BL.clsPrioridad();
                return oClsPrioridad.getConsultarPrioridad();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}