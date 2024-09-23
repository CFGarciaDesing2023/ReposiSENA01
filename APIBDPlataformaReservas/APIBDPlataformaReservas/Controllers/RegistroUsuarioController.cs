using APIBDPlataformaReservas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBDPlataformaReservas.Controllers
{
    public class RegistroUsuarioController : ApiController
    {
        // GET api/<controller
        public List<Models.RegistroUsuario> Get()
        {
            return RegistroUsuarioData.Listar();
        }

        // GET controller >/5
        public List<Models.RegistroUsuario> Get(string id)
        {
            return RegistroUsuarioData.ObtenerUsuario(id);
        }
        // POST controller
        public bool Post([FromBody] Models.RegistroUsuario oUsuario)
        {
            return RegistroUsuarioData.registrarUsuario(oUsuario);

        }

        // PUT controller >/5
        public bool Put([FromBody] Models.RegistroUsuario oUsuario)
        {
            return RegistroUsuarioData.ActualizarUsuario(oUsuario);
        }

        // DELETE controller >/5
        public bool DELETE(string id)
        {
            return RegistroUsuarioData.EliminarUsuario(id);
        }
        
    }
}