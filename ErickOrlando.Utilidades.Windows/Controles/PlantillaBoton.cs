using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ErickOrlando.Utilidades.Windows.Controles
{
    [ToolboxBitmap(typeof(PlantillaBoton), "ErickOrlando.Utilidades.Windows.PlantillaBoton"), Designer(typeof(PlantillaBotonControlDesigner)), DefaultEvent("Click"), ToolboxItem(true), Description("Plantilla para los botones estandar Colaboracion de Erick Orlando © 2008-2012")]
    public partial class PlantillaBoton : XtraUserControl
    {
        private TextEdit m_CajaTexto;
        private ButtonEdit m_CajaTextoConBoton;
        private TipoBoton m_Imagen;

        // Events
        public new event BotonClick Click;


        public PlantillaBoton()
        {
            InitializeComponent();
            this.Boton.Click += new EventHandler(this.ClickBoton);

        }

        private void CambiarImagen(TipoBoton img)
        {
            switch (img)
            {
                case TipoBoton.Buscar:
                    this.Boton.Image = Properties.Resources.buscar;
                    this.Boton.ImageLocation = ImageLocation.MiddleCenter;
                    base.Size = new Size(0x23, 0x1b);
                    this.Boton.Text = string.Empty;
                    break;

                case TipoBoton.BuscarPrompt:
                    this.Boton.Image =Properties.Resources.prompt;
                    this.Boton.ImageLocation =ImageLocation.MiddleLeft;
                    base.Size = new Size(0x23, 0x1b);
                    this.Boton.Text = string.Empty;
                    break;

                case TipoBoton.Agregar:
                    this.Boton.Image =Properties.Resources.nuevo;
                    this.Boton.ImageLocation = ImageLocation.MiddleLeft;
                    base.Size = new Size(100, 0x18);
                    this.Boton.Text = "&Agregar";
                    break;

                case TipoBoton.Modificar:
                    this.Boton.Image =Properties.Resources.editar;
                    this.Boton.ImageLocation = ImageLocation.MiddleLeft;
                    base.Size = new Size(100, 0x18);
                    this.Boton.Text = "&Modificar";
                    break;

                case TipoBoton.Eliminar:
                    this.Boton.Image =Properties.Resources.eliminar;
                    this.Boton.ImageLocation = ImageLocation.MiddleLeft;
                    base.Size = new Size(100, 0x18);
                    this.Boton.Text = "&Eliminar";
                    break;
            }
            this.Boton.Size = base.Size;
        }

        private void ClickBoton(object sender, EventArgs e)
        {
            if (this.Click != null)
            {
                this.Click(sender, e);
            }
            if (this.CajaTexto != null)
            {
                this.CajaTexto.Font = new Font(this.CajaTexto.Font, FontStyle.Bold);
            }
            if (this.CajaTextoConBoton != null)
            {
                this.CajaTextoConBoton.Font = new Font(this.CajaTextoConBoton.Font, FontStyle.Bold);
            }
        }

        private void EventoTecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.ClickBoton(this, new EventArgs());
            }
        }

        // Properties
        [Description("Obtiene el Boton interno de este Control"), Category("Plantilla")]
        public SimpleButton BotonInterno
        {
            get
            {
                return this.Boton;
            }
        }

        [Category("Plantilla"), Description("Especifica el cuadro de Texto que esta asociado a este boton")]
        public TextEdit CajaTexto
        {
            get
            {
                return this.m_CajaTexto;
            }
            set
            {
                this.m_CajaTexto = value;
                if (value != null)
                {
                    if ((this.m_Imagen == TipoBoton.BuscarPrompt) | (this.m_Imagen == TipoBoton.Buscar))
                    {
                        value.KeyUp += new KeyEventHandler(this.EventoTecla);
                    }
                    else
                    {
                        value.KeyUp -= new KeyEventHandler(this.EventoTecla);
                    }
                }
            }
        }

        [Description("Especifica el control ButtonEdit que este asociado a este boton"), Category("Plantilla")]
        public ButtonEdit CajaTextoConBoton
        {
            get
            {
                return this.m_CajaTextoConBoton;
            }
            set
            {
                this.m_CajaTextoConBoton = value;
                if (value != null)
                {
                    if ((this.m_Imagen == TipoBoton.BuscarPrompt) | (this.m_Imagen == TipoBoton.Buscar))
                    {
                        value.KeyUp += new KeyEventHandler(this.EventoTecla);
                    }
                    else
                    {
                        value.KeyUp -= new KeyEventHandler(this.EventoTecla);
                    }
                }
            }
        }

        [Description("Especifica la Imagen que se mostrara en el boton"), Category("Plantilla")]
        public TipoBoton Imagen
        {
            get
            {
                this.CambiarImagen(this.m_Imagen);
                return this.m_Imagen;
            }
            set
            {
                this.CambiarImagen(value);
                this.m_Imagen = value;
            }
        }

        // Nested Types
        public delegate void BotonClick(object sender, EventArgs e);

        public enum TipoBoton
        {
            Buscar,
            BuscarPrompt,
            Agregar,
            Modificar,
            Eliminar
        }

    }
}
