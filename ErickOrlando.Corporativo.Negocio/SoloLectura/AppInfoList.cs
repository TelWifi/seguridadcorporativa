using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using System.Data.SqlClient;
using System.Data;
using Csla.Data;

namespace Gromero.Corporativo.SoloLectura
{
    [Serializable]
    public class AppInfoList :
      ReadOnlyListBase<AppInfoList, AppInfo>
    {
        #region Factory Methods

        public static AppInfoList GetAppInfoList(string filtro)
        {
            return DataPortal.Fetch<AppInfoList>(filtro);
        }

        private AppInfoList()
        { /* require use of factory methods */ }

        #endregion

        #region Data Access

        private void DataPortal_Fetch(string criteria)
        {
            RaiseListChangedEvents = false;
            IsReadOnly = false;

            using (var cn = new SqlConnection(BaseDatos.ConexionBD))
            {
                cn.Open();
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "usp_SelectPerfilesByUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", criteria);
                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            this.Add(AppInfo.GetAppInfo(dr));
                            //if (Contains(app))
                            //{
                            //    var aplicacion = this.Single(p => p.NombreApp.Equals(app.NombreApp));
                            //    aplicacion.Perfiles.Add(PerfilInfo.GetPerfilInfo(dr));
                            //}
                            //else
                            //{
                            //    Add(app);
                            //    app.Perfiles.Add(PerfilInfo.GetPerfilInfo(dr));
                            //}
                        }
                    }
                }
            }

            IsReadOnly = true;
            RaiseListChangedEvents = true;
        }

        #endregion
    }
}
