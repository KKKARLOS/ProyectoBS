namespace Proyecto.Logica.Models
{
    public class clsTareas
    {
        public int inCodigo { get; set; }
        public string stTitular { get; set; }
        public string stAsunto { get; set; }
        public string stFechaVencimiento { get; set; }
        public string stContacto { get; set; }
        public string stCuenta { get; set; }
        // tipos de datos objetos los que tienen clave foranea
        public clsEstado oClsEstado { get; set; }
        public clsPrioridad oClsPrioridad { get; set; }
        public string stEnviarMensaje { get; set; }
        public string stRepetir { get; set; }
        public string stDescripcion { get; set; }
    }
}
