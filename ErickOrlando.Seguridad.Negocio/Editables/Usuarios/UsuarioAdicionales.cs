using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ErickOrlando.Utilidades.Mail;
using System.Configuration;
using ErickOrlando.Seguridad.Login;

namespace ErickOrlando.Seguridad.Negocio.Editables
{
    public partial class Usuario
    {

        public enum TipoCorreo
        {
            UsuarioNuevoExterno,
            UsuarioNuevoInterno,
            CambioClave
        }


        public async void EnvioCorreo(TipoCorreo tipoCorreo)
        {
            var Ruta = string.Empty;
            var Cadena = new String[] {
                    Nombres,
                    Codigo,
                    DateTime.Today.ToString("dd/MM/yyyy"),
                    DateTime.Today.AddDays(90).ToString("dd/MM/yyyy")
                };

            var Contenido = new ContenidoMail();

            switch (tipoCorreo)
            {
                case TipoCorreo.UsuarioNuevoExterno:
                    Ruta = "ErickOrlando.Seguridad.Negocio.Editables.Usuarios.PlantillaCorreo.htm";
                    Contenido.Asunto = string.Format(Properties.Resources.msgAsuntoActivacion, this.Codigo);
                    break;
                case TipoCorreo.UsuarioNuevoInterno:
                    Ruta = "ErickOrlando.Seguridad.Negocio.Editables.Usuarios.PlantillaCorreoUsuarioAD.htm";
                    Contenido.Asunto = string.Format(Properties.Resources.msgAsuntoActivacion, this.Codigo);
                    Cadena = new String[]
                    {
                        Nombres,
                        Codigo,
                        Dominio
                    };
                    break;
                case TipoCorreo.CambioClave:
                    Ruta = "ErickOrlando.Seguridad.Negocio.Editables.Usuarios.PlantillaContrasena.htm";
                    Contenido.Asunto = string.Format(Properties.Resources.msgAsuntoRestablecimiento, this.Codigo);
                    break;
            }

            try
            {
                TextReader texto = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(Ruta));

                #region Configuracion del Correo
                var crypto = new SimpleInteroperableEncryption();

                Contenido.RemitenteMail = ConfigurationManager.AppSettings["RemitenteEmail"];
                Contenido.RemitenteNombre = ConfigurationManager.AppSettings["RemitenteNombre"];
                Contenido.Servidor = ConfigurationManager.AppSettings["SMTPServer"];
                Contenido.Puerto = int.Parse(ConfigurationManager.AppSettings["PuertoSMTP"]);
                Contenido.Credenciales = new System.Net.NetworkCredential(
                    crypto.Decrypt(ConfigurationManager.AppSettings["CredencialUser"]),
                    crypto.Decrypt(ConfigurationManager.AppSettings["CredencialPass"]));
                Contenido.UsarSSL = true;
                Contenido.CuerpoMensaje = texto.ReadToEnd();
                Contenido.ListaDestinatarios.Add(Correo);
                Contenido.ArrayValores = Cadena;
                Contenido.Html = true;
                texto.Close();
                #endregion

                #region Contenido del Correo
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(Contenido.RemitenteMail, Contenido.RemitenteNombre);
                    foreach (var Destinatario in Contenido.ListaDestinatarios)
                        mail.To.Add(Destinatario);
                    foreach (var Destinatario in Contenido.ListaDestinatariosCC)
                        mail.CC.Add(Destinatario);
                    foreach (var Destinatario in Contenido.ListaDestinatariosBCC)
                        mail.Bcc.Add(Destinatario);
                    var CuerpoHTML = new StringBuilder();

                    if (Contenido.ArrayValores.Length > 0)
                        CuerpoHTML.AppendFormat(Contenido.CuerpoMensaje, Contenido.ArrayValores);
                    else
                        CuerpoHTML.Append(Contenido.CuerpoMensaje);

                    CuerpoHTML.AppendLine();
                    CuerpoHTML.AppendLine();
                    CuerpoHTML.AppendLine();

                    CuerpoHTML.Append(Contenido.Html ? Contenido.PieDeCorreoHTML : Contenido.PieDeCorreo);

                    mail.Subject = Contenido.Asunto;
                    mail.Body = CuerpoHTML.ToString();
                    mail.IsBodyHtml = Contenido.Html;

                    //Limpiamos el StringBuilder
                    CuerpoHTML.Length = 0;

                    var smtp = new SmtpClient();
                    smtp.Host = Contenido.Servidor;
                    if (Contenido.Puerto.HasValue)
                        smtp.Port = Contenido.Puerto.Value;

                    if (Contenido.Credenciales != null)
                        smtp.Credentials = Contenido.Credenciales;
                    else
                        smtp.UseDefaultCredentials = true;

                    if (Contenido.Servidor.ToLower() == "localhost" || Contenido.Servidor == "127.0.0.1")
                        smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;

                    if (!string.IsNullOrEmpty(Contenido.DirectorioRecojoIIS))
                        smtp.PickupDirectoryLocation = Contenido.DirectorioRecojoIIS;

                    smtp.EnableSsl = Contenido.UsarSSL;

                    //await smtp.SendMailAsync(mail);
                    await smtp.SendMailAsync(mail);
                }
                #endregion

            }
            catch (SmtpException ex)
            {
                var msg = string.Format("{0}\n{1}",
                    ex.Message, ex.InnerException == null ? string.Empty : ex.InnerException.Message);
                System.Diagnostics.Trace.WriteLine(msg);
            }

        }

    }
}
