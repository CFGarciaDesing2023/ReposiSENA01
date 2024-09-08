using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    
    public class TipoHabitacionesData
    {
        /*REGISTRAR Lugar*/
        public static bool RegistrarTipoHabitacion(tiposHabitacion oTiposHabitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarTiposHabitacion'" + oTiposHabitacion.Id_tipo_habitacion + "','" + oTiposHabitacion.nombre_tipo_habitacion + "','" + oTiposHabitacion.Descripcion + "'";
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
        public static bool ActualizarTipoHabitacion(tiposHabitacion oTiposHabitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarTipoHabitacion'" + oTiposHabitacion.Id_tipo_habitacion + "','" + oTiposHabitacion.nombre_tipo_habitacion + "','" + oTiposHabitacion.Descripcion + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR TIPOHABITACION*/
        public static bool EliminarTipoHabitacion(string Id_tipo_habitacion)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia =
    "EXECUTE usp_eliminarTipoHabitacion '" + Id_tipo_habitacion + "'";
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

        /* LISTAR LUGAR*/
        public static List<tiposHabitacion> Listar()
        {
            List<tiposHabitacion> oListaTipoHabitacion = new List<tiposHabitacion>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarTipoHabitacion ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaTipoHabitacion.Add(new tiposHabitacion()
                    {
                        Id_tipo_habitacion = dr["Id_tipo_habitacion"].ToString(),
                        nombre_tipo_habitacion = dr["Inombre_tipo_habitacion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                        



                    });
                }
                return oListaTipoHabitacion;
            }
            else
                return oListaTipoHabitacion;
        }

        /* Consultar LUGAR*/
        public
static List<tiposHabitacion> ObtenerTipoHabitacion(string Id_tipo_habitacion)
        {
            List<tiposHabitacion> oListaTipoHabitacion = new List<tiposHabitacion>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerTipoHabitacion '" + Id_tipo_habitacion + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaTipoHabitacion.Add(new tiposHabitacion()
                    {
                        Id_tipo_habitacion = dr["Id_tipo_habitacion"].ToString(),
                        nombre_tipo_habitacion = dr["Inombre_tipo_habitacion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()

                    });
                }

                return oListaTipoHabitacion;
            }
            else
                return oListaTipoHabitacion;
        }
    }
}
    
