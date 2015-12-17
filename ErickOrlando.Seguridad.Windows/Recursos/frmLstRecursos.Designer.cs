namespace ErickOrlando.Seguridad.Windows.RecursosSeguridad
{
    partial class frmLstRecursos
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recursosInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.recursosInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvRecursos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaRecurso3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboFiltros = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).BeginInit();
            this.grpValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).BeginInit();
            this.grpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltros.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCriterios
            // 
            this.grpCriterios.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCriterios.AppearanceCaption.Options.UseFont = true;
            this.grpCriterios.Controls.Add(this.cboFiltros);
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
            this.grpGrilla.Controls.Add(this.recursosInfoListGridControl);
            this.grpGrilla.Size = new System.Drawing.Size(773, 311);
            this.grpGrilla.Text = "Lista de Recursos";
            // 
            // txtFiltro
            // 
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion1,
            this.colRutaRecurso1,
            this.colNivel});
            this.gridView1.GridControl = this.recursosInfoListGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.Visible = true;
            this.colNivel.VisibleIndex = 2;
            // 
            // recursosInfoListGridControl
            // 
            this.recursosInfoListGridControl.DataSource = this.recursosInfoListBindingSource;
            this.recursosInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode2.LevelTemplate = this.gridView2;
            gridLevelNode3.LevelTemplate = this.gridView3;
            gridLevelNode3.RelationName = "ListaRecursos";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "ListaRecursos";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "RecursosAnidados";
            this.recursosInfoListGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.recursosInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.recursosInfoListGridControl.MainView = this.gdvRecursos;
            this.recursosInfoListGridControl.MenuManager = this.BarraBotones;
            this.recursosInfoListGridControl.Name = "recursosInfoListGridControl";
            this.recursosInfoListGridControl.ShowOnlyPredefinedDetails = true;
            this.recursosInfoListGridControl.Size = new System.Drawing.Size(769, 283);
            this.recursosInfoListGridControl.TabIndex = 0;
            this.recursosInfoListGridControl.UseEmbeddedNavigator = true;
            this.recursosInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvRecursos,
            this.gridView2,
            this.gridView3,
            this.gridView1});
            // 
            // recursosInfoListBindingSource
            // 
            this.recursosInfoListBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.RecursosInfo);
            // 
            // gdvRecursos
            // 
            this.gdvRecursos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colRutaRecurso});
            this.gdvRecursos.GridControl = this.recursosInfoListGridControl;
            this.gdvRecursos.Name = "gdvRecursos";
            this.gdvRecursos.OptionsBehavior.Editable = false;
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion2,
            this.colRutaRecurso2,
            this.colNivel1});
            this.gridView2.GridControl = this.recursosInfoListGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // colNivel1
            // 
            this.colNivel1.FieldName = "Nivel";
            this.colNivel1.Name = "colNivel1";
            this.colNivel1.Visible = true;
            this.colNivel1.VisibleIndex = 2;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion3,
            this.colRutaRecurso3,
            this.colNivel2});
            this.gridView3.GridControl = this.recursosInfoListGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsCustomization.AllowGroup = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion3
            // 
            this.colDescripcion3.FieldName = "Descripcion";
            this.colDescripcion3.Name = "colDescripcion3";
            this.colDescripcion3.Visible = true;
            this.colDescripcion3.VisibleIndex = 0;
            // 
            // colRutaRecurso3
            // 
            this.colRutaRecurso3.FieldName = "RutaRecurso";
            this.colRutaRecurso3.Name = "colRutaRecurso3";
            this.colRutaRecurso3.Visible = true;
            this.colRutaRecurso3.VisibleIndex = 1;
            // 
            // colNivel2
            // 
            this.colNivel2.FieldName = "Nivel";
            this.colNivel2.Name = "colNivel2";
            this.colNivel2.Visible = true;
            this.colNivel2.VisibleIndex = 2;
            // 
            // cboFiltros
            // 
            this.cboFiltros.EditValue = "Buscar por Descripción";
            this.cboFiltros.Location = new System.Drawing.Point(12, 45);
            this.cboFiltros.MenuManager = this.BarraBotones;
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFiltros.Properties.Items.AddRange(new object[] {
            "Buscar por Descripción"});
            this.cboFiltros.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFiltros.Size = new System.Drawing.Size(225, 20);
            this.cboFiltros.TabIndex = 0;
            // 
            // frmLstRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 477);
            this.CriterioBusqueda = "Descripcion";
            this.InfoListDataGridView = this.gdvRecursos;
            this.Name = "frmLstRecursos";
            this.ObjetoLista = this.recursosInfoListBindingSource;
            this.Text = "Lista de Recursos";
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).EndInit();
            this.grpValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).EndInit();
            this.grpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRecursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltros.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboFiltros;
        private DevExpress.XtraGrid.GridControl recursosInfoListGridControl;
        private System.Windows.Forms.BindingSource recursosInfoListBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRecursos;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso1;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso2;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion3;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaRecurso3;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel2;
    }
}