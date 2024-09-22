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
    public class ProductoController : ApiController
    {// GET api/<controller
        public List<Models.Producto> Get()
        {
            return ProductoData.Listar();
        }

        // GET controller >/5
        public List<Models.Producto> Get(string id)
        {
            return ProductoData.ObtenerProducto(id);
        }
        // POST controller
        public bool Post([FromBody] Models.Producto oProducto)
        {
            return ProductoData.RegistrarProducto(oProducto);

        }

        // PUT controller >/5
        public bool Put([FromBody] Models.Producto oProducto)
        {
            return ProductoData.ActualizarProducto(oProducto);
        }

        // DELETE controller >/5
        public bool DELETE(string id)
        {
            return ProductoData.EliminarProducto(id);
        }
    }
}