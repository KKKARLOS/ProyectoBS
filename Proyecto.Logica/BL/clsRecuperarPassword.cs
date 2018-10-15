using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsRecuperarPassword
    {
        SqlConnection _sqlConexion = null; // Me permite comunicación con la base de datos
        SqlCommand _sqlCommand = null; // Me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null; // Me permite adaptar conjunto de datos SQL
        string stConexion = String.Empty; //Cadena de conexion

        public clsRecuperarPassword()
        {
            clsConexion oClsConexion = new clsConexion();
            stConexion = oClsConexion.getConexion();
        }
        /// <summary>
        /// Consulta password
        /// </summary>
        /// <param name="oUsuarios"></param>
        /// <returns>
        /// Registro de usuarios
        /// </returns>
        public DataSet getConsultaPassword(Proyecto.Logica.Models.clsUsuarios oUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _sqlConexion = new SqlConnection(stConexion);
                _sqlConexion.Open();

                _sqlCommand = new SqlCommand("spConsultarPassword", _sqlConexion);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@cLogin", oUsuarios.stLogin));
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
