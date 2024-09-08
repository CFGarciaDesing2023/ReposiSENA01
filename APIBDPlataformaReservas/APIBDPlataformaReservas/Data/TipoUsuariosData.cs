using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class TipoUsuariosData
    {
        

        /* LISTAR habitacion*/
        public static List<TiposUsuarios> Listar()
        {
            List<TiposUsuarios> oListaTipoUsuario = new List<TiposUsuarios>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarTiposUsuarios ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaTipoUsuario.Add(new TiposUsuarios()
                    {
                        IdTipoUsuario = dr[" IdTipoUsuario"].ToString(),
                        NombreTipoUsuario = dr["NombreTipoUsuario"].ToString(),
                        DescripcionTipoUsuario = dr["DescripcionTipoUsuario"].ToString()


                    });
                }
                return oListaTipoUsuario;
            }
            else
                return oListaTipoUsuario;
        }

        
    }
}