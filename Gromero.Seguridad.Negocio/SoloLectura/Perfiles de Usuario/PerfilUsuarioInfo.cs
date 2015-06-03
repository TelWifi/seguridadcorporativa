using Csla;
using Gromero.Seguridad.Datos;
using Gromero.Seguridad.Negocio.Editables;
using System;

namespace Gromero.Seguridad.Negocio.SoloLectura
{
	[Serializable]
	public class PerfilUsuarioInfo : ReadOnlyBase<PerfilUsuarioInfo>
	{
		#region Business Methods

		public string ID { get; set; }
		public string IdUsuario { get; set; }
		public string IdAplicacion { get; set; }
		public string CodigoUsuario { get; set; }
		public string NombresCompletos { get; set; }
		public string Dominio { get; set; }
		public string Alias { get; set; }
		public string AliasAlterno { get; set; }
		public string Correo { get; set; }
		public string CodigoCargo { get; set; }
		public string Cargo { get; set; }
		public string Aplicacion { get; set; }
		public bool Logueado { get; set; }
		public DateTime? UltimoIngreso { get; set; }
		public bool Caduca { get; set; }
		public string Ruta { get; set; }
		public DateTime? VigenciaInicio { get; set; }
		public DateTime? VigenciaFin { get; set; }

		public static readonly PropertyInfo<RolPerfiles> RolesProperty = RegisterProperty<RolPerfiles>(c => c.Roles, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public RolPerfiles Roles
		{
			get
			{
				if (!FieldManager.FieldExists(RolesProperty))
				{
					Roles = RolPerfiles.GetRolPerfiles(ID);
				}
				return GetProperty(RolesProperty);
			}
			private set
			{
				LoadProperty(RolesProperty, value);
				OnPropertyChanged(RolesProperty);
			}
		}

		public static readonly PropertyInfo<RecursosPerfil> RecursosProperty = RegisterProperty<RecursosPerfil>(c => c.Recursos, RelationshipTypes.Child | RelationshipTypes.LazyLoad);
		public RecursosPerfil Recursos
		{
			get
			{
				if (!FieldManager.FieldExists(RecursosProperty))
				{
					Recursos = RecursosPerfil.GetRecursosPerfil(ID);
				}
				return GetProperty(RecursosProperty);
			}
			private set
			{
				LoadProperty(RecursosProperty, value);
				OnPropertyChanged(RecursosProperty);
			}
		}

		#endregion

		#region Factory Methods

		public static PerfilUsuarioInfo GetPerfilUsuarioInfo(PerfilUsuarioComplex data)
		{
			return DataPortal.Fetch<PerfilUsuarioInfo>(data);
		}

		private PerfilUsuarioInfo()
		{ /* require use of factory methods */ }

		#endregion

		#region Data Access

		private void DataPortal_Fetch(PerfilUsuarioComplex criteria)
		{
			ID = criteria.IdPerfilUsuario;
			IdAplicacion = criteria.IdAplicacion;
			IdUsuario = criteria.IdUsuario;
			CodigoUsuario = criteria.CodigoUsuario;
			NombresCompletos = criteria.NombresCompletos;
			Dominio = criteria.Dominio;
			Alias = criteria.Alias;
			AliasAlterno = criteria.AliasAlterno;
			Correo = criteria.Correo;
			CodigoCargo = criteria.CodigoCargo;
			Cargo = criteria.Cargo;
			Aplicacion = criteria.NombreAplicacion;
			Logueado = criteria.Logueado;
			UltimoIngreso = criteria.UltimoIngreso;
			Caduca = criteria.Caduca;
			Ruta = criteria.Ruta;
			VigenciaInicio = criteria.VigenciaInicio;
			VigenciaFin = criteria.VigenciaFin;
		}

		#endregion
	}
}
