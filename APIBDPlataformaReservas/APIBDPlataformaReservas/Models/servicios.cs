using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class servicios
    {
        public string Id_servicio { get; set; }
        public string nombre_servicio { get; set; }
        public string descripcion_servicio { get; set;}
        public decimal Tarifa { get; set; }
    }
}