using System;

namespace modeloss.Entidades
{
    public partial class Pago
    {
        public int IdPago { get; set; }
        public int IdAlquiler { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public int IdMetodoPago { get; set; }
        public int IdEstado { get; set; }
    }
}
