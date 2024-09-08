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
    public class DetallesReservaController : ApiController
    {
        // GET api/<controller
        public List<DetallesReservas> Get()
        {
            return DetallesReservasData.Listar();
        }

        // GET controller >/5
        public List<DetallesReservas> get(string Id_DetalleReservas)
        {
            return DetallesReservasData.ObtenerDetallesReservas(Id_DetalleReservas);
        }
        // POST controller
        public bool Post([FromBody] DetallesReservas oDetalleReservas)
        {
            return DetallesReservasData.RegistrarDetallesReservas(oDetalleReservas);

        }
        // PUT controller >/5
        public bool Put([FromBody] DetallesReservas oDetalleReservas)
        {
            return DetallesReservasData.ActualizarDetallesReservas(oDetalleReservas);
        }

        // DELETE controller >/5
        public bool Delete(string Id_DetalleReserva)
        {
            return DetallesReservasData.EliminarDetalleReserva(Id_DetalleReserva);
        }
    }
}