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
            catch (Exception ex)
            {

                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string addTareas(Proyecto.Logica.Models.clsTareas oClsTareas)
        {
            try
            {
                Proyecto.Logica.BL.clsTareas oclsTareas = new Logica.BL.clsTareas();
                return oclsTareas.addTareas(oClsTareas);            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string updateTareas(Proyecto.Logica.Models.clsTareas oClsTareas)
        {
            try
            {
                Proyecto.Logica.BL.clsTareas oclsTareas = new Logica.BL.clsTareas();
                return oclsTareas.updateTareas(oClsTareas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string deleteTareas(Proyecto.Logica.Models.clsTareas oClsTareas)
        {
            try
            {
                Proyecto.Logica.BL.clsTareas oclsTareas = new Logica.BL.clsTareas();
                return oclsTareas.deleteTareas(oClsTareas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Proyecto.Logica.Models.clsTareas> getAllTareas()
        {
            try
            {
                Proyecto.Logica.BL.clsTareas oclsTareas = new Logica.BL.clsTareas();
                return oclsTareas.getAllTareas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Proyecto.Logica.Models.clsTareas> getTarea(Proyecto.Logica.Models.clsTareas oClsTareas)
        {
            try
            {
                Proyecto.Logica.BL.clsTareas oclsTareas = new Logica.BL.clsTareas();
                return oclsTareas.getTarea(oClsTareas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}