using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GR.COMEX.Framework;
using GR.COMEX.Seguridad.Entidades;
using System.Text;

namespace WindowsTestApp
{
    public partial class Form1 : Form
    {
        //private string UrlBase = "http://tramoldev01.tramarsa.com.pe/GRSeguridad/SeguridadGR.svc/{0}";
        private string UrlBase = "http://localhost:8080/GRSeguridad/SeguridadGR.svc/{0}";

        public Form1()
        {
            InitializeComponent();

            Load += (s, e) =>
            {
                //var permisos = new InfoPermisos() { Accion = TipoAccion.PuedeLeer, Modulo = "Usuario" };

                //try
                //{
                //    Cursor.Current = Cursors.WaitCursor;
                //    button5.Enabled = InformacionREST<InfoPermisos>.EnviarInfo(
                //        new Uri(Publicos.GetDireccionServicio(), "ConsultarPermisos"), permisos);
                //}
                //catch (WebException ex)
                //{
                //    XtraMessageBox.Show(
                //        ex.ToString(),
                //        Text,
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Information);
                //}
                //finally
                //{
                //    Cursor.Current = Cursors.Default;
                //}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var util = new UtilitarioRest();
                var response = util.DeserializarJSON<RequestInfoBasicaUsuarioDTO, ResponseInfoBasicaUsuarioDTO>
                    (new RequestInfoBasicaUsuarioDTO
                    {
                        CodigosUsuario = new List<string> { "evelascom", "jgutierrezs" }
                    }, string.Format(UrlBase, "GetInfoBasicaUsuarios"));

                var cadena = new StringBuilder();
                foreach (var item in response.ListaInfoBasicaUsuarios)
                {
                    cadena.AppendLine(
                        string.Format("Nombres Completos: {0} \n Correo: {1}",
                            item.NombresCompletos,
                            item.Correo));
                }

                MessageBox.Show(cadena.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //WebClient client = new WebClient();
            //byte[] data = client.DownloadData("http://localhost/SeguridadGRomero/Services/Permisos.svc/Employee/2");
            //Stream stream = new MemoryStream(data);

            //DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Employee));

            //var result = obj.ReadObject(stream) as Employee;

            //MessageBox.Show(string.Format("Se encontró el Objeto Employee: {0}", result.Name));
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var util = new UtilitarioRest();

            var url = "http://tramoldev01.tramarsa.com.pe/GRSeguridad/SeguridadGR.svc/GetNombreUsuario";

            var response = util.DeserializarJSON<RequestInfoUsuario, string>(new RequestInfoUsuario
                {
                    IdPerfilUsuario = "c40e8937-659b-4c2a-9a66-c307e3105484"
                }, url);

            MessageBox.Show(string.Format("Resultado del servidor: {0}", response.ToString()));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FileInformation fileInfo = new FileInformation();
            //fileInfo.Name = "Test.txt";
            //fileInfo.Content = Get10MBFile();

            //var result = InformacionREST<FileInformation>.EnviarInformacionInt32(
            //    new Uri("http://localhost/SeguridadGRomero/Services/Permisos.svc/UploadFile"), fileInfo);

            //MessageBox.Show(String.Format("Bytes en Archivo: {0}", result));
        }

        private byte[] Get10MBFile()
        {
            FileStream stream = File.OpenWrite("Test.txt");
            for (int i = 1; i <= 10000000; i++)
                stream.WriteByte(1);

            stream.Close();

            return File.ReadAllBytes("Test.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton habilidado!");
        }


    }
}
