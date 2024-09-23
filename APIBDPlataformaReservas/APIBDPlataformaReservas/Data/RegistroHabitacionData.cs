using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class RegistroHabitacionData
    {
        /*REGISTRAR Habitacion*/
        public static bool RegistrarHabitacion(RegistroHabitacion oHabitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "Execute usp_RegistrarHabitacion '" + oHabitacion.AlojamientoID + "','" + oHabitacion.TipoHabitacion+ "','" + oHabitacion.Descripcion + "','" + oHabitacion.PrecioNoche + "','" + oHabitacion.Estado + "'"; 
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }
       


        /* ACTUALIZAR Habitacion*/
        public static bool ActualizarHabitacion(RegistroHabitacion oHabitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "Execute usp_actualizarHabitacion '" + oHabitacion.HabitacionID + "','" + oHabitacion.AlojamientoID + "','" + oHabitacion.TipoHabitacion + "','" + oHabitacion.Descripcion + "','" + oHabitacion.PrecioNoche +  "','" + oHabitacion.Estado + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }
      

        /* ELIMINAR Habitacion*/
        public static bool EliminarHabitacion(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia ="EXECUTE usp_eliminarhabitacion '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR Habitacion*/
        public static List<RegistroHabitacion> Listar()
        {
            List<RegistroHabitacion> oListaHabitacion = new List<RegistroHabitacion>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia ="EXECUTE usp_ListarHabitacion";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaHabitacion.Add(new RegistroHabitacion()
                    {
                        HabitacionID = Convert.ToInt32(dr["HabitacionID"]),
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        TipoHabitacion = dr["TipoHabitacion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        PrecioNoche = Convert.ToInt32(dr["PrecioNoche"]),
                        Estado = dr["Estado"].ToString()

                    });
                }
                return oListaHabitacion;
            }
            else
                return oListaHabitacion;
        }

        /* Consultar Habitacion*/
        public
static List<RegistroHabitacion> ObtenerHabitacion(string id)
        {
            List<RegistroHabitacion> oListahabitacion = new List<RegistroHabitacion>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerhabitacion '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListahabitacion.Add(new RegistroHabitacion()
                    {
                        HabitacionID = Convert.ToInt32(dr["HabitacionID"]),
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        TipoHabitacion = dr["TipoHabitacion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        PrecioNoche = Convert.ToInt32(dr["PrecioNoche"]),
                        Estado = dr["Estado"].ToString()

                    });
                }

                return oListahabitacion;
            }
            else
                return oListahabitacion;
        }


    }

}

