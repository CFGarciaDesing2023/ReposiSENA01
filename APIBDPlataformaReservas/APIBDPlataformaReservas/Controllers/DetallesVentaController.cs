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
    public class DetallesVentaController : ApiController
    {
        // GET api/<controller
        public List<DetallesVenta> Get()
        {
            return DetallesVentaData.Listar();
        }

        // GET controller >/5
        public List<DetallesVenta> get(string Id_DetalleVenta)
        {
            return DetallesVentaData.ObtenerDetallesVenta(Id_DetalleVenta);
        }
        // POST controller
        public bool Post([FromBody] DetallesVenta oDetalleVenta)
        {
            return DetallesVentaData.RegistrarDetallesVenta(oDetalleVenta);

        }
        // PUT controller >/5
        public bool Put([FromBody] DetallesVenta oDetalleVenta)
        {
            return DetallesVentaData.ActualizarDetallesVenta(oDetalleVenta);
        }

        // DELETE controller >/5
        public bool Delete(string Id_DetalleVenta)
        {
            return DetallesVentaData.EliminarDetalleVenta(Id_DetalleVenta);
        }
    }
}