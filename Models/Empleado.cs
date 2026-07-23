namespace CarpinteriaArtesanal.Models
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string edad { get; set; }
        public string experto { get; set; }
        public string sector { get; set; }
        public bool activo { get; set; }

    }
}
