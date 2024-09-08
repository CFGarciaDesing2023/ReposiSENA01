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
    public class HabitacionController : ApiController
    {

        // GET api/<controller
        public List<habitacion> Get()
        {
            return HabitacionData.Listar();
        }

        // GET controller >/5
        public List<habitacion> get(string Id_habitacion)
        {
            return HabitacionData.ObtenerHabitacion(Id_habitacion);
        }
        // POST controller
        public bool Post([FromBody] habitacion oHabitacion)
        {
            return HabitacionData.registrarHabitacion(oHabitacion);

        }
        // PUT controller >/5
        public bool Put([FromBody] habitacion oHabitacion)
        {
            return HabitacionData.usp_actualizarHabitacion(oHabitacion);
        }

        // DELETE controller >/5
        public bool Delete(string Id_habitacion)
        {
            return HabitacionData.eliminarHabitacion(Id_habitacion);
        }
    }
}