using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
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
    public partial class _PlantillaGestor : _Plantilla
    {
        // Fields
        private bool m_AllowEdit;
        private bool m_AllowNew;
        private bool m_AllowRemove;
        private string m_BotonActualizar;
        private string m_BotonBuscar;
        private string m_BotonEditar;
        private string m_BotonEliminar;
        private string m_BotonNuevo;
        private List<Criterios> m_ListaCriterios;
        private int m_NumeroCaracteres;


        public _PlantillaGestor()
        {
            this.InitializeComponent();
            ButtonPressedEventHandler handler = null;
            this.m_ListaCriterios = new List<Criterios>();
            this.m_NumeroCaracteres = 2;
            this.components = null;
            this.txtFiltro.TextChanged += new EventHandler(this.txtFiltro_TextChanged);
            if (handler == null)
            {
                handler = (sender, e) => this.LimpiaFiltro();
            }
            this.txtFiltro.ButtonClick += handler;
            base.Activated += new EventHandler(this._PlantillaGestor_Activated);
            base.Deactivate += new EventHandler(this._PlantillaGestor_Deactivate);
            base.KeyUp += (s, g) =>
            {
                switch (g.KeyCode)
                {
                    case Keys.Enter:
                        this.Buscar();
                        g.Handled = true;
                        break;
                    case Keys.Escape:
                        Close();
                        break;
                }
            };
            base.DataGridCompleto += new Action(this._PlantillaGestor_DataGridCompleto);

        }

        private void _PlantillaGestor_Activated(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void _PlantillaGestor_DataGridCompleto()
        {
            this.Cursor = Cursors.Arrow;
        }

        private void _PlantillaGestor_Deactivate(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
        }

        public virtual void Actualizar()
        {
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Actualizar();
        }

        private void btnBuscar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Buscar();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Editar();
        }

        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Eliminar();
        }

        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Nuevo();
        }

        public virtual void Buscar()
        {
            if (this.txtFiltro.Visible)
            {
                this.Cursor = Cursors.WaitCursor;
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

        public virtual void Editar()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        public virtual void Eliminar()
        {
            this.Cursor = Cursors.WaitCursor;
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
                base.InfoListDataGridView.DoubleClick += (o, s) => this.Editar();
            }
        }

        private void LimpiaFiltro()
        {
            this.txtFiltro.Text = string.Empty;
        }

        public virtual void Nuevo()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        public virtual void SeleccionaCriterios(int Indice)
        {
            try
            {
                if (base.Visible)
                {
                    this.txtFiltro.Text = string.Empty;
                    this.txtFiltro.Focus();
                    if (Indice < this.ListaCriterios.Count)
                    {
                        this.CriterioBusqueda = this.ListaCriterios[Indice].Valor;
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException(Resources.SeleccionaCriteriosValue);
            }
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

        public decimal ValorDecimal()
        {
            if (!char.IsNumber(this.txtFiltro.Text, 0))
            {
                throw new InvalidOperationException("Ingrese solo valores numericos!");
            }
            return Convert.ToDecimal(this.txtFiltro.Text);
        }

        public int ValorEntero()
        {
            if (!char.IsNumber(this.txtFiltro.Text, 0))
            {
                throw new InvalidOperationException("Ingrese solo valores numericos!");
            }
            return Convert.ToInt32(this.txtFiltro.Text);
        }

        // Properties
        [Description("Permitir Ver/Editar Registros"), Category("Plantilla")]
        public bool AllowEdit
        {
            get
            {
                this.m_AllowEdit = this.ToolEditar.Enabled;
                return this.m_AllowEdit;
            }
            set
            {
                this.m_AllowEdit = value;
                this.ToolEditar.Enabled = value;
            }
        }

        [Category("Plantilla"), Description("Permite editar la Barra de Herramientas")]
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

        [Category("Plantilla"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("Permitir Crear Registros")]
        public bool AllowNew
        {
            get
            {
                this.m_AllowNew = this.ToolNuevo.Enabled;
                return this.m_AllowNew;
            }
            set
            {
                this.ToolNuevo.Enabled = value;
            }
        }

        [Description("Permitir Eliminar Registros"), Category("Plantilla"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowRemove
        {
            get
            {
                this.m_AllowRemove = this.ToolEliminar.Enabled;
                return this.m_AllowRemove;
            }
            set
            {
                this.m_AllowRemove = value;
                this.ToolEliminar.Enabled = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Category("Plantilla"), Description("Texto del Boton Actualizar")]
        public string BotonActualizar
        {
            get
            {
                this.m_BotonActualizar = this.ToolActualizar.Caption;
                return this.m_BotonActualizar;
            }
            set
            {
                this.m_BotonActualizar = value;
                this.ToolActualizar.Caption = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Description("Texto del Boton Buscar"), Category("Plantilla")]
        public string BotonBuscar
        {
            get
            {
                this.m_BotonBuscar = this.ToolBuscar.Caption;
                return this.m_BotonBuscar;
            }
            set
            {
                this.m_BotonBuscar = value;
                this.ToolBuscar.Caption = value;
            }
        }

        [Category("Plantilla"), Description("Texto del Boton Editar"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string BotonEditar
        {
            get
            {
                this.m_BotonEditar = this.ToolEditar.Caption;
                return this.m_BotonEditar;
            }
            set
            {
                this.m_BotonEditar = value;
                this.ToolEditar.Caption = value;
            }
        }

        [Description("Texto del Boton Eliminar"), Category("Plantilla"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string BotonEliminar
        {
            get
            {
                this.m_BotonEliminar = this.ToolEliminar.Caption;
                return this.m_BotonEliminar;
            }
            set
            {
                this.m_BotonEliminar = value;
                this.ToolEliminar.Caption = value;
            }
        }

        [Category("Plantilla"), Description("Texto del Boton Nuevo")]
        public string BotonNuevo
        {
            get
            {
                this.m_BotonNuevo = this.ToolNuevo.Caption;
                return this.m_BotonNuevo;
            }
            set
            {
                this.m_BotonNuevo = value;
                this.ToolNuevo.Caption = value;
            }
        }

        [Description("Criterio de Busqueda Predeterminado"), Category("Plantilla")]
        public string CriterioBusqueda { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("Lista Generica de los Criterios que se usaran en el Gestor"), Category("Plantilla")]
        public List<Criterios> ListaCriterios
        {
            get
            {
                return this.m_ListaCriterios;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Category("Plantilla"), Description("Numero de Caracteres minimo a validar en el cuadro de busqueda")]
        public int NumeroCaracteres
        {
            get
            {
                return this.m_NumeroCaracteres;
            }
            set
            {
                this.m_NumeroCaracteres = value;
            }
        }

    }
}
