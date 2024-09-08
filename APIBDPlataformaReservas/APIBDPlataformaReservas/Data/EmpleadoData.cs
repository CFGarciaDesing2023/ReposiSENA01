using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class EmpleadoData
    {
        public static bool RegistrarEmpleado(Empleado oEmpleado)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarEmpleado'" + oEmpleado.IdEmpleado + "','" + oEmpleado.IdUsuario + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ACTUALIZAR Servicio*/
        public static bool ActualizarEmpleado(Empleado oEmpleado)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarEmpleado'" + oEmpleado.IdEmpleado + "','" + oEmpleado.IdUsuario + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR Cliente*/
        public static bool EliminarEmpleado(string IdEmpleado)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarEmpleado '" + IdEmpleado + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR Servicios*/
        public static List<Empleado> Listar()
        {
            List<Empleado> oListaEmpleado = new List<Empleado>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarEmpleado ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaEmpleado.Add(new Empleado()
                    {
                        IdEmpleado = dr[" IdEmpleado"].ToString(),
                        IdUsuario = dr["IdUsuario"].ToString()




                    });
                }
                return oListaEmpleado;
            }
            else
                return oListaEmpleado;
        }

        /* Consultar servicios*/
        public static List<Empleado> ObtenerEmpleado(string IdEmpleado)
        {
            List<Empleado> oListarEmpleado = new List<Empleado>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerEmpleado'" + IdEmpleado+ "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarEmpleado.Add(new Empleado()
                    {
                        IdEmpleado = dr[" Id_Cliente"].ToString(),
                        IdUsuario = dr["IdUsuario"].ToString()


                    });
                }

                return oListarEmpleado;
            }
            else
                return oListarEmpleado;
        }
    }
}