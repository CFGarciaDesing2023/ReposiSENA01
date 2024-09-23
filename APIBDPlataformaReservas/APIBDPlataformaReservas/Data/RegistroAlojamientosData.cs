using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace APIBDPlataformaReservas.Data
{
    public class RegistroAlojamientosData
    {
        /*REGISTRAR ALOJAMIENTO*/
        public static bool RegistrarAlojamiento(RegistroAlojamientos oAlojamiento)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_RegistrarAlojamientos2 '" + oAlojamiento.AdministradorID + "','" + oAlojamiento.TipoAlojamiento + "','" + oAlojamiento.Nombre + "','" + oAlojamiento.Ubicacion + "','" + oAlojamiento.DescripcionInstalaciones + "','" + oAlojamiento.Capacidad_Habitaciones + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }
       
        /* ACTUALIZAR ALOJAMIENTO*/
        public static bool usp_ActualizarAlojamiento(RegistroAlojamientos oAlojamiento)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ActualizarAlojamiento '" + oAlojamiento.AlojamientoID + "','" + oAlojamiento.AdministradorID + "','" + oAlojamiento.TipoAlojamiento + "','" + oAlojamiento.Nombre + "','" + oAlojamiento.Ubicacion + "','"  + oAlojamiento.DescripcionInstalaciones + "','" + oAlojamiento.Capacidad_Habitaciones + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }


        /* ELIMINAR ALOJAMIENTO*/
        public static bool EliminarAlojamiento(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_EliminarAlojamiento '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR ALOJAMIENTO*/
        public static List<RegistroAlojamientos> Listar()
        {
            List<RegistroAlojamientos> oListaAlojamiento = new List<RegistroAlojamientos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarAlojamiento";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaAlojamiento.Add(new RegistroAlojamientos()
                    {
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        AdministradorID = Convert.ToInt32(dr["AdministradorID"]),
                        TipoAlojamiento = dr["TipoAlojamiento"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Ubicacion = dr["Ubicacion"].ToString(),
                        DescripcionInstalaciones = dr["DescripcionInstalaciones"].ToString(),
                        Capacidad_Habitaciones = Convert.ToInt32(dr["Capacidad_Habitaciones"]),
                        FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"].ToString())




                    });
                }
                return oListaAlojamiento;
            }
            else
                return oListaAlojamiento;
        }


        /* Consultar ALOJAMIENTO*/
        public
static List<RegistroAlojamientos> ObtenerLugar(string id)
        {
            List<RegistroAlojamientos> oListaAlojamiento = new List<RegistroAlojamientos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerAlojamiento '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaAlojamiento.Add(new RegistroAlojamientos()
                    {
                        AlojamientoID = Convert.ToInt32(dr["AlojamientoID"]),
                        AdministradorID = Convert.ToInt32(dr["AdministradorID"]),
                        TipoAlojamiento = dr["TipoAlojamiento"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Ubicacion = dr["Ubicacion"].ToString(),
                        Capacidad_Habitaciones = Convert.ToInt32(dr["Capacidad_Habitaciones"]),
                        FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"].ToString())


                    });
                }

                return oListaAlojamiento;
            }
            else
                return oListaAlojamiento;
        }
    }
}
