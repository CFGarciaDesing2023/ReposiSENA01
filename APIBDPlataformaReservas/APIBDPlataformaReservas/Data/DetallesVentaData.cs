using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class DetallesVentaData
    {
        /* registrar DetallesVenta*/
        public static bool RegistrarDetallesVenta(DetallesVenta oDetallesVenta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_registrarDetallesVenta '" + oDetallesVenta.IdDetallesVenta + "','" + oDetallesVenta.IdVenta + "','" + oDetallesVenta.Id_Producto + "','" + oDetallesVenta.Id_servicio + "','" + oDetallesVenta.fechaInicia + "','" + oDetallesVenta.FechaFin + "','" + oDetallesVenta.valorAPagar + "','" + oDetallesVenta.cantidad + "','" + oDetallesVenta.EstadoVenta + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }
        /* ACTUALIZAR DetallesVenta*/
        public static bool ActualizarDetallesVenta(DetallesVenta oDetallesVenta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ActualizarDetallesVenta '" + oDetallesVenta.IdDetallesVenta + "','" + oDetallesVenta.IdVenta + "','" + oDetallesVenta.Id_Producto + "','" + oDetallesVenta.Id_servicio + "','" + oDetallesVenta.fechaInicia + "','" + oDetallesVenta.FechaFin + "','" + oDetallesVenta.valorAPagar + "','" + oDetallesVenta.cantidad + "','" + oDetallesVenta.EstadoVenta + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR DetallesVenta*/
        public static bool EliminarDetalleVenta(string Id_DetalleVenta)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia =
    "EXECUTE usp_eliminarDetalleVenta '" + Id_DetalleVenta + "'";
            if (
            objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }
        /* LISTAR DetallesVenta*/
        public static List<DetallesVenta> Listar()
        {
            List<DetallesVenta> oListaDetallesVenta = new List<DetallesVenta>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarDetalleVenta ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaDetallesVenta.Add(new DetallesVenta()
                    {
                        IdDetallesVenta = dr[" IdDetallesVenta"].ToString(),
                        IdVenta = dr[" IdVenta"].ToString(),
                        Id_Producto = dr["Id_Producto "].ToString(),
                        Id_servicio = dr["Id_servicio"].ToString(),
                        fechaInicia = Convert.ToDateTime(dr["fechaInicia"].ToString()),
                        FechaFin = Convert.ToDateTime(dr["FechaFin"].ToString()),
                        valorAPagar = Convert.ToInt32(dr[" valorAPagar"].ToString()),
                        cantidad = dr["cantidad"].ToString(),
                        EstadoVenta = dr["EstadoVenta"].ToString()

                    });
                }
                return oListaDetallesVenta;
            }
            else
                return oListaDetallesVenta;
        }
        /* Consultar DetallesVenta*/
        public
static List<DetallesVenta> ObtenerDetallesVenta(string Id_DetallesVenta)
        {
            List<DetallesVenta> oListaDetallesVenta = new List<DetallesVenta>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerDetallesVenta '" + Id_DetallesVenta + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaDetallesVenta.Add(new DetallesVenta()
                    {
                        IdDetallesVenta = dr[" IdDetallesVenta"].ToString(),
                        IdVenta = dr[" IdVenta"].ToString(),
                        Id_Producto = dr["Id_Producto "].ToString(),
                        Id_servicio = dr["Id_servicio"].ToString(),
                        fechaInicia = Convert.ToDateTime(dr["fechaInicia"].ToString()),
                        FechaFin = Convert.ToDateTime(dr["FechaFin"].ToString()),
                        valorAPagar = Convert.ToInt32(dr[" valorAPagar"].ToString()),
                        cantidad = dr["cantidad"].ToString(),
                        EstadoVenta = dr["EstadoVenta"].ToString()
                    });
                }

                return oListaDetallesVenta;
            }
            else
                return oListaDetallesVenta;
        }

    }
}