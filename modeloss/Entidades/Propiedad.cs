namespace modeloss.Entidades
{
    public partial class Propiedad
    {
        public int IdPropiedad { get; set; }
        public string Codigo { get; set; }
        public int IdTipoPropiedad { get; set; }
        public string Direccion { get; set; }
        public int IdMunicipio { get; set; }
        public decimal Precio { get; set; }
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    }
}
