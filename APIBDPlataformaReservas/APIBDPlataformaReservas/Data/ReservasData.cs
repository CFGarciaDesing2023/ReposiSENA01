using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class ReservasData
    {
        /*REGISTRAR RESERVAS*/
        public static bool RegistrarReservas(Reservas oReservas)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarReservas'" + oReservas.Id_Reserva + "','" + oReservas.Id_Cliente + "','" + oReservas.Id_Alojamiento + "','" + oReservas.fecha_inicio + "','" + oReservas.fecha_fin +  "'";
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
        public static bool ActualizarReservas(Reservas oReservas)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarReservas'" + oReservas.Id_Reserva + "','" + oReservas.Id_Cliente + "','" + oReservas.Id_Alojamiento + "','" + oReservas.fecha_inicio + "','" + oReservas.fecha_fin + "'"; 
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
        public static bool EliminarReserva(string Id_Reserva)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarReservas '" + Id_Reserva + "'";
            if ( objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR Reserva*/
        public static List<Reservas> Listar()
        {
            List<Reservas> oListaReservas = new List<Reservas>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarReservas ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaReservas.Add(new Reservas()
                    {
                        Id_Reserva = dr[" Id_Reservas"].ToString(),
                        Id_Cliente = dr["Id_Cliente"].ToString(),
                        Id_Alojamiento = dr["Id_Alojamiento"].ToString(),
                        fecha_inicio = Convert.ToDateTime(dr["fecha_inicio"].ToString()),
                        fecha_fin = Convert.ToDateTime(dr["fecha_fin"].ToString())
                        



                    });
                }
                return oListaReservas;
            }
            else
                return oListaReservas;
        }

        /* Consultar Reservas*/
        public static List<Reservas> ObtenerReservas(string Id_Reserva)
        {
            List<Reservas> oListarReservas = new List<Reservas>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ObtenerReserva '" + Id_Reserva + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarReservas.Add(new Reservas()
                    {
                        Id_Reserva = dr[" Id_Reservas"].ToString(),
                        Id_Cliente = dr["Id_Cliente"].ToString(),
                        Id_Alojamiento = dr["Id_Alojamiento"].ToString(),
                        fecha_inicio = Convert.ToDateTime(dr["fecha_inicio"].ToString()),
                        fecha_fin = Convert.ToDateTime(dr["fecha_fin"].ToString())


                    });
                }

                return oListarReservas;
            }
            else
                return oListarReservas;
        }

    }
}