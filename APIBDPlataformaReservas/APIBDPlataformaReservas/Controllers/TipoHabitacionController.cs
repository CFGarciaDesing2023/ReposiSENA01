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
    public class TipoHabitacionController : ApiController
    {
        // GET api/<controller
        public List<tiposHabitacion> Get()
        {
            return TipoHabitacionesData.Listar();
        }

        // GET controller >/5
        public List<tiposHabitacion> get(string Id_tipo_habitacion)
        {
            return TipoHabitacionesData.ObtenerTipoHabitacion(Id_tipo_habitacion);
        }
        // POST controller
        public bool Post([FromBody] tiposHabitacion oTipoHabitacion)
        {
            return TipoHabitacionesData.RegistrarTipoHabitacion(oTipoHabitacion);

        }
        // PUT controller >/5
        public bool Put([FromBody] tiposHabitacion oTipoHabitacion)
        {
            return TipoHabitacionesData.ActualizarTipoHabitacion(oTipoHabitacion);
        }

        // DELETE controller >/5
        public bool Delete(string Id_tipo_habitacion)
        {
            return TipoHabitacionesData.EliminarTipoHabitacion(Id_tipo_habitacion);
        }
    }
}