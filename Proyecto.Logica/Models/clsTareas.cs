namespace Proyecto.Logica.Models
{
    public class clsTareas
    {
        public int stCodigo { get; set; }
        public string stTitular { get; set; }
        public string stAsunto { get; set; }
        public string stFechaVencimiento { get; set; }
        public string stContacto { get; set; }
        // tipos de datos objetos los que tienen clave foranea
        public clsEstado oClsEstado { get; set; }
        public clsPrioridad oClsPrioridad { get; set; }
        public char chEnviarMensaje { get; set; }
        public char chRepetir { get; set; }
        public string stDescripcion { get; set; }
    }
}
