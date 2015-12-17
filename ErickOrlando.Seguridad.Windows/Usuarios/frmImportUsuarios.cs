using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using ErickOrlando.Seguridad.Negocio.SoloLectura;
using ErickOrlando.Seguridad.Negocio.SoloLectura.Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Usuarios
{
    public partial class frmImportUsuarios : _PlantillaMntDeGestor
    {
        public frmImportUsuarios()
        {
            InitializeComponent();
        }

        public List<Usuario> LeerUsuarioAImportar(string FileFullPath)
        {
            bool filaContieneData = false;

            List<Usuario> usuarioList = new List<Usuario>();

            using (StreamReader stream = new StreamReader(FileFullPath))
            {
                while (!stream.EndOfStream)
                {
                    Usuario usuario = this.BuildUsuario(stream.ReadLine());

                    if (filaContieneData)
                        usuarioList.Add(usuario);

                    filaContieneData = true;
                }
                //sr.Close();
            }
            return usuarioList;
        }

        private Usuario BuildUsuario(string linea)
        {
            string[] camposArray = linea.Split(',');

            Usuario usuario = Usuario.NewUsuario();

            usuario.Tipo = camposArray[0].Trim();
            usuario.Dominio = camposArray[1].Trim();
            usuario.Codigo = camposArray[2].Trim();
            usuario.Nombres = camposArray[3].Trim();
            usuario.ApellidoPaterno = camposArray[4].Trim();
            usuario.ApellidoMaterno = camposArray[5].Trim();
            usuario.Correo = camposArray[6].Trim();
            usuario.Alias = camposArray[7].Trim();
            usuario.DNI = camposArray[8].Trim();
            usuario.IdEmpresa = camposArray[9].Trim();
            usuario.IdEmpresaPertenencia = camposArray[10].Trim();
            usuario.IdCargo = camposArray[11].Trim();


            return usuario;
        }

        private void GenerarCSV()
        {
            List<Usuario> usuarioList = usuarioListBindingSource.List as List<Usuario>;

            if (!usuarioList.Any())
                return;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ConError,Tipo,Dominio,Codigo,Nombres,ApellidoPaterno,ApellidoMaterno,Correo,Alias,DNI,IdEmpresa,IdEmpresaPertenencia,Cargo,Error");
            usuarioList.ForEach(x =>
            {
                stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}"
                                                      , x.Estado ? "OK" : "Error"
                                                      , x.Tipo
                                                      , x.Dominio
                                                      , x.Codigo
                                                      , x.Nombres
                                                      , x.ApellidoPaterno
                                                      , x.ApellidoMaterno
                                                      , x.Correo
                                                      , x.Alias
                                                      , x.DNI
                                                      , x.IdEmpresa
                                                      , x.IdEmpresaPertenencia
                                                      , x.IdCargo
                                                      , x.AliasAlterno
                                                      ));
            });

            string filePathInforme = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// "C:\\exportado\\";
            string fileNameInforme = string.Format("ImportacionDeUsuarios_{0}.csv", DateTime.Now.ToString("yyyMMddHHmm"));
            string fullPathInforme = string.Format(@"{0}\{1}", filePathInforme, fileNameInforme);

            if (!Directory.Exists(filePathInforme))
                Directory.CreateDirectory(filePathInforme);

            using (StreamWriter sw = new StreamWriter(fullPathInforme))
            {
                sw.Write(stringBuilder.ToString());
            }
            System.Diagnostics.Process.Start(fullPathInforme);
        }

        private List<Usuario> ValidarDatosAImportar(List<Usuario> usuarioList)
        {
            TipoUsuarioInfoList tipoUsuarioInfoList = TipoUsuarioInfoList.GetTipoUsuarioInfoList();
            EmpresaInfoList empresaInfoList = EmpresaInfoList.GetEmpresaInfoList();
            DominioInfoList dominioInfoList = DominioInfoList.GetDominioInfoList();
            CargoSociedadInfoList cargoSociedadInfoList = CargoSociedadInfoList.GetCargoSociedadInfoList();
            UsuarioInfoList usuarioInfoList = UsuarioInfoList.GetUsuarioInfoList(new FiltroCriteria { NombreCampo = "", ValorBusqueda = "" });

            usuarioList.ForEach(x =>
                {
                    try
                    {
                        #region VALIDACIOIN VALORES OBLIGATORIOS

                        if (string.IsNullOrEmpty(x.Tipo))
                            throw new Exception("Tipo no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.Codigo))
                            throw new Exception("Código no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.Dominio))
                            throw new Exception("Dominio no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.Nombres))
                            throw new Exception("Nombres no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.ApellidoMaterno))
                            throw new Exception("ApellidoMaterno no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.ApellidoPaterno))
                            throw new Exception("ApellidoPaterno no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.IdEmpresa))
                            throw new Exception("Empresa no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.IdEmpresaPertenencia))
                            throw new Exception("EmpresaPertenencia no tiene el formato correcto");

                        if (string.IsNullOrEmpty(x.IdCargo))
                            throw new Exception("Cargo no tiene el formato correcto");

                        #endregion

                        #region VALIDACION SI DATOS EXISTE

                        if (tipoUsuarioInfoList.Where(xy => xy.Codigo == x.Codigo).Any())
                            throw new Exception("No existe el tipo descrito");

                        if(dominioInfoList.Where(xy => xy.NombreCorto == x.Dominio).Any())
                            throw new Exception("No existe el dominio descrito");

                        var empresaInfoListFilter = empresaInfoList.Where(xy => xy.RazonSocial.ToUpper().Contains(x.IdEmpresa.ToUpper())).ToList();
                        if (empresaInfoListFilter.Any())
                            x.IdEmpresa = empresaInfoListFilter.FirstOrDefault().ID;
                        else
                            throw new Exception("No existe la empresa descrita");

                        empresaInfoListFilter = empresaInfoList.Where(xy => xy.RazonSocial.ToUpper().Contains(x.IdEmpresaPertenencia.ToUpper())).ToList();
                        if (empresaInfoListFilter.Any())
                            x.IdEmpresaPertenencia = empresaInfoListFilter.FirstOrDefault().ID;
                        else
                            throw new Exception("No existe la empresa de pertenencia descrita");

                        var cargoSociedadInfoListFilter = cargoSociedadInfoList.Where(xy => xy.Descripcion.ToUpper().Contains(x.IdCargo.ToUpper())).ToList();
                        if (cargoSociedadInfoListFilter.Any())
                            x.IdCargo = cargoSociedadInfoListFilter.FirstOrDefault().ID;
                        else
                            throw new Exception("No existe el cargo descrita");

                        #endregion

                        if (usuarioInfoList.Where(xy => xy.Codigo == x.Codigo).Any())
                            throw new Exception("El usuario ya existe");

                        x.Estado = true;
                    }
                    catch (Exception ex)
                    {
                        x.AliasAlterno = ex.Message;
                        x.Estado = false;
                    }
                });

            return usuarioList;
        }

        public override void Grabar()
        {
            try
            {
                List<Usuario> usuarioList = usuarioListBindingSource.List as List<Usuario>;
                if (!usuarioList.Any())
                    return;

                usuarioListBindingSource.RaiseListChangedEvents = false;
                usuarioListBindingSource.EndEdit();

                usuarioList.ForEach(x =>
                    {
                        try
                        {
                            x.AliasAlterno = "";
                            if (x.Estado)
                                x = x.Save();

                        }
                        catch (ValidationException)
                        {
                            XtraMessageBox.Show(x.BrokenRulesCollection.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            x.AliasAlterno = x.BrokenRulesCollection.ToString();

                            throw;
                        }
                    });
                usuarioListBindingSource.ResetBindings(false);

                XtraMessageBox.Show("Registro grabado correctamente!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                //base.Grabar();
            }
            catch (DataPortalException ex)
            {
                XtraMessageBox.Show(ex.BusinessException.Message, "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmImportUsuarios_Load(object sender, EventArgs e)
        {
            this.BarraBotones.Bars.Clear();
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog browseFile = new OpenFileDialog();
                browseFile.Filter = "CSV Files (*.csv)|*.csv";
                browseFile.Multiselect = false;
                if (browseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    List<Usuario> usuarioList = this.LeerUsuarioAImportar(browseFile.FileName);
                    direccionLabel.Text = browseFile.FileName;

                    usuarioList = ValidarDatosAImportar(usuarioList);

                    usuarioListBindingSource.DataSource = usuarioList;
                    usuarioListBindingSource.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Seleccionar",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void importarReporteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.Grabar();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Procesar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void generarReporteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.GenerarCSV();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
