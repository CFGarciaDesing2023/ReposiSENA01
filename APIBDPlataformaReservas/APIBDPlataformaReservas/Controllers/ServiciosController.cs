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
    public class ServiciosController : ApiController
    {
        // GET api/<controller
        public List<servicios> Get()
        {
            return ServiciosData.Listar();
        }

        // GET controller >/5
        public List<servicios> get(string Id_Servicios)
        {
            return ServiciosData.ObtenerServicios(Id_Servicios);
        }
        // POST controller
        public bool Post([FromBody] servicios oServicios)
        {
            return ServiciosData.RegistrarServicios(oServicios);

        }
        // PUT controller >/5
        public bool Put([FromBody] servicios oServicios)
        {
            return ServiciosData.ActualizarServicios(oServicios);
        }

        // DELETE controller >/5
        public bool Delete(string Id_Servicios)
        {
            return ServiciosData.EliminarServicios(Id_Servicios);
        }
    }
}