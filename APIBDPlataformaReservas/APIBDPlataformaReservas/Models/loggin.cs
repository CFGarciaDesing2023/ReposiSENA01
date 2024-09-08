using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Models
{
    public class loggin
    {
        public string Id_Usuario { get; set; }
        public string nombreUsuario { get; set; }
        public string IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string emailUsuarios { get; set; }
        public string contraseñaUsuario {get; set;}
        public string CodTipoUsuario { get; set; }

    }
}