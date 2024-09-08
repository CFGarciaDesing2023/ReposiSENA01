using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class VentaData
    {
        public static bool RegistrarVenta(venta oVenta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarVenta'" + oVenta.Id_Venta + "','" + oVenta.fecha_venta + "','" + "','" + oVenta.Id_Cliente + "','" + oVenta.Id_Empleado + oVenta.Id_Alojamiento + "','" + oVenta.MontoVenta +  "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ACTUALIZAR Habitacion*/
        public static bool ActualizarVenta(venta oVenta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarVenta'" + oVenta.Id_Venta + "','" + oVenta.fecha_venta + "','" + "','" + oVenta.Id_Cliente + "','" + oVenta.Id_Empleado + oVenta.Id_Alojamiento + "','" + oVenta.MontoVenta + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR Reserva*/
        public static bool EliminarVenta(string Id_Venta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarVenta '" + Id_Venta + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR Reserva*/
        public static List<venta> Listar()
        {
            List<venta> oListaVenta = new List<venta>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarVenta ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaVenta.Add(new venta()
                    {
                        Id_Venta = dr[" Id_Venta"].ToString(),
                        fecha_venta = Convert.ToDateTime(dr["fecha_venta"].ToString()),
                        Id_Cliente = dr["Id_Cliente"].ToString(),
                        Id_Empleado = dr["Id_Empleado"].ToString(),
                        Id_Alojamiento = dr["Id_Alojamiento"].ToString(),
                        MontoVenta = Convert.ToInt32(dr["MontoVenta"].ToString())




                    });
                }
                return oListaVenta;
            }
            else
                return oListaVenta;
        }

        /* Consultar LUGAR*/
        public static List<venta> ObtenerVenta(string Id_Venta)
        {
            List<venta> oListarVenta = new List<venta>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerVenta '" + Id_Venta + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarVenta.Add(new venta()
                    {
                        Id_Venta = dr[" Id_Reservas"].ToString(),
                        fecha_venta = Convert.ToDateTime(dr["fecha_venta"].ToString()),
                        Id_Cliente = dr["Id_Cliente"].ToString(),
                        Id_Empleado= dr["Id_Empleado"].ToString(),
                        Id_Alojamiento = dr["Id_Alojamiento"].ToString(),
                        MontoVenta = Convert.ToInt32(dr["MontoVenta"].ToString())

                    });
                }

                return oListarVenta;
            }
            else
                return oListarVenta;
        }
    }
}