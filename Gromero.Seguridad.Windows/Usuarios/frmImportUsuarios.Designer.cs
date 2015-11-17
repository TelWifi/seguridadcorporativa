namespace Gromero.Seguridad.Windows.Usuarios
{
    partial class frmImportUsuarios
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
            this.usuariosGridControl = new DevExpress.XtraGrid.GridControl();
            this.usuarioListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDominio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliasAlterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.importarReporteButton = new System.Windows.Forms.Button();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.seleccionarButton = new System.Windows.Forms.Button();
            this.generarReporteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosGridControl
            // 
            this.usuariosGridControl.DataSource = this.usuarioListBindingSource;
            this.usuariosGridControl.Location = new System.Drawing.Point(13, 88);
            this.usuariosGridControl.MainView = this.gridView1;
            this.usuariosGridControl.Name = "usuariosGridControl";
            this.usuariosGridControl.Size = new System.Drawing.Size(957, 373);
            this.usuariosGridControl.TabIndex = 8;
            this.usuariosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // usuarioListBindingSource
            // 
            this.usuarioListBindingSource.DataSource = typeof(Gromero.Seguridad.Negocio.Editables.Usuario);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colTipo,
            this.colDominio,
            this.colCodigo,
            this.colNombres,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colCorreo,
            this.colAlias,
            this.colDNI,
            this.colAliasAlterno});
            this.gridView1.GridControl = this.usuariosGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Valido";
            this.colEstado.FieldName = "Estado";
            this.colEstado.MaxWidth = 15;
            this.colEstado.MinWidth = 40;
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 0;
            this.colEstado.Width = 40;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.MaxWidth = 20;
            this.colTipo.MinWidth = 30;
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 30;
            // 
            // colDominio
            // 
            this.colDominio.FieldName = "Dominio";
            this.colDominio.Name = "colDominio";
            this.colDominio.Visible = true;
            this.colDominio.VisibleIndex = 3;
            this.colDominio.Width = 73;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 2;
            this.colCodigo.Width = 73;
            // 
            // colNombres
            // 
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 4;
            this.colNombres.Width = 73;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.FieldName = "ApellidoPaterno";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.Visible = true;
            this.colApellidoPaterno.VisibleIndex = 5;
            this.colApellidoPaterno.Width = 73;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.FieldName = "ApellidoMaterno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.Visible = true;
            this.colApellidoMaterno.VisibleIndex = 6;
            this.colApellidoMaterno.Width = 73;
            // 
            // colCorreo
            // 
            this.colCorreo.FieldName = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 7;
            this.colCorreo.Width = 73;
            // 
            // colAlias
            // 
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 9;
            this.colAlias.Width = 73;
            // 
            // colDNI
            // 
            this.colDNI.FieldName = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.Visible = true;
            this.colDNI.VisibleIndex = 8;
            this.colDNI.Width = 73;
            // 
            // colAliasAlterno
            // 
            this.colAliasAlterno.Caption = "Mensaje";
            this.colAliasAlterno.FieldName = "AliasAlterno";
            this.colAliasAlterno.MinWidth = 100;
            this.colAliasAlterno.Name = "colAliasAlterno";
            this.colAliasAlterno.Visible = true;
            this.colAliasAlterno.VisibleIndex = 10;
            this.colAliasAlterno.Width = 100;
            // 
            // importarReporteButton
            // 
            this.importarReporteButton.Location = new System.Drawing.Point(13, 59);
            this.importarReporteButton.Name = "importarReporteButton";
            this.importarReporteButton.Size = new System.Drawing.Size(125, 23);
            this.importarReporteButton.TabIndex = 7;
            this.importarReporteButton.Text = "Procesar";
            this.importarReporteButton.UseVisualStyleBackColor = true;
            this.importarReporteButton.Click += new System.EventHandler(this.importarReporteButton_Click);
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(144, 35);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(19, 13);
            this.direccionLabel.TabIndex = 6;
            this.direccionLabel.Text = "...";
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Location = new System.Drawing.Point(13, 30);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(125, 23);
            this.seleccionarButton.TabIndex = 5;
            this.seleccionarButton.Text = "Seleccione archivo";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            this.seleccionarButton.Click += new System.EventHandler(this.seleccionarButton_Click);
            // 
            // generarReporteButton
            // 
            this.generarReporteButton.Location = new System.Drawing.Point(147, 59);
            this.generarReporteButton.Name = "generarReporteButton";
            this.generarReporteButton.Size = new System.Drawing.Size(120, 23);
            this.generarReporteButton.TabIndex = 9;
            this.generarReporteButton.Text = "Exportar csv";
            this.generarReporteButton.UseVisualStyleBackColor = true;
            this.generarReporteButton.Click += new System.EventHandler(this.generarReporteButton_Click);
            // 
            // frmImportUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 456);
            this.Controls.Add(this.usuariosGridControl);
            this.Controls.Add(this.importarReporteButton);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.seleccionarButton);
            this.Controls.Add(this.generarReporteButton);
            this.Name = "frmImportUsuarios";
            this.Text = "Importación de usuarios";
            this.Load += new System.EventHandler(this.frmImportUsuarios_Load);
            this.Controls.SetChildIndex(this.generarReporteButton, 0);
            this.Controls.SetChildIndex(this.seleccionarButton, 0);
            this.Controls.SetChildIndex(this.direccionLabel, 0);
            this.Controls.SetChildIndex(this.importarReporteButton, 0);
            this.Controls.SetChildIndex(this.usuariosGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl usuariosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button importarReporteButton;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Button seleccionarButton;
        private System.Windows.Forms.Button generarReporteButton;
        private System.Windows.Forms.BindingSource usuarioListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDominio;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colDNI;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colAliasAlterno;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}