namespace ErickOrlando.Seguridad.Windows.Aplicaciones
{
	partial class frmLstAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLstAplicacion));
            this.aplicacionInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplicacionInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvAplicaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcronimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCriterios = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).BeginInit();
            this.grpValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).BeginInit();
            this.grpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAplicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCriterios
            // 
            this.grpCriterios.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCriterios.AppearanceCaption.Options.UseFont = true;
            this.grpCriterios.Controls.Add(this.labelControl1);
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
            this.grpGrilla.Controls.Add(this.aplicacionInfoListGridControl);
            this.grpGrilla.Size = new System.Drawing.Size(773, 312);
            this.grpGrilla.Text = "Lista de Aplicaciones";
            // 
            // txtFiltro
            // 
            // 
            // aplicacionInfoListBindingSource
            // 
            this.aplicacionInfoListBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.AplicacionInfo);
            // 
            // aplicacionInfoListGridControl
            // 
            this.aplicacionInfoListGridControl.DataSource = this.aplicacionInfoListBindingSource;
            this.aplicacionInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aplicacionInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.aplicacionInfoListGridControl.MainView = this.gdvAplicaciones;
            this.aplicacionInfoListGridControl.MenuManager = this.BarraBotones;
            this.aplicacionInfoListGridControl.Name = "aplicacionInfoListGridControl";
            this.aplicacionInfoListGridControl.Size = new System.Drawing.Size(769, 284);
            this.aplicacionInfoListGridControl.TabIndex = 0;
            this.aplicacionInfoListGridControl.UseEmbeddedNavigator = true;
            this.aplicacionInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvAplicaciones});
            // 
            // gdvAplicaciones
            // 
            this.gdvAplicaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre,
            this.colAcronimo,
            this.colTipo,
            this.colRuta});
            this.gdvAplicaciones.GridControl = this.aplicacionInfoListGridControl;
            this.gdvAplicaciones.Name = "gdvAplicaciones";
            this.gdvAplicaciones.OptionsBehavior.Editable = false;
            this.gdvAplicaciones.OptionsDetail.EnableMasterViewMode = false;
            this.gdvAplicaciones.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvAplicaciones.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNombre, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colAcronimo
            // 
            this.colAcronimo.FieldName = "Acronimo";
            this.colAcronimo.Name = "colAcronimo";
            this.colAcronimo.Visible = true;
            this.colAcronimo.VisibleIndex = 1;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 2;
            // 
            // colRuta
            // 
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 3;
            // 
            // cboCriterios
            // 
            this.cboCriterios.EditValue = "Nombre";
            this.cboCriterios.Location = new System.Drawing.Point(112, 45);
            this.cboCriterios.MenuManager = this.BarraBotones;
            this.cboCriterios.Name = "cboCriterios";
            this.cboCriterios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCriterios.Properties.Items.AddRange(new object[] {
            "Nombre",
            "Acronimo",
            "Ruta",
            "Sin Filtros (Mostrar Todos)"});
            this.cboCriterios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCriterios.Size = new System.Drawing.Size(174, 20);
            this.cboCriterios.TabIndex = 0;
            this.cboCriterios.SelectedIndexChanged += new System.EventHandler(this.cboCriterios_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Filtrar por:";
            // 
            // frmLstAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.CriterioBusqueda = "Nombre";
            this.InfoListDataGridView = this.gdvAplicaciones;
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios3"))));
            this.MaximizeBox = true;
            this.Name = "frmLstAplicacion";
            this.ObjetoLista = this.aplicacionInfoListBindingSource;
            this.Text = "Lista de Aplicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            this.grpCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).EndInit();
            this.grpValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).EndInit();
            this.grpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAplicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl aplicacionInfoListGridControl;
		private System.Windows.Forms.BindingSource aplicacionInfoListBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gdvAplicaciones;
		private DevExpress.XtraGrid.Columns.GridColumn colNombre;
		private DevExpress.XtraGrid.Columns.GridColumn colAcronimo;
		private DevExpress.XtraGrid.Columns.GridColumn colTipo;
		private DevExpress.XtraGrid.Columns.GridColumn colRuta;
		private DevExpress.XtraEditors.ComboBoxEdit cboCriterios;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}