using APIBDPlataformaReservas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIBDPlataformaReservas.Data
{
    public class TipoLugarData
    {

        /* LISTAR Reserva*/
        public static List<tipoLugar> Listar()
        {
            List< tipoLugar> oListatipoLugar = new List<tipoLugar>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarTipoLugar";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListatipoLugar.Add(new tipoLugar()
                    {
                        IdTiposAlojamientos = dr[" IdTiposAlojamientos"].ToString(),
                        NombreTiposAlojamientos = dr[" NombreTiposAlojamientos"].ToString(),
                        DescripcionTiposAlojamientos = dr[" DescripcionTiposAlojamientos"].ToString()



                    });
                }
                return oListatipoLugar;
            }
            else
                return oListatipoLugar;
        }


    }
}


