namespace Gromero.Seguridad.Windows.RecursosSeguridad
{
    partial class frmRecursos
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label rutaRecursoLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.gdvRecursos2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listaRecursosGridControl = new DevExpress.XtraGrid.GridControl();
            this.listaRecursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvRecursos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvRecursos3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvDetalles2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detallesGridControl = new DevExpress.XtraGrid.GridControl();
            this.detallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvDetalles3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.descripcionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rutaRecursoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tabRecursos = new DevExpress.XtraTab.XtraTabControl();
            this.tpRecursosAnidados = new DevExpress.XtraTab.XtraTabPage();
            this.tpDetalles = new DevExpress.XtraTab.XtraTabPage();
            this.btnAdd = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnEdit = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnDelete = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            rutaRecursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecursosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaRecursoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRecursos)).BeginInit();
            this.tabRecursos.SuspendLayout();
            this.tpRecursosAnidados.SuspendLayout();
            this.tpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(11, 40);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(65, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // rutaRecursoLabel
            // 
            rutaRecursoLabel.AutoSize = true;
            rutaRecursoLabel.Location = new System.Drawing.Point(10, 66);
            rutaRecursoLabel.Name = "rutaRecursoLabel";
            rutaRecursoLabel.Size = new System.Drawing.Size(76, 13);
            rutaRecursoLabel.TabIndex = 6;
            rutaRecursoLabel.Text = "Ruta Recurso:";
            // 
            // gdvRecursos2
            // 
            this.gdvRecursos2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion1,
            this.colRutaRecurso1});
            this.gdvRecursos2.GridControl = this.listaRecursosGridControl;
            this.gdvRecursos2.Name = "gdvRecursos2";
            this.gdvRecursos2.OptionsBehavior.Editable = false;
            this.gdvRecursos2.OptionsCustomization.AllowGroup = false;
            this.gdvRecursos2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvRecursos2.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            // 
            // colRutaRecurso1
            // 
            this.colRutaRecurso1.FieldName = "RutaRecurso";
            this.colRutaRecurso1.Name = "colRutaRecurso1";
            this.colRutaRecurso1.Visible = true;
            this.colRutaRecurso1.VisibleIndex = 1;
            // 
            // listaRecursosGridControl
            // 
            this.listaRecursosGridControl.DataSource = this.listaRecursosBindingSource;
            this.listaRecursosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gdvRecursos2;
            gridLevelNode2.LevelTemplate = this.gdvRecursos3;
            gridLevelNode2.RelationName = "ListaRecursos";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "ListaRecursos";
            this.listaRecursosGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.listaRecursosGridControl.Location = new System.Drawing.Point(0, 0);
            this.listaRecursosGridControl.MainView = this.gdvRecursos;
            this.listaRecursosGridControl.MenuManager = this.BarraBotones;
            this.listaRecursosGridControl.Name = "listaRecursosGridControl";
            this.listaRecursosGridControl.ShowOnlyPredefinedDetails = true;
            this.listaRecursosGridControl.Size = new System.Drawing.Size(533, 310);
            this.listaRecursosGridControl.TabIndex = 8;
            this.listaRecursosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvRecursos,
            this.gdvRecursos3,
            this.gdvRecursos2});
            // 
            // listaRecursosBindingSource
            // 
            this.listaRecursosBindingSource.DataMember = "ListaRecursos";
            this.listaRecursosBindingSource.DataSource = this.recursosBindingSource;
            // 
            // recursosBindingSource
            // 
            this.recursosBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.Editables.Recursos);
            // 
            // gdvRecursos
            // 
            this.gdvRecursos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colRutaRecurso});
            this.gdvRecursos.GridControl = this.listaRecursosGridControl;
            this.gdvRecursos.Name = "gdvRecursos";
            this.gdvRecursos.OptionsCustomization.AllowGroup = false;
            this.gdvRecursos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvRecursos.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // colRutaRecurso
            // 
            this.colRutaRecurso.FieldName = "RutaRecurso";
            this.colRutaRecurso.Name = "colRutaRecurso";
            this.colRutaRecurso.Visible = true;
            this.colRutaRecurso.VisibleIndex = 1;
            // 
            // gdvRecursos3
            // 
            this.gdvRecursos3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion2,
            this.colRutaRecurso2});
            this.gdvRecursos3.GridControl = this.listaRecursosGridControl;
            this.gdvRecursos3.Name = "gdvRecursos3";
            this.gdvRecursos3.OptionsBehavior.Editable = false;
            this.gdvRecursos3.OptionsCustomization.AllowGroup = false;
            this.gdvRecursos3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvRecursos3.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 0;
            // 
            // colRutaRecurso2
            // 
            this.colRutaRecurso2.FieldName = "RutaRecurso";
            this.colRutaRecurso2.Name = "colRutaRecurso2";
            this.colRutaRecurso2.Visible = true;
            this.colRutaRecurso2.VisibleIndex = 1;
            // 
            // gdvDetalles2
            // 
            this.gdvDetalles2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo1,
            this.colDescripcion4});
            this.gdvDetalles2.GridControl = this.detallesGridControl;
            this.gdvDetalles2.Name = "gdvDetalles2";
            this.gdvDetalles2.OptionsBehavior.Editable = false;
            this.gdvDetalles2.OptionsCustomization.AllowGroup = false;
            this.gdvDetalles2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvDetalles2.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo1
            // 
            this.colCodigo1.FieldName = "Codigo";
            this.colCodigo1.Name = "colCodigo1";
            this.colCodigo1.Visible = true;
            this.colCodigo1.VisibleIndex = 0;
            // 
            // colDescripcion4
            // 
            this.colDescripcion4.FieldName = "Descripcion";
            this.colDescripcion4.Name = "colDescripcion4";
            this.colDescripcion4.Visible = true;
            this.colDescripcion4.VisibleIndex = 1;
            // 
            // detallesGridControl
            // 
            this.detallesGridControl.DataSource = this.detallesBindingSource;
            this.detallesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode3.LevelTemplate = this.gdvDetalles2;
            gridLevelNode4.LevelTemplate = this.gdvDetalles3;
            gridLevelNode4.RelationName = "Detalles";
            gridLevelNode3.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            gridLevelNode3.RelationName = "Detalles";
            this.detallesGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.detallesGridControl.Location = new System.Drawing.Point(0, 0);
            this.detallesGridControl.MainView = this.gdvDetalles;
            this.detallesGridControl.MenuManager = this.BarraBotones;
            this.detallesGridControl.Name = "detallesGridControl";
            this.detallesGridControl.ShowOnlyPredefinedDetails = true;
            this.detallesGridControl.Size = new System.Drawing.Size(533, 310);
            this.detallesGridControl.TabIndex = 0;
            this.detallesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDetalles,
            this.gdvDetalles3,
            this.gdvDetalles2});
            // 
            // detallesBindingSource
            // 
            this.detallesBindingSource.DataMember = "Detalles";
            this.detallesBindingSource.DataSource = this.recursosBindingSource;
            // 
            // gdvDetalles
            // 
            this.gdvDetalles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescripcion3});
            this.gdvDetalles.GridControl = this.detallesGridControl;
            this.gdvDetalles.Name = "gdvDetalles";
            this.gdvDetalles.OptionsCustomization.AllowGroup = false;
            this.gdvDetalles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvDetalles.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colDescripcion3
            // 
            this.colDescripcion3.FieldName = "Descripcion";
            this.colDescripcion3.Name = "colDescripcion3";
            this.colDescripcion3.Visible = true;
            this.colDescripcion3.VisibleIndex = 1;
            // 
            // gdvDetalles3
            // 
            this.gdvDetalles3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo2,
            this.colDescripcion5});
            this.gdvDetalles3.GridControl = this.detallesGridControl;
            this.gdvDetalles3.Name = "gdvDetalles3";
            this.gdvDetalles3.OptionsBehavior.Editable = false;
            this.gdvDetalles3.OptionsCustomization.AllowGroup = false;
            this.gdvDetalles3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvDetalles3.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo2
            // 
            this.colCodigo2.FieldName = "Codigo";
            this.colCodigo2.Name = "colCodigo2";
            this.colCodigo2.Visible = true;
            this.colCodigo2.VisibleIndex = 0;
            // 
            // colDescripcion5
            // 
            this.colDescripcion5.FieldName = "Descripcion";
            this.colDescripcion5.Name = "colDescripcion5";
            this.colDescripcion5.Visible = true;
            this.colDescripcion5.VisibleIndex = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(662, 31);
            // 
            // descripcionTextEdit
            // 
            this.descripcionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.recursosBindingSource, "Descripcion", true));
            this.descripcionTextEdit.Location = new System.Drawing.Point(92, 37);
            this.descripcionTextEdit.MenuManager = this.BarraBotones;
            this.descripcionTextEdit.Name = "descripcionTextEdit";
            this.descripcionTextEdit.Size = new System.Drawing.Size(193, 20);
            this.descripcionTextEdit.TabIndex = 6;
            // 
            // rutaRecursoTextEdit
            // 
            this.rutaRecursoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.recursosBindingSource, "RutaRecurso", true));
            this.rutaRecursoTextEdit.Location = new System.Drawing.Point(92, 63);
            this.rutaRecursoTextEdit.MenuManager = this.BarraBotones;
            this.rutaRecursoTextEdit.Name = "rutaRecursoTextEdit";
            this.rutaRecursoTextEdit.Size = new System.Drawing.Size(366, 20);
            this.rutaRecursoTextEdit.TabIndex = 7;
            // 
            // tabRecursos
            // 
            this.tabRecursos.Location = new System.Drawing.Point(14, 89);
            this.tabRecursos.Name = "tabRecursos";
            this.tabRecursos.SelectedTabPage = this.tpDetalles;
            this.tabRecursos.Size = new System.Drawing.Size(535, 335);
            this.tabRecursos.TabIndex = 10;
            this.tabRecursos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpDetalles,
            this.tpRecursosAnidados});
            // 
            // tpRecursosAnidados
            // 
            this.tpRecursosAnidados.Controls.Add(this.listaRecursosGridControl);
            this.tpRecursosAnidados.Name = "tpRecursosAnidados";
            this.tpRecursosAnidados.Size = new System.Drawing.Size(533, 310);
            this.tpRecursosAnidados.Text = "Recursos Anidados";
            // 
            // tpDetalles
            // 
            this.tpDetalles.AutoScroll = true;
            this.tpDetalles.Controls.Add(this.detallesGridControl);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Size = new System.Drawing.Size(533, 310);
            this.tpDetalles.Text = "Detalles del Recurso";
            // 
            // btnAdd
            // 
            this.btnAdd.CajaTexto = null;
            this.btnAdd.CajaTextoConBoton = null;
            this.btnAdd.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Agregar;
            this.btnAdd.Location = new System.Drawing.Point(555, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CajaTexto = null;
            this.btnEdit.CajaTextoConBoton = null;
            this.btnEdit.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Modificar;
            this.btnEdit.Location = new System.Drawing.Point(555, 261);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 24);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CajaTexto = null;
            this.btnDelete.CajaTextoConBoton = null;
            this.btnDelete.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Eliminar;
            this.btnDelete.Location = new System.Drawing.Point(555, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 24);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnDelete_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.recursosBindingSource;
            // 
            // frmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 465);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabRecursos);
            this.Controls.Add(rutaRecursoLabel);
            this.Controls.Add(this.rutaRecursoTextEdit);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextEdit);
            this.Name = "frmRecursos";
            this.Text = "Recursos";
            this.Controls.SetChildIndex(this.descripcionTextEdit, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.rutaRecursoTextEdit, 0);
            this.Controls.SetChildIndex(rutaRecursoLabel, 0);
            this.Controls.SetChildIndex(this.tabRecursos, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecursosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaRecursoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRecursos)).EndInit();
            this.tabRecursos.ResumeLayout(false);
            this.tpRecursosAnidados.ResumeLayout(false);
            this.tpDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource recursosBindingSource;
        private DevExpress.XtraEditors.TextEdit descripcionTextEdit;
        private DevExpress.XtraEditors.TextEdit rutaRecursoTextEdit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private System.Windows.Forms.BindingSource listaRecursosBindingSource;
        private DevExpress.XtraGrid.GridControl listaRecursosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursos;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursos2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso1;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursos3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso2;
        private DevExpress.XtraTab.XtraTabControl tabRecursos;
        private DevExpress.XtraTab.XtraTabPage tpRecursosAnidados;
        private DevExpress.XtraTab.XtraTabPage tpDetalles;
        private DevExpress.XtraGrid.GridControl detallesGridControl;
        private System.Windows.Forms.BindingSource detallesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetalles2;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion4;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetalles3;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion5;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion3;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnAdd;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnEdit;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnDelete;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}