namespace ErickOrlando.Seguridad.Windows.Cargos
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
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(21, 65);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(56, 17);
            codigoLabel.TabIndex = 5;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(21, 97);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(83, 17);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(21, 129);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(55, 17);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "Estado:";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.Editables.Cargo);
            // 
            // codigoTextEdit
            // 
            this.codigoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cargoBindingSource, "Codigo", true));
            this.codigoTextEdit.Location = new System.Drawing.Point(104, 62);
            this.codigoTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codigoTextEdit.MenuManager = this.BarraBotones;
            this.codigoTextEdit.Name = "codigoTextEdit";
            this.codigoTextEdit.Size = new System.Drawing.Size(117, 22);
            this.codigoTextEdit.TabIndex = 6;
            // 
            // descripcionTextEdit
            // 
            this.descripcionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cargoBindingSource, "Descripcion", true));
            this.descripcionTextEdit.Location = new System.Drawing.Point(104, 94);
            this.descripcionTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descripcionTextEdit.MenuManager = this.BarraBotones;
            this.descripcionTextEdit.Name = "descripcionTextEdit";
            this.descripcionTextEdit.Size = new System.Drawing.Size(117, 22);
            this.descripcionTextEdit.TabIndex = 7;
            // 
            // estadoCheckEdit
            // 
            this.estadoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cargoBindingSource, "Estado", true));
            this.estadoCheckEdit.Location = new System.Drawing.Point(101, 126);
            this.estadoCheckEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.estadoCheckEdit.MenuManager = this.BarraBotones;
            this.estadoCheckEdit.Name = "estadoCheckEdit";
            this.estadoCheckEdit.Properties.Caption = "Habilitado";
            this.estadoCheckEdit.Size = new System.Drawing.Size(87, 20);
            this.estadoCheckEdit.TabIndex = 9;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.cargoBindingSource;
            // 
            // frmMntCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 206);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoCheckEdit);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextEdit);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextEdit);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmMntCargo";
            this.Text = "Cargo";
            this.Controls.SetChildIndex(this.codigoTextEdit, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextEdit, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.estadoCheckEdit, 0);
            this.Controls.SetChildIndex(estadoLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cargoBindingSource;
        private DevExpress.XtraEditors.TextEdit codigoTextEdit;
        private DevExpress.XtraEditors.TextEdit descripcionTextEdit;
        private DevExpress.XtraEditors.CheckEdit estadoCheckEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}