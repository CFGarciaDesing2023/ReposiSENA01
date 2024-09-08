using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class TiposDocumentosData
    {
        
        /* LISTAR Tipos Documentos*/
        public static List<TiposDocumentos> Listar()
        {
            List<TiposDocumentos> oListaTiposDocumentos = new List<TiposDocumentos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "select * from TiposDocumentos";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaTiposDocumentos.Add(new TiposDocumentos()
                    {
                        IdTipoDocumento = dr["IdTipoDocumento"].ToString(),
                        NombreTipoDocumento = dr["NombreTipoDocumento"].ToString(),
                        DescripcionTipoDocumento = dr["DescripcionTipoDocumento"].ToString()



                    });
                }
                return oListaTiposDocumentos;
            }
            else
                return oListaTiposDocumentos;
        }

       

    }
}


    
