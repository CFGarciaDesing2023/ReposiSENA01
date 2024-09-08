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
    public class TipoUsuariosController : ApiController
    {
        // GET api/<controller
        public List<TiposUsuarios> Get()
        {
            return TipoUsuariosData.Listar();
        }

        
    }
}