using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ErickOrlando.Utilidades.Data;

namespace ErickOrlando.Seguridad.Entidades
{
    /// <summary>
    /// Lista de Dominios
    /// </summary>
    public class DominioInfoList : List<DominioInfo>
    {
        private DominioInfoList()
        {

        }

        /// <summary>
        /// Devuelve la lista de Dominios
        /// </summary>
        /// <returns></returns>
        public static DominioInfoList GetDominioInfoList()
        {
            var lista = new DominioInfoList();

            using (var cn = new SqlConnection(BaseDatos.ConexionBD))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "usp_DominiosSelectAll";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cn.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DominioInfo(dr.GetString("NombreCorto"), dr.GetString("RutaDominio")));
                        }
                    }
                }
            }

            return lista;
        }
    }
}
