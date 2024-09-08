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
    public class VentasController : ApiController
    {

        // GET api/<controller
        public List<venta> Get()
        {
            return VentaData.Listar();
        }

        // GET controller >/5
        public List<venta> get(string Id_Venta)
        {
            return VentaData.ObtenerVenta(Id_Venta);
        }
        // POST controller
        public bool Post([FromBody] venta oVenta)
        {
            return VentaData.RegistrarVenta(oVenta);

        }
        // PUT controller >/5
        public bool Put([FromBody] venta oVenta)
        {
            return VentaData.ActualizarVenta(oVenta);
        }

        // DELETE controller >/5
        public bool Delete(string Id_Venta)
        {
            return VentaData.EliminarVenta(Id_Venta);
        }
    }
}