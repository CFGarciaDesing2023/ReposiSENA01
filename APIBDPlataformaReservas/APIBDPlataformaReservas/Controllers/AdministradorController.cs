using APIBDPlataformaReservas.Data;
using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBDPlataformaReservas.Controllers
{
    public class AdministradorController : ApiController
    {
        // GET api/<controller
        public List<Administrador> Get()
        {
            return AdministradorData.Listar();
        }

        // GET controller >/5
        public List<Administrador> get(string Id_Administrador)
        {
            return AdministradorData.ObtenerAdministrador(Id_Administrador);
        }
        // POST controller
        public bool Post([FromBody] Administrador oAdministrador)
        {
            return AdministradorData.RegistrarAdministrador(oAdministrador);

        }
        // PUT controller >/5
        public bool Put([FromBody] Administrador oAdministrador)
        {
            return AdministradorData.ActualizarAdministrador(oAdministrador);
        }

        // DELETE controller >/5
        public bool Delete(string Id_Administrador)
        {
            return AdministradorData.eliminarAdministrador(Id_Administrador);
        }
    }
}