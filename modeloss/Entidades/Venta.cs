using System;

namespace modeloss.Entidades
{
    public partial class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdPropiedad { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
