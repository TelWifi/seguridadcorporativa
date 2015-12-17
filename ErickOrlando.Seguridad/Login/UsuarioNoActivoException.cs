using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ErickOrlando.Seguridad.Login
{
	/// <summary>
	/// Excepcion que representa un Usuario No Activo
	/// </summary>
	[Serializable]
	public class UsuarioNoActivoException : Exception
	{

		private const string MensajeConstante = "El usuario {0} no está Activo! Consulte al Administrador del Sistema";

		private string _NombreUsuario;
		/// <summary>
		/// Nombre de Usuario
		/// </summary>
		public string NombreUsuario
		{
			get { return _NombreUsuario; }
			set { _NombreUsuario = value; }
		}

		private string _Mensaje;
		/// <summary>
		/// Mensaje que contiene la Excepcion
		/// </summary>
		public override string Message
		{
			get
			{
				if (!String.IsNullOrEmpty(_NombreUsuario))
					_Mensaje = string.Format(MensajeConstante, _NombreUsuario);
				return _Mensaje;
			}
		}

		/// <summary>
		/// Inicializa una nueva instancia de UsuarioNoActivoException
		/// </summary>
		public UsuarioNoActivoException()
		{
			_Mensaje = string.Format(MensajeConstante, string.Empty);
		}

		/// <summary>
		/// Inicializa una nueva instancia de UsuarioNoActivoException
		/// </summary>
		public UsuarioNoActivoException(string message)
			: base(message)
		{

		}

		/// <summary>
		/// Inicializa una nueva instancia de UsuarioNoActivoException
		/// </summary>
		public UsuarioNoActivoException(string message, Exception innerException)
			: base(message, innerException)
		{
			
		}
		/// <summary>
		/// Inicializa una nueva instancia de UsuarioNoActivoException
		/// </summary>
		protected UsuarioNoActivoException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{
			if (info != null)
				_NombreUsuario = info.GetString("_NombreUsuario");
		}


		/// <summary>
		/// Obtiene un Dato de un objeto serializado
		/// </summary>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (info != null)
				info.AddValue("_NombreUsuario", _NombreUsuario);
		}

	}

}
