namespace Gromero.Seguridad.WinForms
{
	partial class LoginForm
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lnkCambiarClave = new DevExpress.XtraEditors.HyperLinkEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboDominio = new DevExpress.XtraEditors.ComboBoxEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkCambiarClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDominio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.usuario;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(327, 115);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.contrasena;
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(327, 168);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(327, 139);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(239, 22);
            toolTipTitleItem1.Appearance.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.usuario;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.usuario;
            toolTipTitleItem1.Text = "Usuario";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Ingrese el Nombre de Usuario";
            toolTipTitleItem2.LeftIndent = 6;
            toolTipTitleItem2.Text = "Puede ingresar el Dominio separándolo \r\ncon el caracter \'\\\'";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            this.txtUser.SuperTip = superToolTip1;
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(327, 193);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(239, 22);
            this.txtPass.TabIndex = 3;
            // 
            // lnkCambiarClave
            // 
            this.lnkCambiarClave.EditValue = "Cambiar Contraseña";
            this.lnkCambiarClave.Location = new System.Drawing.Point(327, 227);
            this.lnkCambiarClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lnkCambiarClave.Name = "lnkCambiarClave";
            this.lnkCambiarClave.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lnkCambiarClave.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lnkCambiarClave.Properties.Appearance.Options.UseBackColor = true;
            this.lnkCambiarClave.Properties.Appearance.Options.UseForeColor = true;
            this.lnkCambiarClave.Size = new System.Drawing.Size(145, 22);
            this.lnkCambiarClave.TabIndex = 4;
            this.lnkCambiarClave.Visible = false;
            this.lnkCambiarClave.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.lnkCambiarClave_OpenLink);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.Ok;
            this.btnLogin.Location = new System.Drawing.Point(327, 273);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "&Autenticar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.Close;
            this.btnCancelar.Location = new System.Drawing.Point(464, 273);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.Ok;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(325, 57);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 20);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Dominio:";
            // 
            // cboDominio
            // 
            this.cboDominio.EditValue = "";
            this.cboDominio.Location = new System.Drawing.Point(327, 89);
            this.cboDominio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDominio.Name = "cboDominio";
            this.cboDominio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDominio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboDominio.Size = new System.Drawing.Size(239, 22);
            this.cboDominio.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Gromero.Seguridad.WinForms.Properties.Resources.Security_Approved_icon;
            this.pictureBox1.Location = new System.Drawing.Point(77, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Gromero.Seguridad.WinForms.Properties.Resources.fondoapp;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(623, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboDominio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnkCambiarClave);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkCambiarClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDominio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtUser;
		private DevExpress.XtraEditors.TextEdit txtPass;
		private DevExpress.XtraEditors.HyperLinkEdit lnkCambiarClave;
		private DevExpress.XtraEditors.SimpleButton btnLogin;
		private DevExpress.XtraEditors.SimpleButton btnCancelar;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.ComboBoxEdit cboDominio;
		private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}