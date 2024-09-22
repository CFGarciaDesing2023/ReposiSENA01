using APIBDPlataformaReservas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBDPlataformaReservas.Controllers
{
    public class RegistroVentasController : ApiController
    {
        // GET api/<controller
        public List<Models.RegistroVentas> Get()
        {
            return RegistroVentasData.Listar();
        }

        // GET controller >/5
        public List<Models.RegistroVentas> get(string id)
        {
            return RegistroVentasData.ObtenerVenta(id);
        }
        // POST controller
        public bool Post([FromBody] Models.RegistroVentas oVenta)
        {
            return RegistroVentasData.RegistrarVenta(oVenta);

        }
        // PUT controller >/5
        public bool Put([FromBody] Models.RegistroVentas oVenta)
        {
            return RegistroVentasData.ActualizarVenta(oVenta);
        }

        // DELETE controller >/5
        public bool Delete(string id)
        {
            return RegistroVentasData.EliminarVenta(id);
        }
    }
}