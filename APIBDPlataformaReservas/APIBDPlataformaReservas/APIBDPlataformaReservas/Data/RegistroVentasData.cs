using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class RegistroVentasData
    {
        /* Registrar VENTA*/
        public static bool RegistrarVenta(RegistroVentas oVenta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_RegistrarVenta '" + oVenta.ClienteID + "','" + oVenta.AlojamientoID + "','" + oVenta.EmpleadoID + "','" + oVenta.ProductoID + "','" + oVenta.CantidadVendida+ "','" + oVenta.Precio_Unitario + "','"+oVenta.Total + "','"+oVenta.EstadoVenta + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ACTUALIZAR VENTA*/
        public static bool ActualizarVenta(RegistroVentas oVenta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ActualizarVenta '" + oVenta.ClienteID + "','" + oVenta.AlojamientoID + "','" + oVenta.EmpleadoID + "','" + oVenta.ProductoID + "','" + oVenta.CantidadVendida + "','" + oVenta.Precio_Unitario + "','" + oVenta.Total + "','" + oVenta.EstadoVenta + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR VENTA*/
        public static bool EliminarVenta(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarVenta '" + id+"'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR VENTA*/
        public static List<RegistroVentas> Listar()
        {
            List<RegistroVentas> oListaVenta = new List<RegistroVentas>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "Execute usp_listarVentas"; 

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaVenta.Add(new RegistroVentas()
                    {
                        VentaID = Convert.ToInt32(dr["VentaID"]),
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]),
                        FechaVenta = Convert.ToDateTime(dr["FechaVenta"].ToString()),
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        CantidadVendida = Convert.ToInt32(dr["CantidadVendida"]),
                        Precio_Unitario = Convert.ToInt32(dr["Precio_Unitario"]),
                        Total = Convert.ToInt32(dr["Total"]),
                        EstadoVenta = dr["EstadoVenta"].ToString()

                    });
                }
                return oListaVenta;
            }
            else
                return oListaVenta;
        }

        /* Consultar VENTA*/
        public static List<RegistroVentas> ObtenerVenta(string id)
        {
            List<RegistroVentas> oListarVenta = new List<RegistroVentas>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerVenta'" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarVenta.Add(new RegistroVentas()
                    {
                        VentaID = Convert.ToInt32(dr["VentaID"]),
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]),
                        FechaVenta = Convert.ToDateTime(dr["FechaVenta"].ToString()),
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        CantidadVendida = Convert.ToInt32(dr["CantidadVendida"]),
                        Precio_Unitario = Convert.ToInt32(dr["Precio_Unitario"]),
                        Total = Convert.ToInt32(dr["Total"]),
                        EstadoVenta = dr["EstadoVenta"].ToString()

                    });
                }

                return oListarVenta;
            }
            else
                return oListarVenta;
        }
    }
}