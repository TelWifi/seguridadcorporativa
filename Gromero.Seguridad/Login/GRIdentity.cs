using Csla;
using Csla.Data;
using Csla.Security;
using ErickOrlando.Utilidades.Data;
using GRomeroAD.DirectoryServices;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Gromero.Seguridad.Login
{
	/// <summary>
	/// Representa la Identidad del Usuario
	/// </summary>
	[Serializable]
	internal class GRIdentity : CslaIdentityBase<GRIdentity>
	{

		#region Metodos Fabricas
		public static GRIdentity GetIdentity(string userName, string passWord, string Dominio)
		{
			return DataPortal.Fetch<GRIdentity>(new FiltroGRomero(userName, passWord, Dominio));
		}

		public static GRIdentity GetIdentity(string userName, string password)
		{
			return DataPortal.Fetch<GRIdentity>(new UsernameCriteria(userName, password));
		}

		internal static GRIdentity GetIdentity(FiltroUsuario criteria)
		{
			return DataPortal.Fetch<GRIdentity>(criteria);
		}

		public static GRIdentity GetIdentity(Guid IdPerfilUsuario)
		{
			return DataPortal.Fetch<GRIdentity>(IdPerfilUsuario);
		}

		public static GRIdentity GetIdentity()
		{
			return DataPortal.Fetch<GRIdentity>();
		}

		public GRIdentity()
		{
			var acronimo = ConfigurationManager.AppSettings["AcronimoAplicacion"] as string;
			if (!string.IsNullOrEmpty(acronimo))
			{
				ApplicationContext.GlobalContext["Acronimo"] = acronimo;
			}
		}

		#endregion

		#region Filtro de Usuario
		[Serializable]
		private class FiltroGRomero : UsernameCriteria
		{
			public string Dominio { get; set; }

			public FiltroGRomero(string userName, string password, string dominio)
				: base(userName, password)
			{
				Dominio = dominio;
			}
		}
		[Serializable]
		internal class FiltroUsuario
		{
			public string Usuario { get; set; }
			public string Dominio { get; set; }

			public FiltroUsuario(string _usuario, string _dominio)
			{
				Usuario = _usuario;
				Dominio = _dominio;
			}
		}

		#endregion



		#region Data Access

		private void DataPortal_Fetch(FiltroUsuario criteria)
		{
			using (var cn = new SqlConnection(BaseDatos.ConexionBD))
			{
				cn.Open();
				using (var cmd = cn.CreateCommand())
				{
					cmd.CommandText = "usp_GetInfoUser";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@Usuario", criteria.Usuario);
					cmd.Parameters.AddWithValue("@Dominio", criteria.Dominio);
					//Recuperamos el Acronimo
					var acronimo = Csla.ApplicationContext.GlobalContext["Acronimo"] as string;
					cmd.Parameters.AddWithValue("@Acronimo", acronimo ?? string.Empty);
					using (var dr = cmd.ExecuteReader())
					{
						if (dr.Read())
							Fetch(dr);
						else
							SetNonUserData();
					}
				}
			}
		}

		private void DataPortal_Fetch(FiltroGRomero criteria)
		{
			//Logueo en el Dominio
			//Usamos los servicios del Active Directory
			IsAuthenticated = GRomeroDirectory.LoguearEnDominio(new WinCredentials(
																	criteria.Username,
																	criteria.Password,
																	criteria.Dominio));
			if (IsAuthenticated)
			{
				Name = criteria.Username;
				AuthenticationType = "Csla";
			}
			else
				SetNonUserData();

		}

		private void DataPortal_Fetch(UsernameCriteria criteria)
		{
			using (var cn = new SqlConnection(BaseDatos.ConexionBD))
			{
				cn.Open();
				using (var cmd = cn.CreateCommand())
				{
					cmd.CommandText = "usp_LoginUser";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@Usuario", criteria.Username);
					cmd.Parameters.AddWithValue("@Clave", criteria.Password);
					//Recuperamos el Acronimo
					var acronimo = Csla.ApplicationContext.GlobalContext["Acronimo"] as string;
					cmd.Parameters.AddWithValue("@Acronimo", acronimo ?? string.Empty);

					using (var dr = cmd.ExecuteReader())
					{
						if (dr.Read())
							Fetch(dr);
						else
							SetNonUserData();
					}
				}
			}
		}

		private void DataPortal_Fetch(Guid IdPerfilUsuario)
		{
			using (var cn = new SqlConnection(BaseDatos.ConexionBD))
			{
				cn.Open();
				using (var cmd = cn.CreateCommand())
				{
					cmd.CommandText = "usp_LoginUserByPerfil";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IdPerfilUsuario", IdPerfilUsuario.ToString());
					using (var dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							InfoUsuario.Initialize();
							InfoUsuario.Instancia.FechaUltimoIngreso = dr.GetDateTime("UltimoIngreso");
							InfoUsuario.Instancia.IdUsuario = dr.GetString("IdUsuario");
							InfoUsuario.Instancia.IdPerfilUsuario = dr.GetString("IdPerfilUsuario");
							InfoUsuario.Instancia.Acronimo = dr.GetString("Acronimo");
							InfoUsuario.Instancia.NombresCompletos = dr.GetString("NombresCompletos");
							InfoUsuario.Instancia.CorreoUsuario = dr.GetString("CorreoUsuario");
							InfoUsuario.Instancia.Dominio = dr.GetString("Dominio");
							InfoUsuario.Instancia.Tipo = (dr.GetString("Tipo") == "I");
							IsAuthenticated = true;
							Name = dr.GetString("NombreUsuario");
							GetRoles();
						}
						else
							SetNonUserData();
					}
				}
			}
		}

		private void DataPortal_Fetch()
		{
			Name = "Anonimo";
			IsAuthenticated = true;
		}

		private void Fetch(IDataReader dr)
		{
			InfoUsuario.Initialize();
			InfoUsuario.Instancia.IdUsuario = dr.GetString("IdUsuario");
			Name = dr.GetString("CodigoUsuario");
			if (!dr.GetBoolean("Estado"))
				throw new UsuarioNoActivoException() { NombreUsuario = Name };

			InfoUsuario.Instancia.NombresCompletos = dr.GetString("NombresCompletos");
			InfoUsuario.Instancia.CorreoUsuario = dr.GetString("CorreoUsuario");
			InfoUsuario.Instancia.Tipo = (dr.GetString("Tipo") == "I");
			InfoUsuario.Instancia.Dominio = dr.GetString("Dominio");
			InfoUsuario.Instancia.FechaUltimoIngreso = dr.GetDateTimeNow("UltimoIngreso");
			InfoUsuario.Instancia.IdPerfilUsuario = dr.GetString("IdPerfilUsuario");
			InfoUsuario.Instancia.Acronimo = dr.GetString("Acronimo");

			GetRoles();

			//Solo si el Usuario es Externo, y además está presente el campo de Cantidad de Claves....
			if (dr.ExisteCampo("CantClaves") && dr.GetString("Tipo") == "E" && dr.GetInt32("CantClaves") < 1)
				throw new UsuarioSinClaveException() { NombreUsuario = Name };

			IsAuthenticated = true;
			AuthenticationType = "Csla";

			//Guardamos los valores
			InfoUsuario.Instancia.SaveParametros();
		}

		private void SetNonUserData()
		{
			base.Name = string.Empty;
			base.IsAuthenticated = false;
			base.AuthenticationType = string.Empty;
			base.Roles = new Csla.Core.MobileList<string>();
		}

		private void GetRoles()
		{
			Roles = new Csla.Core.MobileList<string>();
			using (var cn = new SqlConnection(BaseDatos.ConexionBD))
			{
				cn.Open();
				using (var cmd = cn.CreateCommand())
				{
					cmd.CommandText = "usp_GetRolesByPerfil";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IdPerfilUsuario", InfoUsuario.Instancia.IdPerfilUsuario);
					using (var dr = new SafeDataReader(cmd.ExecuteReader()))
						while (dr.Read())
							Roles.Add(dr.GetString("NombreRol"));
				}
			}
		}

		#endregion
	}
}
