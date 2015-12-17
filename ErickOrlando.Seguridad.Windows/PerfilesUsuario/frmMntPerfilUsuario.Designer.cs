namespace ErickOrlando.Seguridad.Windows.PerfilesUsuario
{
	partial class frmMntPerfilUsuario
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label caducaLabel;
            System.Windows.Forms.Label aplicacionLabel;
            System.Windows.Forms.Label vigenciaInicioLabel;
            System.Windows.Forms.Label vigenciaFinLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gdvPermisos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOpcionPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConceder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rolesPerfilesGridControl = new DevExpress.XtraGrid.GridControl();
            this.rolesPerfilesBindingSource = new System.Windows.Forms.BindingSource();
            this.perfilUsuarioBindingSource = new System.Windows.Forms.BindingSource();
            this.gdvRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.caducaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.btnBuscarApp = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.aplicacionTextEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.btnBuscarUsuario = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.usuarioTextEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource();
            this.aplicacionBindingSource = new System.Windows.Forms.BindingSource();
            this.btnAgregarRol = new DevExpress.XtraEditors.SimpleButton();
            this.vigenciaInicioDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.vigenciaFinDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lstRoles = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuitarRol = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.tabPerfiles = new DevExpress.XtraTab.XtraTabControl();
            this.tpRoles = new DevExpress.XtraTab.XtraTabPage();
            this.tpRecursos = new DevExpress.XtraTab.XtraTabPage();
            this.btnAsignarRecursos = new DevExpress.XtraEditors.SimpleButton();
            this.recursosGridControl = new DevExpress.XtraGrid.GridControl();
            this.recursosBindingSource = new System.Windows.Forms.BindingSource();
            this.gdvRecursosPerfil = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConcederRecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActualizarPermisos = new DevExpress.XtraEditors.SimpleButton();
            usuarioLabel = new System.Windows.Forms.Label();
            caducaLabel = new System.Windows.Forms.Label();
            aplicacionLabel = new System.Windows.Forms.Label();
            vigenciaInicioLabel = new System.Windows.Forms.Label();
            vigenciaFinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPerfilesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPerfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caducaCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaInicioDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaInicioDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaFinDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaFinDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPerfiles)).BeginInit();
            this.tabPerfiles.SuspendLayout();
            this.tpRoles.SuspendLayout();
            this.tpRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recursosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursosPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(12, 77);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(47, 13);
            usuarioLabel.TabIndex = 15;
            usuarioLabel.Text = "Usuario:";
            // 
            // caducaLabel
            // 
            caducaLabel.AutoSize = true;
            caducaLabel.Location = new System.Drawing.Point(12, 158);
            caducaLabel.Name = "caducaLabel";
            caducaLabel.Size = new System.Drawing.Size(47, 13);
            caducaLabel.TabIndex = 16;
            caducaLabel.Text = "Caduca:";
            // 
            // aplicacionLabel
            // 
            aplicacionLabel.AutoSize = true;
            aplicacionLabel.Location = new System.Drawing.Point(12, 46);
            aplicacionLabel.Name = "aplicacionLabel";
            aplicacionLabel.Size = new System.Drawing.Size(58, 13);
            aplicacionLabel.TabIndex = 19;
            aplicacionLabel.Text = "Aplicacion:";
            // 
            // vigenciaInicioLabel
            // 
            vigenciaInicioLabel.AutoSize = true;
            vigenciaInicioLabel.Location = new System.Drawing.Point(12, 106);
            vigenciaInicioLabel.Name = "vigenciaInicioLabel";
            vigenciaInicioLabel.Size = new System.Drawing.Size(78, 13);
            vigenciaInicioLabel.TabIndex = 19;
            vigenciaInicioLabel.Text = "Vigencia Inicio:";
            // 
            // vigenciaFinLabel
            // 
            vigenciaFinLabel.AutoSize = true;
            vigenciaFinLabel.Location = new System.Drawing.Point(12, 132);
            vigenciaFinLabel.Name = "vigenciaFinLabel";
            vigenciaFinLabel.Size = new System.Drawing.Size(67, 13);
            vigenciaFinLabel.TabIndex = 20;
            vigenciaFinLabel.Text = "Vigencia Fin:";
            // 
            // gdvPermisos
            // 
            this.gdvPermisos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOpcionPadre,
            this.colOpcion,
            this.colConceder});
            this.gdvPermisos.GridControl = this.rolesPerfilesGridControl;
            this.gdvPermisos.Name = "gdvPermisos";
            this.gdvPermisos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gdvPermisos.OptionsDetail.AutoZoomDetail = true;
            this.gdvPermisos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvPermisos.OptionsView.ShowAutoFilterRow = true;
            this.gdvPermisos.OptionsView.ShowIndicator = false;
            // 
            // colOpcionPadre
            // 
            this.colOpcionPadre.FieldName = "OpcionPadre";
            this.colOpcionPadre.Name = "colOpcionPadre";
            this.colOpcionPadre.OptionsColumn.AllowEdit = false;
            this.colOpcionPadre.Visible = true;
            this.colOpcionPadre.VisibleIndex = 0;
            this.colOpcionPadre.Width = 274;
            // 
            // colOpcion
            // 
            this.colOpcion.FieldName = "Opcion";
            this.colOpcion.Name = "colOpcion";
            this.colOpcion.OptionsColumn.AllowEdit = false;
            this.colOpcion.Visible = true;
            this.colOpcion.VisibleIndex = 1;
            this.colOpcion.Width = 623;
            // 
            // colConceder
            // 
            this.colConceder.FieldName = "Conceder";
            this.colConceder.Name = "colConceder";
            this.colConceder.Visible = true;
            this.colConceder.VisibleIndex = 2;
            this.colConceder.Width = 122;
            // 
            // rolesPerfilesGridControl
            // 
            this.rolesPerfilesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesPerfilesGridControl.DataSource = this.rolesPerfilesBindingSource;
            gridLevelNode1.LevelTemplate = this.gdvPermisos;
            gridLevelNode1.RelationName = "Permisos";
            this.rolesPerfilesGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.rolesPerfilesGridControl.Location = new System.Drawing.Point(270, 39);
            this.rolesPerfilesGridControl.MainView = this.gdvRoles;
            this.rolesPerfilesGridControl.MenuManager = this.BarraBotones;
            this.rolesPerfilesGridControl.Name = "rolesPerfilesGridControl";
            this.rolesPerfilesGridControl.ShowOnlyPredefinedDetails = true;
            this.rolesPerfilesGridControl.Size = new System.Drawing.Size(592, 315);
            this.rolesPerfilesGridControl.TabIndex = 22;
            this.rolesPerfilesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvRoles,
            this.gdvPermisos});
            // 
            // rolesPerfilesBindingSource
            // 
            this.rolesPerfilesBindingSource.DataMember = "RolesPerfiles";
            this.rolesPerfilesBindingSource.DataSource = this.perfilUsuarioBindingSource;
            // 
            // perfilUsuarioBindingSource
            // 
            this.perfilUsuarioBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.Editables.PerfilUsuario);
            // 
            // gdvRoles
            // 
            this.gdvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreRol});
            this.gdvRoles.GridControl = this.rolesPerfilesGridControl;
            this.gdvRoles.Name = "gdvRoles";
            this.gdvRoles.OptionsBehavior.Editable = false;
            this.gdvRoles.OptionsCustomization.AllowGroup = false;
            this.gdvRoles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvRoles.OptionsView.ShowGroupPanel = false;
            this.gdvRoles.OptionsView.ShowIndicator = false;
            // 
            // colNombreRol
            // 
            this.colNombreRol.FieldName = "NombreRol";
            this.colNombreRol.Name = "colNombreRol";
            this.colNombreRol.Visible = true;
            this.colNombreRol.VisibleIndex = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(770, 31);
            // 
            // caducaCheckEdit
            // 
            this.caducaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.perfilUsuarioBindingSource, "Caduca", true));
            this.caducaCheckEdit.Location = new System.Drawing.Point(91, 155);
            this.caducaCheckEdit.MenuManager = this.BarraBotones;
            this.caducaCheckEdit.Name = "caducaCheckEdit";
            this.caducaCheckEdit.Properties.Caption = "Sí";
            this.caducaCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.caducaCheckEdit.TabIndex = 7;
            // 
            // btnBuscarApp
            // 
            this.btnBuscarApp.CajaTexto = null;
            this.btnBuscarApp.CajaTextoConBoton = this.aplicacionTextEdit;
            this.btnBuscarApp.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.BuscarPrompt;
            this.btnBuscarApp.Location = new System.Drawing.Point(351, 38);
            this.btnBuscarApp.Name = "btnBuscarApp";
            this.btnBuscarApp.Size = new System.Drawing.Size(35, 27);
            this.btnBuscarApp.TabIndex = 1;
            this.btnBuscarApp.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnBuscarAplicacion_Click);
            // 
            // aplicacionTextEdit
            // 
            this.aplicacionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.perfilUsuarioBindingSource, "Aplicacion", true));
            this.aplicacionTextEdit.Location = new System.Drawing.Point(93, 43);
            this.aplicacionTextEdit.MenuManager = this.BarraBotones;
            this.aplicacionTextEdit.Name = "aplicacionTextEdit";
            this.aplicacionTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.aplicacionTextEdit.Size = new System.Drawing.Size(252, 20);
            this.aplicacionTextEdit.TabIndex = 0;
            this.aplicacionTextEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.aplicacionTextEdit_ButtonClick);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.CajaTexto = null;
            this.btnBuscarUsuario.CajaTextoConBoton = this.usuarioTextEdit;
            this.btnBuscarUsuario.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.BuscarPrompt;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(351, 71);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(35, 27);
            this.btnBuscarUsuario.TabIndex = 4;
            this.btnBuscarUsuario.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnBuscarUsuario_Click);
            // 
            // usuarioTextEdit
            // 
            this.usuarioTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.perfilUsuarioBindingSource, "Usuario", true));
            this.usuarioTextEdit.Location = new System.Drawing.Point(93, 74);
            this.usuarioTextEdit.MenuManager = this.BarraBotones;
            this.usuarioTextEdit.Name = "usuarioTextEdit";
            this.usuarioTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.usuarioTextEdit.Size = new System.Drawing.Size(252, 20);
            this.usuarioTextEdit.TabIndex = 3;
            this.usuarioTextEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.usuarioTextEdit_ButtonClick);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.aplicacionBindingSource;
            // 
            // aplicacionBindingSource
            // 
            this.aplicacionBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.AplicacionInfoList);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Image = global::ErickOrlando.Seguridad.Windows.Properties.Resources.derecha;
            this.btnAgregarRol.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregarRol.Location = new System.Drawing.Point(231, 87);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(33, 37);
            this.btnAgregarRol.TabIndex = 8;
            this.btnAgregarRol.ToolTip = "Agregar Rol de Aplicación";
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // vigenciaInicioDateEdit
            // 
            this.vigenciaInicioDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.perfilUsuarioBindingSource, "VigenciaInicio", true));
            this.vigenciaInicioDateEdit.EditValue = null;
            this.vigenciaInicioDateEdit.Location = new System.Drawing.Point(93, 103);
            this.vigenciaInicioDateEdit.MenuManager = this.BarraBotones;
            this.vigenciaInicioDateEdit.Name = "vigenciaInicioDateEdit";
            this.vigenciaInicioDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vigenciaInicioDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.vigenciaInicioDateEdit.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.False;
            this.vigenciaInicioDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.vigenciaInicioDateEdit.Size = new System.Drawing.Size(252, 20);
            this.vigenciaInicioDateEdit.TabIndex = 5;
            // 
            // vigenciaFinDateEdit
            // 
            this.vigenciaFinDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.perfilUsuarioBindingSource, "VigenciaFin", true));
            this.vigenciaFinDateEdit.EditValue = null;
            this.vigenciaFinDateEdit.Location = new System.Drawing.Point(93, 129);
            this.vigenciaFinDateEdit.MenuManager = this.BarraBotones;
            this.vigenciaFinDateEdit.Name = "vigenciaFinDateEdit";
            this.vigenciaFinDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vigenciaFinDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.vigenciaFinDateEdit.Size = new System.Drawing.Size(252, 20);
            this.vigenciaFinDateEdit.TabIndex = 6;
            // 
            // lstRoles
            // 
            this.lstRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRoles.DataSource = this.rolesBindingSource;
            this.lstRoles.DisplayMember = "Nombre";
            this.lstRoles.Location = new System.Drawing.Point(12, 39);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.True;
            this.lstRoles.Size = new System.Drawing.Size(213, 316);
            this.lstRoles.TabIndex = 21;
            this.lstRoles.ValueMember = "Id";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Roles Disponibles";
            // 
            // btnQuitarRol
            // 
            this.btnQuitarRol.Image = global::ErickOrlando.Seguridad.Windows.Properties.Resources.izquierda;
            this.btnQuitarRol.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnQuitarRol.Location = new System.Drawing.Point(231, 130);
            this.btnQuitarRol.Name = "btnQuitarRol";
            this.btnQuitarRol.Size = new System.Drawing.Size(33, 37);
            this.btnQuitarRol.TabIndex = 8;
            this.btnQuitarRol.ToolTip = "Quitar el Rol Seleccionado";
            this.btnQuitarRol.Click += new System.EventHandler(this.btnQuitarRol_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.perfilUsuarioBindingSource;
            // 
            // tabPerfiles
            // 
            this.tabPerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPerfiles.Location = new System.Drawing.Point(3, 180);
            this.tabPerfiles.Name = "tabPerfiles";
            this.tabPerfiles.SelectedTabPage = this.tpRoles;
            this.tabPerfiles.Size = new System.Drawing.Size(875, 390);
            this.tabPerfiles.TabIndex = 23;
            this.tabPerfiles.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpRoles,
            this.tpRecursos});
            // 
            // tpRoles
            // 
            this.tpRoles.Controls.Add(this.rolesPerfilesGridControl);
            this.tpRoles.Controls.Add(this.btnAgregarRol);
            this.tpRoles.Controls.Add(this.labelControl1);
            this.tpRoles.Controls.Add(this.btnQuitarRol);
            this.tpRoles.Controls.Add(this.lstRoles);
            this.tpRoles.Name = "tpRoles";
            this.tpRoles.Size = new System.Drawing.Size(873, 365);
            this.tpRoles.Text = "Asignación de Roles";
            // 
            // tpRecursos
            // 
            this.tpRecursos.AutoScroll = true;
            this.tpRecursos.Controls.Add(this.btnAsignarRecursos);
            this.tpRecursos.Controls.Add(this.recursosGridControl);
            this.tpRecursos.Name = "tpRecursos";
            this.tpRecursos.Size = new System.Drawing.Size(873, 365);
            this.tpRecursos.Text = "Asignación de Recursos";
            // 
            // btnAsignarRecursos
            // 
            this.btnAsignarRecursos.Image = global::ErickOrlando.Seguridad.Windows.Properties.Resources.EditarRol;
            this.btnAsignarRecursos.Location = new System.Drawing.Point(198, 7);
            this.btnAsignarRecursos.Name = "btnAsignarRecursos";
            this.btnAsignarRecursos.Size = new System.Drawing.Size(143, 23);
            this.btnAsignarRecursos.TabIndex = 1;
            this.btnAsignarRecursos.Text = "Asignar Recursos";
            this.btnAsignarRecursos.Click += new System.EventHandler(this.btnAsignarRecursos_Click);
            // 
            // recursosGridControl
            // 
            this.recursosGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.recursosGridControl.DataSource = this.recursosBindingSource;
            this.recursosGridControl.Location = new System.Drawing.Point(0, 36);
            this.recursosGridControl.MainView = this.gdvRecursosPerfil;
            this.recursosGridControl.MenuManager = this.BarraBotones;
            this.recursosGridControl.Name = "recursosGridControl";
            this.recursosGridControl.Size = new System.Drawing.Size(870, 328);
            this.recursosGridControl.TabIndex = 0;
            this.recursosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvRecursosPerfil});
            // 
            // recursosBindingSource
            // 
            this.recursosBindingSource.DataMember = "Recursos";
            this.recursosBindingSource.DataSource = this.perfilUsuarioBindingSource;
            // 
            // gdvRecursosPerfil
            // 
            this.gdvRecursosPerfil.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colNivel,
            this.colConcederRecurso});
            this.gdvRecursosPerfil.GridControl = this.recursosGridControl;
            this.gdvRecursosPerfil.Name = "gdvRecursosPerfil";
            this.gdvRecursosPerfil.OptionsCustomization.AllowGroup = false;
            this.gdvRecursosPerfil.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvRecursosPerfil.OptionsView.ShowGroupPanel = false;
            this.gdvRecursosPerfil.OptionsView.ShowIndicator = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.OptionsColumn.AllowEdit = false;
            this.colNivel.Visible = true;
            this.colNivel.VisibleIndex = 2;
            // 
            // colConcederRecurso
            // 
            this.colConcederRecurso.FieldName = "Conceder";
            this.colConcederRecurso.Name = "colConcederRecurso";
            this.colConcederRecurso.Visible = true;
            this.colConcederRecurso.VisibleIndex = 3;
            // 
            // btnActualizarPermisos
            // 
            this.btnActualizarPermisos.Image = global::ErickOrlando.Seguridad.Windows.Properties.Resources.EditarRol;
            this.btnActualizarPermisos.Location = new System.Drawing.Point(427, 158);
            this.btnActualizarPermisos.Name = "btnActualizarPermisos";
            this.btnActualizarPermisos.Size = new System.Drawing.Size(144, 23);
            this.btnActualizarPermisos.TabIndex = 23;
            this.btnActualizarPermisos.Text = "Actualizar Permisos";
            this.btnActualizarPermisos.ToolTip = "Permite actualizar todos los permisos efectivos basados en la plantilla";
            this.btnActualizarPermisos.Click += new System.EventHandler(this.btnActualizarPermisos_Click);
            // 
            // frmMntPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 600);
            this.Controls.Add(this.btnActualizarPermisos);
            this.Controls.Add(this.tabPerfiles);
            this.Controls.Add(vigenciaFinLabel);
            this.Controls.Add(this.vigenciaFinDateEdit);
            this.Controls.Add(vigenciaInicioLabel);
            this.Controls.Add(this.vigenciaInicioDateEdit);
            this.Controls.Add(aplicacionLabel);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnBuscarApp);
            this.Controls.Add(caducaLabel);
            this.Controls.Add(this.caducaCheckEdit);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextEdit);
            this.Controls.Add(this.aplicacionTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(590, 494);
            this.Name = "frmMntPerfilUsuario";
            this.Text = "Perfiles de Usuario";
            this.Controls.SetChildIndex(this.aplicacionTextEdit, 0);
            this.Controls.SetChildIndex(this.usuarioTextEdit, 0);
            this.Controls.SetChildIndex(usuarioLabel, 0);
            this.Controls.SetChildIndex(this.caducaCheckEdit, 0);
            this.Controls.SetChildIndex(caducaLabel, 0);
            this.Controls.SetChildIndex(this.btnBuscarApp, 0);
            this.Controls.SetChildIndex(this.btnBuscarUsuario, 0);
            this.Controls.SetChildIndex(aplicacionLabel, 0);
            this.Controls.SetChildIndex(this.vigenciaInicioDateEdit, 0);
            this.Controls.SetChildIndex(vigenciaInicioLabel, 0);
            this.Controls.SetChildIndex(this.vigenciaFinDateEdit, 0);
            this.Controls.SetChildIndex(vigenciaFinLabel, 0);
            this.Controls.SetChildIndex(this.tabPerfiles, 0);
            this.Controls.SetChildIndex(this.btnActualizarPermisos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPerfilesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPerfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caducaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaInicioDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaInicioDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaFinDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigenciaFinDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPerfiles)).EndInit();
            this.tabPerfiles.ResumeLayout(false);
            this.tpRoles.ResumeLayout(false);
            this.tpRoles.PerformLayout();
            this.tpRecursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recursosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursosPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private DevExpress.XtraEditors.CheckEdit caducaCheckEdit;
		private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnBuscarApp;
		private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnBuscarUsuario;
		private DevExpress.XtraEditors.ButtonEdit usuarioTextEdit;
        private DevExpress.XtraEditors.ButtonEdit aplicacionTextEdit;
		private System.Windows.Forms.BindingSource rolesBindingSource;
		private DevExpress.XtraEditors.SimpleButton btnAgregarRol;
		private DevExpress.XtraEditors.DateEdit vigenciaInicioDateEdit;
		private DevExpress.XtraEditors.DateEdit vigenciaFinDateEdit;
        private DevExpress.XtraEditors.ListBoxControl lstRoles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuitarRol;
        private System.Windows.Forms.BindingSource rolesPerfilesBindingSource;
        private DevExpress.XtraGrid.GridControl rolesPerfilesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvPermisos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRoles;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRol;
        private System.Windows.Forms.BindingSource perfilUsuarioBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.BindingSource aplicacionBindingSource;
        private DevExpress.XtraTab.XtraTabControl tabPerfiles;
        private DevExpress.XtraTab.XtraTabPage tpRoles;
        private DevExpress.XtraTab.XtraTabPage tpRecursos;
        private DevExpress.XtraEditors.SimpleButton btnAsignarRecursos;
        private DevExpress.XtraGrid.GridControl recursosGridControl;
        private System.Windows.Forms.BindingSource recursosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursosPerfil;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private DevExpress.XtraGrid.Columns.GridColumn colConcederRecurso;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraEditors.SimpleButton btnActualizarPermisos;
        private DevExpress.XtraGrid.Columns.GridColumn colOpcionPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colOpcion;
        private DevExpress.XtraGrid.Columns.GridColumn colConceder;
	}
}