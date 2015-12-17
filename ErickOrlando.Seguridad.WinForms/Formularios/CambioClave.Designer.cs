namespace ErickOrlando.Seguridad.WinForms
{
    partial class CambioClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioClave));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNew = new DevExpress.XtraEditors.TextEdit();
            this.txtConfirm = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.cambiarClaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.respuestaSecretaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiarClaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaSecretaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Contraseña Nueva:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 142);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Confirmar Contraseña:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Usuario:";
            // 
            // txtNew
            // 
            this.txtNew.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cambiarClaveBindingSource, "ClaveNueva", true));
            this.txtNew.EditValue = "";
            this.txtNew.Location = new System.Drawing.Point(134, 113);
            this.txtNew.Name = "txtNew";
            this.txtNew.Properties.UseSystemPasswordChar = true;
            this.txtNew.Size = new System.Drawing.Size(258, 20);
            this.txtNew.TabIndex = 1;
            // 
            // txtConfirm
            // 
            this.txtConfirm.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cambiarClaveBindingSource, "ConfirmarClave", true));
            this.txtConfirm.EditValue = "";
            this.txtConfirm.Location = new System.Drawing.Point(134, 139);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Properties.UseSystemPasswordChar = true;
            this.txtConfirm.Size = new System.Drawing.Size(258, 20);
            this.txtConfirm.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::ErickOrlando.Seguridad.WinForms.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(215, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::ErickOrlando.Seguridad.WinForms.Properties.Resources.Ok;
            this.btnOK.Location = new System.Drawing.Point(74, 181);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Aceptar";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.cambiarClaveBindingSource;
            // 
            // cambiarClaveBindingSource
            // 
            this.cambiarClaveBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Entidades.CambiarClave);
            // 
            // respuestaSecretaTextEdit
            // 
            this.respuestaSecretaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cambiarClaveBindingSource, "RespuestaSecreta", true));
            this.respuestaSecretaTextEdit.Location = new System.Drawing.Point(134, 87);
            this.respuestaSecretaTextEdit.Name = "respuestaSecretaTextEdit";
            this.respuestaSecretaTextEdit.Properties.UseSystemPasswordChar = true;
            this.respuestaSecretaTextEdit.Size = new System.Drawing.Size(258, 20);
            this.respuestaSecretaTextEdit.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cambiarClaveBindingSource, "Usuario", true));
            this.labelControl1.Location = new System.Drawing.Point(135, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "labelControl1";
            // 
            // labelControl5
            // 
            this.labelControl5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cambiarClaveBindingSource, "NombresCompletos", true));
            this.labelControl5.Location = new System.Drawing.Point(134, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "labelControl1";
            // 
            // labelControl6
            // 
            this.labelControl6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cambiarClaveBindingSource, "PreguntaSecreta", true));
            this.labelControl6.Location = new System.Drawing.Point(134, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "labelControl1";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Nombres Completos:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 64);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(88, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Pregunta Secreta:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 90);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(95, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Respuesta Secreta:";
            // 
            // CambioClave
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(412, 224);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.respuestaSecretaTextEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambioClave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambiarClaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaSecretaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNew;
        private DevExpress.XtraEditors.TextEdit txtConfirm;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.BindingSource cambiarClaveBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit respuestaSecretaTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}