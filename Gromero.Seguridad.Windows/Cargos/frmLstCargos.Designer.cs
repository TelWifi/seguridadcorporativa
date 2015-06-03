namespace Gromero.Seguridad.Windows.Cargos
{
    partial class frmLstCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLstCargos));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.cargoInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvCargos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboFiltros = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).BeginInit();
            this.grpValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).BeginInit();
            this.grpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCargos)).BeginInit();
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
            this.grpGrilla.Controls.Add(this.cargoInfoListGridControl);
            this.grpGrilla.Size = new System.Drawing.Size(773, 312);
            this.grpGrilla.Text = "Lista de Cargos";
            // 
            // txtFiltro
            // 
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(773, 31);
            // 
            // cargoInfoListBindingSource
            // 
            this.cargoInfoListBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.SoloLectura.CargoInfo);
            // 
            // cargoInfoListGridControl
            // 
            this.cargoInfoListGridControl.DataSource = this.cargoInfoListBindingSource;
            this.cargoInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cargoInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.cargoInfoListGridControl.MainView = this.gdvCargos;
            this.cargoInfoListGridControl.MenuManager = this.BarraBotones;
            this.cargoInfoListGridControl.Name = "cargoInfoListGridControl";
            this.cargoInfoListGridControl.Size = new System.Drawing.Size(769, 284);
            this.cargoInfoListGridControl.TabIndex = 0;
            this.cargoInfoListGridControl.UseEmbeddedNavigator = true;
            this.cargoInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvCargos});
            // 
            // gdvCargos
            // 
            this.gdvCargos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colEstado});
            this.gdvCargos.GridControl = this.cargoInfoListGridControl;
            this.gdvCargos.Name = "gdvCargos";
            this.gdvCargos.OptionsBehavior.Editable = false;
            this.gdvCargos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvCargos.OptionsView.ColumnAutoWidth = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            // 
            // cboFiltros
            // 
            this.cboFiltros.EditValue = "(Todos)";
            this.cboFiltros.Location = new System.Drawing.Point(12, 45);
            this.cboFiltros.MenuManager = this.BarraBotones;
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFiltros.Properties.Items.AddRange(new object[] {
            "(Todos)",
            "Filtrar por Código",
            "Filtrar por Descripción"});
            this.cboFiltros.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFiltros.Size = new System.Drawing.Size(227, 20);
            this.cboFiltros.TabIndex = 0;
            // 
            // frmLstCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.InfoListDataGridView = this.gdvCargos;
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
            this.Name = "frmLstCargos";
            this.ObjetoLista = this.cargoInfoListBindingSource;
            this.Text = "Lista de Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).EndInit();
            this.grpValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).EndInit();
            this.grpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltros.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraGrid.GridControl cargoInfoListGridControl;
        private System.Windows.Forms.BindingSource cargoInfoListBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvCargos;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.ComboBoxEdit cboFiltros;
    }
}