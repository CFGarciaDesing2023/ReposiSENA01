using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class RegistroHabitacion
    {
        public int HabitacionID { get; set; }
        public int AlojamientoID { get; set; }
        public string TipoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioNoche { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estado { get; set; }

    }
}