using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class AdministradorData
    {
        public static bool RegistrarAdministrador(Administrador oAdministrador)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarAdministrador'" + oAdministrador.IdAdministrador + "','" + oAdministrador.IdUsuario + "'";
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
        public static bool ActualizarAdministrador(Administrador oAdministrador)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_actualizarAdministrador'" + oAdministrador.IdAdministrador + "','" + oAdministrador.IdUsuario + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR Administrador*/
        public static bool eliminarAdministrador(string IdAdministrador)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarAdministrador '" + IdAdministrador + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* LISTAR Administrador*/
        public static List<Administrador> Listar()
        {
            List<Administrador> oListaAdministrador = new List<Administrador>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarAdministrador ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaAdministrador.Add(new Administrador()
                    {
                        IdAdministrador = dr[" IdAdministrador"].ToString(),
                        IdUsuario = dr["nombre_servicio"].ToString()




                    });
                }
                return oListaAdministrador;
            }
            else
                return oListaAdministrador;
        }

        /* Consultar servicios*/
        public static List<Administrador> ObtenerAdministrador(string IdAdministrador)
        {
            List<Administrador> oListarAdministrador = new List<Administrador>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerAdministrador '" + IdAdministrador + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarAdministrador.Add(new Administrador()
                    {
                        IdAdministrador = dr[" IdAdministrador"].ToString(),
                        IdUsuario = dr["IdUsuario"].ToString()


                    });
                }

                return oListarAdministrador;
            }
            else
                return oListarAdministrador;
        }
    }
}