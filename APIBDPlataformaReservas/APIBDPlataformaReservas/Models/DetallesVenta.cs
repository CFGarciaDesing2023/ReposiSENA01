using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class DetallesVenta
    {
        public string IdDetallesVenta { get; set; }
        public string IdVenta { get; set; }
        public string Id_Producto { get; set; }
        public string Id_servicio{ get; set; }
        public DateTime fechaInicia { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal valorAPagar{ get; set; }
        public string cantidad { get; set; }
        public string EstadoVenta { get; set; }
    }
}