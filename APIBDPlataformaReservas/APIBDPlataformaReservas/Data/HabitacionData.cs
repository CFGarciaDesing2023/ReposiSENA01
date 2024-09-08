using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class HabitacionData
    {
        /*REGISTRAR Habitacion*/
        public static bool registrarHabitacion(Models.habitacion oHabitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarhabitacion'" + oHabitacion.Id_habitacion + "','" + oHabitacion.nombre_habitacion + "','" + oHabitacion.Id_Alojamiento + "','" + oHabitacion.Id_tipo_habitacion + "','" + oHabitacion.Descripcion + "','" + oHabitacion.Tarifa + "'";
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
        public static bool usp_actualizarHabitacion(habitacion oHabitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarHabitacion'" + oHabitacion.Id_habitacion + "','" + oHabitacion.nombre_habitacion + "','" + oHabitacion.Id_Alojamiento + "','" + oHabitacion.Id_tipo_habitacion + "','" + oHabitacion.Descripcion + "','" + oHabitacion.Tarifa + "'"; 
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR habitacion*/
        public static bool eliminarHabitacion(string Id_habitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia =
    "EXECUTE usp_eliminarhabitacion '" + Id_habitacion + "'";
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

        /* LISTAR habitacion*/
        public static List<habitacion> Listar()
        {
            List<habitacion> oListaHabitacion = new List<habitacion>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarhabitacion ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaHabitacion.Add(new habitacion()
                    {
                        Id_habitacion = dr[" Id_habitacion"].ToString(),
                        nombre_habitacion = dr["nombre_habitacion"].ToString(),
                        Id_Alojamiento = dr["Id_Alojamiento"].ToString(),
                        Id_tipo_habitacion = dr["Id_tipo_habitacion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Tarifa  = Convert.ToInt32(dr[" Tarifa"].ToString())

                    });
                }
                return oListaHabitacion;
            }
            else
                return oListaHabitacion;
        }

        /* Consultar Habitacion*/
        public
static List<habitacion> ObtenerHabitacion(string Id_habitacion)
        {
            List<habitacion> oListahabitacion = new List<habitacion>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerhabitacion '" + Id_habitacion + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListahabitacion.Add(new habitacion()
                    {
                        Id_habitacion = dr[" Id_habitacion"].ToString(),
                        nombre_habitacion = dr["nombre_habitacion"].ToString(),
                        Id_Alojamiento = dr["Id_Alojamiento"].ToString(),
                        Id_tipo_habitacion = dr["Id_tipo_habitacion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Tarifa = Convert.ToInt32(dr[" Tarifa"].ToString())

                    });
                }

                return oListahabitacion;
            }
            else
                return oListahabitacion;
        }


    }

}

