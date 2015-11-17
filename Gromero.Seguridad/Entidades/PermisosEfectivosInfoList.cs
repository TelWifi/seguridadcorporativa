using Csla;
using Csla.Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gromero.Seguridad.Entidades
{
	[Serializable]
	internal class PermisosEfectivosInfoList :
	  ReadOnlyListBase<PermisosEfectivosInfoList, PermisosEfectivosInfo>
	{
		#region Factory Methods

		private const string Permisos = "PermisosEfectivos";

		private static PermisosEfectivosInfoList _Lista;

		public static void InvalidateCache()
		{
			if (_Lista == null) return;
			_Lista.IsReadOnly = false;
			_Lista.Clear();
			_Lista.IsReadOnly = true;
			ApplicationContext.LocalContext[Permisos] = null;
		}

		public static PermisosEfectivosInfoList GetPermisosEfectivosInfoList()
		{
			if (ApplicationContext.LocalContext[Permisos] != null)
				_Lista = ApplicationContext.LocalContext[Permisos] as PermisosEfectivosInfoList;
			else
			{
				_Lista = DataPortal.Fetch<PermisosEfectivosInfoList>();
				ApplicationContext.LocalContext[Permisos] = _Lista;
			}
			return _Lista;
		}

		private PermisosEfectivosInfoList()
		{ /* require use of factory methods */ }

		#endregion

		public class FiltroPermisos : IEquatable<FiltroPermisos>
		{
			private FiltroPermisos(string _modulo, string _opcion)
			{
				Modulo = _modulo;
				Opcion = _opcion;
			}

			public string Modulo { get; set; }
			public string Opcion { get; set; }

			#region Miembros de IEquatable<FiltroPermisos>

			public bool Equals(FiltroPermisos other)
			{
				return string.Concat(other.Modulo, other.Opcion).Equals(string.Concat(Modulo, Opcion));
			}

			#endregion

			public override int GetHashCode()
			{
				return string.Concat(Modulo, Opcion).GetHashCode();
			}
		}

		#region Data Access

		private void DataPortal_Fetch()
		{
			RaiseListChangedEvents = false;
			IsReadOnly = false;

			InfoUsuario.Initialize();

			using (var cn = new SqlConnection(BaseDatos.ConexionBD))
			{
				cn.Open();
				using (var cmd = cn.CreateCommand())
				{
					cmd.CommandText = "usp_ConsultarPermisos";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IdPerfilUsuario",
						InfoUsuario.Instancia.IdPerfilUsuario);
					cmd.Parameters.AddWithValue("@Acronimo",
						InfoUsuario.Instancia.Acronimo);
					using (var dr = new SafeDataReader(cmd.ExecuteReader()))
					{
						while (dr.Read())
							Add(PermisosEfectivosInfo.GetPermisosEfectivosInfo(dr));
					}
				}
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

		#endregion
	}
}
