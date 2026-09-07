using System;

namespace modeloss.Entidades
{
    public partial class Alquiler
    {
        public int IdAlquiler { get; set; }
        public int IdCliente { get; set; }
        public int IdPropiedad { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PagoMensual { get; set; }
    }
}
