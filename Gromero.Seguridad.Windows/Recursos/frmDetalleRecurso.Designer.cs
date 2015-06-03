namespace Gromero.Seguridad.Windows.RecursosSeguridad
{
    partial class frmDetalleRecurso
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
            System.Windows.Forms.Label descripcionLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gdvDetalles2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recursoDetalleGridControl = new DevExpress.XtraGrid.GridControl();
            this.detallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codigoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descripcionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnEdit = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.btnAdd = new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoDetalleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(12, 39);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(44, 13);
            codigoLabel.TabIndex = 5;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 65);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(65, 13);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // gdvDetalles2
            // 
            this.gdvDetalles2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo1,
            this.colDescripcion1,
            this.colNivel1});
            this.gdvDetalles2.GridControl = this.recursoDetalleGridControl;
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
            // colDescripcion1
            // 
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            // 
            // colNivel1
            // 
            this.colNivel1.FieldName = "Nivel";
            this.colNivel1.Name = "colNivel1";
            this.colNivel1.Visible = true;
            this.colNivel1.VisibleIndex = 2;
            // 
            // recursoDetalleGridControl
            // 
            this.recursoDetalleGridControl.DataSource = this.detallesBindingSource;
            gridLevelNode1.LevelTemplate = this.gdvDetalles2;
            gridLevelNode1.RelationName = "Detalles";
            this.recursoDetalleGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.recursoDetalleGridControl.Location = new System.Drawing.Point(15, 95);
            this.recursoDetalleGridControl.MainView = this.gdvDetalles;
            this.recursoDetalleGridControl.MenuManager = this.BarraBotones;
            this.recursoDetalleGridControl.Name = "recursoDetalleGridControl";
            this.recursoDetalleGridControl.ShowOnlyPredefinedDetails = true;
            this.recursoDetalleGridControl.Size = new System.Drawing.Size(407, 254);
            this.recursoDetalleGridControl.TabIndex = 8;
            this.recursoDetalleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDetalles,
            this.gdvDetalles2});
            // 
            // detallesBindingSource
            // 
            this.detallesBindingSource.DataMember = "Detalles";
            this.detallesBindingSource.DataSource = this.recursoDetalleBindingSource;
            // 
            // recursoDetalleBindingSource
            // 
            this.recursoDetalleBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.Editables.RecursoDetalle);
            // 
            // gdvDetalles
            // 
            this.gdvDetalles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colNivel});
            this.gdvDetalles.GridControl = this.recursoDetalleGridControl;
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
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.OptionsColumn.AllowEdit = false;
            this.colNivel.Visible = true;
            this.colNivel.VisibleIndex = 2;
            // 
            // codigoTextEdit
            // 
            this.codigoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.recursoDetalleBindingSource, "Codigo", true));
            this.codigoTextEdit.Location = new System.Drawing.Point(83, 36);
            this.codigoTextEdit.MenuManager = this.BarraBotones;
            this.codigoTextEdit.Name = "codigoTextEdit";
            this.codigoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codigoTextEdit.TabIndex = 6;
            // 
            // descripcionTextEdit
            // 
            this.descripcionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.recursoDetalleBindingSource, "Descripcion", true));
            this.descripcionTextEdit.Location = new System.Drawing.Point(83, 62);
            this.descripcionTextEdit.MenuManager = this.BarraBotones;
            this.descripcionTextEdit.Name = "descripcionTextEdit";
            this.descripcionTextEdit.Size = new System.Drawing.Size(226, 20);
            this.descripcionTextEdit.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.CajaTexto = null;
            this.btnDelete.CajaTextoConBoton = null;
            this.btnDelete.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Eliminar;
            this.btnDelete.Location = new System.Drawing.Point(428, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 24);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CajaTexto = null;
            this.btnEdit.CajaTextoConBoton = null;
            this.btnEdit.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Modificar;
            this.btnEdit.Location = new System.Drawing.Point(428, 198);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 24);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CajaTexto = null;
            this.btnAdd.CajaTextoConBoton = null;
            this.btnAdd.Imagen = ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.TipoBoton.Agregar;
            this.btnAdd.Location = new System.Drawing.Point(428, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Click += new ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton.BotonClick(this.btnAdd_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.detallesBindingSource;
            // 
            // frmDetalleRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 383);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.recursoDetalleGridControl);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextEdit);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextEdit);
            this.Name = "frmDetalleRecurso";
            this.Text = "Detalle del Recurso";
            this.Controls.SetChildIndex(this.codigoTextEdit, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextEdit, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.recursoDetalleGridControl, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BarraBotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoDetalleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursoDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource recursoDetalleBindingSource;
        private DevExpress.XtraEditors.TextEdit codigoTextEdit;
        private DevExpress.XtraEditors.TextEdit descripcionTextEdit;
        private System.Windows.Forms.BindingSource detallesBindingSource;
        private DevExpress.XtraGrid.GridControl recursoDetalleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetalles2;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel1;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnDelete;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnEdit;
        private ErickOrlando.Utilidades.Windows.Controles.PlantillaBoton btnAdd;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}