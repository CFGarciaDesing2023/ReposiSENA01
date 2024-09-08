using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class Lugar
    {
      public string Id_Alojamiento { get; set; }
        public string Id_Administrador { get; set; }
        public string CodTipoAlojamiento { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion  { get; set; }
        public string Calificacion { get; set; }
        public string Telefono { get; set; }
        public string Instalaciones { get; set; }

    }
}