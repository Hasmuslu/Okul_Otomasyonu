namespace Okul_Otomasyon
{
    partial class nufuscuzdani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nufuscuzdani));
            this.lbltc = new DevExpress.XtraEditors.LabelControl();
            this.lblsoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblad = new DevExpress.XtraEditors.LabelControl();
            this.lbldt = new DevExpress.XtraEditors.LabelControl();
            this.lblcinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltc
            // 
            this.lbltc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Appearance.Options.UseFont = true;
            this.lbltc.Location = new System.Drawing.Point(12, 143);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(85, 16);
            this.lbltc.TabIndex = 0;
            this.lbltc.Text = "labelControl1";
            // 
            // lblsoyad
            // 
            this.lblsoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Appearance.Options.UseFont = true;
            this.lblsoyad.Location = new System.Drawing.Point(264, 143);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(85, 16);
            this.lblsoyad.TabIndex = 0;
            this.lblsoyad.Text = "labelControl1";
            // 
            // lblad
            // 
            this.lblad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Appearance.Options.UseFont = true;
            this.lblad.Location = new System.Drawing.Point(264, 216);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(85, 16);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "labelControl1";
            // 
            // lbldt
            // 
            this.lbldt.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldt.Appearance.Options.UseFont = true;
            this.lbldt.Location = new System.Drawing.Point(273, 285);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(85, 16);
            this.lbldt.TabIndex = 0;
            this.lbldt.Text = "labelControl1";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Appearance.Options.UseFont = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(463, 285);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(85, 16);
            this.lblcinsiyet.TabIndex = 0;
            this.lblcinsiyet.Text = "labelControl1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(53, 205);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(164, 191);
            this.pictureEdit1.TabIndex = 1;
            // 
            // nufuscuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(747, 428);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lbldt);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lbltc);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "nufuscuzdani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nufuscuzdani";
            this.Load += new System.EventHandler(this.nufuscuzdani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbltc;
        private DevExpress.XtraEditors.LabelControl lblsoyad;
        private DevExpress.XtraEditors.LabelControl lblad;
        private DevExpress.XtraEditors.LabelControl lbldt;
        private DevExpress.XtraEditors.LabelControl lblcinsiyet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}