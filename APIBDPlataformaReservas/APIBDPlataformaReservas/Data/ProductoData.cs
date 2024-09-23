using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class ProductoData
    {
        /* Registrar Producto*/
        public static bool RegistrarProducto(Producto oProducto)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_RegistrarProducto '" + oProducto.Nombre + "','" + oProducto.Descripcion + "','" + oProducto.CantidadDisponible + "','" + oProducto.Estado + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        /* ACTUALIZAR Producto*/
        public static bool ActualizarProducto(Producto oProducto)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ActualizarProducto '" + oProducto.ProductoID + "','" + oProducto.Nombre + "','" + oProducto.Descripcion + "','" + oProducto.CantidadDisponible + "','" + oProducto.Estado + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }

        }



        /* ELIMINAR Producto*/
        public static bool EliminarProducto(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarProducto '" + id + "'";
            
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
                
        }
        /* LISTAR Producto*/
        public static List<Producto> Listar()
        {
            List<Producto> oListaProducto= new List<Producto>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "Execute usp_ListarProducto";

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaProducto.Add(new Producto()
                    {

                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        CantidadDisponible = Convert.ToInt32(dr["CantidadDisponible"]),
                        Estado = dr["Estado"].ToString()
                        


                    });
                }
                return oListaProducto;
            }
            else
                return oListaProducto;
        }
        /* Consultar Producto*/
        public static List<Producto> ObtenerProducto(string id)
        {
            List<Producto> oListaProducto = new List<Producto>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = $"EXECUTE usp_ObtenerProducto  '" + id + "'";

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaProducto.Add(new Producto()
                    {
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        CantidadDisponible = Convert.ToInt32(dr["CantidadDisponible"]),
                        Estado = dr["Estado"].ToString()


                    });
                }

                return oListaProducto;
            }
            else
                return oListaProducto;
        }
    }
}