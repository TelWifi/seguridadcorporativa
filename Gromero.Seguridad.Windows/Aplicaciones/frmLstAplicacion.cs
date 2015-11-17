using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Data;
using ErickOrlando.Utilidades.Windows;
using Gromero.Seguridad.Negocio.Editables;
using Gromero.Seguridad.Negocio.SoloLectura;
using System;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows.Aplicaciones
{
    public partial class frmLstAplicacion : _PlantillaGestor
    {
        #region Declaracion de Variables
        private AplicacionInfo _Aplicacion;
        #endregion

        #region Constructor
        public frmLstAplicacion()
        {
            InitializeComponent();

            gdvAplicaciones.KeyDown += (s, o) =>
                {
                    if (o.KeyCode == Keys.Enter)
                        Editar();
                };

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Metodos Privados
        public override void CargaDatosActuales()
        {
            base.CargaDatosActuales();
            _Aplicacion = ObjetoLista.Current as AplicacionInfo;
        }
        #endregion

        #region Barra de Botones
        public override void Nuevo()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                base.Nuevo();
                using (var frm = new frmMntAplicacion(Aplicacion.NewAplicacion()))
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
                using (var frm = new frmMntAplicacion(Aplicacion.GetAplicacion(_Aplicacion.ID)))
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

                Aplicacion.DeleteAplicacion(_Aplicacion.ID);
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
                    aplicacionInfoListBindingSource.DataSource = AplicacionInfoList.GetAplicacionInfoList(crit);
                    if (aplicacionInfoListBindingSource.Count > 0)
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
