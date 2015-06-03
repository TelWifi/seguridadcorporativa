namespace Gromero.Seguridad.Negocio.SoloLectura.Reportes
{
	partial class PermisosPorApp
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

		#region Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermisosPorApp));
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.PermisoBindingSource = new System.Windows.Forms.BindingSource();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrRichText7 = new DevExpress.XtraReports.UI.XRRichText();
			this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
			this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
			this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
			this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
			this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PermisoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox1,
            this.xrLabel5,
            this.xrLabel4});
			this.Detail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Detail.HeightF = 23F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.StylePriority.UseFont = false;
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrCheckBox1
			// 
			this.xrCheckBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "Conceder")});
			this.xrCheckBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(292.2916F, 0F);
			this.xrCheckBox1.Name = "xrCheckBox1";
			this.xrCheckBox1.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrCheckBox1.StylePriority.UseFont = false;
			// 
			// xrLabel5
			// 
			this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Opcion")});
			this.xrLabel5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(171.4584F, 0F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.Text = "xrLabel5";
			// 
			// xrLabel4
			// 
			this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ObjetoAutorizacion")});
			this.xrLabel4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.999943F, 0F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(154.7916F, 23F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.Text = "xrLabel4";
			// 
			// TopMargin
			// 
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1});
			this.TopMargin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.StylePriority.UseFont = false;
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrRichText1
			// 
			this.xrRichText1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrRichText1.ForeColor = System.Drawing.Color.CadetBlue;
			this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(20.41667F, 29.12501F);
			this.xrRichText1.Name = "xrRichText1";
			this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
			this.xrRichText1.SizeF = new System.Drawing.SizeF(594.1667F, 40.04165F);
			this.xrRichText1.StylePriority.UseFont = false;
			this.xrRichText1.StylePriority.UseForeColor = false;
			// 
			// BottomMargin
			// 
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
			this.BottomMargin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BottomMargin.HeightF = 47.91667F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.StylePriority.UseFont = false;
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrPageInfo1
			// 
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(466.6667F, 10.00001F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
			// 
			// PermisoBindingSource
			// 
			this.PermisoBindingSource.DataSource = typeof(Gromero.Seguridad.Datos.ReportePermiso);
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel3,
            this.xrRichText7,
            this.xrRichText6,
            this.xrRichText5,
            this.xrRichText4,
            this.xrRichText3,
            this.xrRichText2,
            this.xrLabel2,
            this.xrLabel1});
			this.GroupHeader1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Aplicacion", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("Perfil", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("NombresCompletos", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = 130.2083F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.RepeatEveryPage = true;
			this.GroupHeader1.StylePriority.UseFont = false;
			// 
			// xrLine1
			// 
			this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(4.166667F, 123.9583F);
			this.xrLine1.Name = "xrLine1";
			this.xrLine1.SizeF = new System.Drawing.SizeF(576.0416F, 2F);
			// 
			// xrLabel3
			// 
			this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NombresCompletos")});
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(250F, 43.41669F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(327.0833F, 23F);
			this.xrLabel3.Text = "xrLabel3";
			// 
			// xrRichText7
			// 
			this.xrRichText7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrRichText7.LocationFloat = new DevExpress.Utils.PointFloat(292.2916F, 90.12495F);
			this.xrRichText7.Name = "xrRichText7";
			this.xrRichText7.SerializableRtfString = resources.GetString("xrRichText7.SerializableRtfString");
			this.xrRichText7.SizeF = new System.Drawing.SizeF(100F, 29.04167F);
			this.xrRichText7.StylePriority.UseFont = false;
			// 
			// xrRichText6
			// 
			this.xrRichText6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(171.4584F, 90.12495F);
			this.xrRichText6.Name = "xrRichText6";
			this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
			this.xrRichText6.SizeF = new System.Drawing.SizeF(100F, 29.04168F);
			this.xrRichText6.StylePriority.UseFont = false;
			// 
			// xrRichText5
			// 
			this.xrRichText5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 90.12495F);
			this.xrRichText5.Name = "xrRichText5";
			this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
			this.xrRichText5.SizeF = new System.Drawing.SizeF(154.7916F, 29.04169F);
			this.xrRichText5.StylePriority.UseFont = false;
			// 
			// xrRichText4
			// 
			this.xrRichText4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 43.41669F);
			this.xrRichText4.Name = "xrRichText4";
			this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
			this.xrRichText4.SizeF = new System.Drawing.SizeF(208.3333F, 21.33334F);
			this.xrRichText4.StylePriority.UseFont = false;
			// 
			// xrRichText3
			// 
			this.xrRichText3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(250F, 10.00001F);
			this.xrRichText3.Name = "xrRichText3";
			this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
			this.xrRichText3.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrRichText3.StylePriority.UseFont = false;
			// 
			// xrRichText2
			// 
			this.xrRichText2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
			this.xrRichText2.Name = "xrRichText2";
			this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
			this.xrRichText2.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrRichText2.StylePriority.UseFont = false;
			// 
			// xrLabel2
			// 
			this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Perfil")});
			this.xrLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(369.7917F, 10.00001F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.Text = "xrLabel2";
			// 
			// xrLabel1
			// 
			this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Aplicacion")});
			this.xrLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(118.3333F, 10.00001F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.Text = "xrLabel1";
			// 
			// PermisosPorApp
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
			this.DataSource = this.PermisoBindingSource;
			this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 48);
			this.Scripts.OnDataSourceDemanded = "PermisosPorApp_DataSourceDemanded";
			this.ScriptsSource = "\r\n";
			this.Version = "12.1";
			((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PermisoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel5;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRRichText xrRichText1;
		private DevExpress.XtraReports.UI.XRRichText xrRichText3;
		private DevExpress.XtraReports.UI.XRRichText xrRichText2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRRichText xrRichText7;
		private DevExpress.XtraReports.UI.XRRichText xrRichText6;
		private DevExpress.XtraReports.UI.XRRichText xrRichText5;
		private DevExpress.XtraReports.UI.XRRichText xrRichText4;
		private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
		public System.Windows.Forms.BindingSource PermisoBindingSource;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLine xrLine1;
	}
}
