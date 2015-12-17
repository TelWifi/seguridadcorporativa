namespace ErickOrlando.Seguridad.Windows.Usuarios
{
    partial class frmLstUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLstUsuarios));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.cboCriterios = new DevExpress.XtraEditors.ComboBoxEdit();
            this.usuarioInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioInfoListGridControl = new DevExpress.XtraGrid.GridControl();
            this.gdvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDominio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaLabora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaPertenencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).BeginInit();
            this.grpValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).BeginInit();
            this.grpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(773, 31);
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
            this.grpGrilla.Controls.Add(this.usuarioInfoListGridControl);
            this.grpGrilla.Size = new System.Drawing.Size(773, 312);
            this.grpGrilla.Text = "Lista de Usuarios";
            // 
            // txtFiltro
            // 
            // 
            // cboCriterios
            // 
            this.cboCriterios.EditValue = "Codigo de Usuario";
            this.cboCriterios.Location = new System.Drawing.Point(47, 46);
            this.cboCriterios.MenuManager = this.BarraBotones;
            this.cboCriterios.Name = "cboCriterios";
            this.cboCriterios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCriterios.Properties.Items.AddRange(new object[] {
            "Codigo de Usuario",
            "Nombres",
            "Apellido Paterno",
            "Apellido Materno",
            "DNI",
            "Correo Electrónico",
            "Sin Filtros (Mostrar Todos)"});
            this.cboCriterios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCriterios.Size = new System.Drawing.Size(204, 20);
            this.cboCriterios.TabIndex = 1;
            this.cboCriterios.SelectedIndexChanged += new System.EventHandler(this.cboCriterios_SelectedIndexChanged);
            // 
            // usuarioInfoListBindingSource
            // 
            this.usuarioInfoListBindingSource.DataSource = typeof(ErickOrlando.Seguridad.Negocio.SoloLectura.UsuarioInfo);
            // 
            // usuarioInfoListGridControl
            // 
            this.usuarioInfoListGridControl.DataSource = this.usuarioInfoListBindingSource;
            this.usuarioInfoListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarioInfoListGridControl.Location = new System.Drawing.Point(2, 26);
            this.usuarioInfoListGridControl.MainView = this.gdvUsuarios;
            this.usuarioInfoListGridControl.MenuManager = this.BarraBotones;
            this.usuarioInfoListGridControl.Name = "usuarioInfoListGridControl";
            this.usuarioInfoListGridControl.Size = new System.Drawing.Size(769, 284);
            this.usuarioInfoListGridControl.TabIndex = 0;
            this.usuarioInfoListGridControl.UseEmbeddedNavigator = true;
            this.usuarioInfoListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsuarios});
            // 
            // gdvUsuarios
            // 
            this.gdvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colAlias,
            this.colDominio,
            this.colNombres,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colCorreo,
            this.colDNI,
            this.colEstado,
            this.colTipo,
            this.colEmpresaLabora,
            this.colEmpresaPertenencia,
            this.colCargo});
            this.gdvUsuarios.GridControl = this.usuarioInfoListGridControl;
            this.gdvUsuarios.Name = "gdvUsuarios";
            this.gdvUsuarios.OptionsBehavior.Editable = false;
            this.gdvUsuarios.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvUsuarios.OptionsView.ColumnAutoWidth = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 70;
            // 
            // colDominio
            // 
            this.colDominio.FieldName = "Dominio";
            this.colDominio.Name = "colDominio";
            this.colDominio.Visible = true;
            this.colDominio.VisibleIndex = 12;
            this.colDominio.Width = 65;
            // 
            // colNombres
            // 
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 2;
            this.colNombres.Width = 69;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.FieldName = "ApellidoPaterno";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.Visible = true;
            this.colApellidoPaterno.VisibleIndex = 3;
            this.colApellidoPaterno.Width = 112;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.FieldName = "ApellidoMaterno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.Visible = true;
            this.colApellidoMaterno.VisibleIndex = 4;
            this.colApellidoMaterno.Width = 115;
            // 
            // colCorreo
            // 
            this.colCorreo.FieldName = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 5;
            this.colCorreo.Width = 57;
            // 
            // colDNI
            // 
            this.colDNI.FieldName = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.Visible = true;
            this.colDNI.VisibleIndex = 6;
            this.colDNI.Width = 39;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 57;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 8;
            this.colTipo.Width = 43;
            // 
            // colEmpresaLabora
            // 
            this.colEmpresaLabora.Caption = "Empresa donde labora";
            this.colEmpresaLabora.FieldName = "EmpresaLabora";
            this.colEmpresaLabora.Name = "colEmpresaLabora";
            this.colEmpresaLabora.Visible = true;
            this.colEmpresaLabora.VisibleIndex = 9;
            this.colEmpresaLabora.Width = 145;
            // 
            // colEmpresaPertenencia
            // 
            this.colEmpresaPertenencia.FieldName = "EmpresaPertenencia";
            this.colEmpresaPertenencia.Name = "colEmpresaPertenencia";
            this.colEmpresaPertenencia.Visible = true;
            this.colEmpresaPertenencia.VisibleIndex = 10;
            this.colEmpresaPertenencia.Width = 139;
            // 
            // colCargo
            // 
            this.colCargo.FieldName = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 11;
            this.colCargo.Width = 52;
            // 
            // colAlias
            // 
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 1;
            // 
            // frmLstUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.CriterioBusqueda = "Codigo";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.InfoListDataGridView = this.gdvUsuarios;
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios1"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios2"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios3"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios4"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios5"))));
            this.ListaCriterios.Add(((ErickOrlando.Utilidades.Windows.Criterios)(resources.GetObject("$this.ListaCriterios6"))));
            this.MaximizeBox = true;
            this.Name = "frmLstUsuarios";
            this.ObjetoLista = this.usuarioInfoListBindingSource;
            this.Text = "Lista de Usuarios";
            //this.Controls.SetChildIndex(this.barDockControlTop, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCriterios)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpValores)).EndInit();
            this.grpValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrilla)).EndInit();
            this.grpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCriterios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInfoListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboCriterios;
        private DevExpress.XtraGrid.GridControl usuarioInfoListGridControl;
        private System.Windows.Forms.BindingSource usuarioInfoListBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colDNI;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
		private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
		private DevExpress.XtraGrid.Columns.GridColumn colDominio;
		private DevExpress.XtraGrid.Columns.GridColumn colEmpresaLabora;
		private DevExpress.XtraGrid.Columns.GridColumn colEmpresaPertenencia;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
    }
}