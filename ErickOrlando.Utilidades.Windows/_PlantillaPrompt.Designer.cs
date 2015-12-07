using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ErickOrlando.Utilidades.Windows.Controles;
using ErickOrlando.Utilidades.Windows.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ErickOrlando.Utilidades.Windows
{
    partial class _PlantillaPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        // Fields
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private BarDockControl barDockControl1;
        private BarDockControl barDockControl2;
        private BarDockControl barDockControl3;
        private BarDockControl barDockControl4;
        protected BarManager BarraBotones;
        private PlantillaBoton btnBusqueda;
        protected ComboBoxEdit cboFiltro;
        private IContainer components;
        protected GroupControl grpCriterios;
        protected GroupControl grpResultados;
        private BarStaticItem lblEstado;
        protected LabelControl lblFiltro;
        protected LabelControl lblValor;
        protected SplitContainerControl splitContainerControl1;
        private BarButtonItem ToolAceptar;
        private BarButtonItem ToolActualizar;
        private BarButtonItem ToolCancelar;
        protected ButtonEdit txtFiltro;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpResultados = new GroupControl();
            this.grpCriterios = new GroupControl();
            this.btnBusqueda = new PlantillaBoton();
            this.txtFiltro = new ButtonEdit();
            this.cboFiltro = new ComboBoxEdit();
            this.lblValor = new LabelControl();
            this.lblFiltro = new LabelControl();
            this.splitContainerControl1 = new SplitContainerControl();
            this.BarraBotones = new BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new BarDockControl();
            this.barDockControl2 = new BarDockControl();
            this.barDockControl3 = new BarDockControl();
            this.barDockControl4 = new BarDockControl();
            this.ToolAceptar = new BarButtonItem();
            this.ToolCancelar = new BarButtonItem();
            this.ToolActualizar = new BarButtonItem();
            this.lblEstado = new BarStaticItem();
            this.grpResultados.BeginInit();
            this.grpCriterios.BeginInit();
            this.grpCriterios.SuspendLayout();
            this.txtFiltro.Properties.BeginInit();
            this.cboFiltro.Properties.BeginInit();
            this.splitContainerControl1.BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.BarraBotones.BeginInit();
            base.SuspendLayout();
            this.grpResultados.AppearanceCaption.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.grpResultados.AppearanceCaption.Options.UseFont = true;
            this.grpResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResultados.Location = new Point(0, 0);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new Size(0x217, 0xf6);
            this.grpResultados.TabIndex = 0;
            this.grpResultados.Text = "Resultados";
            this.grpCriterios.AppearanceCaption.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.grpCriterios.AppearanceCaption.Options.UseFont = true;
            this.grpCriterios.Controls.Add(this.btnBusqueda);
            this.grpCriterios.Controls.Add(this.txtFiltro);
            this.grpCriterios.Controls.Add(this.cboFiltro);
            this.grpCriterios.Controls.Add(this.lblValor);
            this.grpCriterios.Controls.Add(this.lblFiltro);
            this.grpCriterios.Dock = DockStyle.Fill;
            this.grpCriterios.Location = new Point(0, 0);
            this.grpCriterios.Name = "grpCriterios";
            this.grpCriterios.Size = new Size(0x217, 0x70);
            this.grpCriterios.TabIndex = 0;
            this.grpCriterios.Text = "Criterios de B\x00fasqueda";
            this.btnBusqueda.CajaTexto = (TextEdit)this.txtFiltro;
            this.btnBusqueda.CajaTextoConBoton = null;
            this.btnBusqueda.Imagen = PlantillaBoton.TipoBoton.Buscar;
            this.btnBusqueda.Location = new Point(0x1ef, 0x38);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new Size(0x23, 0x1b);
            this.btnBusqueda.TabIndex = 2;
            this.txtFiltro.Location = new Point(0xda, 0x3f);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Delete) });
            this.txtFiltro.Size = new Size(0x110, 20);
            this.txtFiltro.TabIndex = 1;
            this.cboFiltro.Location = new Point(0x16, 0x3f);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboFiltro.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.cboFiltro.Size = new Size(0x90, 20);
            this.cboFiltro.TabIndex = 0;
            this.lblValor.Location = new Point(0xda, 0x2c);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new Size(0x1c, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            this.lblFiltro.Location = new Point(0x16, 0x2c);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new Size(0x1c, 13);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtro:";
            this.splitContainerControl1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new Point(0, 0x1f);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grpCriterios);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grpResultados);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new Size(0x217, 0x16b);
            this.splitContainerControl1.SplitterPosition = 0x70;
            this.splitContainerControl1.TabIndex = 14;
            this.BarraBotones.AllowCustomization = false;
            this.BarraBotones.Bars.AddRange(new DevExpress.XtraBars.Bar[] { this.bar1, this.bar3 });
            this.BarraBotones.DockControls.Add(this.barDockControl1);
            this.BarraBotones.DockControls.Add(this.barDockControl2);
            this.BarraBotones.DockControls.Add(this.barDockControl3);
            this.BarraBotones.DockControls.Add(this.barDockControl4);
            this.BarraBotones.Form = this;
            this.BarraBotones.Items.AddRange(new BarItem[] { this.ToolAceptar, this.ToolCancelar, this.ToolActualizar, this.lblEstado });
            this.BarraBotones.MaxItemId = 4;
            this.BarraBotones.StatusBar= (bar3);
            this.bar1.BarName = "Personalizada 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            bar1.DockStyle = BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo((BarLinkUserDefines)BarLinkUserDefines.PaintStyle, (BarItem)this.ToolAceptar, (BarItemPaintStyle)BarItemPaintStyle.CaptionGlyph), new LinkPersistInfo((BarLinkUserDefines)BarLinkUserDefines.PaintStyle, (BarItem)this.ToolCancelar, "", true, true, true, 0, null, (BarItemPaintStyle)BarItemPaintStyle.CaptionGlyph), new LinkPersistInfo((BarLinkUserDefines)BarLinkUserDefines.PaintStyle, (BarItem)this.ToolActualizar, "", true, true, true, 0, null, (BarItemPaintStyle)BarItemPaintStyle.CaptionGlyph) });
            this.bar1.Text = "Personalizada 2";
            this.bar3.BarName = "Personalizada 3";
            this.bar3.CanDockStyle= BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo((BarItem)this.lblEstado) });
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Personalizada 3";
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = DockStyle.Top;
            this.barDockControl1.Location = new Point(0, 0);
            this.barDockControl1.Size = new Size(0x217, 0x1f);
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = DockStyle.Bottom;
            this.barDockControl2.Location = new Point(0, 0x18a);
            this.barDockControl2.Size = new Size(0x217, 0x19);
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = DockStyle.Left;
            this.barDockControl3.Location = new Point(0, 0x1f);
            this.barDockControl3.Size = new Size(0, 0x16b);
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = DockStyle.Right;
            this.barDockControl4.Location = new Point(0x217, 0x1f);
            this.barDockControl4.Size = new Size(0, 0x16b);
            this.ToolAceptar.Caption = "&Aceptar";
            this.ToolAceptar.Glyph = Resources.ok;
            this.ToolAceptar.Id = 0;
            this.ToolAceptar.Name = "ToolAceptar";
            this.ToolCancelar.Caption = "&Cancelar";
            this.ToolCancelar.Glyph = Resources.cancelar;
            this.ToolCancelar.Id = 1;
            this.ToolCancelar.Name = "ToolCancelar";
            this.ToolActualizar.Caption = "&Refrescar";
            this.ToolActualizar.Glyph = Resources.refrescar;
            this.ToolActualizar.Id = 2;
            this.ToolActualizar.Name = "ToolActualizar";
            this.lblEstado.Caption = "Listo";
            this.lblEstado.Id = 3;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TextAlignment = StringAlignment.Near;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x217, 0x1a3);
            base.Controls.Add(this.splitContainerControl1);
            base.Controls.Add(this.barDockControl3);
            base.Controls.Add(this.barDockControl4);
            base.Controls.Add(this.barDockControl2);
            base.Controls.Add(this.barDockControl1);
            base.EtiquetaEstado = this.lblEstado;
            base.Name = "_PlantillaPrompt";
            this.Text = "_PlantillaPrompt";
            this.grpResultados.EndInit();
            this.grpCriterios.EndInit();
            this.grpCriterios.ResumeLayout(false);
            this.grpCriterios.PerformLayout();
            this.txtFiltro.Properties.EndInit();
            this.cboFiltro.Properties.EndInit();
            this.splitContainerControl1.EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.BarraBotones.EndInit();
            base.ResumeLayout(false);

        }

        #endregion
    }
}