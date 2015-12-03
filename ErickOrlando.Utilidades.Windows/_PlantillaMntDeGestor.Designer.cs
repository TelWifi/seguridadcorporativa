using DevExpress.XtraBars;
using ErickOrlando.Utilidades.Windows.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ErickOrlando.Utilidades.Windows
{
    partial class _PlantillaMntDeGestor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Bar bar1;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarDockControl barDockControlTop;
        protected BarManager BarraBotones;
        private Bar BarraEstado;
        private IContainer components;
        private BarStaticItem lblEstado;
        protected BarButtonItem ToolActualizar;
        protected BarButtonItem ToolCancelar;
        protected BarButtonItem ToolGrabar;


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
            this.BarraBotones = new BarManager();
            this.bar1 = new Bar();
            this.ToolGrabar = new BarButtonItem();
            this.ToolCancelar = new BarButtonItem();
            this.ToolActualizar = new BarButtonItem();
            this.barDockControlTop = new BarDockControl();
            this.barDockControlBottom = new BarDockControl();
            this.barDockControlLeft = new BarDockControl();
            this.barDockControlRight = new BarDockControl();
            this.BarraEstado = new Bar();
            this.lblEstado = new BarStaticItem();
            this.BarraBotones.BeginInit();
            base.SuspendLayout();
            this.BarraBotones.AllowCustomization = false;
            this.BarraBotones.AllowQuickCustomization = false;
            this.BarraBotones.Bars.AddRange(new Bar[] { this.bar1, this.BarraEstado });
            this.BarraBotones.DockControls.Add(this.barDockControlTop);
            this.BarraBotones.DockControls.Add(this.barDockControlBottom);
            this.BarraBotones.DockControls.Add(this.barDockControlLeft);
            this.BarraBotones.DockControls.Add(this.barDockControlRight);
            this.BarraBotones.Form = this;
            this.BarraBotones.Items.AddRange(new BarItem[] { this.ToolGrabar, this.ToolCancelar, this.ToolActualizar, this.lblEstado });
            this.BarraBotones.MaxItemId = 4;
            this.BarraBotones.StatusBar = this.BarraEstado;
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo((BarItem)this.ToolGrabar), new LinkPersistInfo((BarItem)this.ToolCancelar, true), new LinkPersistInfo((BarLinkUserDefines)BarLinkUserDefines.PaintStyle, (BarItem)this.ToolActualizar, "", true, true, true, 0, null, (BarItemPaintStyle)BarItemPaintStyle.CaptionGlyph) });
            this.bar1.Text = "Herramientas";
            this.ToolGrabar.Caption = "&Grabar";
            this.ToolGrabar.Glyph = Resources.db_update;
            this.ToolGrabar.Id = 0;
            this.ToolGrabar.Name = "ToolGrabar";
            this.ToolGrabar.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            this.ToolCancelar.Caption = "&Cancelar";
            this.ToolCancelar.Glyph = Resources.cerrar;
            this.ToolCancelar.Id = 1;
            this.ToolCancelar.Name = "ToolCancelar";
            this.ToolCancelar.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            this.ToolActualizar.Caption = "&Actualizar";
            this.ToolActualizar.Glyph = Resources.actualizar;
            this.ToolActualizar.Id = 2;
            this.ToolActualizar.Name = "ToolActualizar";
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = DockStyle.Top;
            this.barDockControlTop.Location = new Point(0, 0);
            this.barDockControlTop.Size = new Size(0x209, 0x1f);
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = DockStyle.Bottom;
            this.barDockControlBottom.Location = new Point(0, 0x127);
            this.barDockControlBottom.Size = new Size(0x209, 0x19);
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = DockStyle.Left;
            this.barDockControlLeft.Location = new Point(0, 0x1f);
            this.barDockControlLeft.Size = new Size(0, 0x108);
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = DockStyle.Right;
            this.barDockControlRight.Location = new Point(0x209, 0x1f);
            this.barDockControlRight.Size = new Size(0, 0x108);
            this.BarraEstado.BarName = "BarraEstado";
            this.BarraEstado.CanDockStyle = BarCanDockStyle.Bottom;
            this.BarraEstado.DockCol = 0;
            this.BarraEstado.DockRow = 0;
            this.BarraEstado.DockStyle = BarDockStyle.Bottom;
            this.BarraEstado.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo((BarItem)this.lblEstado) });
            this.BarraEstado.OptionsBar.AllowQuickCustomization = false;
            this.BarraEstado.OptionsBar.DrawDragBorder = false;
            this.BarraEstado.OptionsBar.UseWholeRow = true;
            this.lblEstado.Caption = "Listo";
            this.lblEstado.Id = 3;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TextAlignment = StringAlignment.Near;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x209, 320);
            base.Controls.Add(this.barDockControlLeft);
            base.Controls.Add(this.barDockControlRight);
            base.Controls.Add(this.barDockControlBottom);
            base.Controls.Add(this.barDockControlTop);
            base.EtiquetaEstado = this.lblEstado;
            base.Name = "_PlantillaMntDeGestor";
            this.Text = "_PlantillaMntDeGestor";
            this.BarraBotones.EndInit();
            base.ResumeLayout(false);

        }

        #endregion
    }
}