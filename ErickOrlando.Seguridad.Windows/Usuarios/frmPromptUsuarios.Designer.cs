namespace ErickOrlando.Seguridad.Windows.Usuarios
{
	partial class frmPromptUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromptUsuarios));
			this.usuarioInfoListBindingSource = new System.Windows.Forms.BindingSource();
			this.usuarioInfoListGridControl = new DevExpress.XtraGrid.GridControl();
			this.gdvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDNI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.grpResultados)).BeginInit();
			this.grpResultados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
			this.grpCriterios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// grpResultados
			// 
			this.grpResultados.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpResultados.AppearanceCaption.Options.UseFont = true;
			this.grpResultados.Controls.Add(this.usuarioInfoListGridControl);
			this.grpResultados.Size = new System.Drawing.Size(535, 240);
			// 
			// grpCriterios
			// 
			this.grpCriterios.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpCriterios.AppearanceCaption.Options.UseFont = true;
			// 
			// txtFiltro
			// 
			// 
			// cboFiltro
			// 
			this.cboFiltro.EditValue = "Codigo de Usuario";
			this.cboFiltro.Properties.Items.AddRange(new object[] {
            "Codigo de Usuario",
            "Nombres",
            "Apellido Paterno",
            "Apellido Materno",
            "DNI",
            "Correo Electrónico",
            "Sin Filtros (Mostrar Todos)"});
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Size = new System.Drawing.Size(535, 364);
			// 
			// usuarioInfoListBindingSource
			// 
			this.usuarioInfoListBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.UsuarioInfo);
			// 
			// usuarioInfoListGridControl
			// 
			this.usuarioInfoListGridControl.DataSource = this.usuarioInfoListBindingSource;
			this.usuarioInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usuarioInfoListGridControl.Location = new System.Drawing.Point(2, 26);
			this.usuarioInfoListGridControl.MainView = this.gdvUsuarios;
			this.usuarioInfoListGridControl.Name = "usuarioInfoListGridControl";
			this.usuarioInfoListGridControl.Size = new System.Drawing.Size(531, 212);
			this.usuarioInfoListGridControl.TabIndex = 0;
			this.usuarioInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsuarios});
			// 
			// gdvUsuarios
			// 
			this.gdvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colNombres,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colCorreo,
            this.colDNI,
            this.colEstado,
            this.colTipo});
			this.gdvUsuarios.GridControl = this.usuarioInfoListGridControl;
			this.gdvUsuarios.Name = "gdvUsuarios";
			this.gdvUsuarios.OptionsBehavior.Editable = false;
			this.gdvUsuarios.OptionsDetail.EnableMasterViewMode = false;
			this.gdvUsuarios.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gdvUsuarios.OptionsView.ColumnAutoWidth = false;
			// 
			// colCodigo
			// 
			this.colCodigo.FieldName = "Codigo";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.Visible = true;
			this.colCodigo.VisibleIndex = 0;
			this.colCodigo.Width = 52;
			// 
			// colNombres
			// 
			this.colNombres.FieldName = "Nombres";
			this.colNombres.Name = "colNombres";
			this.colNombres.Visible = true;
			this.colNombres.VisibleIndex = 1;
			this.colNombres.Width = 61;
			// 
			// colApellidoPaterno
			// 
			this.colApellidoPaterno.FieldName = "ApellidoPaterno";
			this.colApellidoPaterno.Name = "colApellidoPaterno";
			this.colApellidoPaterno.Visible = true;
			this.colApellidoPaterno.VisibleIndex = 2;
			this.colApellidoPaterno.Width = 97;
			// 
			// colApellidoMaterno
			// 
			this.colApellidoMaterno.FieldName = "ApellidoMaterno";
			this.colApellidoMaterno.Name = "colApellidoMaterno";
			this.colApellidoMaterno.Visible = true;
			this.colApellidoMaterno.VisibleIndex = 3;
			this.colApellidoMaterno.Width = 99;
			// 
			// colCorreo
			// 
			this.colCorreo.FieldName = "Correo";
			this.colCorreo.Name = "colCorreo";
			this.colCorreo.Visible = true;
			this.colCorreo.VisibleIndex = 4;
			this.colCorreo.Width = 52;
			// 
			// colDNI
			// 
			this.colDNI.FieldName = "DNI";
			this.colDNI.Name = "colDNI";
			this.colDNI.Visible = true;
			this.colDNI.VisibleIndex = 5;
			this.colDNI.Width = 37;
			// 
			// colEstado
			// 
			this.colEstado.FieldName = "Estado";
			this.colEstado.Name = "colEstado";
			this.colEstado.Visible = true;
			this.colEstado.VisibleIndex = 6;
			this.colEstado.Width = 52;
			// 
			// colTipo
			// 
			this.colTipo.FieldName = "Tipo";
			this.colTipo.Name = "colTipo";
			this.colTipo.Visible = true;
			this.colTipo.VisibleIndex = 7;
			this.colTipo.Width = 39;
			// 
			// frmPromptUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 419);
			this.CriterioBusqueda = "Codigo";
			this.InfoListDataGridView = this.gdvUsuarios;
			this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
			this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
			this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
			this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios3"))));
			this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios4"))));
			this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios5"))));
			this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios6"))));
			this.Name = "frmPromptUsuarios";
			this.ObjetoLista = this.usuarioInfoListBindingSource;
			this.Text = "Búsqueda de Usuarios";
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
			((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl usuarioInfoListGridControl;
		private System.Windows.Forms.BindingSource usuarioInfoListBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gdvUsuarios;
		private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
		private DevExpress.XtraGrid.Columns.GridColumn colNombres;
		private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
		private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
		private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
		private DevExpress.XtraGrid.Columns.GridColumn colDNI;
		private DevExpress.XtraGrid.Columns.GridColumn colEstado;
		private DevExpress.XtraGrid.Columns.GridColumn colTipo;
	}
}