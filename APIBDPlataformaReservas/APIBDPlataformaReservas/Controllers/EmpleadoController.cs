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
    public class EmpleadoController : ApiController
    {
        // GET api/<controller
        public List<Empleado> Get()
        {
            return EmpleadoData.Listar();
        }

        // GET controller >/5
        public List<Empleado> get(string Id_Empleado)
        {
            return EmpleadoData.ObtenerEmpleado(Id_Empleado);
        }
        // POST controller
        public bool Post([FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.RegistrarEmpleado(oEmpleado);

        }
        // PUT controller >/5
        public bool Put([FromBody] Empleado oEmpleado)
        {
            return EmpleadoData.ActualizarEmpleado(oEmpleado);
        }

        // DELETE controller >/5
        public bool Delete(string Id_Empleado)
        {
            return EmpleadoData.EliminarEmpleado(Id_Empleado);
        }
    }
}