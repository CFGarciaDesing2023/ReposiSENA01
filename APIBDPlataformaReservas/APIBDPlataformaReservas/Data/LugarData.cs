using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class LugarData
    {
        /*REGISTRAR Lugar*/
        public static bool registrarLugar(Lugar oLugar)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarLugar'" + oLugar.Id_Alojamiento + "','" + oLugar.Id_Administrador + "','" + oLugar.Id_Alojamiento + "','" + oLugar.CodTipoAlojamiento + "','" + oLugar.Nombre + "','" + oLugar.Ubicacion + "','" + oLugar.Calificacion + "','" + oLugar.Telefono + "','" + oLugar.Instalaciones + "'";
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
        public static bool usp_actualizarLugar(Lugar oLugar)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarLugar'" + oLugar.Id_Alojamiento + "','" + oLugar.Id_Administrador + "','" + oLugar.Id_Alojamiento + "','" + oLugar.CodTipoAlojamiento + "','" + oLugar.Nombre + "','" + oLugar.Ubicacion + "','" + oLugar.Calificacion + "','" + oLugar.Telefono + "','" + oLugar.Instalaciones + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR Lugar*/
        public static bool eliminarLugar(string Id_Alojamiento)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia =
    "EXECUTE usp_eliminarLugar '" + Id_Alojamiento + "'";
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
        public static List<Lugar> Listar()
        {
            List<Lugar> oListaLugar = new List<Lugar>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarLugar ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaLugar.Add(new Lugar()
                    {
                        Id_Alojamiento = dr[" Id_Alojamiento"].ToString(),
                        Id_Administrador = dr["Id_Administrador"].ToString(),
                        CodTipoAlojamiento = dr["CodTipoAlojamiento"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Ubicacion = dr["Ubicacion"].ToString(),
                        Calificacion = dr["Calificacion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Instalaciones = dr["Instalaciones"].ToString()
                     
                        

                    });
                }
                return oListaLugar;
            }
            else
                return oListaLugar;
        }

        /* Consultar LUGAR*/
        public
static List<Lugar> ObtenerLugar(string Id_Alojamiento)
        {
            List<Lugar> oListaLugar = new List<Lugar>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerLugar '" + Id_Alojamiento + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaLugar.Add(new Lugar()
                    {
                        Id_Alojamiento = dr[" Id_Alojamiento"].ToString(),
                        Id_Administrador = dr["Id_Administrador"].ToString(),
                        CodTipoAlojamiento = dr["CodTipoAlojamiento"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Ubicacion = dr["Ubicacion"].ToString(),
                        Calificacion = dr["Calificacion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Instalaciones = dr["Instalaciones"].ToString()


                    });
                }

                return oListaLugar;
            }
            else
                return oListaLugar;
        }
    }
}