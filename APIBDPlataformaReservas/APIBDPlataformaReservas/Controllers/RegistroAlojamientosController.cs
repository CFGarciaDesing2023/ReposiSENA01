using APIBDPlataformaReservas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBDPlataformaReservas.Controllers
{
    public class RegistroAlojamientosController : ApiController
    {
        // GET api/<controller
        public List<Models.RegistroAlojamientos> Get()
        {
            return RegistroAlojamientosData.Listar();
        }

        // GET controller >/5
        public List<Models.RegistroAlojamientos> get(string id)
        {
            return RegistroAlojamientosData.ObtenerLugar(id);
        }
        // POST controller
        public bool Post([FromBody] Models.RegistroAlojamientos oAlojamiento)
        {
            return RegistroAlojamientosData.RegistrarAlojamiento(oAlojamiento);

        }
        // PUT controller >/5
        public bool Put([FromBody] Models.RegistroAlojamientos oAlojamiento)
        {
            return RegistroAlojamientosData.usp_ActualizarAlojamiento(oAlojamiento);
        }

        // DELETE controller >/5
        public bool Delete(string id)
        {
            return RegistroAlojamientosData.EliminarAlojamiento(id);
        }
    }
}