namespace ErickOrlando.Seguridad.Windows.Usuarios
{
	partial class frmPromptUsuariosAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromptUsuariosAD));
            this.usuarioADInfoListBindingSource = new System.Windows.Forms.BindingSource();
            this.usuarioADInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvUsuariosAD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrincipalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dominioInfoListBindingSource = new System.Windows.Forms.BindingSource();
            this.dominioTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpResultados)).BeginInit();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioADInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioADInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuariosAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dominioInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dominioTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResultados
            // 
            this.grpResultados.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultados.AppearanceCaption.Options.UseFont = true;
            this.grpResultados.Controls.Add(this.usuarioADInfoListGridControl);
            this.grpResultados.Size = new System.Drawing.Size(556, 306);
            // 
            // grpCriterios
            // 
            this.grpCriterios.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCriterios.AppearanceCaption.Options.UseFont = true;
            this.grpCriterios.Controls.Add(this.dominioTextEdit);
            this.grpCriterios.Controls.Add(this.labelControl1);
            this.grpCriterios.Size = new System.Drawing.Size(556, 142);
            this.grpCriterios.Controls.SetChildIndex(this.lblFiltro, 0);
            this.grpCriterios.Controls.SetChildIndex(this.lblValor, 0);
            this.grpCriterios.Controls.SetChildIndex(this.cboFiltro, 0);
            this.grpCriterios.Controls.SetChildIndex(this.txtFiltro, 0);
            this.grpCriterios.Controls.SetChildIndex(this.labelControl1, 0);
            this.grpCriterios.Controls.SetChildIndex(this.dominioTextEdit, 0);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(217, 63);
            // 
            // cboFiltro
            // 
            this.cboFiltro.EditValue = "Nombre de Usuario";
            this.cboFiltro.Properties.Items.AddRange(new object[] {
            "Nombre de Usuario",
            "Correo Electrónico"});
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(217, 44);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(556, 460);
            this.splitContainerControl1.SplitterPosition = 142;
            // 
            // usuarioADInfoListBindingSource
            // 
            this.usuarioADInfoListBindingSource.DataSource = typeof(GRomeroAD.DirectoryServices.Directorio);
            // 
            // usuarioADInfoListGridControl
            // 
            this.usuarioADInfoListGridControl.DataSource = this.usuarioADInfoListBindingSource;
            this.usuarioADInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarioADInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.usuarioADInfoListGridControl.MainView = this.gdvUsuariosAD;
            this.usuarioADInfoListGridControl.Name = "usuarioADInfoListGridControl";
            this.usuarioADInfoListGridControl.Size = new System.Drawing.Size(552, 278);
            this.usuarioADInfoListGridControl.TabIndex = 0;
            this.usuarioADInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsuariosAD});
            // 
            // gdvUsuariosAD
            // 
            this.gdvUsuariosAD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colDepartamento,
            this.colCompany,
            this.colDisplayName,
            this.colPrincipalName});
            this.gdvUsuariosAD.GridControl = this.usuarioADInfoListGridControl;
            this.gdvUsuariosAD.Name = "gdvUsuariosAD";
            this.gdvUsuariosAD.OptionsBehavior.Editable = false;
            this.gdvUsuariosAD.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvUsuariosAD.OptionsView.ColumnAutoWidth = false;
            this.gdvUsuariosAD.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUserName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Usuario";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            this.colUserName.Width = 68;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Nombres";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            this.colFirstName.Width = 61;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Apellidos";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            this.colLastName.Width = 61;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Correo";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 52;
            // 
            // colDepartamento
            // 
            this.colDepartamento.FieldName = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 6;
            this.colDepartamento.Width = 88;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Compañía";
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 7;
            this.colCompany.Width = 66;
            // 
            // colDisplayName
            // 
            this.colDisplayName.Caption = "Nombre para Mostrar";
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 1;
            this.colDisplayName.Width = 121;
            // 
            // colPrincipalName
            // 
            this.colPrincipalName.Caption = "Inicio de Sesión";
            this.colPrincipalName.FieldName = "PrincipalName";
            this.colPrincipalName.Name = "colPrincipalName";
            this.colPrincipalName.Visible = true;
            this.colPrincipalName.VisibleIndex = 5;
            this.colPrincipalName.Width = 93;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Dominio:";
            // 
            // dominioInfoListBindingSource
            // 
            this.dominioInfoListBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.Dominios.DominioInfoList);
            // 
            // dominioTextEdit
            // 
            this.dominioTextEdit.Location = new System.Drawing.Point(22, 105);
            this.dominioTextEdit.Name = "dominioTextEdit";
            this.dominioTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dominioTextEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.dominioTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dominioTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreCorto", "Nombre Corto", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreLargo", "Nombre Largo", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.dominioTextEdit.Properties.DataSource = this.dominioInfoListBindingSource;
            this.dominioTextEdit.Properties.DisplayMember = "NombreCorto";
            this.dominioTextEdit.Properties.NullText = "";
            this.dominioTextEdit.Properties.ValueMember = "NombreLargo";
            this.dominioTextEdit.Size = new System.Drawing.Size(144, 20);
            this.dominioTextEdit.TabIndex = 27;
            // 
            // frmPromptUsuariosAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 515);
            this.CriterioBusqueda = "UserName";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.InfoListDataGridView = this.gdvUsuariosAD;
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
            this.Name = "frmPromptUsuariosAD";
            this.ObjetoLista = this.usuarioADInfoListBindingSource;
            this.Text = "Búsqueda de Usuarios en el Directorio Activo";
            ((System.ComponentModel.ISupportInitialize)(this.grpResultados)).EndInit();
            this.grpResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            this.grpCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioADInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioADInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuariosAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dominioInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dominioTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl usuarioADInfoListGridControl;
		private System.Windows.Forms.BindingSource usuarioADInfoListBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gdvUsuariosAD;
		private DevExpress.XtraGrid.Columns.GridColumn colUserName;
		private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
		private DevExpress.XtraGrid.Columns.GridColumn colLastName;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail;
		private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
		private DevExpress.XtraGrid.Columns.GridColumn colCompany;
		private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
		private DevExpress.XtraGrid.Columns.GridColumn colPrincipalName;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LookUpEdit dominioTextEdit;
		private System.Windows.Forms.BindingSource dominioInfoListBindingSource;
	}
}