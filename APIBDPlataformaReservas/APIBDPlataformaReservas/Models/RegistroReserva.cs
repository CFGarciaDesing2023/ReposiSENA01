using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class RegistroReserva
    {
        public int ReservaID { get; set; }
        public int ClienteID { get; set; }
        public int AlojamientoID { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string TipoHabitacion { get; set; }
        public int HabitacionID { get; set; }
        public int NumeroPersonas { get; set; }
        public decimal ValorTotal { get; set; }
        public string Estado { get; set; }
    }
}