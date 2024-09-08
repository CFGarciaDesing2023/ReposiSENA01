using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class productos
    {
        public string Id_producto { get; set; }
        public string nombreproducto { get; set; }
        public string descripcion_producto { get; set; }
        public decimal precio { get; set; }
        public DateTime  FechaVencimiento{ get; set; }
    }
}