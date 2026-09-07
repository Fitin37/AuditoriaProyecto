using System;

namespace modeloss.Entidades
{
    public partial class Mantenimiento
    {
        public int IdMantenimiento { get; set; }
        public int IdPropiedad { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public int IdEstado { get; set; }
    }
}
