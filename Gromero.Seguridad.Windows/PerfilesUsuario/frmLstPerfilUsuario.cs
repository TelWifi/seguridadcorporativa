using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Utilidades.Windows;
using Gromero.Seguridad.Negocio.Editables;
using Gromero.Seguridad.Negocio.SoloLectura;
using System;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows.PerfilesUsuario
{
	public partial class frmLstPerfilUsuario : _PlantillaGestor
	{
		#region Declaracion de Variables
		private PerfilUsuarioInfo _PerfilUsuario;
		#endregion

		#region Constructor
		public frmLstPerfilUsuario()
		{
			InitializeComponent();
			Cursor.Current = Cursors.Default;
		}
		#endregion

		#region Metodos Privados
		public override void CargaDatosActuales()
		{
			base.CargaDatosActuales();
			_PerfilUsuario = ObjetoLista.Current as PerfilUsuarioInfo;
		}

		private void cboCriterios_SelectedIndexChanged(object sender, EventArgs e)
		{
			SeleccionaCriterios(cboCriterios.SelectedIndex);
		}
		#endregion

		#region Barra de Botones
		public override void Nuevo()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				base.Nuevo();
				using (var frm = new frmMntPerfilUsuario(PerfilUsuario.NewPerfilUsuario()))
					if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						Buscar();
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Nuevo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Nuevo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		public override void Editar()
		{
			base.Editar();
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				//Comprobamos que al menos un registro hay sido seleccionado
				CargaDatosActuales();
				using (var frm = new frmMntPerfilUsuario(PerfilUsuario.GetPerfilUsuario(_PerfilUsuario.ID)))
				{
					if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						Buscar();
				}
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Ver/Editar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Ver/Editar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		public override void Eliminar()
		{
			base.Eliminar();
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				CargaDatosActuales();
				if (XtraMessageBox.Show("Desea eliminar el registro?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
					return;

				PerfilUsuario.DeletePerfilUsuario(_PerfilUsuario.ID);
				Buscar();
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Eliminar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Eliminar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}

		}

		public override void Actualizar()
		{
			base.Actualizar();
		}

		public override void Buscar()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				//base.Buscar();
				//Aplicar los Filtros
				using (var crit = new FiltroCriteria()
					{
						NombreCampo = CriterioBusqueda,
						ValorBusqueda = txtFiltro.Text
					})
				{
					perfilUsuarioInfoListBindingSource.DataSource = PerfilUsuarioInfoList.GetPerfilUsuarioInfoList(crit);
                    gdvPerfilUsuario.BestFitColumns();
				}
			}
			catch (DataPortalException ex)
			{
				XtraMessageBox.Show(ex.BusinessException.Message,
					"Buscar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message,
					"Buscar",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}
		#endregion

	}
}
