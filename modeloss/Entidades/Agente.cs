namespace modeloss.Entidades
{
    public partial class Agente
    {
        public int IdAgente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public decimal Comision { get; set; }
        public int IdEstado { get; set; }
    }
}
