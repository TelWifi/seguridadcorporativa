using Csla;
using Csla.Rules;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using Gromero.Seguridad.Negocio.Editables;
using Gromero.Seguridad.Negocio.SoloLectura;
using Gromero.Seguridad.Negocio.SoloLectura.Dominios;
using GRomeroAD.DirectoryServices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows.Usuarios
{
	public partial class frmMntUsuarios : _PlantillaMntDeGestor
	{

		#region Declaracion de Variables
		private Usuario m_Usuario;
		#endregion

		#region Constructores
		public frmMntUsuarios()
		{
			InitializeComponent();
		}

		public frmMntUsuarios(Usuario _usuario)
		{
			InitializeComponent();

			m_Usuario = _usuario;
			usuarioBindingSource.DataSource = _usuario;

			//notificarConCorreoLabel.Visible = _usuario.IsNew;
			//notificarConCorreoCheckEdit.Visible = _usuario.IsNew;

			Cursor.Current = Cursors.Default;
		}
		#endregion

		#region Grabar
		public override void Grabar()
		{
			usuarioBindingSource.RaiseListChangedEvents = false;
			usuarioBindingSource.EndEdit();

			try
			{
				Cursor.Current = Cursors.WaitCursor;
				m_Usuario = m_Usuario.Save();
				XtraMessageBox.Show("Registro grabado correctamente!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

				base.Grabar();
			}
			catch (ValidationException)
			{
				XtraMessageBox.Show(m_Usuario.BrokenRulesCollection.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Grabar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Grabar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}

			usuarioBindingSource.RaiseListChangedEvents = true;
		}
		#endregion

		#region Cancelar
		public override void Cancelar()
		{
			usuarioBindingSource.CancelEdit();
			base.Cancelar();
		}
		#endregion

		#region Actualizar
		public override void Actualizar()
		{
			base.Actualizar();
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				empresaInfoListBindingSource.DataSource = EmpresaInfoList.GetEmpresaInfoList();
				tipoUsuarioInfoListBindingSource.DataSource = TipoUsuarioInfoList.GetTipoUsuarioInfoList();
				dominioInfoListBindingSource.DataSource = DominioInfoList.GetDominioInfoList();
				cargoSociedadInfoListBindingSource.DataSource = CargoSociedadInfoList.GetCargoSociedadInfoList();
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Actualizar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Actualizar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}
		#endregion

		#region Eventos del Formulario


		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				using (var frm = new frmPromptUsuariosAD() { CadenaBusqueda = codigoTextEdit.Text })
				{
					if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						var resultado = frm.ListaObjetos.First() as Directorio;
						m_Usuario.Codigo = resultado.UserName;
						m_Usuario.Nombres = resultado.FirstName;
						//Dividimos los apellidos con un espacio en blanco
						var apellidos = resultado.LastName.Split(' ');
						m_Usuario.ApellidoPaterno = apellidos.First();
						m_Usuario.ApellidoMaterno = apellidos.Last();
						m_Usuario.Correo = resultado.Email;
						usuarioBindingSource.ResetBindings(false);
						idEmpresaLookUpEdit.Focus();
					}
				}
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Buscar Usuario",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Buscar Usuario",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void tipoTextEdit_EditValueChanged(object sender, EventArgs e)
		{
			if (tipoTextEdit.EditValue != null)
			{
				btnBuscar.Visible = (tipoTextEdit.EditValue.ToString() == "I");
			}
		}

		#endregion

        private void importarButton_Click(object sender, EventArgs e)
        {
            using (frmImportUsuarios frm = new frmImportUsuarios())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
                frm.Close();
            }
        }

	}
}
