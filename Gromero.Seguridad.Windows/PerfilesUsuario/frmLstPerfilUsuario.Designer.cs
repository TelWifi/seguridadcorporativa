namespace Gromero.Seguridad.Windows.PerfilesUsuario
{
	partial class frmLstPerfilUsuario
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLstPerfilUsuario));
            this.gdvPermisos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.perfilUsuarioInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.perfilUsuarioInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvPerfilUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombresCompletos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAplicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogueado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltimoIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaduca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVigenciaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVigenciaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCriterios = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gdvRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdvRecursos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpcionPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConceder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConceder1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecursoPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).BeginInit();
            this.grpValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).BeginInit();
            this.grpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPerfilUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCriterios
            // 
            this.grpCriterios.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCriterios.AppearanceCaption.Options.UseFont = true;
            this.grpCriterios.Controls.Add(this.cboCriterios);
            // 
            // grpValores
            // 
            this.grpValores.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpValores.AppearanceCaption.Options.UseFont = true;
            // 
            // grpGrilla
            // 
            this.grpGrilla.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrilla.AppearanceCaption.Options.UseFont = true;
            this.grpGrilla.Controls.Add(this.perfilUsuarioInfoListGridControl);
            this.grpGrilla.Size = new System.Drawing.Size(773, 312);
            this.grpGrilla.Text = "Lista de Perfiles de Usuario";
            // 
            // txtFiltro
            // 
            // 
            // gdvPermisos
            // 
            this.gdvPermisos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOpcion,
            this.colOpcionPadre,
            this.colConceder});
            this.gdvPermisos.GridControl = this.perfilUsuarioInfoListGridControl;
            this.gdvPermisos.Name = "gdvPermisos";
            this.gdvPermisos.OptionsBehavior.Editable = false;
            this.gdvPermisos.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // perfilUsuarioInfoListGridControl
            // 
            this.perfilUsuarioInfoListGridControl.DataSource = this.perfilUsuarioInfoListBindingSource;
            this.perfilUsuarioInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gdvRoles;
            gridLevelNode2.LevelTemplate = this.gdvPermisos;
            gridLevelNode2.RelationName = "Permisos";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "Roles";
            gridLevelNode3.LevelTemplate = this.gdvRecursos;
            gridLevelNode3.RelationName = "Recursos";
            this.perfilUsuarioInfoListGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode3});
            this.perfilUsuarioInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.perfilUsuarioInfoListGridControl.MainView = this.gdvPerfilUsuario;
            this.perfilUsuarioInfoListGridControl.MenuManager = this.BarraBotones;
            this.perfilUsuarioInfoListGridControl.Name = "perfilUsuarioInfoListGridControl";
            this.perfilUsuarioInfoListGridControl.ShowOnlyPredefinedDetails = true;
            this.perfilUsuarioInfoListGridControl.Size = new System.Drawing.Size(769, 284);
            this.perfilUsuarioInfoListGridControl.TabIndex = 0;
            this.perfilUsuarioInfoListGridControl.UseEmbeddedNavigator = true;
            this.perfilUsuarioInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvPerfilUsuario,
            this.gdvPermisos,
            this.gdvRoles,
            this.gdvRecursos});
            // 
            // perfilUsuarioInfoListBindingSource
            // 
            this.perfilUsuarioInfoListBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.SoloLectura.PerfilUsuarioInfo);
            // 
            // gdvPerfilUsuario
            // 
            this.gdvPerfilUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoUsuario,
            this.colAlias,
            this.colNombresCompletos,
            this.colCorreo,
            this.colAplicacion,
            this.colLogueado,
            this.colUltimoIngreso,
            this.colCaduca,
            this.colVigenciaInicio,
            this.colVigenciaFin});
            this.gdvPerfilUsuario.GridControl = this.perfilUsuarioInfoListGridControl;
            this.gdvPerfilUsuario.Name = "gdvPerfilUsuario";
            this.gdvPerfilUsuario.OptionsBehavior.Editable = false;
            this.gdvPerfilUsuario.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvPerfilUsuario.OptionsView.ColumnAutoWidth = false;
            this.gdvPerfilUsuario.OptionsView.ShowIndicator = false;
            // 
            // colNombresCompletos
            // 
            this.colNombresCompletos.FieldName = "NombresCompletos";
            this.colNombresCompletos.Name = "colNombresCompletos";
            this.colNombresCompletos.Visible = true;
            this.colNombresCompletos.VisibleIndex = 2;
            this.colNombresCompletos.Width = 132;
            // 
            // colAplicacion
            // 
            this.colAplicacion.Caption = "Aplicación";
            this.colAplicacion.FieldName = "Aplicacion";
            this.colAplicacion.Name = "colAplicacion";
            this.colAplicacion.Visible = true;
            this.colAplicacion.VisibleIndex = 4;
            this.colAplicacion.Width = 76;
            // 
            // colLogueado
            // 
            this.colLogueado.FieldName = "Logueado";
            this.colLogueado.Name = "colLogueado";
            this.colLogueado.Width = 66;
            // 
            // colUltimoIngreso
            // 
            this.colUltimoIngreso.FieldName = "UltimoIngreso";
            this.colUltimoIngreso.Name = "colUltimoIngreso";
            this.colUltimoIngreso.Visible = true;
            this.colUltimoIngreso.VisibleIndex = 8;
            this.colUltimoIngreso.Width = 103;
            // 
            // colCaduca
            // 
            this.colCaduca.FieldName = "Caduca";
            this.colCaduca.Name = "colCaduca";
            this.colCaduca.Visible = true;
            this.colCaduca.VisibleIndex = 5;
            this.colCaduca.Width = 60;
            // 
            // colVigenciaInicio
            // 
            this.colVigenciaInicio.FieldName = "VigenciaInicio";
            this.colVigenciaInicio.Name = "colVigenciaInicio";
            this.colVigenciaInicio.Visible = true;
            this.colVigenciaInicio.VisibleIndex = 6;
            this.colVigenciaInicio.Width = 100;
            // 
            // colVigenciaFin
            // 
            this.colVigenciaFin.FieldName = "VigenciaFin";
            this.colVigenciaFin.Name = "colVigenciaFin";
            this.colVigenciaFin.Visible = true;
            this.colVigenciaFin.VisibleIndex = 7;
            this.colVigenciaFin.Width = 85;
            // 
            // cboCriterios
            // 
            this.cboCriterios.EditValue = "Código de Usuario";
            this.cboCriterios.Location = new System.Drawing.Point(32, 45);
            this.cboCriterios.MenuManager = this.BarraBotones;
            this.cboCriterios.Name = "cboCriterios";
            this.cboCriterios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCriterios.Properties.Items.AddRange(new object[] {
            "Código de Usuario",
            "Acrónimo de Aplicación",
            "Nombre de Perfil",
            "Sin Filtros (Mostrar Todos)"});
            this.cboCriterios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCriterios.Size = new System.Drawing.Size(195, 20);
            this.cboCriterios.TabIndex = 0;
            this.cboCriterios.SelectedIndexChanged += new System.EventHandler(this.cboCriterios_SelectedIndexChanged);
            // 
            // gdvRoles
            // 
            this.gdvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreRol});
            this.gdvRoles.GridControl = this.perfilUsuarioInfoListGridControl;
            this.gdvRoles.Name = "gdvRoles";
            this.gdvRoles.OptionsBehavior.Editable = false;
            this.gdvRoles.OptionsCustomization.AllowGroup = false;
            this.gdvRoles.OptionsCustomization.AllowSort = false;
            this.gdvRoles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvRoles.OptionsView.ShowGroupPanel = false;
            // 
            // gdvRecursos
            // 
            this.gdvRecursos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colConceder1,
            this.colNivel,
            this.colRecursoPadre});
            this.gdvRecursos.GridControl = this.perfilUsuarioInfoListGridControl;
            this.gdvRecursos.Name = "gdvRecursos";
            this.gdvRecursos.OptionsBehavior.Editable = false;
            this.gdvRecursos.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colNombreRol
            // 
            this.colNombreRol.FieldName = "NombreRol";
            this.colNombreRol.Name = "colNombreRol";
            this.colNombreRol.Visible = true;
            this.colNombreRol.VisibleIndex = 0;
            // 
            // colOpcion
            // 
            this.colOpcion.FieldName = "Opcion";
            this.colOpcion.Name = "colOpcion";
            this.colOpcion.Visible = true;
            this.colOpcion.VisibleIndex = 1;
            // 
            // colOpcionPadre
            // 
            this.colOpcionPadre.FieldName = "OpcionPadre";
            this.colOpcionPadre.Name = "colOpcionPadre";
            this.colOpcionPadre.Visible = true;
            this.colOpcionPadre.VisibleIndex = 0;
            // 
            // colConceder
            // 
            this.colConceder.FieldName = "Conceder";
            this.colConceder.Name = "colConceder";
            this.colConceder.Visible = true;
            this.colConceder.VisibleIndex = 2;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // colConceder1
            // 
            this.colConceder1.FieldName = "Conceder";
            this.colConceder1.Name = "colConceder1";
            this.colConceder1.Visible = true;
            this.colConceder1.VisibleIndex = 3;
            // 
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.Visible = true;
            this.colNivel.VisibleIndex = 4;
            // 
            // colRecursoPadre
            // 
            this.colRecursoPadre.FieldName = "RecursoPadre";
            this.colRecursoPadre.Name = "colRecursoPadre";
            this.colRecursoPadre.Visible = true;
            this.colRecursoPadre.VisibleIndex = 0;
            // 
            // colCodigoUsuario
            // 
            this.colCodigoUsuario.FieldName = "CodigoUsuario";
            this.colCodigoUsuario.Name = "colCodigoUsuario";
            this.colCodigoUsuario.Visible = true;
            this.colCodigoUsuario.VisibleIndex = 0;
            this.colCodigoUsuario.Width = 103;
            // 
            // colAlias
            // 
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 1;
            // 
            // colCorreo
            // 
            this.colCorreo.FieldName = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 3;
            // 
            // frmLstPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.CriterioBusqueda = "CodigoUsuario";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.InfoListDataGridView = this.gdvPerfilUsuario;
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios3"))));
            this.MaximizeBox = true;
            this.Name = "frmLstPerfilUsuario";
            this.ObjetoLista = this.perfilUsuarioInfoListBindingSource;
            this.Text = "Lista de Perfiles de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).EndInit();
            this.grpValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).EndInit();
            this.grpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPerfilUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.ComboBoxEdit cboCriterios;
		private DevExpress.XtraGrid.GridControl perfilUsuarioInfoListGridControl;
		private System.Windows.Forms.BindingSource perfilUsuarioInfoListBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gdvPerfilUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNombresCompletos;
		private DevExpress.XtraGrid.Columns.GridColumn colAplicacion;
		private DevExpress.XtraGrid.Columns.GridColumn colLogueado;
		private DevExpress.XtraGrid.Columns.GridColumn colUltimoIngreso;
		private DevExpress.XtraGrid.Columns.GridColumn colCaduca;
		private DevExpress.XtraGrid.Columns.GridColumn colVigenciaInicio;
		private DevExpress.XtraGrid.Columns.GridColumn colVigenciaFin;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvPermisos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRoles;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRol;
        private DevExpress.XtraGrid.Columns.GridColumn colOpcion;
        private DevExpress.XtraGrid.Columns.GridColumn colOpcionPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colConceder;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursos;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colConceder1;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private DevExpress.XtraGrid.Columns.GridColumn colRecursoPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
	}
}