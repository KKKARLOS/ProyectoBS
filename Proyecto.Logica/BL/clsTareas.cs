using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using Proyecto.Logica.Entidades;

namespace Proyecto.Logica.BL
{
    public class clsTareas
    {
        public string addTareas(Models.clsTareas oClsTareas)
        {
            try
            {
                using (var dbContext = new SqlServerEntities())
                {
                    Entidades.tbTareas oTarea = new tbTareas();


                    oTarea.tareCodigo = oClsTareas.inCodigo;
                    oTarea.tareTitular = oClsTareas.stTitular;
                    oTarea.tareAsunto = oClsTareas.stAsunto;
                    oTarea.tareFechaVencimiento = oClsTareas.stFechaVencimiento;
                    oTarea.tareContacto = oClsTareas.stContacto;
                    oTarea.tareCuenta = oClsTareas.stCuenta;
                    oTarea.estaCodigo = oClsTareas.oClsEstado.inEstaCodigo;
                    oTarea.prioCodigo = oClsTareas.oClsPrioridad.inCodigo;
                    oTarea.tareEnviarMensaje = oClsTareas.stEnviarMensaje;
                    oTarea.tareRepetir = oClsTareas.stRepetir;
                    oTarea.tareDescripcion = oClsTareas.stDescripcion;

                    dbContext.tbTareas.Add(oTarea);
                    dbContext.SaveChanges();

                    return "Grabación correcta";
                }
                //using ()
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string updateTareas(Models.clsTareas oClsTareas)
        {
            try
            {
                using (var dbContext = new SqlServerEntities())
                {
                    Entidades.tbTareas oTarea = (from q in dbContext.tbTareas
                                                 where q.tareCodigo == oClsTareas.inCodigo
                                                 select q).FirstOrDefault();

                    oTarea.tareTitular = oClsTareas.stTitular;
                    oTarea.tareAsunto = oClsTareas.stAsunto;
                    oTarea.tareFechaVencimiento = oClsTareas.stFechaVencimiento;
                    oTarea.tareContacto = oClsTareas.stContacto;
                    oTarea.tareCuenta = oClsTareas.stCuenta;
                    oTarea.estaCodigo = oClsTareas.oClsEstado.inEstaCodigo;
                    oTarea.prioCodigo = oClsTareas.oClsPrioridad.inCodigo;
                    oTarea.tareEnviarMensaje = oClsTareas.stEnviarMensaje;
                    oTarea.tareRepetir = oClsTareas.stRepetir;
                    oTarea.tareDescripcion = oClsTareas.stDescripcion;

                    dbContext.SaveChanges();

                    return "Grabación correcta";
                }
                //using ()
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string deleteTareas(Models.clsTareas oClsTareas)
        {
            try
            {
                using (var dbContext = new SqlServerEntities())
                {
                    Entidades.tbTareas oTarea = (from q in dbContext.tbTareas
                                                 where q.tareCodigo == oClsTareas.inCodigo
                                                 select q).FirstOrDefault();

                    dbContext.tbTareas.Remove(oTarea);
                    dbContext.SaveChanges();

                    return "Grabación correcta";
                }
                //using ()
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Models.clsTareas> getAllTareas()
        {
            try
            {
                using (SqlServerEntities dbContext = new SqlServerEntities())
                {
                    return (from q in dbContext.tbTareas  
                            join tbEs in dbContext.tbEstadoTareas on q.estaCodigo equals tbEs.estaCodigo
                            join tbPr in dbContext.tbPrioridad on q.prioCodigo equals tbPr.prioCodigo
                            select new Models.clsTareas
                                {
                                    inCodigo=q.tareCodigo,
                                    stTitular=q.tareTitular,
                                    stAsunto=q.tareAsunto,
                                    stFechaVencimiento=q.tareFechaVencimiento,
                                    stContacto=q.tareContacto,
                                    stCuenta=q.tareCuenta,
                                    oClsEstado= new Models.clsEstado { inEstaCodigo = (int)q.estaCodigo, stDescripcion=tbEs.estaDescripcion },
                                    oClsPrioridad= new Models.clsPrioridad { inCodigo = (int)q.prioCodigo, stDescripcion=tbPr.prioDescripcion },
                                    stEnviarMensaje=q.tareEnviarMensaje,
                                    stRepetir= q.tareRepetir,
                                    stDescripcion = q.tareDescripcion
                                }
                            ).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Models.clsTareas> getTarea(Models.clsTareas oClsTareas)
        {
            try
            {
                using (SqlServerEntities dbContext = new SqlServerEntities())
                {
                    return (from q in dbContext.tbTareas
                            join tbEs in dbContext.tbEstadoTareas on q.estaCodigo equals tbEs.estaCodigo
                            join tbPr in dbContext.tbPrioridad on q.prioCodigo equals tbPr.prioCodigo
                            where q.tareCodigo==oClsTareas.inCodigo
                            select new Models.clsTareas
                                {
                                    inCodigo = q.tareCodigo,
                                    stTitular = q.tareTitular,
                                    stAsunto = q.tareAsunto,
                                    stFechaVencimiento = q.tareFechaVencimiento,
                                    stContacto = q.tareContacto,
                                    stCuenta=q.tareCuenta,
                                    oClsEstado = new Models.clsEstado { inEstaCodigo = (int)q.estaCodigo, stDescripcion = tbEs.estaDescripcion },
                                    oClsPrioridad = new Models.clsPrioridad { inCodigo = (int)q.prioCodigo, stDescripcion = tbPr.prioDescripcion },
                                    stEnviarMensaje =q.tareEnviarMensaje,
                                    stRepetir = q.tareRepetir,
                                    stDescripcion = q.tareDescripcion
                            }
                            ).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
