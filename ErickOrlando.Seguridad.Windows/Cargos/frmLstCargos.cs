using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Utilidades.Windows;
using ErickOrlando.Seguridad.Negocio.Editables;
using ErickOrlando.Seguridad.Negocio.SoloLectura;
using System;
using System.Windows.Forms;

namespace ErickOrlando.Seguridad.Windows.Cargos
{
    public partial class frmLstCargos : _PlantillaGestor
    {
        #region Declaracion de Variables
        private CargoInfo _Cargo;
        #endregion

        #region Constructor
        public frmLstCargos()
        {
            InitializeComponent();
            cboFiltros.SelectedIndexChanged += (s, o) =>
                {
                    SeleccionaCriterios(cboFiltros.SelectedIndex);
                };
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Metodos Privados
        public override void CargaDatosActuales()
        {
            base.CargaDatosActuales();
            _Cargo = ObjetoLista.Current as CargoInfo;
        }
        #endregion

        #region Barra de Botones
        public override void Nuevo()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                base.Nuevo();
                using (var frm = new frmMntCargo(Cargo.NewCargo()))
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
                using (var frm = new frmMntCargo(Cargo.GetCargo(_Cargo.ID)))
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

                Cargo.DeleteCargo(_Cargo.ID);
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
                using (var filtro = new FiltroCriteria())
                {
                    filtro.NombreCampo = CriterioBusqueda;
                    filtro.ValorBusqueda = txtFiltro.Text;
                    cargoInfoListBindingSource.DataSource = CargoInfoList.GetCargoInfoList(filtro);
                    if (cargoInfoListBindingSource.Count > 0)
                        gdvCargos.BestFitColumns();
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
