using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class RegistroVentas
    {
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public int AlojamientoID { get; set; }
        public int EmpleadoID { get; set; }

        public DateTime FechaVenta { get; set; }
        public int ProductoID { get; set; }
        public int CantidadVendida { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Total { get; set; }
        public int Cantidad { get; set; }
        public string EstadoVenta { get; set; }
    }
}