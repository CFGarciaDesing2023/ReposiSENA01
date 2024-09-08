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
    public class logginData
    {

        /* registrar USUARIO*/
        public static bool registrarUsuario(loggin oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = $"EXECUTE usp_registrarUsuario '{oUsuario.Id_Usuario}', '{oUsuario.nombreUsuario}', '{oUsuario.IdTipoDocumento}', '{oUsuario.NumeroDocumento}', '{oUsuario.Direccion}', '{oUsuario.Telefono}', '{oUsuario.sexo}', '{ oUsuario.FechaNacimiento }', '{oUsuario.emailUsuarios }', '{oUsuario.contraseñaUsuario}', '{oUsuario.CodTipoUsuario}'";
            if (objEst.EjecutarSentencia(sentencia, false)) { 
                objEst = null;
            return false; }
else
                objEst = null;
            return true;
        }
        /* ACTUALIZAR USUARIO*/
        public static bool actualizarUsuario(loggin oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "usp_registrarUsuario '" + oUsuario.Id_Usuario + "','" + oUsuario.nombreUsuario + "','" + oUsuario.IdTipoDocumento + "','" + oUsuario.CodTipoUsuario + "','" + oUsuario.Direccion + "','" + oUsuario.Telefono + "','" + oUsuario.sexo + "','" + oUsuario.FechaNacimiento + "','" + oUsuario.emailUsuarios + "','" + oUsuario.contraseñaUsuario + "'";
            if (objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
                objEst = null;
            return true;
        }

        /* ELIMINAR USUARIO*/
        public static bool eliminarUsuario(string Id_Usuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia =
    "EXECUTE usp_eliminarUsuario '" + Id_Usuario + "'";
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
        /* LISTAR USUARIO*/
        public static List<loggin> Listar()
        {
            List<loggin> oListaUsuario = new List<loggin>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarUsuarios";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new loggin()
                    {
                        Id_Usuario = dr["Id_Usuario"].ToString(),
                        nombreUsuario = dr["nombreUsuario"].ToString(),
                        IdTipoDocumento = dr["IdTipoDocumento"].ToString(),
                        NumeroDocumento = dr["NumeroDocumento"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        sexo = dr["sexo"].ToString(),
                        FechaNacimiento = Convert.ToDateTime (dr ["FechaNacimiento"]. ToString()),
                        emailUsuarios = dr["emailUsuarios"].ToString(),
                        contraseñaUsuario = dr["contraseñaUsuario"].ToString(),
                        CodTipoUsuario = dr["CodTiposUsuario"].ToString()
                    });
                }
                return oListaUsuario;
            }
            else
                return oListaUsuario;
        }
        /* Consultar USUARIO*/
        public
static List<loggin> ObtenerUsuario(string Id_Usuario)
        {
            List<loggin> oListaUsuario = new List<loggin>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerUsuario '" + Id_Usuario + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new loggin()
                    {
                        Id_Usuario = dr[" Id_Usuario"].ToString(),
                        nombreUsuario = dr["nombreUsuario"].ToString(),
                        IdTipoDocumento = dr["IdTipoDocumento"].ToString(),
                        NumeroDocumento = dr["NumeroDocumento"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        sexo = dr["sexo"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"].ToString()),
                        emailUsuarios = dr["emailUsuarios"].ToString(),
                        contraseñaUsuario = dr["contraseñaUsuario"].ToString(),
                        CodTipoUsuario = dr["CodTipoUsuario"].ToString()
                    });
                }

                return oListaUsuario;
            }
            else
                return oListaUsuario;
        }

        
    }

}