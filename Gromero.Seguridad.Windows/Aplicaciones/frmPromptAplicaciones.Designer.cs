namespace Gromero.Seguridad.Windows.Aplicaciones
{
	partial class frmPromptAplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromptAplicaciones));
            this.aplicacionInfoListBindingSource = new System.Windows.Forms.BindingSource();
            this.aplicacionInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvAplicaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcronimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpResultados)).BeginInit();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAplicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResultados
            // 
            this.grpResultados.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultados.AppearanceCaption.Options.UseFont = true;
            this.grpResultados.Controls.Add(this.aplicacionInfoListGridControl);
            this.grpResultados.Size = new System.Drawing.Size(546, 239);
            // 
            // grpCriterios
            // 
            this.grpCriterios.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCriterios.AppearanceCaption.Options.UseFont = true;
            this.grpCriterios.Size = new System.Drawing.Size(546, 112);
            // 
            // txtFiltro
            // 
            // 
            // cboFiltro
            // 
            this.cboFiltro.EditValue = "Nombre";
            this.cboFiltro.Properties.Items.AddRange(new object[] {
            "Nombre",
            "Acronimo",
            "Ruta",
            "(Sin Filtros) Mostrar Todos"});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(546, 363);
            // 
            // aplicacionInfoListBindingSource
            // 
            this.aplicacionInfoListBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.SoloLectura.AplicacionInfo);
            // 
            // aplicacionInfoListGridControl
            // 
            this.aplicacionInfoListGridControl.DataSource = this.aplicacionInfoListBindingSource;
            this.aplicacionInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aplicacionInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.aplicacionInfoListGridControl.MainView = this.gdvAplicaciones;
            this.aplicacionInfoListGridControl.Name = "aplicacionInfoListGridControl";
            this.aplicacionInfoListGridControl.Size = new System.Drawing.Size(542, 211);
            this.aplicacionInfoListGridControl.TabIndex = 0;
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
            this.gdvAplicaciones.OptionsView.ColumnAutoWidth = false;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 158;
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
            // frmPromptAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 418);
            this.CriterioBusqueda = "Nombre";
            this.InfoListDataGridView = this.gdvAplicaciones;
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios3"))));
            this.Name = "frmPromptAplicaciones";
            this.ObjetoLista = this.aplicacionInfoListBindingSource;
            this.Text = "Búsqueda de Aplicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.grpResultados)).EndInit();
            this.grpResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            this.grpCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAplicaciones)).EndInit();
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
	}
}