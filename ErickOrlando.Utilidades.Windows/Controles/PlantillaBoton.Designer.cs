using DevExpress.XtraEditors;
using ErickOrlando.Utilidades.Windows.Properties;

namespace ErickOrlando.Utilidades.Windows.Controles
{
    partial class PlantillaBoton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SimpleButton Boton;


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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Boton = new SimpleButton();
            base.SuspendLayout();
            this.Boton.Image = Resources.buscar_prompt;
            this.Boton.Location = new System.Drawing.Point(0, 0);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(0x19, 0x17);
            this.Boton.TabIndex = 0;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.Controls.Add(this.Boton);
            base.Name = "PlantillaBoton";
            base.Size = new System.Drawing.Size(0x19, 0x17);
            base.ResumeLayout(false);

        }

        #endregion
    }
}
