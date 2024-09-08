using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class DetallesReservasData
    {
        /* registrar Detallesreserva*/
        public static bool RegistrarDetallesReservas(DetallesReservas oDetallesReservas)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_registrarDetallesReservas '" + oDetallesReservas.Id_DetalleReserva + "','" + oDetallesReservas.Id_Reserva + "','" + oDetallesReservas.Id_habiatacion + "','" + oDetallesReservas.NumeroPersonas + "','" + oDetallesReservas.ValorTotal + "','" + oDetallesReservas.Condiciones + "','" + oDetallesReservas.Observaciones + "','" + oDetallesReservas.EstadoReserva +  "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }
        /* ACTUALIZAR Detallesreserva*/
        public static bool ActualizarDetallesReservas(DetallesReservas oDetallesReservas)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ActualizarDetallesReserva '" + oDetallesReservas.Id_DetalleReserva + "','" + oDetallesReservas.Id_Reserva + "','" + oDetallesReservas.Id_habiatacion + "','" + oDetallesReservas.NumeroPersonas + "','" + oDetallesReservas.ValorTotal + "','" + oDetallesReservas.Condiciones + "','" + oDetallesReservas.Observaciones + "','" + oDetallesReservas.EstadoReserva +  "'";
            if (objEst.EjecutarSentencia(sentencia, false)) 
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR Detallesreserva*/
        public static bool EliminarDetalleReserva(string Id_DetalleReserva)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia =
    "EXECUTE usp_eliminarDetalleReserva '" + Id_DetalleReserva + "'";
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
        /* LISTAR Detallesreserva*/
        public static List<DetallesReservas> Listar()
        {
            List<DetallesReservas> oListaDetallesReserva = new List<DetallesReservas>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarDetalleReserva ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaDetallesReserva.Add(new DetallesReservas()
                    {
                        Id_DetalleReserva = dr[" Id_DetalleReserva"].ToString(),
                        Id_Reserva = dr[" Id_Reserva"].ToString(),
                        Id_habiatacion = dr["Id_habiatacion"].ToString(),
                        NumeroPersonas = dr["NumeroPersonas"].ToString(),
                        ValorTotal = Convert.ToInt32(dr[" ValorTotal"].ToString()),
                        Condiciones = dr["Condiciones"].ToString(),
                       Observaciones = dr["Observaciones"].ToString(),
                        EstadoReserva = dr["EstadoReserva"].ToString()

                    });
                }
                return oListaDetallesReserva;
            }
            else
                return oListaDetallesReserva;
        }
        /* Consultar Detallesreserva*/
        public
static List<DetallesReservas> ObtenerDetallesReservas(string Id_DetalleReserva)
        {
            List<DetallesReservas> oListaDetallesReservas = new List<DetallesReservas>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerDetallesReservas '" + Id_DetalleReserva + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaDetallesReservas.Add(new DetallesReservas()
                    {
                        Id_DetalleReserva = dr[" Id_DetalleReserva"].ToString(),
                        Id_Reserva = dr["Id_Reserva"].ToString(),
                        Id_habiatacion = dr["Id_habiatacion"].ToString(),
                        NumeroPersonas = dr["NumeroPersonas"].ToString(),
                        ValorTotal = Convert.ToInt32(dr[" ValorTotal"].ToString()),
                        Condiciones = dr["Condiciones"].ToString(),
                        Observaciones = dr["Observaciones"].ToString(),
                        EstadoReserva = dr["EstadoReserva"].ToString()
                    });
                }

                return oListaDetallesReservas;
            }
            else
                return oListaDetallesReservas;
        }


    }
}