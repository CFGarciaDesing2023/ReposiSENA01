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
    public class TipoLugarController : ApiController
    {
        // GET api/<controller
        public List<tipoLugar> Get()
        {
            return TipoLugarData.Listar();
        }

       
    }
}