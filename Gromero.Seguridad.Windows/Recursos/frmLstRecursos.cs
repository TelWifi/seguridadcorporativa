using Csla;
using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows;
using Gromero.Seguridad.Negocio.Editables;
using Gromero.Seguridad.Negocio.SoloLectura;
using System;
using System.Windows.Forms;

namespace Gromero.Seguridad.Windows.RecursosSeguridad
{
    public partial class frmLstRecursos : _PlantillaGestor
    {
        #region Declaracion de Variables
        private RecursosInfo _Recursos;
        #endregion

        #region Constructor
        public frmLstRecursos()
        {
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Metodos Privados
        public override void CargaDatosActuales()
        {
            base.CargaDatosActuales();
            _Recursos = ObjetoLista.Current as RecursosInfo;
        }
        #endregion

        #region Barra de Botones
        public override void Nuevo()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                base.Nuevo();
                using (var frm = new frmRecursos(Recursos.NewRecursos()))
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
                using (var frm = new frmRecursos(Recursos.GetRecursos(_Recursos.ID)))
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

                Recursos.DeleteRecursos(_Recursos.ID);
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
                using (var crit = new ErickOrlando.Utilidades.Data.FiltroCriteria())
                {
                    crit.NombreCampo = CriterioBusqueda;
                    crit.ValorBusqueda = txtFiltro.Text;
                    //Aplicar los Filtros
                    recursosInfoListBindingSource.DataSource = RecursosInfoList.GetRecursosInfoList(crit);
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
