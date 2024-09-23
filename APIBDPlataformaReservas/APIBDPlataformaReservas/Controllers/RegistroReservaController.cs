using APIBDPlataformaReservas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBDPlataformaReservas.Controllers
{
    public class RegistroReservaController : ApiController
    {
        // GET api/<controller
        public List<Models.RegistroReserva> Get()
        {
            return RegistroReservasData.Listar();
        }

        // GET controller >/5
        public List<Models.RegistroReserva> get(string id)
        {
            return RegistroReservasData.ObtenerReservas(id);
        }
        // POST controller
        public bool Post([FromBody] Models.RegistroReserva oReservas)
        {
            return RegistroReservasData.RegistrarReservas(oReservas);

        }
        // PUT controller >/5
        public bool Put([FromBody] Models.RegistroReserva oReservas)
        {
            return RegistroReservasData.ActualizarReservas(oReservas);
        }

        // DELETE controller >/5
        public bool Delete(string id)
        {
            return RegistroReservasData.EliminarReserva(id);
        }
    }
}