using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using ErickOrlando.Utilidades.Windows.Controles;
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
    public partial class _PlantillaPrompt : _Plantilla
    {
        private bool m_DesdeGrilla;
        private List<Criterios> m_ListaCriterios;
        private List<object> m_ListaObjetos;
        private int m_NumeroCaracteres;

        // Methods
        public _PlantillaPrompt()
        {
            PlantillaBoton.BotonClick click = null;
            ItemClickEventHandler handler = null;
            ItemClickEventHandler handler2 = null;
            ItemClickEventHandler handler3 = null;
            EventHandler handler4 = null;
            BindingCompleteEventHandler handler5 = null;
            this.m_ListaCriterios = new List<Criterios>();
            this.m_ListaObjetos = new List<object>();
            this.m_NumeroCaracteres = 2;
            this.components = null;
            this.InitializeComponent();
            this.CadenaBusqueda = string.Empty;
            if (click == null)
            {
                click = (s, e) => this.Buscar();
            }
            this.btnBusqueda.Click += click;
            if (handler == null)
            {
                handler = (s, e) => this.Aceptar();
            }
            this.ToolAceptar.ItemClick += handler;
            if (handler2 == null)
            {
                handler2 = (s, e) => this.Cancelar();
            }
            this.ToolCancelar.ItemClick += handler2;
            if (handler3 == null)
            {
                handler3 = (s, e) => this.Actualizar();
            }
            this.ToolActualizar.ItemClick += handler3;
            base.KeyUp += new KeyEventHandler(this._Plantilla_KeyPress);
            this.txtFiltro.TextChanged += new EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.KeyUp += new KeyEventHandler(this.Filtro);
            this.txtFiltro.ButtonClick += new ButtonPressedEventHandler(this.btnClearText_Click);
            if (base.InfoListDataGridView != null)
            {
                if (handler4 == null)
                {
                    handler4 = (s, e) => this.Aceptar();
                }
                base.InfoListDataGridView.DoubleClick += handler4;
            }
            if (base.ObjetoLista != null)
            {
                if (handler5 == null)
                {
                    handler5 = (s, e) => this._PlantillaPrompt_DataGridCompleto();
                }
                base.ObjetoLista.BindingComplete += handler5;
            }
        }

        private void _Plantilla_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.Buscar();
                    break;

                case Keys.Escape:
                    this.Cancelar();
                    break;
            }
        }

        private void _PlantillaPrompt_DataGridCompleto()
        {
            this.Cursor = Cursors.Arrow;
        }

        public virtual void Aceptar()
        {
            if (base.InfoListDataGridView != null)
            {
                if (base.ObjetoLista != null)
                {
                    this.m_ListaObjetos.Add(base.ObjetoLista.Current);
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void AceptarDesdeGrilla(object sender, EventArgs e)
        {
            if (!this.m_DesdeGrilla)
            {
                this.Aceptar();
                this.m_DesdeGrilla = true;
            }
        }

        public virtual void Actualizar()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            this.txtFiltro.Text = string.Empty;
        }

        public virtual void Buscar()
        {
            if (this.txtFiltro.Visible)
            {
                bool flag = false;
                int length = this.txtFiltro.Text.Length;
                switch (length)
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        if (char.IsDigit(this.txtFiltro.Text.First<char>()))
                        {
                            flag = true;
                            break;
                        }
                        flag = false;
                        break;

                    default:
                        if (!this.txtFiltro.Visible)
                        {
                            flag = false;
                        }
                        else if (length < this.NumeroCaracteres)
                        {
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                        break;
                }
                if (!flag)
                {
                    throw new ArgumentException(Resources.IngresaCriterios);
                }
            }
        }

        public virtual void Cancelar()
        {
            base.DialogResult = DialogResult.Cancel;
        }
        private void Filtro(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Buscar();
                e.Handled = true;
            }
        }

        public override void Formulario(object sender, EventArgs e)
        {
            base.Formulario(sender, e);
            if (base.InfoListDataGridView != null)
            {
                base.InfoListDataGridView.DoubleClick += new EventHandler(this.AceptarDesdeGrilla);
            }
        }

        private DialogResult MostrarDialogo()
        {
            base.Visible = false;
            this.RealizarBusqueda();
            if (base.InfoListDataGridView != null)
            {
                if (base.InfoListDataGridView.RowCount == 1)
                {
                    return DialogResult.OK;
                }
                return base.ShowDialog();
            }
            if (base.ObjetoLista != null)
            {
                if (base.ObjetoLista.Count == 1)
                {
                    return DialogResult.OK;
                }
                return base.ShowDialog();
            }
            return base.ShowDialog();
        }

        private void RealizarBusqueda()
        {
            if (this.CadenaBusqueda != string.Empty)
            {
                base.Visible = false;
                this.txtFiltro.Text = this.CadenaBusqueda;
                this.Buscar();
                if (base.InfoListDataGridView != null)
                {
                    if (base.InfoListDataGridView.RowCount == 1)
                    {
                        this.Aceptar();
                    }
                }
                else if ((base.ObjetoLista != null) && (base.ObjetoLista.Count == 1))
                {
                    this.Aceptar();
                }
            }
        }

        public virtual void SeleccionaCriterios(int Indice)
        {
            try
            {
                if (base.Visible)
                {
                    this.txtFiltro.Text = string.Empty;
                    this.txtFiltro.Focus();
                }
                if (Indice < this.ListaCriterios.Count)
                {
                    this.CriterioBusqueda = this.ListaCriterios[Indice].Valor;
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException(Resources.SeleccionaCriteriosValue);
            }
        }

        public new DialogResult ShowDialog()
        {
            if (!string.IsNullOrEmpty(this.CadenaBusqueda))
            {
                return this.MostrarDialogo();
            }
            return base.ShowDialog();
        }

        public new DialogResult ShowDialog(IWin32Window owner)
        {
            if (!string.IsNullOrEmpty(this.CadenaBusqueda))
            {
                return this.MostrarDialogo();
            }
            return base.ShowDialog(owner);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if ((this.txtFiltro.Visible & base.Visible) && (this.txtFiltro.Text.IndexOf("%") > -1))
            {
                this.txtFiltro.SuspendLayout();
                this.txtFiltro.Text = this.txtFiltro.Text.Replace("%", string.Empty);
                this.txtFiltro.ResumeLayout();
            }
        }

        // Properties
        [Description("Permite editar la Barra de Herramientas"), Category("Plantilla")]
        public bool AllowEditBarItems
        {
            get
            {
                return this.BarraBotones.AllowCustomization;
            }
            set
            {
                this.BarraBotones.AllowCustomization = value;
            }
        }

        [Description("Cadena que se buscara en el Prompt antes de llamar al Formulario"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Category("Plantilla")]
        public string CadenaBusqueda { get; set; }

        [Category("Plantilla"), Description("Criterio de Busqueda Predeterminado")]
        public string CriterioBusqueda { get; set; }

        [Category("Plantilla"), Description("Lista Generica de los Criterios que se usaran en el Prompt"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<Criterios> ListaCriterios
        {
            get
            {
                return this.m_ListaCriterios;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Lista Generica de Objetos que devuelve el Prompt"), Category("Plantilla")]
        public List<object> ListaObjetos
        {
            get
            {
                return this.m_ListaObjetos;
            }
        }

        [Category("Plantilla"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("Numero de Caracteres minimo a validar en el cuadro de busqueda")]
        public int NumeroCaracteres
        {
            get
            {
                return this.m_NumeroCaracteres;
            }
            set
            {
                if (value < 2)
                {
                    throw new InvalidOperationException("No se puede establecer a un valor inferior a 2");
                }
                this.m_NumeroCaracteres = value;
            }
        }

    }
}
