using DevExpress.XtraBars;
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
    public partial class _PlantillaMntDeGestor : _Plantilla
    {
        // Methods
        public _PlantillaMntDeGestor()
        {
            ItemClickEventHandler handler = null;
            ItemClickEventHandler handler2 = null;
            ItemClickEventHandler handler3 = null;
            this.components = null;
            this.InitializeComponent();
            this.SoloLectura = false;
            this.Nuevo = true;
            if (handler == null)
            {
                handler = (s, e) => this.Grabar();
            }
            this.ToolGrabar.ItemClick += handler;
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
        }

        private void _Plantilla_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Cancelar();
            }
        }

        private void _PlantillaMntDeGestor_DataGridCompleto()
        {
            this.Cursor = Cursors.Arrow;
        }

        public virtual void Actualizar()
        {
        }

        public virtual void Cancelar()
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        public override void Formulario(object sender, EventArgs e)
        {
            base.Formulario(sender, e);
            this.Actualizar();
            this.ManipulaControles(base.Controls);
            if (this.SoloLectura)
            {
                this.ToolGrabar.Enabled = false;
            }
        }

        public virtual void Grabar()
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        public virtual void ManipulaControles(Control.ControlCollection Contenedor)
        {
            if (this.SoloLectura)
            {
                foreach (Control control in Contenedor)
                {
                    if ((control.Controls != null) && (control.Controls.Count > 0))
                    {
                        this.ManipulaControles(control.Controls);
                    }
                    if ((control.DataBindings.Count > 0) && (control.DataBindings[0].DataSource != null))
                    {
                        control.Enabled = false;
                    }
                }
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

        [Description("Permite saber si se esta creando un registro nuevo o no, por defecto es True"), Category("Plantilla")]
        public bool Nuevo { get; set; }

        [Description("Permite establecer si los controles contenidos seran de Solo Lectura"), Category("Plantilla")]
        public bool SoloLectura { get; set; }

    }
}
