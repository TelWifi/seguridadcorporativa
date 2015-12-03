using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ErickOrlando.Utilidades.Windows.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErickOrlando.Utilidades.Windows
{
    public partial class _Plantilla : XtraForm
    {

        // Events
        protected event Action DataGridCompleto;

        public _Plantilla()
        {
            KeyEventHandler handler = null;
            this.DataGridCompleto = delegate
            {
            };
            this.components = null;
            this.InitializeComponent();
            base.KeyPreview = true;
            base.Load += new EventHandler(this.Formulario);
            this.BindingCompletado();
            if (handler == null)
            {
                handler = delegate (object o, KeyEventArgs s)
                {
                    if (s.KeyCode == Keys.Escape)
                    {
                        base.Close();
                    }
                };
            }
            base.KeyDown += handler;
        }

        private void BindingCompletado()
        {
            if (this.ObjetoLista != null)
            {
                this.ObjetoLista.BindingComplete += delegate (object o, BindingCompleteEventArgs s)
                {
                    if ((this.InfoListDataGridView != null) && (this.EtiquetaEstado != null))
                    {
                        this.EtiquetaEstado.Caption = string.Format("Nro de Filas: {0}", this.InfoListDataGridView.RowCount);
                        this.DataGridCompleto();
                    }
                };
            }
        }

        public virtual void CargaControl(BindingSource InfoListBindingSource, object GetInfoList)
        {
            try
            {
                InfoListBindingSource.DataSource = GetInfoList;
            }
            catch (Exception exception)
            {
                throw new ApplicationException(exception.Message);
            }
        }

        public virtual void CargaDatosActuales()
        {
            if (this.InfoListDataGridView == null)
            {
                throw new InvalidOperationException(Resources.InfoListDisenador);
            }
            if (this.InfoListDataGridView.SelectedRowsCount <= 0)
            {
                throw new InvalidOperationException(Resources.EscogerRegistros);
            }
        }

        public virtual void Formulario(object sender, EventArgs e)
        {
        }

        // Properties
        [Category("Plantilla"), Description("Control de Etiqueta en una Barra de Estado")]
        public BarStaticItem EtiquetaEstado { get; set; }

        [Category("Plantilla"), Description("Control GridView que se usar\x00e1 en el Formulario")]
        public GridView InfoListDataGridView { get; set; }

        [Description("Control BindingSource que se usar\x00e1 en el Formulario"), Category("Plantilla")]
        public BindingSource ObjetoLista { get; set; }

    }
}
