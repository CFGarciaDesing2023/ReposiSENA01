using APIBDPlataformaReservas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBDPlataformaReservas.Controllers
{
    public class RegistroHabitacionController : ApiController
    {// GET api/<controller
        public List<Models.RegistroHabitacion> Get()
        {
            return RegistroHabitacionData.Listar();
        }

        // GET controller >/5
        public List<Models.RegistroHabitacion> get(string id)
        {
            return RegistroHabitacionData.ObtenerHabitacion(id);
        }
        // POST controller
        public bool Post([FromBody] Models.RegistroHabitacion oHabitacion)
        {
            return RegistroHabitacionData.RegistrarHabitacion(oHabitacion);

        }
        // PUT controller >/5
        public bool Put([FromBody] Models.RegistroHabitacion oHabitacion)
        {
            return RegistroHabitacionData.ActualizarHabitacion(oHabitacion);
        }

        // DELETE controller >/5
        public bool Delete(string id)
        {
            return RegistroHabitacionData.EliminarHabitacion(id);
        }
    }
}