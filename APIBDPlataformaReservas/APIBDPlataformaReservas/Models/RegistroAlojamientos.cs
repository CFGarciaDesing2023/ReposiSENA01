using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class RegistroAlojamientos
    {
        public int AlojamientoID { get; set; }
        public int AdministradorID { get; set; }
        public string TipoAlojamiento{ get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string DescripcionInstalaciones { get; set; }
        public int Capacidad_Habitaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
     


    }
}