namespace Gromero.Seguridad.Windows
{
	partial class MainForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Lista de Aplicaciones");
            this.gdvPermisos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConceder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.perfilUsuarioInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.mnuPerfiles = new System.Windows.Forms.ContextMenuStrip();
            this.nuevoPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUsuarioInfoListBindingSource = new System.Windows.Forms.BindingSource();
            this.gdvPerfiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombresCompletos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDominio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAplicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogueado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltimoIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaduca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVigenciaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVigenciaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
            this.bbiEmpresas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAplicaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPerfiles = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bsiUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.bsiCorreo = new DevExpress.XtraBars.BarStaticItem();
            this.bsiDominio = new DevExpress.XtraBars.BarStaticItem();
            this.bsiLastSession = new DevExpress.XtraBars.BarStaticItem();
            this.mnuNuevo = new DevExpress.XtraBars.BarSubItem();
            this.mnuEditar = new DevExpress.XtraBars.BarSubItem();
            this.mnuEliminar = new DevExpress.XtraBars.BarSubItem();
            this.bbiPermisosPorApp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPermisosPorUser = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRolesPorApp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUsersPorApp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUsersLogged = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRecursos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCargos = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection();
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAutorizaciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgReportes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGraficos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tvwAplicaciones = new System.Windows.Forms.TreeView();
            this.mnuTree = new System.Windows.Forms.ContextMenuStrip();
            this.toolActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewImageCollection = new System.Windows.Forms.ImageList();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iRightTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iCenterTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iLeftTextAlign = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListGridControl)).BeginInit();
            this.mnuPerfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            this.mnuTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdvPermisos
            // 
            this.gdvPermisos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colModulo,
            this.colOpcion,
            this.colRol,
            this.colConceder});
            this.gdvPermisos.GridControl = this.perfilUsuarioInfoListGridControl;
            this.gdvPermisos.Name = "gdvPermisos";
            this.gdvPermisos.OptionsBehavior.Editable = false;
            this.gdvPermisos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvPermisos.OptionsView.ShowGroupPanel = false;
            // 
            // colModulo
            // 
            this.colModulo.Caption = "Objeto de Autorización";
            this.colModulo.FieldName = "Modulo";
            this.colModulo.Name = "colModulo";
            this.colModulo.Visible = true;
            this.colModulo.VisibleIndex = 0;
            // 
            // colOpcion
            // 
            this.colOpcion.FieldName = "Opcion";
            this.colOpcion.Name = "colOpcion";
            this.colOpcion.Visible = true;
            this.colOpcion.VisibleIndex = 1;
            // 
            // colRol
            // 
            this.colRol.FieldName = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.Visible = true;
            this.colRol.VisibleIndex = 2;
            // 
            // colConceder
            // 
            this.colConceder.FieldName = "Conceder";
            this.colConceder.Name = "colConceder";
            this.colConceder.Visible = true;
            this.colConceder.VisibleIndex = 3;
            // 
            // perfilUsuarioInfoListGridControl
            // 
            this.perfilUsuarioInfoListGridControl.ContextMenuStrip = this.mnuPerfiles;
            this.perfilUsuarioInfoListGridControl.DataSource = this.perfilUsuarioInfoListBindingSource;
            this.perfilUsuarioInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perfilUsuarioInfoListGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.LevelTemplate = this.gdvPermisos;
            gridLevelNode1.RelationName = "Permisos";
            this.perfilUsuarioInfoListGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.perfilUsuarioInfoListGridControl.Location = new System.Drawing.Point(0, 0);
            this.perfilUsuarioInfoListGridControl.MainView = this.gdvPerfiles;
            this.perfilUsuarioInfoListGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.perfilUsuarioInfoListGridControl.MenuManager = this.ribbonControl;
            this.perfilUsuarioInfoListGridControl.Name = "perfilUsuarioInfoListGridControl";
            this.perfilUsuarioInfoListGridControl.ShowOnlyPredefinedDetails = true;
            this.perfilUsuarioInfoListGridControl.Size = new System.Drawing.Size(1040, 658);
            this.perfilUsuarioInfoListGridControl.TabIndex = 0;
            this.perfilUsuarioInfoListGridControl.UseEmbeddedNavigator = true;
            this.perfilUsuarioInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvPerfiles,
            this.gdvPermisos});
            // 
            // mnuPerfiles
            // 
            this.mnuPerfiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPerfiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPerfilToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.eliminarPerfilToolStripMenuItem,
            this.toolStripMenuItem1,
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem,
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem});
            this.mnuPerfiles.Name = "mnuPerfiles";
            this.mnuPerfiles.Size = new System.Drawing.Size(422, 140);
            // 
            // nuevoPerfilToolStripMenuItem
            // 
            this.nuevoPerfilToolStripMenuItem.Image = global::Gromero.Seguridad.Windows.Properties.Resources.nuevoRol;
            this.nuevoPerfilToolStripMenuItem.Name = "nuevoPerfilToolStripMenuItem";
            this.nuevoPerfilToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.nuevoPerfilToolStripMenuItem.Size = new System.Drawing.Size(421, 26);
            this.nuevoPerfilToolStripMenuItem.Text = "&Nuevo Perfil de Usuario";
            this.nuevoPerfilToolStripMenuItem.Click += new System.EventHandler(this.nuevoPerfilToolStripMenuItem_Click);
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Image = global::Gromero.Seguridad.Windows.Properties.Resources.EditarRol;
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(421, 26);
            this.editarPerfilToolStripMenuItem.Text = "&Editar Perfil de Usuario";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // eliminarPerfilToolStripMenuItem
            // 
            this.eliminarPerfilToolStripMenuItem.Image = global::Gromero.Seguridad.Windows.Properties.Resources.EliminarRol;
            this.eliminarPerfilToolStripMenuItem.Name = "eliminarPerfilToolStripMenuItem";
            this.eliminarPerfilToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.eliminarPerfilToolStripMenuItem.Size = new System.Drawing.Size(421, 26);
            this.eliminarPerfilToolStripMenuItem.Text = "E&liminar Perfil de Usuario";
            this.eliminarPerfilToolStripMenuItem.Click += new System.EventHandler(this.eliminarPerfilToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(418, 6);
            // 
            // asignarPerfilesDeFormaMasivaToolStripMenuItem
            // 
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem.Image = global::Gromero.Seguridad.Windows.Properties.Resources.cambiarvista;
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem.Name = "asignarPerfilesDeFormaMasivaToolStripMenuItem";
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem.Size = new System.Drawing.Size(421, 26);
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem.Text = "Asignar Perfiles de Forma &Masiva";
            this.asignarPerfilesDeFormaMasivaToolStripMenuItem.Click += new System.EventHandler(this.asignarPerfilesDeFormaMasivaToolStripMenuItem_Click);
            // 
            // actualizarPermisosDeTodosLosPerfilesToolStripMenuItem
            // 
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem.Image = global::Gromero.Seguridad.Windows.Properties.Resources.actualizar;
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem.Name = "actualizarPermisosDeTodosLosPerfilesToolStripMenuItem";
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem.Size = new System.Drawing.Size(421, 26);
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem.Text = "&Actualizar permisos de todos los Perfiles";
            this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem.Click += new System.EventHandler(this.actualizarPermisosDeTodosLosPerfilesToolStripMenuItem_Click);
            // 
            // perfilUsuarioInfoListBindingSource
            // 
            this.perfilUsuarioInfoListBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.SoloLectura.PerfilUsuarioInfo);
            // 
            // gdvPerfiles
            // 
            this.gdvPerfiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAlias,
            this.colCodigoUsuario,
            this.colNombresCompletos,
            this.colDominio,
            this.colAplicacion,
            this.colLogueado,
            this.colUltimoIngreso,
            this.colCaduca,
            this.colVigenciaInicio,
            this.colVigenciaFin});
            this.gdvPerfiles.GridControl = this.perfilUsuarioInfoListGridControl;
            this.gdvPerfiles.Name = "gdvPerfiles";
            this.gdvPerfiles.OptionsBehavior.Editable = false;
            this.gdvPerfiles.OptionsDetail.SmartDetailExpand = false;
            this.gdvPerfiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvPerfiles.OptionsView.ShowFooter = true;
            this.gdvPerfiles.OptionsView.ShowViewCaption = true;
            this.gdvPerfiles.ViewCaption = "Presione CTRL+F para buscar registros";
            // 
            // colAlias
            // 
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 1;
            this.colAlias.Width = 45;
            // 
            // colCodigoUsuario
            // 
            this.colCodigoUsuario.FieldName = "CodigoUsuario";
            this.colCodigoUsuario.Name = "colCodigoUsuario";
            this.colCodigoUsuario.Visible = true;
            this.colCodigoUsuario.VisibleIndex = 0;
            this.colCodigoUsuario.Width = 100;
            // 
            // colNombresCompletos
            // 
            this.colNombresCompletos.FieldName = "NombresCompletos";
            this.colNombresCompletos.Name = "colNombresCompletos";
            this.colNombresCompletos.Visible = true;
            this.colNombresCompletos.VisibleIndex = 2;
            this.colNombresCompletos.Width = 129;
            // 
            // colDominio
            // 
            this.colDominio.FieldName = "Dominio";
            this.colDominio.Name = "colDominio";
            this.colDominio.Visible = true;
            this.colDominio.VisibleIndex = 3;
            this.colDominio.Width = 63;
            // 
            // colAplicacion
            // 
            this.colAplicacion.FieldName = "Aplicacion";
            this.colAplicacion.Name = "colAplicacion";
            this.colAplicacion.Visible = true;
            this.colAplicacion.VisibleIndex = 4;
            this.colAplicacion.Width = 74;
            // 
            // colLogueado
            // 
            this.colLogueado.FieldName = "Logueado";
            this.colLogueado.Name = "colLogueado";
            this.colLogueado.Visible = true;
            this.colLogueado.VisibleIndex = 9;
            this.colLogueado.Width = 60;
            // 
            // colUltimoIngreso
            // 
            this.colUltimoIngreso.DisplayFormat.FormatString = "g";
            this.colUltimoIngreso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUltimoIngreso.FieldName = "UltimoIngreso";
            this.colUltimoIngreso.Name = "colUltimoIngreso";
            this.colUltimoIngreso.Visible = true;
            this.colUltimoIngreso.VisibleIndex = 8;
            this.colUltimoIngreso.Width = 96;
            // 
            // colCaduca
            // 
            this.colCaduca.Caption = "Perfil Caduca";
            this.colCaduca.FieldName = "Caduca";
            this.colCaduca.GroupFormat.FormatString = "Perfiles: {0}";
            this.colCaduca.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCaduca.Name = "colCaduca";
            this.colCaduca.Visible = true;
            this.colCaduca.VisibleIndex = 5;
            this.colCaduca.Width = 92;
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
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.iExit,
            this.iAbout,
            this.rgbiSkins,
            this.bbiEmpresas,
            this.bbiUsuarios,
            this.bbiAplicaciones,
            this.bbiPerfiles,
            this.bsiUsuario,
            this.bsiCorreo,
            this.bsiDominio,
            this.bsiLastSession,
            this.mnuNuevo,
            this.mnuEditar,
            this.mnuEliminar,
            this.bbiActualizar,
            this.bbiPermisosPorApp,
            this.bbiPermisosPorUser,
            this.bbiRolesPorApp,
            this.bbiUsersPorApp,
            this.bbiUsersLogged,
            this.bbiRecursos,
            this.bbiCargos});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 84;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage,
            this.rbpReportes,
            this.helpRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(1283, 168);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iExit);
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.bbiEmpresas);
            this.appMenu.ItemLinks.Add(this.bbiUsuarios);
            this.appMenu.ItemLinks.Add(this.bbiAplicaciones);
            this.appMenu.ItemLinks.Add(this.bbiPerfiles);
            this.appMenu.ItemLinks.Add(this.iExit);
            this.appMenu.ItemLinks.Add(this.bbiActualizar);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            // 
            // bbiEmpresas
            // 
            this.bbiEmpresas.Caption = "Empresas";
            this.bbiEmpresas.Description = "Muestra el Mantenimiento de Empresas";
            this.bbiEmpresas.Hint = "Muestra el Mantenimiento de Empresas";
            this.bbiEmpresas.Id = 62;
            this.bbiEmpresas.ImageIndex = 2;
            this.bbiEmpresas.LargeImageIndex = 1;
            this.bbiEmpresas.Name = "bbiEmpresas";
            this.bbiEmpresas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEmpresas_ItemClick);
            // 
            // bbiUsuarios
            // 
            this.bbiUsuarios.Caption = "Usuarios";
            this.bbiUsuarios.Description = "Muestra el Mantenimiento de Usuarios";
            this.bbiUsuarios.Hint = "Muestra el Mantenimiento de Usuarios";
            this.bbiUsuarios.Id = 63;
            this.bbiUsuarios.ImageIndex = 1;
            this.bbiUsuarios.LargeImageIndex = 2;
            this.bbiUsuarios.Name = "bbiUsuarios";
            this.bbiUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUsuarios_ItemClick);
            // 
            // bbiAplicaciones
            // 
            this.bbiAplicaciones.Caption = "Aplicaciones";
            this.bbiAplicaciones.Description = "Muestra el Mantenimiento de Aplicaciones";
            this.bbiAplicaciones.Hint = "Muestra el Mantenimiento de Aplicaciones";
            this.bbiAplicaciones.Id = 64;
            this.bbiAplicaciones.ImageIndex = 3;
            this.bbiAplicaciones.LargeImageIndex = 3;
            this.bbiAplicaciones.Name = "bbiAplicaciones";
            this.bbiAplicaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAplicaciones_ItemClick);
            // 
            // bbiPerfiles
            // 
            this.bbiPerfiles.Caption = "Perfiles de Usuario";
            this.bbiPerfiles.Description = "Muestra el Mantenimiento de Perfiles de Usuario";
            this.bbiPerfiles.Hint = "Muestra el Mantenimiento de Perfiles de Usuario";
            this.bbiPerfiles.Id = 65;
            this.bbiPerfiles.ImageIndex = 4;
            this.bbiPerfiles.LargeImageIndex = 4;
            this.bbiPerfiles.Name = "bbiPerfiles";
            this.bbiPerfiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPerfiles_ItemClick);
            // 
            // iExit
            // 
            this.iExit.Caption = "Salir";
            this.iExit.Description = "Cierra la Aplicación";
            this.iExit.Hint = "Cierra la Aplicación";
            this.iExit.Id = 20;
            this.iExit.ImageIndex = 8;
            this.iExit.LargeImageIndex = 8;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // bbiActualizar
            // 
            this.bbiActualizar.Caption = "Actualizar Permisos";
            this.bbiActualizar.Description = "Actualiza los Permisos del Usuario Actual";
            this.bbiActualizar.Hint = "Actualiza los Permisos del Usuario Actual";
            this.bbiActualizar.Id = 74;
            this.bbiActualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.bbiActualizar.LargeImageIndex = 11;
            this.bbiActualizar.Name = "bbiActualizar";
            this.bbiActualizar.ShortcutKeyDisplayString = "F5";
            this.bbiActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiActualizar_ItemClick);
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Usuarios.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Empresas.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Aplicaciones.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Perfiles.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Email-icon.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Empresa.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Star.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "usuario.png");
            // 
            // iAbout
            // 
            this.iAbout.Caption = "Información";
            this.iAbout.Description = "Muestra información General de la Aplicación";
            this.iAbout.Hint = "Muestra información General de la Aplicación";
            this.iAbout.Id = 24;
            this.iAbout.ImageIndex = 10;
            this.iAbout.LargeImageIndex = 10;
            this.iAbout.Name = "iAbout";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            this.rgbiSkins.Description = "Cambia la Apariencia de la Aplicación";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Hint = "Cambia la Apariencia de la Aplicación";
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // bsiUsuario
            // 
            this.bsiUsuario.Caption = "Usuario:";
            this.bsiUsuario.Description = "Nombre del Usuario Autenticado";
            this.bsiUsuario.Hint = "Nombre del Usuario Autenticado";
            this.bsiUsuario.Id = 66;
            this.bsiUsuario.ImageIndex = 14;
            this.bsiUsuario.Name = "bsiUsuario";
            this.bsiUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            this.bsiUsuario.ItemDoubleClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bsiUsuario_ItemDoubleClick);
            // 
            // bsiCorreo
            // 
            this.bsiCorreo.Caption = "Correo:";
            this.bsiCorreo.Description = "Correo Electrónico del Usuario";
            this.bsiCorreo.Hint = "Correo Electrónico del Usuario";
            this.bsiCorreo.Id = 67;
            this.bsiCorreo.ImageIndex = 11;
            this.bsiCorreo.Name = "bsiCorreo";
            this.bsiCorreo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiDominio
            // 
            this.bsiDominio.Caption = "Dominio:";
            this.bsiDominio.Description = "Dominio al que pertenece el usuario";
            this.bsiDominio.Hint = "Dominio al que pertenece el usuario";
            this.bsiDominio.Id = 68;
            this.bsiDominio.ImageIndex = 12;
            this.bsiDominio.Name = "bsiDominio";
            this.bsiDominio.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiLastSession
            // 
            this.bsiLastSession.Caption = "Ultimo Ingreso:";
            this.bsiLastSession.Description = "Fecha/Hora de la última sesión";
            this.bsiLastSession.Hint = "Fecha/Hora de la última sesión";
            this.bsiLastSession.Id = 69;
            this.bsiLastSession.ImageIndex = 13;
            this.bsiLastSession.Name = "bsiLastSession";
            this.bsiLastSession.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Caption = "Nuevo Perfil";
            this.mnuNuevo.Id = 70;
            this.mnuNuevo.Name = "mnuNuevo";
            // 
            // mnuEditar
            // 
            this.mnuEditar.Caption = "Editar Perfil";
            this.mnuEditar.Id = 71;
            this.mnuEditar.Name = "mnuEditar";
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Caption = "Eliminar Perfil";
            this.mnuEliminar.Id = 72;
            this.mnuEliminar.Name = "mnuEliminar";
            // 
            // bbiPermisosPorApp
            // 
            this.bbiPermisosPorApp.Caption = "Permisos y Perfiles por Aplicación";
            this.bbiPermisosPorApp.Id = 77;
            this.bbiPermisosPorApp.Name = "bbiPermisosPorApp";
            this.bbiPermisosPorApp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPermisosPorApp_ItemClick);
            // 
            // bbiPermisosPorUser
            // 
            this.bbiPermisosPorUser.Caption = "Permisos y Perfiles por Usuario";
            this.bbiPermisosPorUser.Id = 78;
            this.bbiPermisosPorUser.Name = "bbiPermisosPorUser";
            // 
            // bbiRolesPorApp
            // 
            this.bbiRolesPorApp.Caption = "Roles y Perfiles por Aplicación";
            this.bbiRolesPorApp.Id = 79;
            this.bbiRolesPorApp.Name = "bbiRolesPorApp";
            // 
            // bbiUsersPorApp
            // 
            this.bbiUsersPorApp.Caption = "Usuarios por Aplicación";
            this.bbiUsersPorApp.Id = 80;
            this.bbiUsersPorApp.Name = "bbiUsersPorApp";
            // 
            // bbiUsersLogged
            // 
            this.bbiUsersLogged.Caption = "Usuarios Logueados por Aplicación";
            this.bbiUsersLogged.Id = 81;
            this.bbiUsersLogged.Name = "bbiUsersLogged";
            // 
            // bbiRecursos
            // 
            this.bbiRecursos.Caption = "Recursos";
            this.bbiRecursos.Id = 82;
            this.bbiRecursos.ImageIndex = 5;
            this.bbiRecursos.LargeImageIndex = 5;
            this.bbiRecursos.Name = "bbiRecursos";
            this.bbiRecursos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRecursos_ItemClick);
            // 
            // bbiCargos
            // 
            this.bbiCargos.Caption = "Cargos";
            this.bbiCargos.Id = 83;
            this.bbiCargos.LargeImageIndex = 9;
            this.bbiCargos.Name = "bbiCargos";
            this.bbiCargos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCargos_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Empresas.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Usuarios.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Aplicaciones.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Perfiles.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "Ribbon_Info_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "refresh-icon.png");
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRibbonPageGroup,
            this.rpgAutorizaciones,
            this.skinsRibbonPageGroup,
            this.exitRibbonPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Inicio";
            // 
            // fileRibbonPageGroup
            // 
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiEmpresas);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiUsuarios);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiAplicaciones);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiPerfiles);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiCargos);
            this.fileRibbonPageGroup.ItemLinks.Add(this.bbiRecursos);
            this.fileRibbonPageGroup.Name = "fileRibbonPageGroup";
            this.fileRibbonPageGroup.ShowCaptionButton = false;
            this.fileRibbonPageGroup.Text = "Mantenimientos";
            // 
            // rpgAutorizaciones
            // 
            this.rpgAutorizaciones.ItemLinks.Add(this.bbiActualizar);
            this.rpgAutorizaciones.Name = "rpgAutorizaciones";
            this.rpgAutorizaciones.ShowCaptionButton = false;
            this.rpgAutorizaciones.Text = "Autorizaciones";
            // 
            // skinsRibbonPageGroup
            // 
            this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
            this.skinsRibbonPageGroup.ShowCaptionButton = false;
            this.skinsRibbonPageGroup.Text = "Apariencias";
            // 
            // exitRibbonPageGroup
            // 
            this.exitRibbonPageGroup.ItemLinks.Add(this.iExit);
            this.exitRibbonPageGroup.Name = "exitRibbonPageGroup";
            this.exitRibbonPageGroup.ShowCaptionButton = false;
            this.exitRibbonPageGroup.Text = "Acciones";
            // 
            // rbpReportes
            // 
            this.rbpReportes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgReportes,
            this.rpgGraficos});
            this.rbpReportes.Name = "rbpReportes";
            this.rbpReportes.Text = "Consultas";
            // 
            // rpgReportes
            // 
            this.rpgReportes.ItemLinks.Add(this.bbiPermisosPorApp);
            this.rpgReportes.ItemLinks.Add(this.bbiPermisosPorUser);
            this.rpgReportes.ItemLinks.Add(this.bbiRolesPorApp);
            this.rpgReportes.ItemLinks.Add(this.bbiUsersPorApp);
            this.rpgReportes.Name = "rpgReportes";
            this.rpgReportes.ShowCaptionButton = false;
            this.rpgReportes.Text = "Reportes";
            // 
            // rpgGraficos
            // 
            this.rpgGraficos.ItemLinks.Add(this.bbiUsersLogged);
            this.rpgGraficos.Name = "rpgGraficos";
            this.rpgGraficos.ShowCaptionButton = false;
            this.rpgGraficos.Text = "Gráficos";
            // 
            // helpRibbonPage
            // 
            this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.helpRibbonPageGroup});
            this.helpRibbonPage.Name = "helpRibbonPage";
            this.helpRibbonPage.Text = "Ayuda";
            // 
            // helpRibbonPageGroup
            // 
            this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
            this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
            this.helpRibbonPageGroup.ShowCaptionButton = false;
            this.helpRibbonPageGroup.Text = "Ayuda";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiUsuario);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiCorreo);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiDominio);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiLastSession);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 826);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1283, 36);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 168);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.splitContainerControl.Panel1.Controls.Add(this.tvwAplicaciones);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.perfilUsuarioInfoListGridControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1283, 658);
            this.splitContainerControl.SplitterPosition = 203;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // tvwAplicaciones
            // 
            this.tvwAplicaciones.ContextMenuStrip = this.mnuTree;
            this.tvwAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwAplicaciones.ImageIndex = 0;
            this.tvwAplicaciones.ImageList = this.treeViewImageCollection;
            this.tvwAplicaciones.Location = new System.Drawing.Point(0, 0);
            this.tvwAplicaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvwAplicaciones.Name = "tvwAplicaciones";
            treeNode1.Name = "MainNode";
            treeNode1.Text = "Lista de Aplicaciones";
            this.tvwAplicaciones.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvwAplicaciones.SelectedImageIndex = 0;
            this.tvwAplicaciones.Size = new System.Drawing.Size(237, 658);
            this.tvwAplicaciones.TabIndex = 0;
            // 
            // mnuTree
            // 
            this.mnuTree.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolActualizar});
            this.mnuTree.Name = "mnuTree";
            this.mnuTree.Size = new System.Drawing.Size(183, 30);
            // 
            // toolActualizar
            // 
            this.toolActualizar.Image = global::Gromero.Seguridad.Windows.Properties.Resources.actualizar;
            this.toolActualizar.Name = "toolActualizar";
            this.toolActualizar.Size = new System.Drawing.Size(182, 26);
            this.toolActualizar.Text = "Actualizar Lista";
            this.toolActualizar.Click += new System.EventHandler(this.toolActualizar_Click);
            // 
            // treeViewImageCollection
            // 
            this.treeViewImageCollection.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImageCollection.ImageStream")));
            this.treeViewImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewImageCollection.Images.SetKeyName(0, "sistemas.png");
            this.treeViewImageCollection.Images.SetKeyName(1, "roles.png");
            this.treeViewImageCollection.Images.SetKeyName(2, "modulo.png");
            this.treeViewImageCollection.Images.SetKeyName(3, "profile.png");
            this.treeViewImageCollection.Images.SetKeyName(4, "opciones.png");
            this.treeViewImageCollection.Images.SetKeyName(5, "users.png");
            this.treeViewImageCollection.Images.SetKeyName(6, "usuario.png");
            this.treeViewImageCollection.Images.SetKeyName(7, "Folder-icon.png");
            this.treeViewImageCollection.Images.SetKeyName(8, "Folder-Open-icon.png");
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Ayuda";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageIndex = 9;
            this.iHelp.LargeImageIndex = 9;
            this.iHelp.Name = "iHelp";
            // 
            // iRightTextAlign
            // 
            this.iRightTextAlign.Caption = "Right";
            this.iRightTextAlign.Id = 59;
            this.iRightTextAlign.ImageIndex = 14;
            this.iRightTextAlign.Name = "iRightTextAlign";
            // 
            // iCenterTextAlign
            // 
            this.iCenterTextAlign.Caption = "Center";
            this.iCenterTextAlign.Id = 58;
            this.iCenterTextAlign.ImageIndex = 13;
            this.iCenterTextAlign.Name = "iCenterTextAlign";
            // 
            // iLeftTextAlign
            // 
            this.iLeftTextAlign.Caption = "Left";
            this.iLeftTextAlign.Id = 57;
            this.iLeftTextAlign.ImageIndex = 12;
            this.iLeftTextAlign.Name = "iLeftTextAlign";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 862);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Aplicación Corporativa de Seguridad ©";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gdvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListGridControl)).EndInit();
            this.mnuPerfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.perfilUsuarioInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            this.mnuTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.BarButtonItem iExit;
		private DevExpress.XtraBars.BarButtonItem iAbout;
		private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
		private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRibbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
		private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.Utils.ImageCollection ribbonImageCollection;
		private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
		private DevExpress.XtraBars.BarButtonItem bbiEmpresas;
		private DevExpress.XtraBars.BarButtonItem bbiUsuarios;
		private DevExpress.XtraBars.BarButtonItem bbiAplicaciones;
		private DevExpress.XtraBars.BarButtonItem bbiPerfiles;
		private System.Windows.Forms.TreeView tvwAplicaciones;
		private DevExpress.XtraBars.BarStaticItem bsiUsuario;
		private DevExpress.XtraBars.BarStaticItem bsiCorreo;
		private DevExpress.XtraBars.BarStaticItem bsiDominio;
		private DevExpress.XtraBars.BarStaticItem bsiLastSession;
		private DevExpress.XtraBars.BarButtonItem iHelp;
		private DevExpress.XtraBars.BarButtonItem iRightTextAlign;
		private DevExpress.XtraBars.BarButtonItem iCenterTextAlign;
		private DevExpress.XtraBars.BarButtonItem iLeftTextAlign;
		private DevExpress.XtraGrid.GridControl perfilUsuarioInfoListGridControl;
		private System.Windows.Forms.BindingSource perfilUsuarioInfoListBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gdvPerfiles;
		private DevExpress.XtraGrid.Columns.GridColumn colNombresCompletos;
		private DevExpress.XtraGrid.Columns.GridColumn colAplicacion;
		private DevExpress.XtraGrid.Columns.GridColumn colLogueado;
		private DevExpress.XtraGrid.Columns.GridColumn colUltimoIngreso;
		private DevExpress.XtraGrid.Columns.GridColumn colCaduca;
		private System.Windows.Forms.ImageList treeViewImageCollection;
		private System.Windows.Forms.ContextMenuStrip mnuTree;
		private System.Windows.Forms.ToolStripMenuItem toolActualizar;
		private DevExpress.XtraBars.BarSubItem mnuNuevo;
		private DevExpress.XtraBars.BarSubItem mnuEditar;
		private DevExpress.XtraBars.BarSubItem mnuEliminar;
		private System.Windows.Forms.ContextMenuStrip mnuPerfiles;
		private System.Windows.Forms.ToolStripMenuItem nuevoPerfilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarPerfilToolStripMenuItem;
		private DevExpress.XtraBars.BarButtonItem bbiActualizar;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAutorizaciones;
		private DevExpress.XtraGrid.Columns.GridColumn colVigenciaInicio;
		private DevExpress.XtraGrid.Columns.GridColumn colVigenciaFin;
		private DevExpress.XtraGrid.Views.Grid.GridView gdvPermisos;
		private DevExpress.XtraGrid.Columns.GridColumn colModulo;
		private DevExpress.XtraGrid.Columns.GridColumn colOpcion;
		private DevExpress.XtraGrid.Columns.GridColumn colRol;
		private DevExpress.XtraGrid.Columns.GridColumn colConceder;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem asignarPerfilesDeFormaMasivaToolStripMenuItem;
		private DevExpress.XtraBars.Ribbon.RibbonPage rbpReportes;
		private DevExpress.XtraBars.BarButtonItem bbiPermisosPorApp;
		private DevExpress.XtraBars.BarButtonItem bbiPermisosPorUser;
		private DevExpress.XtraBars.BarButtonItem bbiRolesPorApp;
		private DevExpress.XtraBars.BarButtonItem bbiUsersPorApp;
		private DevExpress.XtraBars.BarButtonItem bbiUsersLogged;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReportes;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGraficos;
		private DevExpress.XtraBars.BarButtonItem bbiRecursos;
		private DevExpress.XtraBars.BarButtonItem bbiCargos;
		private DevExpress.XtraGrid.Columns.GridColumn colDominio;
		private DevExpress.XtraGrid.Columns.GridColumn colAlias;
		private System.Windows.Forms.ToolStripMenuItem actualizarPermisosDeTodosLosPerfilesToolStripMenuItem;
		private DevExpress.XtraGrid.Columns.GridColumn colCodigoUsuario;





	}
}
