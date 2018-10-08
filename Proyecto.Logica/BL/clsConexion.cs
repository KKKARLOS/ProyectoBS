using System.Configuration;

namespace Proyecto.Logica.BL
{
    public class clsConexion
    {
        /// <summary>
        /// Obtiene conexión a base de datos
        /// </summary>
        /// <returns>
        /// Devuelve cadena conexión
        /// </returns>
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["cnx"].ToString();
        }
    }
}
