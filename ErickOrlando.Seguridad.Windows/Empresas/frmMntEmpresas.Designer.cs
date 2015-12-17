namespace ErickOrlando.Seguridad.Windows.Empresas
{
    partial class frmMntEmpresas
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label nombreCortoLabel;
            System.Windows.Forms.Label rUCLabel;
            this.empresaBindingSource = new System.Windows.Forms.BindingSource();
            this.codigoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.razonSocialTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nombreCortoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rUCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            codigoLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            nombreCortoLabel = new System.Windows.Forms.Label();
            rUCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razonSocialTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreCortoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(12, 52);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(44, 13);
            codigoLabel.TabIndex = 14;
            codigoLabel.Text = "Codigo:";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.Editables.Empresa);
            // 
            // codigoTextEdit
            // 
            this.codigoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.empresaBindingSource, "Codigo", true));
            this.codigoTextEdit.Location = new System.Drawing.Point(102, 49);
            this.codigoTextEdit.MenuManager = this.BarraBotones;
            this.codigoTextEdit.Name = "codigoTextEdit";
            this.codigoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codigoTextEdit.TabIndex = 0;
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(12, 92);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(71, 13);
            razonSocialLabel.TabIndex = 15;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // razonSocialTextEdit
            // 
            this.razonSocialTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.empresaBindingSource, "RazonSocial", true));
            this.razonSocialTextEdit.Location = new System.Drawing.Point(102, 89);
            this.razonSocialTextEdit.MenuManager = this.BarraBotones;
            this.razonSocialTextEdit.Name = "razonSocialTextEdit";
            this.razonSocialTextEdit.Size = new System.Drawing.Size(258, 20);
            this.razonSocialTextEdit.TabIndex = 1;
            // 
            // nombreCortoLabel
            // 
            nombreCortoLabel.AutoSize = true;
            nombreCortoLabel.Location = new System.Drawing.Point(12, 129);
            nombreCortoLabel.Name = "nombreCortoLabel";
            nombreCortoLabel.Size = new System.Drawing.Size(78, 13);
            nombreCortoLabel.TabIndex = 16;
            nombreCortoLabel.Text = "Nombre Corto:";
            // 
            // nombreCortoTextEdit
            // 
            this.nombreCortoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.empresaBindingSource, "NombreCorto", true));
            this.nombreCortoTextEdit.Location = new System.Drawing.Point(102, 126);
            this.nombreCortoTextEdit.MenuManager = this.BarraBotones;
            this.nombreCortoTextEdit.Name = "nombreCortoTextEdit";
            this.nombreCortoTextEdit.Size = new System.Drawing.Size(204, 20);
            this.nombreCortoTextEdit.TabIndex = 2;
            // 
            // rUCLabel
            // 
            rUCLabel.AutoSize = true;
            rUCLabel.Location = new System.Drawing.Point(12, 170);
            rUCLabel.Name = "rUCLabel";
            rUCLabel.Size = new System.Drawing.Size(32, 13);
            rUCLabel.TabIndex = 17;
            rUCLabel.Text = "RUC:";
            // 
            // rUCTextEdit
            // 
            this.rUCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.empresaBindingSource, "RUC", true));
            this.rUCTextEdit.Location = new System.Drawing.Point(102, 167);
            this.rUCTextEdit.MenuManager = this.BarraBotones;
            this.rUCTextEdit.Name = "rUCTextEdit";
            this.rUCTextEdit.Size = new System.Drawing.Size(120, 20);
            this.rUCTextEdit.TabIndex = 3;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.empresaBindingSource;
            // 
            // frmMntEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 228);
            this.Controls.Add(rUCLabel);
            this.Controls.Add(this.rUCTextEdit);
            this.Controls.Add(nombreCortoLabel);
            this.Controls.Add(this.nombreCortoTextEdit);
            this.Controls.Add(razonSocialLabel);
            this.Controls.Add(this.razonSocialTextEdit);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextEdit);
            this.Name = "frmMntEmpresas";
            this.Text = "Empresas";
            this.Controls.SetChildIndex(this.codigoTextEdit, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            this.Controls.SetChildIndex(this.razonSocialTextEdit, 0);
            this.Controls.SetChildIndex(razonSocialLabel, 0);
            this.Controls.SetChildIndex(this.nombreCortoTextEdit, 0);
            this.Controls.SetChildIndex(nombreCortoLabel, 0);
            this.Controls.SetChildIndex(this.rUCTextEdit, 0);
            this.Controls.SetChildIndex(rUCLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razonSocialTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreCortoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource empresaBindingSource;
        private DevExpress.XtraEditors.TextEdit codigoTextEdit;
        private DevExpress.XtraEditors.TextEdit razonSocialTextEdit;
        private DevExpress.XtraEditors.TextEdit nombreCortoTextEdit;
        private DevExpress.XtraEditors.TextEdit rUCTextEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}