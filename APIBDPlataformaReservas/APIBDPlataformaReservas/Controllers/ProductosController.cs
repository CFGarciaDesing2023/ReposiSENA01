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
    public class ProductosController : ApiController
    {
        // GET api/<controller
        public List<Reservas> Get()
        {
            return ReservasData.Listar();
        }

        // GET controller >/5
        public List<Reservas> get(string Id_Reserva)
        {
            return ReservasData.ObtenerReservas(Id_Reserva);
        }
        // POST controller
        public bool Post([FromBody] Reservas oReservas)
        {
            return ReservasData.RegistrarReservas(oReservas);

        }
        // PUT controller >/5
        public bool Put([FromBody] Reservas oReservas)
        {
            return ReservasData.ActualizarReservas(oReservas);
        }

        // DELETE controller >/5
        public bool Delete(string Id_Reserva)
        {
            return LugarData.eliminarLugar(Id_Reserva);
        }
    }
}