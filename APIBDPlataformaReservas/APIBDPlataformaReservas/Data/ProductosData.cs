using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class ProductosData
    {

        public static bool registrarProductos(productos oProductos)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarProductos'" + oProductos.Id_producto + "','" + oProductos.nombreproducto + "','" + "','" + oProductos.descripcion_producto + "','" + oProductos.precio + "','" + oProductos.FechaVencimiento + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ACTUALIZAR Productos*/
        public static bool usp_actualizarProductos(productos oProductos)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarProductos'" + oProductos.Id_producto + "','" + oProductos.nombreproducto + "','" + "','" + oProductos.descripcion_producto + "','" + oProductos.precio + "','" + oProductos.FechaVencimiento + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR Productos*/
        public static bool eliminarProductos(string Id_producto)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarProductos '" + Id_producto + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR Productos*/
        public static List<productos> Listar()
        {
            List<productos> oListaProductos = new List<productos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarProductos ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaProductos.Add(new productos()
                    {
                        Id_producto = dr[" Id_producto"].ToString(),
                        nombreproducto = dr["nombreproducto "].ToString(),
                        descripcion_producto = dr["descripcion_producto"].ToString(),
                        precio = Convert.ToInt32(dr["precio"].ToString()),
                        FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"].ToString())



                    });
                }
                return oListaProductos;
            }
            else
                return oListaProductos;
        }

        /* Consultar Productos*/
        public static List<productos> ObtenerProductos(string Id_producto)
        {
            List<productos> oListarProducto = new List<productos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerProducto '" + Id_producto + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarProducto.Add(new productos()
                    {
                        Id_producto = dr[" Id_producto"].ToString(),
                        nombreproducto = dr["nombreproducto "].ToString(),
                        descripcion_producto = dr["descripcion_producto"].ToString(),
                        precio = Convert.ToInt32(dr["precio"].ToString()),
                        FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"].ToString())


                    });
                }

                return oListarProducto;
            }
            else
                return oListarProducto;
        }

    }
}