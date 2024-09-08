using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class ClienteData
    {
        public static bool registrarCliente(Cliente oCliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarCliente'" + oCliente.IdCliente + "','" + oCliente.IdUsuario + "'";
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
        public static bool usp_actualizarCliente(Cliente oCliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarCliente'" + oCliente.IdCliente + "','" + oCliente.IdUsuario + "'";
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
        public static bool eliminarCliente(string Id_Cliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarCliente '" + Id_Cliente + "'";
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
        public static List<Cliente> Listar()
        {
            List<Cliente> oListaCliente = new List<Cliente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarCliente ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaCliente.Add(new Cliente()
                    {
                        IdCliente = dr[" Id_Cliente"].ToString(),
                        IdUsuario = dr["IdUsuario"].ToString()
                        



                    });
                }
                return oListaCliente;
            }
            else
                return oListaCliente;
        }

        /* Consultar servicios*/
        public static List<Cliente> ObtenerCliente(string IdCliente)
        {
            List<Cliente> oListarCliente = new List<Cliente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerCliente '" + IdCliente + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarCliente.Add(new Cliente()
                    {
                        IdCliente = dr[" Id_Cliente"].ToString(),
                        IdUsuario = dr["IdUsuario"].ToString()


                    });
                }

                return oListarCliente;
            }
            else
                return oListarCliente;
        }
    }
}