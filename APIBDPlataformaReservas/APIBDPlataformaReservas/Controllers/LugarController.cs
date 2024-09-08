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
    public class LugarController : ApiController
    {
        // GET api/<controller
        public List<Lugar> Get()
        {
            return LugarData.Listar();
        }

        // GET controller >/5
        public List<Lugar> get(string Id_Alojamiento)
        {
            return LugarData.ObtenerLugar(Id_Alojamiento);
        }
        // POST controller
        public bool Post([FromBody] Lugar oLugar)
        {
            return LugarData.registrarLugar(oLugar);

        }
        // PUT controller >/5
        public bool Put([FromBody] Lugar oLugar)
        {
            return LugarData.usp_actualizarLugar(oLugar);
        }

        // DELETE controller >/5
        public bool Delete(string Id_Alojamiento)
        {
            return LugarData.eliminarLugar(Id_Alojamiento);
        }
    }

    
}
