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
    public class TiposDocumentosController : ApiController
    {

        // GET api/<controller
        public List<TiposDocumentos> Get()
        {
            return TiposDocumentosData.Listar();
        }

        // GET controller >/5
       

        
   

       
       
    }
}