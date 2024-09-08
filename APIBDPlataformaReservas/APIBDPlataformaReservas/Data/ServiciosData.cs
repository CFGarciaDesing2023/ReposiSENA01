using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class ServiciosData
    {
        public static bool RegistrarServicios(servicios oServicios)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarServicios'" + oServicios.Id_servicio + "','" + oServicios.nombre_servicio + "','" + "','" + oServicios.descripcion_servicio + "','" + oServicios.Tarifa +  "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ACTUALIZAR Servicio*/
        public static bool ActualizarServicios(servicios oServicios)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarServicios'" + oServicios.Id_servicio + "','" + oServicios.nombre_servicio + "','" + "','" + oServicios.descripcion_servicio + "','" + oServicios.Tarifa + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR Servicio*/
        public static bool EliminarServicios(string Id_servicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarServicio '" + Id_servicio + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR Servicios*/
        public static List<servicios> Listar()
        {
            List<servicios> oListaServicios = new List<servicios>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarServicios ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaServicios.Add(new servicios()
                    {
                        Id_servicio = dr[" Id_Servicio"].ToString(),
                        nombre_servicio = dr["nombre_servicio"].ToString(),
                        descripcion_servicio = dr["descripcio_servicio"].ToString(),
                        Tarifa= Convert.ToInt32(dr[" Tarifa"].ToString())



                    });
                }
                return oListaServicios;
            }
            else
                return oListaServicios;
        }

        /* Consultar servicios*/
        public static List<servicios> ObtenerServicios(string Id_servicio)
        {
            List<servicios> oListarServicio = new List<servicios>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerServicios '" + Id_servicio + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarServicio.Add(new servicios()
                    {
                        Id_servicio = dr[" Id_Servicio"].ToString(),
                        nombre_servicio = dr["nombre_servicio"].ToString(),
                        descripcion_servicio = dr["descripcio_servicio"].ToString(),
                        Tarifa = Convert.ToInt32(dr[" Tarifa"].ToString())

                    });
                }

                return oListarServicio;
            }
            else
                return oListarServicio;
        }
    }
}