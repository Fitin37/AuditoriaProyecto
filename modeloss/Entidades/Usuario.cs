namespace modeloss.Entidades
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }
        public int IdEstado { get; set; }
    }
}
