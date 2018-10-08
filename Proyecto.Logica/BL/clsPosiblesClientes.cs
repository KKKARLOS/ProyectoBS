using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsPosiblesClientes
    {
        SqlConnection _sqlConexion = null; // Me permite comunicación con la base de datos
        SqlCommand _sqlCommand = null; // Me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null; // Me permite adaptar conjunto de datos SQL
        string stConexion = String.Empty; //Cadena de conexion

        SqlParameter _SqlParameter = null;
        public clsPosiblesClientes()
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
        public DataSet getPosiblesCLientes()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _sqlConexion = new SqlConnection(stConexion);
                _sqlConexion.Open();

                _sqlCommand = new SqlCommand("spConsultarPosiblesCLientes", _sqlConexion);
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
        /// <summary>
        /// Administrar posibles clientes
        /// </summary>
        /// <param name="oClsPosibleClientes"></param>
        /// <param name="iOpcion"></param>
        /// <returns>
        /// Mensaje de operacionnnnnnn
        /// </returns>
        public string setAdministrarPosiblesCLientes(Models.clsPosibleClientes oClsPosibleClientes, int iOpcion)
        {
            try
            {

                _sqlConexion = new SqlConnection(stConexion);
                _sqlConexion.Open();

                _sqlCommand = new SqlCommand("spAdministrarPosiblesCLientes", _sqlConexion);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", oClsPosibleClientes.inIdentificacion));
                _sqlCommand.Parameters.Add(new SqlParameter("@cEmpresa", oClsPosibleClientes.stEmpresa));
                _sqlCommand.Parameters.Add(new SqlParameter("@cPrimerNombre", oClsPosibleClientes.stPrimerNombre));
                _sqlCommand.Parameters.Add(new SqlParameter("@cSegundoNombre", oClsPosibleClientes.stSegundoNombre));
                _sqlCommand.Parameters.Add(new SqlParameter("@cPrimerApellido", oClsPosibleClientes.stPrimerApellido));
                _sqlCommand.Parameters.Add(new SqlParameter("@cSegundoApellido", oClsPosibleClientes.stSegundoApellido));
                _sqlCommand.Parameters.Add(new SqlParameter("@cDireccion", oClsPosibleClientes.stDireccion));
                _sqlCommand.Parameters.Add(new SqlParameter("@cTelefono", oClsPosibleClientes.stTelefono));
                _sqlCommand.Parameters.Add(new SqlParameter("@cCorreo", oClsPosibleClientes.stCorreo));
                _sqlCommand.Parameters.Add(new SqlParameter("@nOpcion", iOpcion));

                _SqlParameter = new SqlParameter();
                _SqlParameter.ParameterName = "@cMensaje";
                _SqlParameter.Direction = ParameterDirection.Output;
                _SqlParameter.SqlDbType = SqlDbType.VarChar;
                _SqlParameter.Size = 50;

                _sqlCommand.Parameters.Add(_SqlParameter);

                _sqlCommand.ExecuteNonQuery();
                return _SqlParameter.Value.ToString();
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
