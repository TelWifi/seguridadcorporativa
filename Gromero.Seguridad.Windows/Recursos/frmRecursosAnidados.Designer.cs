namespace Gromero.Seguridad.Windows.RecursosSeguridad
{
    partial class frmRecursosAnidados
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
            this.gdvRecursos2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recursoHijoGridControl = new DevExpress.XtraGrid.GridControl();
            this.listaRecursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursoHijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvRecursos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvDetalles2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detallesGridControl = new DevExpress.XtraGrid.GridControl();
            this.detallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.descripcionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rutaRecursoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnEdit = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnDelete = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.tabRecursos = new DevExpress.XtraTab.XtraTabControl();
            this.tpRecursos = new DevExpress.XtraTab.XtraTabPage();
            this.tpDetalles = new DevExpress.XtraTab.XtraTabPage();
            descripcionLabel = new System.Windows.Forms.Label();
            rutaRecursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoHijoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoHijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaRecursoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRecursos)).BeginInit();
            this.tabRecursos.SuspendLayout();
            this.tpRecursos.SuspendLayout();
            this.tpDetalles.SuspendLayout();
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
            this.gdvRecursos2.GridControl = this.recursoHijoGridControl;
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
            // recursoHijoGridControl
            // 
            this.recursoHijoGridControl.DataSource = this.listaRecursosBindingSource;
            this.recursoHijoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gdvRecursos2;
            gridLevelNode1.RelationName = "ListaRecursos";
            this.recursoHijoGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.recursoHijoGridControl.Location = new System.Drawing.Point(0, 0);
            this.recursoHijoGridControl.MainView = this.gdvRecursos;
            this.recursoHijoGridControl.MenuManager = this.BarraBotones;
            this.recursoHijoGridControl.Name = "recursoHijoGridControl";
            this.recursoHijoGridControl.ShowOnlyPredefinedDetails = true;
            this.recursoHijoGridControl.Size = new System.Drawing.Size(519, 257);
            this.recursoHijoGridControl.TabIndex = 8;
            this.recursoHijoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvRecursos,
            this.gdvRecursos2});
            // 
            // listaRecursosBindingSource
            // 
            this.listaRecursosBindingSource.DataMember = "ListaRecursos";
            this.listaRecursosBindingSource.DataSource = this.recursoHijoBindingSource;
            // 
            // recursoHijoBindingSource
            // 
            this.recursoHijoBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.Editables.RecursoHijo);
            // 
            // gdvRecursos
            // 
            this.gdvRecursos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colRutaRecurso});
            this.gdvRecursos.GridControl = this.recursoHijoGridControl;
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
            // gdvDetalles2
            // 
            this.gdvDetalles2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo1,
            this.colDescripcion3,
            this.colNivel1});
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
            // colDescripcion3
            // 
            this.colDescripcion3.FieldName = "Descripcion";
            this.colDescripcion3.Name = "colDescripcion3";
            this.colDescripcion3.Visible = true;
            this.colDescripcion3.VisibleIndex = 1;
            // 
            // colNivel1
            // 
            this.colNivel1.FieldName = "Nivel";
            this.colNivel1.Name = "colNivel1";
            this.colNivel1.OptionsColumn.AllowEdit = false;
            this.colNivel1.Visible = true;
            this.colNivel1.VisibleIndex = 2;
            // 
            // detallesGridControl
            // 
            this.detallesGridControl.DataSource = this.detallesBindingSource;
            this.detallesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.LevelTemplate = this.gdvDetalles2;
            gridLevelNode2.RelationName = "Detalles";
            this.detallesGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.detallesGridControl.Location = new System.Drawing.Point(0, 0);
            this.detallesGridControl.MainView = this.gdvDetalles;
            this.detallesGridControl.MenuManager = this.BarraBotones;
            this.detallesGridControl.Name = "detallesGridControl";
            this.detallesGridControl.ShowOnlyPredefinedDetails = true;
            this.detallesGridControl.Size = new System.Drawing.Size(519, 257);
            this.detallesGridControl.TabIndex = 0;
            this.detallesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDetalles,
            this.gdvDetalles2});
            // 
            // detallesBindingSource
            // 
            this.detallesBindingSource.DataMember = "Detalles";
            this.detallesBindingSource.DataSource = this.recursoHijoBindingSource;
            // 
            // gdvDetalles
            // 
            this.gdvDetalles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescripcion2,
            this.colNivel});
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
            // colDescripcion2
            // 
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 1;
            // 
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.OptionsColumn.AllowEdit = false;
            this.colNivel.Visible = true;
            this.colNivel.VisibleIndex = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(521, 31);
            // 
            // descripcionTextEdit
            // 
            this.descripcionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.recursoHijoBindingSource, "Descripcion", true));
            this.descripcionTextEdit.Location = new System.Drawing.Point(92, 37);
            this.descripcionTextEdit.MenuManager = this.BarraBotones;
            this.descripcionTextEdit.Name = "descripcionTextEdit";
            this.descripcionTextEdit.Size = new System.Drawing.Size(311, 20);
            this.descripcionTextEdit.TabIndex = 6;
            // 
            // rutaRecursoTextEdit
            // 
            this.rutaRecursoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.recursoHijoBindingSource, "RutaRecurso", true));
            this.rutaRecursoTextEdit.Location = new System.Drawing.Point(92, 63);
            this.rutaRecursoTextEdit.MenuManager = this.BarraBotones;
            this.rutaRecursoTextEdit.Name = "rutaRecursoTextEdit";
            this.rutaRecursoTextEdit.Size = new System.Drawing.Size(389, 20);
            this.rutaRecursoTextEdit.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.CajaTexto = null;
            this.btnAdd.CajaTextoConBoton = null;
            this.btnAdd.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Agregar;
            this.btnAdd.Location = new System.Drawing.Point(541, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CajaTexto = null;
            this.btnEdit.CajaTextoConBoton = null;
            this.btnEdit.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Modificar;
            this.btnEdit.Location = new System.Drawing.Point(541, 219);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 24);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CajaTexto = null;
            this.btnDelete.CajaTextoConBoton = null;
            this.btnDelete.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Eliminar;
            this.btnDelete.Location = new System.Drawing.Point(541, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 24);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnDelete_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.recursoHijoBindingSource;
            // 
            // tabRecursos
            // 
            this.tabRecursos.Location = new System.Drawing.Point(13, 89);
            this.tabRecursos.Name = "tabRecursos";
            this.tabRecursos.SelectedTabPage = this.tpDetalles;
            this.tabRecursos.Size = new System.Drawing.Size(521, 282);
            this.tabRecursos.TabIndex = 10;
            this.tabRecursos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpDetalles,
            this.tpRecursos});
            // 
            // tpRecursos
            // 
            this.tpRecursos.Controls.Add(this.recursoHijoGridControl);
            this.tpRecursos.Name = "tpRecursos";
            this.tpRecursos.Size = new System.Drawing.Size(519, 257);
            this.tpRecursos.Text = "Recursos Anidados";
            // 
            // tpDetalles
            // 
            this.tpDetalles.AutoScroll = true;
            this.tpDetalles.Controls.Add(this.detallesGridControl);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Size = new System.Drawing.Size(519, 257);
            this.tpDetalles.Text = "Detalles";
            // 
            // frmRecursosAnidados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 401);
            this.Controls.Add(this.tabRecursos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(rutaRecursoLabel);
            this.Controls.Add(this.rutaRecursoTextEdit);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextEdit);
            this.Name = "frmRecursosAnidados";
            this.Text = "Recursos Anidados";
            this.Controls.SetChildIndex(this.descripcionTextEdit, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.rutaRecursoTextEdit, 0);
            this.Controls.SetChildIndex(rutaRecursoLabel, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.tabRecursos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoHijoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoHijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaRecursoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRecursos)).EndInit();
            this.tabRecursos.ResumeLayout(false);
            this.tpRecursos.ResumeLayout(false);
            this.tpDetalles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private System.Windows.Forms.BindingSource recursoHijoBindingSource;
        private DevExpress.XtraEditors.TextEdit descripcionTextEdit;
        private DevExpress.XtraEditors.TextEdit rutaRecursoTextEdit;
        private System.Windows.Forms.BindingSource listaRecursosBindingSource;
        private DevExpress.XtraGrid.GridControl recursoHijoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursos2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso1;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursos;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnAdd;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnEdit;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnDelete;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraTab.XtraTabControl tabRecursos;
        private DevExpress.XtraTab.XtraTabPage tpRecursos;
        private DevExpress.XtraTab.XtraTabPage tpDetalles;
        private DevExpress.XtraGrid.GridControl detallesGridControl;
        private System.Windows.Forms.BindingSource detallesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetalles2;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion3;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
    }
}