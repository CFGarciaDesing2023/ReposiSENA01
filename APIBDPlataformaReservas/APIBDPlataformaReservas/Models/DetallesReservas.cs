using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class DetallesReservas
    {
        public string Id_DetalleReserva { get; set; }
        public string Id_Reserva { get; set; }
        public string Id_habiatacion { get; set; }
        public string NumeroPersonas { get; set; }
        public decimal ValorTotal { get; set; }
        public string Condiciones { get; set; }
        public string Observaciones { get; set; }
        public string EstadoReserva { get; set; }

    }
}