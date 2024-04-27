namespace ServisMasters.Formlar.UrunlerSekmesi
{
    partial class FrmQrKodOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrKodOlustur));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbQrKodOlusturSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnQrKodOlusturQrOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbQrKodOlusturSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(93, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(346, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SERİ NO İÇİN QR KOD OLUŞTURMA";
            // 
            // pictureBox1
            // 
            this.tablePanel1.SetColumn(this.pictureBox1, 1);
            this.pictureBox1.Location = new System.Drawing.Point(93, 130);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(170, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel1.SetRow(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TbQrKodOlusturSeriNo
            // 
            this.tablePanel1.SetColumn(this.TbQrKodOlusturSeriNo, 1);
            this.TbQrKodOlusturSeriNo.Location = new System.Drawing.Point(93, 32);
            this.TbQrKodOlusturSeriNo.Name = "TbQrKodOlusturSeriNo";
            this.TbQrKodOlusturSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbQrKodOlusturSeriNo.Properties.Appearance.Options.UseFont = true;
            this.tablePanel1.SetRow(this.TbQrKodOlusturSeriNo, 1);
            this.TbQrKodOlusturSeriNo.Size = new System.Drawing.Size(260, 30);
            this.TbQrKodOlusturSeriNo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 35);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(80, 23);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "SERİ NO:";
            // 
            // BtnQrKodOlusturQrOlustur
            // 
            this.BtnQrKodOlusturQrOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.BtnQrKodOlusturQrOlustur.Appearance.Options.UseFont = true;
            this.BtnQrKodOlusturQrOlustur.AutoSize = true;
            this.tablePanel1.SetColumn(this.BtnQrKodOlusturQrOlustur, 1);
            this.BtnQrKodOlusturQrOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQrKodOlusturQrOlustur.ImageOptions.Image")));
            this.BtnQrKodOlusturQrOlustur.Location = new System.Drawing.Point(93, 68);
            this.BtnQrKodOlusturQrOlustur.Name = "BtnQrKodOlusturQrOlustur";
            this.tablePanel1.SetRow(this.BtnQrKodOlusturQrOlustur, 2);
            this.BtnQrKodOlusturQrOlustur.Size = new System.Drawing.Size(154, 36);
            this.BtnQrKodOlusturQrOlustur.TabIndex = 4;
            this.BtnQrKodOlusturQrOlustur.Text = "QR OLUŞTUR";
            this.BtnQrKodOlusturQrOlustur.Click += new System.EventHandler(this.BtnQrKodOlusturQrOlustur_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 90F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F)});
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.pictureBox1);
            this.tablePanel1.Controls.Add(this.BtnQrKodOlusturQrOlustur);
            this.tablePanel1.Controls.Add(this.TbQrKodOlusturSeriNo);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 15F)});
            this.tablePanel1.Size = new System.Drawing.Size(504, 352);
            this.tablePanel1.TabIndex = 6;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // FrmQrKodOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(504, 352);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmQrKodOlustur.IconOptions.LargeImage")));
            this.Name = "FrmQrKodOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Kod";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbQrKodOlusturSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit TbQrKodOlusturSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnQrKodOlusturQrOlustur;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}