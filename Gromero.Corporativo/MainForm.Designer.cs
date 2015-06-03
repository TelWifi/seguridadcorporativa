namespace Gromero.Corporativo
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Aplicaciones");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
			this.treePerfiles = new System.Windows.Forms.TreeView();
			this.treeViewImageCollection = new System.Windows.Forms.ImageList(this.components);
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.bbiLogin = new DevExpress.XtraBars.BarButtonItem();
			this.bbiActualizar = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
			this.rgbSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
			this.rpInicio = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.rpgInicio = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgBotones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgApariencia = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.BarraEstado = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
			this.splitAplicaciones = new DevExpress.XtraEditors.SplitContainerControl();
			this.lblUsuario = new DevExpress.XtraBars.BarStaticItem();
			this.lblDominio = new DevExpress.XtraBars.BarStaticItem();
			this.lblCorreo = new DevExpress.XtraBars.BarStaticItem();
			this.lblUltimoIngreso = new DevExpress.XtraBars.BarStaticItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
			this.splitMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitAplicaciones)).BeginInit();
			this.splitAplicaciones.SuspendLayout();
			this.SuspendLayout();
			// 
			// treePerfiles
			// 
			this.treePerfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treePerfiles.ImageIndex = 0;
			this.treePerfiles.ImageList = this.treeViewImageCollection;
			this.treePerfiles.Location = new System.Drawing.Point(0, 0);
			this.treePerfiles.Name = "treePerfiles";
			treeNode1.ImageKey = "Folder-icon.png";
			treeNode1.Name = "nodApp";
			treeNode1.SelectedImageKey = "Folder-Open-icon.png";
			treeNode1.Text = "Aplicaciones";
			this.treePerfiles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.treePerfiles.SelectedImageIndex = 0;
			this.treePerfiles.Size = new System.Drawing.Size(219, 432);
			this.treePerfiles.TabIndex = 0;
			this.treePerfiles.DoubleClick += new System.EventHandler(this.treePerfiles_DoubleClick);
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
			this.treeViewImageCollection.Images.SetKeyName(7, "Folder-Open-icon.png");
			this.treeViewImageCollection.Images.SetKeyName(8, "Folder-icon.png");
			this.treeViewImageCollection.Images.SetKeyName(9, "Close-icon.png");
			this.treeViewImageCollection.Images.SetKeyName(10, "refresh-icon.png");
			this.treeViewImageCollection.Images.SetKeyName(11, "Email-icon.png");
			this.treeViewImageCollection.Images.SetKeyName(12, "Empresa.png");
			this.treeViewImageCollection.Images.SetKeyName(13, "Star.png");
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureEdit1.EditValue = global::Gromero.Corporativo.Properties.Resources.FondoSeguridad;
			this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
			this.pictureEdit1.Size = new System.Drawing.Size(756, 432);
			this.pictureEdit1.TabIndex = 0;
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Images = this.treeViewImageCollection;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiLogin,
            this.bbiActualizar,
            this.bbiSalir,
            this.rgbSkins,
            this.lblUsuario,
            this.lblDominio,
            this.lblCorreo,
            this.lblUltimoIngreso});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 13;
			this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpInicio});
			this.ribbonControl1.Size = new System.Drawing.Size(987, 137);
			this.ribbonControl1.StatusBar = this.BarraEstado;
			this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below;
			// 
			// bbiLogin
			// 
			this.bbiLogin.Caption = "Iniciar Sesión";
			this.bbiLogin.Description = "Permite Iniciar Sesión con otro usuario";
			this.bbiLogin.Id = 1;
			this.bbiLogin.ImageIndex = 1;
			this.bbiLogin.Name = "bbiLogin";
			toolTipTitleItem1.Text = "Iniciar Sesión";
			toolTipItem1.LeftIndent = 6;
			toolTipItem1.Text = "Permite iniciar sesión nuevamente con otro usuario";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.bbiLogin.SuperTip = superToolTip1;
			this.bbiLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
			// 
			// bbiActualizar
			// 
			this.bbiActualizar.Caption = "Actualizar Lista";
			this.bbiActualizar.Description = "Permite refrescar la lista de las Aplicaciones a las que tiene acceso";
			this.bbiActualizar.Id = 2;
			this.bbiActualizar.ImageIndex = 10;
			this.bbiActualizar.Name = "bbiActualizar";
			toolTipTitleItem2.Text = "Actualizar Lista";
			toolTipItem2.LeftIndent = 6;
			toolTipItem2.Text = "Si el usuario tiene nuevos perfiles, puede actualizar la lista aquí";
			superToolTip2.Items.Add(toolTipTitleItem2);
			superToolTip2.Items.Add(toolTipItem2);
			this.bbiActualizar.SuperTip = superToolTip2;
			this.bbiActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
			// 
			// bbiSalir
			// 
			this.bbiSalir.Caption = "Salir";
			this.bbiSalir.Id = 3;
			this.bbiSalir.ImageIndex = 9;
			this.bbiSalir.Name = "bbiSalir";
			this.bbiSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
			// 
			// rgbSkins
			// 
			this.rgbSkins.Caption = "Seleccione un Tema";
			this.rgbSkins.Id = 8;
			this.rgbSkins.Name = "rgbSkins";
			// 
			// rpInicio
			// 
			this.rpInicio.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgInicio,
            this.rpgBotones,
            this.rpgApariencia});
			this.rpInicio.Name = "rpInicio";
			this.rpInicio.Text = "Inicio";
			// 
			// rpgInicio
			// 
			this.rpgInicio.AllowTextClipping = false;
			this.rpgInicio.ItemLinks.Add(this.bbiLogin);
			this.rpgInicio.Name = "rpgInicio";
			this.rpgInicio.ShowCaptionButton = false;
			this.rpgInicio.Text = "Inicio de Sesión";
			// 
			// rpgBotones
			// 
			this.rpgBotones.ItemLinks.Add(this.bbiActualizar);
			this.rpgBotones.ItemLinks.Add(this.bbiSalir);
			this.rpgBotones.Name = "rpgBotones";
			this.rpgBotones.ShowCaptionButton = false;
			this.rpgBotones.Text = "Acciones";
			// 
			// rpgApariencia
			// 
			this.rpgApariencia.ItemLinks.Add(this.rgbSkins);
			this.rpgApariencia.Name = "rpgApariencia";
			this.rpgApariencia.Text = "Apariencia";
			// 
			// BarraEstado
			// 
			this.BarraEstado.ItemLinks.Add(this.lblUsuario);
			this.BarraEstado.ItemLinks.Add(this.lblDominio);
			this.BarraEstado.ItemLinks.Add(this.lblCorreo);
			this.BarraEstado.Location = new System.Drawing.Point(0, 553);
			this.BarraEstado.Name = "BarraEstado";
			this.BarraEstado.Ribbon = this.ribbonControl1;
			this.BarraEstado.Size = new System.Drawing.Size(987, 28);
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.Horizontal = false;
			this.splitMain.Location = new System.Drawing.Point(0, 0);
			this.splitMain.Name = "splitMain";
			this.splitMain.Panel1.Controls.Add(this.ribbonControl1);
			this.splitMain.Panel1.Text = "Panel1";
			this.splitMain.Panel2.Controls.Add(this.splitAplicaciones);
			this.splitMain.Panel2.Text = "Panel2";
			this.splitMain.Size = new System.Drawing.Size(987, 581);
			this.splitMain.SplitterPosition = 137;
			this.splitMain.TabIndex = 2;
			this.splitMain.Text = "splitContainerControl1";
			// 
			// splitAplicaciones
			// 
			this.splitAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitAplicaciones.Location = new System.Drawing.Point(0, 0);
			this.splitAplicaciones.Name = "splitAplicaciones";
			this.splitAplicaciones.Panel1.Controls.Add(this.treePerfiles);
			this.splitAplicaciones.Panel1.Text = "Panel1";
			this.splitAplicaciones.Panel2.Controls.Add(this.pictureEdit1);
			this.splitAplicaciones.Panel2.Text = "Panel2";
			this.splitAplicaciones.Size = new System.Drawing.Size(987, 432);
			this.splitAplicaciones.SplitterPosition = 219;
			this.splitAplicaciones.TabIndex = 2;
			this.splitAplicaciones.Text = "splitContainerControl1";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Caption = "Usuario:";
			this.lblUsuario.Id = 9;
			this.lblUsuario.ImageIndex = 5;
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// lblDominio
			// 
			this.lblDominio.Caption = "Dominio:";
			this.lblDominio.Id = 10;
			this.lblDominio.ImageIndex = 12;
			this.lblDominio.Name = "lblDominio";
			this.lblDominio.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// lblCorreo
			// 
			this.lblCorreo.Caption = "Correo:";
			this.lblCorreo.Id = 11;
			this.lblCorreo.ImageIndex = 11;
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// lblUltimoIngreso
			// 
			this.lblUltimoIngreso.Caption = "Ultimo Ingreso:";
			this.lblUltimoIngreso.Id = 12;
			this.lblUltimoIngreso.ImageIndex = 13;
			this.lblUltimoIngreso.Name = "lblUltimoIngreso";
			this.lblUltimoIngreso.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 581);
			this.Controls.Add(this.BarraEstado);
			this.Controls.Add(this.splitMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inicio de Sesión Corporativo";
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
			this.splitMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitAplicaciones)).EndInit();
			this.splitAplicaciones.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList treeViewImageCollection;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private System.Windows.Forms.TreeView treePerfiles;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.BarButtonItem bbiLogin;
		private DevExpress.XtraBars.BarButtonItem bbiActualizar;
		private DevExpress.XtraBars.BarButtonItem bbiSalir;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpInicio;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgInicio;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBotones;
		private DevExpress.XtraEditors.SplitContainerControl splitMain;
		private DevExpress.XtraEditors.SplitContainerControl splitAplicaciones;
		private DevExpress.XtraBars.RibbonGalleryBarItem rgbSkins;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgApariencia;
		private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar BarraEstado;
		private DevExpress.XtraBars.BarStaticItem lblUsuario;
		private DevExpress.XtraBars.BarStaticItem lblDominio;
		private DevExpress.XtraBars.BarStaticItem lblCorreo;
		private DevExpress.XtraBars.BarStaticItem lblUltimoIngreso;
	}
}