using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class Reservas
    {
       public string Id_Reserva { get; set; }
        public string Id_Cliente { get; set; }
        public string Id_Alojamiento { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
    }
}