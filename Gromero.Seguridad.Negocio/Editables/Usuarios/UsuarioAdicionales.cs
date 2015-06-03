using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ErickOrlando.Utilidades.Mail;

namespace Gromero.Seguridad.Negocio.Editables
{
	public partial class Usuario
	{

		public enum TipoCorreo
		{
			UsuarioNuevoExterno,
			UsuarioNuevoInterno,
			CambioClave
		}


		public void EnvioCorreo(TipoCorreo tipoCorreo)
		{
			var Ruta = string.Empty;
			var Cadena = new String[] {
					Nombres,
					Codigo,
					DateTime.Today.ToString("dd/MM/yyyy"),
					DateTime.Today.AddDays(90).ToString("dd/MM/yyyy")
				};
			
			var mail = new ContenidoMail();

			switch (tipoCorreo)
			{
				case TipoCorreo.UsuarioNuevoExterno:
					Ruta = "Gromero.Seguridad.Negocio.Editables.Usuarios.PlantillaCorreo.htm";
					mail.Asunto = string.Format(Properties.Resources.msgAsuntoActivacion, this.Codigo);
					break;
				case TipoCorreo.UsuarioNuevoInterno:
					Ruta = "Gromero.Seguridad.Negocio.Editables.Usuarios.PlantillaCorreoUsuarioAD.htm";
					mail.Asunto = string.Format(Properties.Resources.msgAsuntoActivacion, this.Codigo);
					Cadena = new String[] 
					{
						Nombres,
						Codigo,
						Dominio
					};
					break;
				case TipoCorreo.CambioClave:
					Ruta = "Gromero.Seguridad.Negocio.Editables.Usuarios.PlantillaContrasena.htm";
					mail.Asunto = string.Format(Properties.Resources.msgAsuntoRestablecimiento, this.Codigo);
					break;
			}

			try
			{
				TextReader texto = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(Ruta));

				mail.RemitenteMail = "sistemas@gromero.com.pe";
				mail.RemitenteNombre = "Sistemas Grupo Romero";
				mail.Servidor = "traweb01.tramarsa.com.pe";
				mail.Puerto = 25;
				mail.CuerpoMensaje = texto.ReadToEnd();
				mail.ListaDestinatarios.Add(Correo);
				mail.ArrayValores = Cadena;
				mail.Html = true;
				texto.Close();

				EnvioDeCorreo.EnviarCorreo(mail);
			}
			catch (SmtpException ex)
			{
				var msg = string.Format("{0}\n{1}", 
					ex.Message, ex.InnerException == null ? string.Empty : ex.InnerException.Message);
				//System.Diagnostics.Trace.WriteLine(msg);
			}

		}

	}
}
