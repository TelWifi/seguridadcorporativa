namespace Gromero.Seguridad.Windows.Cargos
{
    partial class frmMntCargo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descripcionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.estadoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.sociedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sociedadesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvCargos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoSociedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnDelete = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociedadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociedadesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(18, 53);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(44, 13);
            codigoLabel.TabIndex = 5;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(18, 79);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(65, 13);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(18, 105);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(44, 13);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "Estado:";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.Editables.Cargo);
            // 
            // codigoTextEdit
            // 
            this.codigoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cargoBindingSource, "Codigo", true));
            this.codigoTextEdit.Location = new System.Drawing.Point(89, 50);
            this.codigoTextEdit.MenuManager = this.BarraBotones;
            this.codigoTextEdit.Name = "codigoTextEdit";
            this.codigoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codigoTextEdit.TabIndex = 6;
            // 
            // descripcionTextEdit
            // 
            this.descripcionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cargoBindingSource, "Descripcion", true));
            this.descripcionTextEdit.Location = new System.Drawing.Point(89, 76);
            this.descripcionTextEdit.MenuManager = this.BarraBotones;
            this.descripcionTextEdit.Name = "descripcionTextEdit";
            this.descripcionTextEdit.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextEdit.TabIndex = 7;
            // 
            // estadoCheckEdit
            // 
            this.estadoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cargoBindingSource, "Estado", true));
            this.estadoCheckEdit.Location = new System.Drawing.Point(87, 102);
            this.estadoCheckEdit.MenuManager = this.BarraBotones;
            this.estadoCheckEdit.Name = "estadoCheckEdit";
            this.estadoCheckEdit.Properties.Caption = "Habilitado";
            this.estadoCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.estadoCheckEdit.TabIndex = 9;
            // 
            // sociedadesBindingSource
            // 
            this.sociedadesBindingSource.DataMember = "Sociedades";
            this.sociedadesBindingSource.DataSource = this.cargoBindingSource;
            // 
            // sociedadesGridControl
            // 
            this.sociedadesGridControl.DataSource = this.sociedadesBindingSource;
            this.sociedadesGridControl.Location = new System.Drawing.Point(21, 138);
            this.sociedadesGridControl.MainView = this.gdvCargos;
            this.sociedadesGridControl.MenuManager = this.BarraBotones;
            this.sociedadesGridControl.Name = "sociedadesGridControl";
            this.sociedadesGridControl.Size = new System.Drawing.Size(315, 220);
            this.sociedadesGridControl.TabIndex = 10;
            this.sociedadesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvCargos});
            // 
            // gdvCargos
            // 
            this.gdvCargos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoSociedad});
            this.gdvCargos.GridControl = this.sociedadesGridControl;
            this.gdvCargos.Name = "gdvCargos";
            this.gdvCargos.OptionsCustomization.AllowGroup = false;
            this.gdvCargos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvCargos.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigoSociedad
            // 
            this.colCodigoSociedad.FieldName = "CodigoSociedad";
            this.colCodigoSociedad.Name = "colCodigoSociedad";
            this.colCodigoSociedad.Visible = true;
            this.colCodigoSociedad.VisibleIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.CajaTexto = null;
            this.btnAdd.CajaTextoConBoton = null;
            this.btnAdd.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Agregar;
            this.btnAdd.Location = new System.Drawing.Point(356, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CajaTexto = null;
            this.btnDelete.CajaTextoConBoton = null;
            this.btnDelete.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Eliminar;
            this.btnDelete.Location = new System.Drawing.Point(356, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 24);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnDelete_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.cargoBindingSource;
            // 
            // frmMntCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 394);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.sociedadesGridControl);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoCheckEdit);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextEdit);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextEdit);
            this.Name = "frmMntCargo";
            this.Text = "Cargo";
            this.Controls.SetChildIndex(this.codigoTextEdit, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextEdit, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.estadoCheckEdit, 0);
            this.Controls.SetChildIndex(estadoLabel, 0);
            this.Controls.SetChildIndex(this.sociedadesGridControl, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociedadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociedadesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cargoBindingSource;
        private DevExpress.XtraEditors.TextEdit codigoTextEdit;
        private DevExpress.XtraEditors.TextEdit descripcionTextEdit;
        private DevExpress.XtraEditors.CheckEdit estadoCheckEdit;
        private System.Windows.Forms.BindingSource sociedadesBindingSource;
        private DevExpress.XtraGrid.GridControl sociedadesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvCargos;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoSociedad;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnAdd;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnDelete;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}