namespace ErickOrlando.Seguridad.WinForms
{
    partial class ActivacionUsuario
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
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label nombresCompletosLabel;
            System.Windows.Forms.Label preguntaSecretaLabel;
            System.Windows.Forms.Label respuestaSecretaLabel;
            System.Windows.Forms.Label claveSecretaLabel;
            System.Windows.Forms.Label confirmarClaveLabel;
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivacionUsuario));
            this.activarUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreUsuarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nombresCompletosTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.preguntaSecretaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.respuestaSecretaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.claveSecretaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.confirmarClaveTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            nombresCompletosLabel = new System.Windows.Forms.Label();
            preguntaSecretaLabel = new System.Windows.Forms.Label();
            respuestaSecretaLabel = new System.Windows.Forms.Label();
            claveSecretaLabel = new System.Windows.Forms.Label();
            confirmarClaveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activarUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreUsuarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombresCompletosTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntaSecretaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaSecretaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claveSecretaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmarClaveTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new System.Drawing.Point(12, 18);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(87, 13);
            nombreUsuarioLabel.TabIndex = 1;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // nombresCompletosLabel
            // 
            nombresCompletosLabel.AutoSize = true;
            nombresCompletosLabel.Location = new System.Drawing.Point(12, 44);
            nombresCompletosLabel.Name = "nombresCompletosLabel";
            nombresCompletosLabel.Size = new System.Drawing.Size(106, 13);
            nombresCompletosLabel.TabIndex = 2;
            nombresCompletosLabel.Text = "Nombres Completos:";
            // 
            // preguntaSecretaLabel
            // 
            preguntaSecretaLabel.AutoSize = true;
            preguntaSecretaLabel.Location = new System.Drawing.Point(12, 70);
            preguntaSecretaLabel.Name = "preguntaSecretaLabel";
            preguntaSecretaLabel.Size = new System.Drawing.Size(95, 13);
            preguntaSecretaLabel.TabIndex = 4;
            preguntaSecretaLabel.Text = "Pregunta Secreta:";
            // 
            // respuestaSecretaLabel
            // 
            respuestaSecretaLabel.AutoSize = true;
            respuestaSecretaLabel.Location = new System.Drawing.Point(12, 96);
            respuestaSecretaLabel.Name = "respuestaSecretaLabel";
            respuestaSecretaLabel.Size = new System.Drawing.Size(102, 13);
            respuestaSecretaLabel.TabIndex = 6;
            respuestaSecretaLabel.Text = "Respuesta Secreta:";
            // 
            // claveSecretaLabel
            // 
            claveSecretaLabel.AutoSize = true;
            claveSecretaLabel.Location = new System.Drawing.Point(12, 122);
            claveSecretaLabel.Name = "claveSecretaLabel";
            claveSecretaLabel.Size = new System.Drawing.Size(78, 13);
            claveSecretaLabel.TabIndex = 8;
            claveSecretaLabel.Text = "Clave Secreta:";
            // 
            // confirmarClaveLabel
            // 
            confirmarClaveLabel.AutoSize = true;
            confirmarClaveLabel.Location = new System.Drawing.Point(12, 148);
            confirmarClaveLabel.Name = "confirmarClaveLabel";
            confirmarClaveLabel.Size = new System.Drawing.Size(88, 13);
            confirmarClaveLabel.TabIndex = 10;
            confirmarClaveLabel.Text = "Confirmar Clave:";
            // 
            // activarUsuarioBindingSource
            // 
            this.activarUsuarioBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Entidades.ActivarUsuario);
            // 
            // nombreUsuarioTextEdit
            // 
            this.nombreUsuarioTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activarUsuarioBindingSource, "NombreUsuario", true));
            this.nombreUsuarioTextEdit.Location = new System.Drawing.Point(124, 15);
            this.nombreUsuarioTextEdit.Name = "nombreUsuarioTextEdit";
            this.nombreUsuarioTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.nombreUsuarioTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.nombreUsuarioTextEdit.Properties.ReadOnly = true;
            this.nombreUsuarioTextEdit.Size = new System.Drawing.Size(202, 20);
            this.nombreUsuarioTextEdit.TabIndex = 2;
            // 
            // nombresCompletosTextEdit
            // 
            this.nombresCompletosTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activarUsuarioBindingSource, "NombresCompletos", true));
            this.nombresCompletosTextEdit.Location = new System.Drawing.Point(124, 41);
            this.nombresCompletosTextEdit.Name = "nombresCompletosTextEdit";
            this.nombresCompletosTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.nombresCompletosTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.nombresCompletosTextEdit.Properties.ReadOnly = true;
            this.nombresCompletosTextEdit.Size = new System.Drawing.Size(316, 20);
            this.nombresCompletosTextEdit.TabIndex = 3;
            // 
            // preguntaSecretaTextEdit
            // 
            this.preguntaSecretaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activarUsuarioBindingSource, "PreguntaSecreta", true));
            this.preguntaSecretaTextEdit.Location = new System.Drawing.Point(124, 67);
            this.preguntaSecretaTextEdit.Name = "preguntaSecretaTextEdit";
            this.preguntaSecretaTextEdit.Size = new System.Drawing.Size(316, 20);
            toolTipTitleItem1.Text = "Pregunta Secreta";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Coloque aquí la pregunta secreta que le ayudará a cambiar su contraseña en un fut" +
    "uro";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.preguntaSecretaTextEdit.SuperTip = superToolTip1;
            this.preguntaSecretaTextEdit.TabIndex = 5;
            // 
            // respuestaSecretaTextEdit
            // 
            this.respuestaSecretaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activarUsuarioBindingSource, "RespuestaSecreta", true));
            this.respuestaSecretaTextEdit.Location = new System.Drawing.Point(124, 93);
            this.respuestaSecretaTextEdit.Name = "respuestaSecretaTextEdit";
            this.respuestaSecretaTextEdit.Properties.UseSystemPasswordChar = true;
            this.respuestaSecretaTextEdit.Size = new System.Drawing.Size(316, 20);
            toolTipTitleItem2.Text = "Respuesta Secreta";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Coloque aquí su respuesta a la pregunta secreta, recuerde que se diferencian las " +
    "mayúsculas y minúsculas";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.respuestaSecretaTextEdit.SuperTip = superToolTip2;
            this.respuestaSecretaTextEdit.TabIndex = 7;
            // 
            // claveSecretaTextEdit
            // 
            this.claveSecretaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activarUsuarioBindingSource, "ClaveSecreta", true));
            this.claveSecretaTextEdit.Location = new System.Drawing.Point(124, 119);
            this.claveSecretaTextEdit.Name = "claveSecretaTextEdit";
            this.claveSecretaTextEdit.Properties.UseSystemPasswordChar = true;
            this.claveSecretaTextEdit.Size = new System.Drawing.Size(316, 20);
            this.claveSecretaTextEdit.TabIndex = 9;
            // 
            // confirmarClaveTextEdit
            // 
            this.confirmarClaveTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activarUsuarioBindingSource, "ConfirmarClave", true));
            this.confirmarClaveTextEdit.Location = new System.Drawing.Point(124, 145);
            this.confirmarClaveTextEdit.Name = "confirmarClaveTextEdit";
            this.confirmarClaveTextEdit.Properties.UseSystemPasswordChar = true;
            this.confirmarClaveTextEdit.Size = new System.Drawing.Size(316, 20);
            this.confirmarClaveTextEdit.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::ErickOrlando.Seguridad.WinForms.Properties.Resources.Ok;
            this.btnOK.Location = new System.Drawing.Point(114, 188);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "&Aceptar";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::ErickOrlando.Seguridad.WinForms.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(258, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.activarUsuarioBindingSource;
            // 
            // ActivacionUsuario
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 223);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(confirmarClaveLabel);
            this.Controls.Add(this.confirmarClaveTextEdit);
            this.Controls.Add(claveSecretaLabel);
            this.Controls.Add(this.claveSecretaTextEdit);
            this.Controls.Add(respuestaSecretaLabel);
            this.Controls.Add(this.respuestaSecretaTextEdit);
            this.Controls.Add(preguntaSecretaLabel);
            this.Controls.Add(this.preguntaSecretaTextEdit);
            this.Controls.Add(nombresCompletosLabel);
            this.Controls.Add(this.nombresCompletosTextEdit);
            this.Controls.Add(nombreUsuarioLabel);
            this.Controls.Add(this.nombreUsuarioTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivacionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activación de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.activarUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreUsuarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombresCompletosTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntaSecretaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaSecretaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claveSecretaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmarClaveTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource activarUsuarioBindingSource;
        private DevExpress.XtraEditors.TextEdit nombreUsuarioTextEdit;
        private DevExpress.XtraEditors.TextEdit nombresCompletosTextEdit;
        private DevExpress.XtraEditors.TextEdit preguntaSecretaTextEdit;
        private DevExpress.XtraEditors.TextEdit respuestaSecretaTextEdit;
        private DevExpress.XtraEditors.TextEdit claveSecretaTextEdit;
        private DevExpress.XtraEditors.TextEdit confirmarClaveTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}