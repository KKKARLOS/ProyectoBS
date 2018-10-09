using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto.Logica.BL
{
    public class clsPrioridad
    {
        SqlConnection _sqlConexion = null; // Me permite comunicación con la base de datos
        SqlCommand _sqlCommand = null; // Me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null; // Me permite adaptar conjunto de datos SQL
        string stConexion = String.Empty; //Cadena de conexion

        SqlParameter _SqlParameter = null;
        public clsPrioridad()
        {
            clsConexion oClsConexion = new clsConexion();
            stConexion = oClsConexion.getConexion();
        }
        /// <summary>
        /// Consulta posibles CLientes
        /// </summary>
        /// <returns>
        /// DataSet PosiblesClientes
        /// </returns>
        public DataSet getConsultarPrioridad()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _sqlConexion = new SqlConnection(stConexion);
                _sqlConexion.Open();

                _sqlCommand = new SqlCommand("spConsultarPrioridad", _sqlConexion);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _sqlConexion.Close();
            }
        }
    }
}
