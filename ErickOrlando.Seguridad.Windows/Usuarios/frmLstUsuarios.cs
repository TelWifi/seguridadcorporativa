using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using ErickOrlando.Seguridad.Negocio.SoloLectura;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Usuarios
{
	public partial class frmLstUsuarios : _PlantillaGestor
	{
		#region Declaracion de Variables
		private UsuarioInfo _Usuario;
		#endregion

		#region Constructor
		public frmLstUsuarios()
		{
			InitializeComponent();
			Cursor.Current = Cursors.Default;
		}
		#endregion

		#region Metodos Privados
		public override void CargaDatosActuales()
		{
			base.CargaDatosActuales();
			_Usuario = ObjetoLista.Current as UsuarioInfo;
		}
		#endregion

		#region Barra de Botones
		public override void Nuevo()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				base.Nuevo();
				using (var frm = new frmMntUsuarios(Usuario.NewUsuario()))
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
				using (var frm = new frmMntUsuarios(Usuario.GetUsuario(_Usuario.ID)))
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

				Usuario.DeleteUsuario(_Usuario.ID);
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
				using (var crit = new FiltroCriteria { NombreCampo = CriterioBusqueda, ValorBusqueda = txtFiltro.Text })
				{
					usuarioInfoListBindingSource.DataSource = UsuarioInfoList.GetUsuarioInfoList(crit);
					if (usuarioInfoListBindingSource.Count > 0)
						InfoListDataGridView.BestFitColumns();
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

		private void cboCriterios_SelectedIndexChanged(object sender, EventArgs e)
		{
			SeleccionaCriterios(cboCriterios.SelectedIndex);
		}
	}
}
