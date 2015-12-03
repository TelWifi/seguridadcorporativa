using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ErickOrlando.Utilidades.Windows.Controles;
using ErickOrlando.Utilidades.Windows.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace ErickOrlando.Utilidades.Windows
{
    partial class _PlantillaGestor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // Fields
        protected Bar bar1;
        private Bar bar2;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarDockControl barDockControlTop;
        protected BarManager BarraBotones;
        private PlantillaBoton btnBusqueda;
        protected GroupControl grpCriterios;
        protected GroupControl grpGrilla;
        protected GroupControl grpValores;
        protected BarStaticItem lblEstado;
        private SplitContainerControl splitContainerControl1;
        private SplitContainerControl splitContainerControl2;
        private BarButtonItem ToolActualizar;
        private BarButtonItem ToolBuscar;
        private BarButtonItem ToolEditar;
        private BarButtonItem ToolEliminar;
        private BarButtonItem ToolNuevo;
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
            this.BarraBotones = new BarManager();
            this.bar1 = new Bar();
            this.ToolNuevo = new BarButtonItem();
            this.ToolEditar = new BarButtonItem();
            this.ToolEliminar = new BarButtonItem();
            this.ToolBuscar = new BarButtonItem();
            this.ToolActualizar = new BarButtonItem();
            this.barDockControlTop = new BarDockControl();
            this.barDockControlBottom = new BarDockControl();
            this.barDockControlLeft = new BarDockControl();
            this.barDockControlRight = new BarDockControl();
            this.splitContainerControl1 = new SplitContainerControl();
            this.splitContainerControl2 = new SplitContainerControl();
            this.grpCriterios = new GroupControl();
            this.grpValores = new GroupControl();
            this.btnBusqueda = new PlantillaBoton();
            this.txtFiltro = new ButtonEdit();
            this.grpGrilla = new GroupControl();
            this.bar2 = new Bar();
            this.lblEstado = new BarStaticItem();
            this.BarraBotones.BeginInit();
            this.splitContainerControl1.BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.splitContainerControl2.BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.grpCriterios.BeginInit();
            this.grpValores.BeginInit();
            this.grpValores.SuspendLayout();
            this.txtFiltro.Properties.BeginInit();
            this.grpGrilla.BeginInit();
            base.SuspendLayout();
            this.BarraBotones.AllowCustomization = false;
            this.BarraBotones.AllowQuickCustomization = false;
            this.BarraBotones.Bars.AddRange(new Bar[] { this.bar1, this.bar2 });
            this.BarraBotones.DockControls.Add(this.barDockControlTop);
            this.BarraBotones.DockControls.Add(this.barDockControlBottom);
            this.BarraBotones.DockControls.Add(this.barDockControlLeft);
            this.BarraBotones.DockControls.Add(this.barDockControlRight);
            this.BarraBotones.Form = this;
            this.BarraBotones.Items.AddRange(new BarItem[] { this.ToolNuevo, this.ToolEditar, this.ToolEliminar, this.ToolBuscar, this.ToolActualizar, this.lblEstado });
            this.BarraBotones.MaxItemId = 6;
            this.BarraBotones.StatusBar = this.bar2;
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo((BarItem)this.ToolNuevo), new LinkPersistInfo((BarItem)this.ToolEditar), new LinkPersistInfo((BarItem)this.ToolEliminar), new LinkPersistInfo((BarItem)this.ToolBuscar), new LinkPersistInfo((BarItem)this.ToolActualizar) });
            this.bar1.Text = "Herramientas";
            this.ToolNuevo.Caption = "&Nuevo";
            this.ToolNuevo.Glyph = Resources.db_add;
            this.ToolNuevo.Id = 0;
            this.ToolNuevo.Name = "ToolNuevo";
            this.ToolNuevo.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            this.ToolNuevo.ItemClick += new ItemClickEventHandler(this.btnNuevo_ItemClick);
            this.ToolEditar.Caption = "Ver/&Editar";
            this.ToolEditar.Glyph = Resources.editar;
            this.ToolEditar.Id = 1;
            this.ToolEditar.Name = "ToolEditar";
            this.ToolEditar.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            this.ToolEditar.ItemClick +=new ItemClickEventHandler(this.btnEditar_ItemClick);
            this.ToolEliminar.Caption = "E&liminar";
            this.ToolEliminar.Glyph = Resources.db_remove;
            this.ToolEliminar.Id = 2;
            this.ToolEliminar.Name = "ToolEliminar";
            this.ToolEliminar.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            this.ToolEliminar.ItemClick +=new ItemClickEventHandler(this.btnEliminar_ItemClick);
            this.ToolBuscar.Caption = "&Buscar";
            this.ToolBuscar.Glyph = Resources.buscar;
            this.ToolBuscar.Id = 3;
            this.ToolBuscar.Name = "ToolBuscar";
            this.ToolBuscar.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            this.ToolBuscar.ItemClick +=new ItemClickEventHandler(this.btnBuscar_ItemClick);
            this.ToolActualizar.Caption = "&Actualizar";
            this.ToolActualizar.Glyph = Resources.actualizar;
            this.ToolActualizar.Id = 4;
            this.ToolActualizar.Name = "ToolActualizar";
            this.ToolActualizar.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            this.ToolActualizar.ItemClick +=new ItemClickEventHandler(this.btnActualizar_ItemClick);
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = DockStyle.Top;
            this.barDockControlTop.Location = new Point(0, 0);
            this.barDockControlTop.Size = new Size(0x305, 0x1f);
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = DockStyle.Bottom;
            this.barDockControlBottom.Location = new Point(0, 0x1c5);
            this.barDockControlBottom.Size = new Size(0x305, 0x19);
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = DockStyle.Left;
            this.barDockControlLeft.Location = new Point(0, 0x1f);
            this.barDockControlLeft.Size = new Size(0, 0x1a6);
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = DockStyle.Right;
            this.barDockControlRight.Location = new Point(0x305, 0x1f);
            this.barDockControlRight.Size = new Size(0, 0x1a6);
            this.splitContainerControl1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new Point(0, 0x1f);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grpGrilla);
            this.splitContainerControl1.Panel2.Text = "Contenedor";
            this.splitContainerControl1.Size = new Size(0x305, 0x1a6);
            this.splitContainerControl1.TabIndex = 14;
            this.splitContainerControl1.Text = "splitContainerControl1";
            this.splitContainerControl2.Dock = DockStyle.Fill;
            this.splitContainerControl2.Location = new Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.grpCriterios);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.grpValores);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new Size(0x305, 100);
            this.splitContainerControl2.SplitterPosition = 0x147;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            this.grpCriterios.AppearanceCaption.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.grpCriterios.AppearanceCaption.Options.UseFont = true;
            this.grpCriterios.Dock = DockStyle.Fill;
            this.grpCriterios.Location = new Point(0, 0);
            this.grpCriterios.Name = "grpCriterios";
            this.grpCriterios.Size = new Size(0x147, 100);
            this.grpCriterios.TabIndex = 0;
            this.grpCriterios.Text = "Criterios de Busqueda";
            this.grpValores.AppearanceCaption.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.grpValores.AppearanceCaption.Options.UseFont = true;
            this.grpValores.Controls.Add(this.btnBusqueda);
            this.grpValores.Controls.Add(this.txtFiltro);
            this.grpValores.Dock = DockStyle.Fill;
            this.grpValores.Location = new Point(0, 0);
            this.grpValores.Name = "grpValores";
            this.grpValores.Size = new Size(0x1b9, 100);
            this.grpValores.TabIndex = 0;
            this.grpValores.Text = "Valores";
            this.btnBusqueda.CajaTexto = (TextEdit)this.txtFiltro;
            this.btnBusqueda.CajaTextoConBoton = null;
            this.btnBusqueda.Imagen = PlantillaBoton.TipoBoton.Buscar;
            this.btnBusqueda.Location = new Point(0x153, 0x26);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new Size(0x23, 0x1b);
            this.btnBusqueda.TabIndex = 3;
            this.btnBusqueda.Click += new PlantillaBoton.BotonClick(this.btnBusqueda_Click);
            this.txtFiltro.Location = new Point(0x39, 0x2d);
            this.txtFiltro.MenuManager= (IDXMenuManager)this.BarraBotones;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton((ButtonPredefines)ButtonPredefines.Delete) });
            this.txtFiltro.Size = new Size(0x114, 20);
            this.txtFiltro.TabIndex = 2;
            this.grpGrilla.AppearanceCaption.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.grpGrilla.AppearanceCaption.Options.UseFont = true;
            this.grpGrilla.Dock = DockStyle.Fill;
            this.grpGrilla.Location = new Point(0, 0);
            this.grpGrilla.Name = "grpGrilla";
            this.grpGrilla.Size = new Size(0x305, 0x13d);
            this.grpGrilla.TabIndex = 0;
            this.grpGrilla.Text = "Lista de ";
            this.bar2.BarName = "Personalizada 3";
            this.bar2.CanDockStyle = BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = BarDockStyle.Bottom;
            this.bar2.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(lblEstado) });
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Personalizada 3";
            this.lblEstado.Caption = "Listo";
            this.lblEstado.Id = 5;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TextAlignment = StringAlignment.Near;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x305, 0x1de);
            base.Controls.Add(this.splitContainerControl1);
            base.Controls.Add(this.barDockControlLeft);
            base.Controls.Add(this.barDockControlRight);
            base.Controls.Add(this.barDockControlBottom);
            base.Controls.Add(this.barDockControlTop);
            base.EtiquetaEstado = this.lblEstado;
            base.Name = "_PlantillaGestor";
            this.Text = "_PlantillaGestor";
            this.BarraBotones.EndInit();
            this.splitContainerControl1.EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.splitContainerControl2.EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.grpCriterios.EndInit();
            this.grpValores.EndInit();
            this.grpValores.ResumeLayout(false);
            this.txtFiltro.Properties.EndInit();
            this.grpGrilla.EndInit();
            base.ResumeLayout(false);

        }

        #endregion
    }
}