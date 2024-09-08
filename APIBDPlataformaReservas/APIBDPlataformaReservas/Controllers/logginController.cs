using APIBDPlataformaReservas.Data;
using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIBDPlataformaReservas.Controllers
{
    public class logginController : ApiController
    {
        // GET api/<controller
        public List<loggin> Get()
        {
            return logginData.Listar();
        }

        // GET controller >/5
        public List<loggin> get(string Id_Usuario)
        {
            return logginData.ObtenerUsuario(Id_Usuario);
        }
        // POST controller
        public bool Post([FromBody] loggin oUsuario)
        {
            return logginData.registrarUsuario(oUsuario);

        }
        // PUT controller >/5
        public bool Put([FromBody] loggin oUsuario)
        {
            return logginData.actualizarUsuario(oUsuario);
        }

        // DELETE controller >/5
        public bool Delete(string IdUsuario)
        {
            return logginData.eliminarUsuario(IdUsuario);
        }
    }

    
}