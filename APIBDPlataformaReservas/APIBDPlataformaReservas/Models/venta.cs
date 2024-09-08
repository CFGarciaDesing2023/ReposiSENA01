using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class venta
    {
        public string Id_Venta { get; set; }
       public DateTime fecha_venta { get; set; }
        public string Id_Cliente { get; set; }
        public string Id_Empleado { get; set; }
        public string Id_Alojamiento{ get; set; }
        public decimal MontoVenta{ get; set; }

    }
}