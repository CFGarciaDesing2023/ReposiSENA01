using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class habitacion
    {
        public string Id_habitacion { get; set; }
        public string nombre_habitacion { get; set; }
        public string Id_Alojamiento { get; set; }
        public string Id_tipo_habitacion{get; set;}
        public string Descripcion { get; set; }
        public decimal Tarifa { get; set; }
    }
}