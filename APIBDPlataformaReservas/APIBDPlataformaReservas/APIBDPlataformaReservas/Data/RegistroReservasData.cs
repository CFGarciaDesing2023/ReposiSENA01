using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{ 
    public class RegistroReservasData
    {
        /*REGISTRAR RESERVAS*/
        public static bool RegistrarReservas(RegistroReserva oReservas)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_RegistrarReserva '" + oReservas.ClienteID + "','" + oReservas.AlojamientoID + "','" + oReservas.FechaIngreso.ToString("yyyy/MM/dd HH:mm") + "','" + oReservas.FechaSalida.ToString("yyyy/MM/dd HH:mm") + "','" + oReservas.TipoHabitacion + "','" + oReservas.HabitacionID + "','" + oReservas.NumeroPersonas + "','" + oReservas.ValorTotal + "','" + oReservas.Estado + "'";
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

        /* ACTUALIZAR RESERVAS*/

        public static bool ActualizarReservas(RegistroReserva oReservas)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ActualizarReserva '" + oReservas.ReservaID + "','" + oReservas.ClienteID + "','" + oReservas.AlojamientoID + "','" + oReservas.FechaIngreso.ToString("yyyy/MM/dd HH:mm") + "','" + oReservas.FechaSalida.ToString("yyyy/MM/dd HH:mm") + "','" + oReservas.TipoHabitacion + "','" + oReservas.HabitacionID + "','" + oReservas.NumeroPersonas + "','" + oReservas.ValorTotal + "','" + oReservas.Estado + "'";
            System.Diagnostics.Debug.WriteLine("cristian insert" + sentencia);
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

        /* ELIMINAR RESERVAS*/
        public static bool EliminarReserva(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarReservas '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR RESERVAS*/
        public static List<RegistroReserva> Listar()
        {
            List<RegistroReserva> oListaReservas = new List<RegistroReserva>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ListarReserva";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaReservas.Add(new RegistroReserva()
                    {
                        ReservaID = Convert.ToInt32(dr["ReservaID"]),
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString()),
                        FechaSalida = Convert.ToDateTime(dr["FechaSalida"].ToString()),
                        TipoHabitacion = dr["TipoHabitacion"].ToString(),
                        HabitacionID = Convert.ToInt32(dr["HabitacionID"]),
                        NumeroPersonas = Convert.ToInt32(dr["NumeroPersonas"]),
                        ValorTotal = Convert.ToInt32(dr["ValorTotal"]),
                        Estado = dr["Estado"].ToString()

                    });
                }
                return oListaReservas;
            }
            else
                return oListaReservas;
        }

        /* Consultar RESERVAS*/
        public static List<RegistroReserva> ObtenerReservas(string id)
        {
            List<RegistroReserva> oListarReservas = new List<RegistroReserva>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ObtenerReserva '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarReservas.Add(new RegistroReserva()
                    {
                        ReservaID = Convert.ToInt32(dr["ReservaID"]),
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString()),
                        FechaSalida = Convert.ToDateTime(dr["FechaSalida"].ToString()),
                        TipoHabitacion = dr["TipoHabitacion"].ToString(),
                        HabitacionID = Convert.ToInt32(dr["HabitacionID"]),
                        NumeroPersonas = Convert.ToInt32(dr["NumeroPersonas"]),
                        ValorTotal = Convert.ToInt32(dr["ValorTotal"]),
                        Estado = dr["Estado"].ToString()

                    });
                }

                return oListarReservas;
            }
            else
                return oListarReservas;
        }

    }
}