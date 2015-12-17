namespace ErickOrlando.Seguridad.Windows.Empresas
{
    partial class frmLstEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLstEmpresas));
            this.empresaInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCorto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCriterios = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).BeginInit();
            this.grpValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).BeginInit();
            this.grpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).BeginInit();
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
            this.grpGrilla.Controls.Add(this.empresaInfoListGridControl);
            this.grpGrilla.Size = new System.Drawing.Size(773, 312);
            this.grpGrilla.Text = "Lista de Empresas";
            // 
            // txtFiltro
            // 
            // 
            // empresaInfoListBindingSource
            // 
            this.empresaInfoListBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.EmpresaInfo);
            // 
            // empresaInfoListGridControl
            // 
            this.empresaInfoListGridControl.DataSource = this.empresaInfoListBindingSource;
            this.empresaInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empresaInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.empresaInfoListGridControl.MainView = this.gdvEmpresas;
            this.empresaInfoListGridControl.MenuManager = this.BarraBotones;
            this.empresaInfoListGridControl.Name = "empresaInfoListGridControl";
            this.empresaInfoListGridControl.Size = new System.Drawing.Size(769, 284);
            this.empresaInfoListGridControl.TabIndex = 0;
            this.empresaInfoListGridControl.UseEmbeddedNavigator = true;
            this.empresaInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvEmpresas});
            // 
            // gdvEmpresas
            // 
            this.gdvEmpresas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colNombreCorto,
            this.colRazonSocial,
            this.colRUC});
            this.gdvEmpresas.GridControl = this.empresaInfoListGridControl;
            this.gdvEmpresas.Name = "gdvEmpresas";
            this.gdvEmpresas.OptionsBehavior.Editable = false;
            this.gdvEmpresas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvEmpresas.OptionsView.ColumnAutoWidth = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 81;
            // 
            // colNombreCorto
            // 
            this.colNombreCorto.FieldName = "NombreCorto";
            this.colNombreCorto.Name = "colNombreCorto";
            this.colNombreCorto.Visible = true;
            this.colNombreCorto.VisibleIndex = 1;
            this.colNombreCorto.Width = 97;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 2;
            this.colRazonSocial.Width = 367;
            // 
            // colRUC
            // 
            this.colRUC.FieldName = "RUC";
            this.colRUC.Name = "colRUC";
            this.colRUC.Visible = true;
            this.colRUC.VisibleIndex = 3;
            this.colRUC.Width = 93;
            // 
            // cboCriterios
            // 
            this.cboCriterios.EditValue = "Codigo";
            this.cboCriterios.Location = new System.Drawing.Point(37, 45);
            this.cboCriterios.MenuManager = this.BarraBotones;
            this.cboCriterios.Name = "cboCriterios";
            this.cboCriterios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCriterios.Properties.Items.AddRange(new object[] {
            "Codigo",
            "Nombre Corto",
            "RazonSocial",
            "RUC",
            "Sin Filtros (Mostrar Todos)"});
            this.cboCriterios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCriterios.Size = new System.Drawing.Size(204, 20);
            this.cboCriterios.TabIndex = 0;
            this.cboCriterios.SelectedIndexChanged += new System.EventHandler(this.cboCriterios_SelectedIndexChanged);
            // 
            // frmLstEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.CriterioBusqueda = "Codigo";
            this.InfoListDataGridView = this.gdvEmpresas;
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios3"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios4"))));
            this.Name = "frmLstEmpresas";
            this.ObjetoLista = this.empresaInfoListBindingSource;
            this.Text = "Lista de Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).EndInit();
            this.grpValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).EndInit();
            this.grpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl empresaInfoListGridControl;
        private System.Windows.Forms.BindingSource empresaInfoListBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colRUC;
        private DevExpress.XtraEditors.ComboBoxEdit cboCriterios;
		private DevExpress.XtraGrid.Columns.GridColumn colNombreCorto;
    }
}