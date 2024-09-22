using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using APIBDPlataformaReservas.Models;
using System.Web.Http.Cors;

namespace APIBDPlataformaReservas.Data
{
    public class RegistroUsuarioData
    {


        /* Registrar USUARIO*/
        public static bool registrarUsuario(RegistroUsuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_RegistrarUsuarios '" + oUsuario.NumeroDocumento + "','" + oUsuario.Email + "','" + oUsuario.Contraseña + "','" + oUsuario.TipoUsuario + "','" + oUsuario.TipoDocumento + "','" + oUsuario.NumeroDocumento + "','" + oUsuario.Nombres + "','" + oUsuario.Apellidos + "'";
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

        /* ACTUALIZAR USUARIO*/
        public static bool ActualizarUsuario(RegistroUsuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_ActualizarUsuario '" + oUsuario.NumeroDocumento + "','" + oUsuario.Email + "','" + oUsuario.Contraseña + "','" + oUsuario.TipoUsuario + "','" + oUsuario.TipoDocumento + "','" + oUsuario.NumeroDocumento+ "','" + oUsuario.Nombres + "','" + oUsuario.Apellidos + "'";
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
        


        /* ELIMINAR USUARIO*/
        public static bool EliminarUsuario(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminarUsuario '" + id + "'";
           
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }
        /* LISTAR USUARIO*/
        public static List<RegistroUsuario> Listar()
        {
            List<RegistroUsuario> oListaUsuario = new List<RegistroUsuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia ="Execute usp_listarUsuarios";
           
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new RegistroUsuario()
                    {

                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        Email = dr["Email"].ToString(),
                        Contraseña = dr["Contraseña"].ToString(),
                        TipoUsuario = dr["TipoUsuario"].ToString(),
                        TipoDocumento = dr["TipoDocumento"].ToString(),
                        NumeroDocumento = Convert.ToInt32(dr["NumeroDocumento"]),
                        Nombres = dr["Nombres"].ToString(),
                        Apellidos = dr["Apellidos"].ToString()
                       


                    });
                }
                return oListaUsuario;
            }
            else
                return oListaUsuario;
        }
        /* Consultar USUARIO*/
       
        public static List<RegistroUsuario> ObtenerUsuario(string id)
        {
            List<RegistroUsuario> oListaUsuario = new List<RegistroUsuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = $"EXECUTE usp_ObtenerUsuario  '" + id +"'";
           
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new RegistroUsuario()
                    {
                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        Email = dr["Email"].ToString(),
                        Contraseña = dr["Contraseña"].ToString(),
                        TipoUsuario = dr["TipoUsuario"].ToString(),
                        TipoDocumento = dr["TipoDocumento"].ToString(),
                        NumeroDocumento = Convert.ToInt32(dr["NumeroDocumento"]),
                        Nombres = dr["Nombres"].ToString(),
                        Apellidos = dr["Apellidos"].ToString()


                    });
                }

                return oListaUsuario;
            }
            else
                return oListaUsuario;
        }


     
      


    }

}