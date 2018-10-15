using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsUsuario
    {
        SqlConnection _sqlConexion = null; // Me permite comunicación con la base de datos
        SqlCommand _sqlCommand= null; // Me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null; // Me permite adaptar conjunto de datos SQL
        SqlParameter _SqlParameter = null; //Parametros
        string stConexion = String.Empty; //Cadena de conexion

        public clsUsuario()
        {
            clsConexion oClsConexion = new clsConexion();
            stConexion = oClsConexion.getConexion();
        }
        /// <summary>
        /// Validar Usuario
        /// </summary>
        /// <param name="oUsuarios"></param>
        /// <returns>
        /// Confirmación
        /// </returns>
        public bool getValidarUsuario(Proyecto.Logica.Models.clsUsuarios oUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _sqlConexion = new SqlConnection(stConexion);
                _sqlConexion.Open();

                _sqlCommand = new SqlCommand("spConsultarUsuario", _sqlConexion);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@cLogin", oUsuarios.stLogin));
                _sqlCommand.Parameters.Add(new SqlParameter("@cPassword", oUsuarios.stPassword));
                _sqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;
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
        public string setAdministrarUsuario(Proyecto.Logica.Models.clsUsuarios oUsuarios, int iOpcion)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _sqlConexion = new SqlConnection(stConexion);
                _sqlConexion.Open();

                _sqlCommand = new SqlCommand("SpAdministrarUsuarios", _sqlConexion);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@cLogin", oUsuarios.stLogin));
                _sqlCommand.Parameters.Add(new SqlParameter("@cPassword", oUsuarios.stPassword));
                _sqlCommand.Parameters.Add(new SqlParameter("@cImagen", oUsuarios.stImagen));
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
