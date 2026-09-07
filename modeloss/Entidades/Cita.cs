using System;

namespace modeloss.Entidades
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public int IdCliente { get; set; }
        public int IdAgente { get; set; }
        public int IdPropiedad { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdEstado { get; set; }
    }
}
