namespace ErickOrlando.Seguridad.Windows.PerfilesUsuario
{
	partial class frmPerfilesMasivos
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
            System.Windows.Forms.Label aplicacionLabel;
            this.btnBuscarApp = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.aplicacionTextEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.aplicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkSelectAll = new DevExpress.XtraEditors.CheckEdit();
            this.rolesCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.usuariosListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoSeleccion = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDominio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblMensaje = new DevExpress.XtraEditors.LabelControl();
            aplicacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // aplicacionLabel
            // 
            aplicacionLabel.AutoSize = true;
            aplicacionLabel.Location = new System.Drawing.Point(15, 40);
            aplicacionLabel.Name = "aplicacionLabel";
            aplicacionLabel.Size = new System.Drawing.Size(58, 13);
            aplicacionLabel.TabIndex = 24;
            aplicacionLabel.Text = "Aplicación:";
            // 
            // btnBuscarApp
            // 
            this.btnBuscarApp.CajaTexto = null;
            this.btnBuscarApp.CajaTextoConBoton = this.aplicacionTextEdit;
            this.btnBuscarApp.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.BuscarPrompt;
            this.btnBuscarApp.Location = new System.Drawing.Point(354, 31);
            this.btnBuscarApp.Name = "btnBuscarApp";
            this.btnBuscarApp.Size = new System.Drawing.Size(35, 27);
            this.btnBuscarApp.TabIndex = 1;
            this.btnBuscarApp.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnBuscarAplicacion_Click);
            // 
            // aplicacionTextEdit
            // 
            this.aplicacionTextEdit.Location = new System.Drawing.Point(96, 37);
            this.aplicacionTextEdit.MenuManager = this.BarraBotones;
            this.aplicacionTextEdit.Name = "aplicacionTextEdit";
            this.aplicacionTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.aplicacionTextEdit.Size = new System.Drawing.Size(252, 20);
            this.aplicacionTextEdit.TabIndex = 0;
            // 
            // aplicacionBindingSource
            // 
            this.aplicacionBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.Editables.Aplicacion);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectAll.Location = new System.Drawing.Point(184, 58);
            this.chkSelectAll.MenuManager = this.BarraBotones;
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Properties.Caption = "Seleccionar todo";
            this.chkSelectAll.Size = new System.Drawing.Size(103, 19);
            this.chkSelectAll.TabIndex = 25;
            this.chkSelectAll.Visible = false;
            // 
            // rolesCheckedListBoxControl
            // 
            this.rolesCheckedListBoxControl.DataSource = this.rolesBindingSource;
            this.rolesCheckedListBoxControl.Location = new System.Drawing.Point(18, 83);
            this.rolesCheckedListBoxControl.Name = "rolesCheckedListBoxControl";
            this.rolesCheckedListBoxControl.Size = new System.Drawing.Size(239, 287);
            this.rolesCheckedListBoxControl.TabIndex = 26;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.aplicacionBindingSource;
            // 
            // usuarioInfoListBindingSource
            // 
            this.usuarioInfoListBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.UsuarioInfo);
            // 
            // usuarioInfoListGridControl
            // 
            this.usuarioInfoListGridControl.DataSource = this.usuarioInfoListBindingSource;
            this.usuarioInfoListGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.usuarioInfoListGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.usuarioInfoListGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.usuarioInfoListGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.usuarioInfoListGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.usuarioInfoListGridControl.Location = new System.Drawing.Point(281, 83);
            this.usuarioInfoListGridControl.MainView = this.usuariosListGridView;
            this.usuarioInfoListGridControl.MenuManager = this.BarraBotones;
            this.usuarioInfoListGridControl.Name = "usuarioInfoListGridControl";
            this.usuarioInfoListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoSeleccion});
            this.usuarioInfoListGridControl.Size = new System.Drawing.Size(696, 287);
            this.usuarioInfoListGridControl.TabIndex = 26;
            this.usuarioInfoListGridControl.UseEmbeddedNavigator = true;
            this.usuarioInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usuariosListGridView});
            // 
            // usuariosListGridView
            // 
            this.usuariosListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeleccion,
            this.colCodigo,
            this.colDominio,
            this.colNombres,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colAlias,
            this.colTipo});
            this.usuariosListGridView.GridControl = this.usuarioInfoListGridControl;
            this.usuariosListGridView.Name = "usuariosListGridView";
            this.usuariosListGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.usuariosListGridView.OptionsView.ColumnAutoWidth = false;
            // 
            // colSeleccion
            // 
            this.colSeleccion.Caption = "  ";
            this.colSeleccion.ColumnEdit = this.repoSeleccion;
            this.colSeleccion.FieldName = "Seleccionar";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSeleccion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSeleccion.Visible = true;
            this.colSeleccion.VisibleIndex = 0;
            this.colSeleccion.Width = 41;
            // 
            // repoSeleccion
            // 
            this.repoSeleccion.AutoHeight = false;
            this.repoSeleccion.Name = "repoSeleccion";
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            this.colCodigo.Width = 57;
            // 
            // colDominio
            // 
            this.colDominio.FieldName = "Dominio";
            this.colDominio.Name = "colDominio";
            this.colDominio.OptionsColumn.AllowEdit = false;
            this.colDominio.Visible = true;
            this.colDominio.VisibleIndex = 3;
            this.colDominio.Width = 65;
            // 
            // colNombres
            // 
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.OptionsColumn.AllowEdit = false;
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 4;
            this.colNombres.Width = 69;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.FieldName = "ApellidoPaterno";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.OptionsColumn.AllowEdit = false;
            this.colApellidoPaterno.Visible = true;
            this.colApellidoPaterno.VisibleIndex = 5;
            this.colApellidoPaterno.Width = 112;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.FieldName = "ApellidoMaterno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.OptionsColumn.AllowEdit = false;
            this.colApellidoMaterno.Visible = true;
            this.colApellidoMaterno.VisibleIndex = 6;
            this.colApellidoMaterno.Width = 115;
            // 
            // colAlias
            // 
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.OptionsColumn.AllowEdit = false;
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 2;
            this.colAlias.Width = 46;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.lblMensaje.Appearance.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMensaje.Location = new System.Drawing.Point(18, 376);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(959, 82);
            this.lblMensaje.TabIndex = 27;
            this.lblMensaje.Text = "labelControl1";
            // 
            // frmPerfilesMasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 499);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.usuarioInfoListGridControl);
            this.Controls.Add(this.rolesCheckedListBoxControl);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(aplicacionLabel);
            this.Controls.Add(this.btnBuscarApp);
            this.Controls.Add(this.aplicacionTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "frmPerfilesMasivos";
            this.Text = "Asignación Masiva de Perfiles de Usuario";
            this.Controls.SetChildIndex(this.aplicacionTextEdit, 0);
            this.Controls.SetChildIndex(this.btnBuscarApp, 0);
            this.Controls.SetChildIndex(aplicacionLabel, 0);
            this.Controls.SetChildIndex(this.chkSelectAll, 0);
            this.Controls.SetChildIndex(this.rolesCheckedListBoxControl, 0);
            this.Controls.SetChildIndex(this.usuarioInfoListGridControl, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeleccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnBuscarApp;
        private DevExpress.XtraEditors.ButtonEdit aplicacionTextEdit;
        private System.Windows.Forms.BindingSource aplicacionBindingSource;
        private DevExpress.XtraEditors.CheckedListBoxControl rolesCheckedListBoxControl;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.BindingSource usuarioInfoListBindingSource;
        private DevExpress.XtraGrid.GridControl usuarioInfoListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView usuariosListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDominio;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraEditors.LabelControl lblMensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoSeleccion;
		private DevExpress.XtraEditors.CheckEdit chkSelectAll;
	}
}