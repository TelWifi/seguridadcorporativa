namespace ErickOrlando.Seguridad.Windows.Aplicaciones
{
    partial class frmOpcionesUI
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label claseLabel;
            System.Windows.Forms.Label urlLabel;
            this.gridOpciones = new DevExpress.XtraGrid.GridControl();
            this.listaOpcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opcionesUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvOpciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNroOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.codigoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nombreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tipoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.claseTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.urlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnEdit = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnDelete = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.tpPlantillas = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnUncheck = new DevExpress.XtraEditors.SimpleButton();
            this.btnRoles = new DevExpress.XtraEditors.SimpleButton();
            this.gridPlantillas = new DevExpress.XtraGrid.GridControl();
            this.listaPlantillasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvListaPlantillas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConceder = new DevExpress.XtraGrid.Columns.GridColumn();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            claseLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaOpcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesUIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlantillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlantillasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListaPlantillas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(16, 51);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(44, 13);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(16, 77);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(48, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(16, 103);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 8;
            tipoLabel.Text = "Tipo:";
            // 
            // claseLabel
            // 
            claseLabel.AutoSize = true;
            claseLabel.Location = new System.Drawing.Point(16, 129);
            claseLabel.Name = "claseLabel";
            claseLabel.Size = new System.Drawing.Size(37, 13);
            claseLabel.TabIndex = 10;
            claseLabel.Text = "Clase:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(16, 155);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(24, 13);
            urlLabel.TabIndex = 12;
            urlLabel.Text = "Url:";
            // 
            // gridOpciones
            // 
            this.gridOpciones.DataSource = this.listaOpcionesBindingSource;
            this.gridOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOpciones.Location = new System.Drawing.Point(2, 21);
            this.gridOpciones.MainView = this.gdvOpciones;
            this.gridOpciones.MenuManager = this.BarraBotones;
            this.gridOpciones.Name = "gridOpciones";
            this.gridOpciones.ShowOnlyPredefinedDetails = true;
            this.gridOpciones.Size = new System.Drawing.Size(648, 173);
            this.gridOpciones.TabIndex = 14;
            this.gridOpciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvOpciones});
            // 
            // listaOpcionesBindingSource
            // 
            this.listaOpcionesBindingSource.DataMember = "ListaOpciones";
            this.listaOpcionesBindingSource.DataSource = this.opcionesUIBindingSource;
            // 
            // opcionesUIBindingSource
            // 
            this.opcionesUIBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.Editables.Opcion);
            // 
            // gdvOpciones
            // 
            this.gdvOpciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNroOrden,
            this.colCodigo,
            this.colNombre,
            this.colTipo,
            this.colClase,
            this.colUrl,
            this.colEstado});
            this.gdvOpciones.GridControl = this.gridOpciones;
            this.gdvOpciones.Name = "gdvOpciones";
            this.gdvOpciones.OptionsCustomization.AllowGroup = false;
            this.gdvOpciones.OptionsDetail.EnableMasterViewMode = false;
            this.gdvOpciones.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvOpciones.OptionsView.ColumnAutoWidth = false;
            this.gdvOpciones.OptionsView.ShowGroupPanel = false;
            // 
            // colNroOrden
            // 
            this.colNroOrden.FieldName = "NroOrden";
            this.colNroOrden.Name = "colNroOrden";
            this.colNroOrden.Visible = true;
            this.colNroOrden.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            this.colCodigo.Width = 115;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 118;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 3;
            this.colTipo.Width = 103;
            // 
            // colClase
            // 
            this.colClase.FieldName = "Clase";
            this.colClase.Name = "colClase";
            this.colClase.Visible = true;
            this.colClase.VisibleIndex = 4;
            this.colClase.Width = 126;
            // 
            // colUrl
            // 
            this.colUrl.FieldName = "Url";
            this.colUrl.Name = "colUrl";
            this.colUrl.Visible = true;
            this.colUrl.VisibleIndex = 5;
            this.colUrl.Width = 210;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(782, 31);
            // 
            // codigoTextEdit
            // 
            this.codigoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opcionesUIBindingSource, "Codigo", true));
            this.codigoTextEdit.Location = new System.Drawing.Point(66, 48);
            this.codigoTextEdit.MenuManager = this.BarraBotones;
            this.codigoTextEdit.Name = "codigoTextEdit";
            this.codigoTextEdit.Size = new System.Drawing.Size(130, 20);
            this.codigoTextEdit.TabIndex = 5;
            // 
            // nombreTextEdit
            // 
            this.nombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opcionesUIBindingSource, "Nombre", true));
            this.nombreTextEdit.Location = new System.Drawing.Point(66, 74);
            this.nombreTextEdit.MenuManager = this.BarraBotones;
            this.nombreTextEdit.Name = "nombreTextEdit";
            this.nombreTextEdit.Size = new System.Drawing.Size(208, 20);
            this.nombreTextEdit.TabIndex = 7;
            // 
            // tipoTextEdit
            // 
            this.tipoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opcionesUIBindingSource, "Tipo", true));
            this.tipoTextEdit.Location = new System.Drawing.Point(66, 100);
            this.tipoTextEdit.MenuManager = this.BarraBotones;
            this.tipoTextEdit.Name = "tipoTextEdit";
            this.tipoTextEdit.Size = new System.Drawing.Size(208, 20);
            this.tipoTextEdit.TabIndex = 9;
            // 
            // claseTextEdit
            // 
            this.claseTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opcionesUIBindingSource, "Clase", true));
            this.claseTextEdit.Location = new System.Drawing.Point(66, 126);
            this.claseTextEdit.MenuManager = this.BarraBotones;
            this.claseTextEdit.Name = "claseTextEdit";
            this.claseTextEdit.Size = new System.Drawing.Size(208, 20);
            this.claseTextEdit.TabIndex = 11;
            // 
            // urlTextEdit
            // 
            this.urlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.opcionesUIBindingSource, "Url", true));
            this.urlTextEdit.Location = new System.Drawing.Point(66, 152);
            this.urlTextEdit.MenuManager = this.BarraBotones;
            this.urlTextEdit.Name = "urlTextEdit";
            this.urlTextEdit.Size = new System.Drawing.Size(383, 20);
            this.urlTextEdit.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.CajaTexto = null;
            this.btnAdd.CajaTextoConBoton = null;
            this.btnAdd.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Agregar;
            this.btnAdd.Location = new System.Drawing.Point(686, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.CajaTexto = null;
            this.btnEdit.CajaTextoConBoton = null;
            this.btnEdit.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Modificar;
            this.btnEdit.Location = new System.Drawing.Point(686, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 24);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.CajaTexto = null;
            this.btnDelete.CajaTextoConBoton = null;
            this.btnDelete.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Eliminar;
            this.btnDelete.Location = new System.Drawing.Point(686, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 24);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnDelete_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.opcionesUIBindingSource;
            // 
            // tpPlantillas
            // 
            this.tpPlantillas.Name = "tpPlantillas";
            this.tpPlantillas.Size = new System.Drawing.Size(550, 328);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridOpciones);
            this.groupControl1.Location = new System.Drawing.Point(19, 178);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(652, 196);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Lista de Opciones";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnUncheck);
            this.groupControl2.Controls.Add(this.btnRoles);
            this.groupControl2.Controls.Add(this.gridPlantillas);
            this.groupControl2.Location = new System.Drawing.Point(19, 380);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(649, 155);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "Roles que tienen acceso a esta Opción";
            // 
            // btnUncheck
            // 
            this.btnUncheck.Image = global::ErickOrlando.Seguridad.Windows.Properties.Resources.uncheckicon;
            this.btnUncheck.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUncheck.Location = new System.Drawing.Point(615, 0);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(27, 23);
            this.btnUncheck.TabIndex = 20;
            this.btnUncheck.ToolTip = "Deseleccionar Todo";
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Image = global::ErickOrlando.Seguridad.Windows.Properties.Resources.EditarRol;
            this.btnRoles.Location = new System.Drawing.Point(473, 0);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(136, 23);
            this.btnRoles.TabIndex = 19;
            this.btnRoles.Text = "Completar Roles";
            this.btnRoles.Click += new System.EventHandler(this.bbiRoles_ItemClick);
            // 
            // gridPlantillas
            // 
            this.gridPlantillas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPlantillas.DataSource = this.listaPlantillasBindingSource;
            this.gridPlantillas.Location = new System.Drawing.Point(0, 23);
            this.gridPlantillas.MainView = this.gdvListaPlantillas;
            this.gridPlantillas.MenuManager = this.BarraBotones;
            this.gridPlantillas.Name = "gridPlantillas";
            this.gridPlantillas.Size = new System.Drawing.Size(642, 127);
            this.gridPlantillas.TabIndex = 0;
            this.gridPlantillas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvListaPlantillas});
            // 
            // listaPlantillasBindingSource
            // 
            this.listaPlantillasBindingSource.DataMember = "ListaPlantillas";
            this.listaPlantillasBindingSource.DataSource = this.listaOpcionesBindingSource;
            // 
            // gdvListaPlantillas
            // 
            this.gdvListaPlantillas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreRol,
            this.colNombreOpcion,
            this.colConceder});
            this.gdvListaPlantillas.GridControl = this.gridPlantillas;
            this.gdvListaPlantillas.Name = "gdvListaPlantillas";
            this.gdvListaPlantillas.OptionsCustomization.AllowGroup = false;
            this.gdvListaPlantillas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvListaPlantillas.OptionsView.ShowGroupPanel = false;
            // 
            // colNombreRol
            // 
            this.colNombreRol.FieldName = "NombreRol";
            this.colNombreRol.Name = "colNombreRol";
            this.colNombreRol.OptionsColumn.AllowEdit = false;
            this.colNombreRol.Visible = true;
            this.colNombreRol.VisibleIndex = 0;
            // 
            // colNombreOpcion
            // 
            this.colNombreOpcion.FieldName = "NombreOpcion";
            this.colNombreOpcion.Name = "colNombreOpcion";
            this.colNombreOpcion.OptionsColumn.AllowEdit = false;
            this.colNombreOpcion.Visible = true;
            this.colNombreOpcion.VisibleIndex = 1;
            // 
            // colConceder
            // 
            this.colConceder.FieldName = "Conceder";
            this.colConceder.Name = "colConceder";
            this.colConceder.Visible = true;
            this.colConceder.VisibleIndex = 2;
            // 
            // frmOpcionesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 565);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(urlLabel);
            this.Controls.Add(this.urlTextEdit);
            this.Controls.Add(claseLabel);
            this.Controls.Add(this.claseTextEdit);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextEdit);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextEdit);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "frmOpcionesUI";
            this.Text = "Opciones UI";
            this.Controls.SetChildIndex(this.codigoTextEdit, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            this.Controls.SetChildIndex(this.nombreTextEdit, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.tipoTextEdit, 0);
            this.Controls.SetChildIndex(tipoLabel, 0);
            this.Controls.SetChildIndex(this.claseTextEdit, 0);
            this.Controls.SetChildIndex(claseLabel, 0);
            this.Controls.SetChildIndex(this.urlTextEdit, 0);
            this.Controls.SetChildIndex(urlLabel, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaOpcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesUIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPlantillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlantillasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListaPlantillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource opcionesUIBindingSource;
        private DevExpress.XtraEditors.TextEdit codigoTextEdit;
        private DevExpress.XtraEditors.TextEdit nombreTextEdit;
        private DevExpress.XtraEditors.TextEdit tipoTextEdit;
        private DevExpress.XtraEditors.TextEdit claseTextEdit;
        private DevExpress.XtraEditors.TextEdit urlTextEdit;
        private DevExpress.XtraGrid.GridControl gridOpciones;
        private System.Windows.Forms.BindingSource listaOpcionesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvOpciones;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colClase;
        private DevExpress.XtraGrid.Columns.GridColumn colUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnAdd;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnEdit;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnDelete;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraTab.XtraTabPage tpPlantillas;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridPlantillas;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvListaPlantillas;
        private DevExpress.XtraEditors.SimpleButton btnRoles;
        private DevExpress.XtraGrid.Columns.GridColumn colNroOrden;
        private System.Windows.Forms.BindingSource listaPlantillasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRol;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreOpcion;
        private DevExpress.XtraGrid.Columns.GridColumn colConceder;
        private DevExpress.XtraEditors.SimpleButton btnUncheck;
    }
}