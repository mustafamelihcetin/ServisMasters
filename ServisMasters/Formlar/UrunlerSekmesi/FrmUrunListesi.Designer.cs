﻿
namespace ServisMasters.Formlar
{
    partial class FrmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TBUrunİslemleriUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TBUrunIslemleriUrunId = new DevExpress.XtraEditors.TextEdit();
            this.BtnUrunİslemleriSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunİslemleriGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunİslemleriListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnUrunİslemleriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditTBUrunİslemleriKategori = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TBUrunİslemleriSatisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.TBUrunİslemleriStok = new DevExpress.XtraEditors.TextEdit();
            this.TBUrunİslemleriMarka = new DevExpress.XtraEditors.TextEdit();
            this.TBUrunİslemleriAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunIslemleriUrunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTBUrunİslemleriKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriSatisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 0);
            this.gridControl1.Size = new System.Drawing.Size(1035, 474);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(235)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 35);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(87, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ÜRÜN ADI: ";
            // 
            // TBUrunİslemleriUrunAdi
            // 
            this.tablePanel2.SetColumn(this.TBUrunİslemleriUrunAdi, 1);
            this.TBUrunİslemleriUrunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUrunİslemleriUrunAdi.Location = new System.Drawing.Point(123, 35);
            this.TBUrunİslemleriUrunAdi.Name = "TBUrunİslemleriUrunAdi";
            this.TBUrunİslemleriUrunAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBUrunİslemleriUrunAdi.Properties.Appearance.Options.UseFont = true;
            this.tablePanel2.SetRow(this.TBUrunİslemleriUrunAdi, 1);
            this.TBUrunİslemleriUrunAdi.Size = new System.Drawing.Size(214, 26);
            this.TBUrunİslemleriUrunAdi.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.tablePanel1.SetColumn(this.groupControl1, 1);
            this.groupControl1.Controls.Add(this.tablePanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(1044, 3);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 0);
            this.groupControl1.Size = new System.Drawing.Size(344, 474);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // tablePanel2
            // 
            this.tablePanel2.AutoSize = true;
            this.tablePanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 120F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F)});
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Controls.Add(this.labelControl7);
            this.tablePanel2.Controls.Add(this.TBUrunIslemleriUrunId);
            this.tablePanel2.Controls.Add(this.BtnUrunİslemleriSil);
            this.tablePanel2.Controls.Add(this.BtnUrunİslemleriGuncelle);
            this.tablePanel2.Controls.Add(this.BtnUrunİslemleriListele);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.labelControl4);
            this.tablePanel2.Controls.Add(this.BtnUrunİslemleriKaydet);
            this.tablePanel2.Controls.Add(this.labelControl5);
            this.tablePanel2.Controls.Add(this.lookUpEditTBUrunİslemleriKategori);
            this.tablePanel2.Controls.Add(this.labelControl6);
            this.tablePanel2.Controls.Add(this.TBUrunİslemleriSatisFiyati);
            this.tablePanel2.Controls.Add(this.TBUrunİslemleriStok);
            this.tablePanel2.Controls.Add(this.TBUrunİslemleriUrunAdi);
            this.tablePanel2.Controls.Add(this.TBUrunİslemleriMarka);
            this.tablePanel2.Controls.Add(this.TBUrunİslemleriAlisFiyati);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(2, 33);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(340, 439);
            this.tablePanel2.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(3, 3);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel2.SetRow(this.labelControl7, 0);
            this.labelControl7.Size = new System.Drawing.Size(76, 19);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "ÜRÜN ID: ";
            // 
            // TBUrunIslemleriUrunId
            // 
            this.tablePanel2.SetColumn(this.TBUrunIslemleriUrunId, 1);
            this.TBUrunIslemleriUrunId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUrunIslemleriUrunId.Enabled = false;
            this.TBUrunIslemleriUrunId.Location = new System.Drawing.Point(123, 3);
            this.TBUrunIslemleriUrunId.Name = "TBUrunIslemleriUrunId";
            this.TBUrunIslemleriUrunId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBUrunIslemleriUrunId.Properties.Appearance.Options.UseFont = true;
            this.tablePanel2.SetRow(this.TBUrunIslemleriUrunId, 0);
            this.TBUrunIslemleriUrunId.Size = new System.Drawing.Size(214, 26);
            this.TBUrunIslemleriUrunId.TabIndex = 18;
            // 
            // BtnUrunİslemleriSil
            // 
            this.BtnUrunİslemleriSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnUrunİslemleriSil.Appearance.Options.UseFont = true;
            this.BtnUrunİslemleriSil.AutoSize = true;
            this.tablePanel2.SetColumn(this.BtnUrunİslemleriSil, 1);
            this.BtnUrunİslemleriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrunİslemleriSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUrunİslemleriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunİslemleriSil.ImageOptions.Image")));
            this.BtnUrunİslemleriSil.Location = new System.Drawing.Point(125, 275);
            this.BtnUrunİslemleriSil.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUrunİslemleriSil.Name = "BtnUrunİslemleriSil";
            this.tablePanel2.SetRow(this.BtnUrunİslemleriSil, 8);
            this.BtnUrunİslemleriSil.Size = new System.Drawing.Size(210, 36);
            this.BtnUrunİslemleriSil.TabIndex = 14;
            this.BtnUrunİslemleriSil.Text = "SİL";
            this.BtnUrunİslemleriSil.Click += new System.EventHandler(this.BtnUrunİslemleriSil_Click);
            // 
            // BtnUrunİslemleriGuncelle
            // 
            this.BtnUrunİslemleriGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnUrunİslemleriGuncelle.Appearance.Options.UseFont = true;
            this.BtnUrunİslemleriGuncelle.AutoSize = true;
            this.tablePanel2.SetColumn(this.BtnUrunİslemleriGuncelle, 1);
            this.BtnUrunİslemleriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrunİslemleriGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUrunİslemleriGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunİslemleriGuncelle.ImageOptions.Image")));
            this.BtnUrunİslemleriGuncelle.Location = new System.Drawing.Point(125, 321);
            this.BtnUrunİslemleriGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUrunİslemleriGuncelle.Name = "BtnUrunİslemleriGuncelle";
            this.tablePanel2.SetRow(this.BtnUrunİslemleriGuncelle, 9);
            this.BtnUrunİslemleriGuncelle.Size = new System.Drawing.Size(210, 36);
            this.BtnUrunİslemleriGuncelle.TabIndex = 15;
            this.BtnUrunİslemleriGuncelle.Text = "GÜNCELLE";
            this.BtnUrunİslemleriGuncelle.Click += new System.EventHandler(this.BtnUrunİslemleriGuncelle_Click);
            // 
            // BtnUrunİslemleriListele
            // 
            this.BtnUrunİslemleriListele.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnUrunİslemleriListele.Appearance.Options.UseFont = true;
            this.BtnUrunİslemleriListele.AutoSize = true;
            this.tablePanel2.SetColumn(this.BtnUrunİslemleriListele, 1);
            this.BtnUrunİslemleriListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrunİslemleriListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUrunİslemleriListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunİslemleriListele.ImageOptions.Image")));
            this.BtnUrunİslemleriListele.Location = new System.Drawing.Point(125, 367);
            this.BtnUrunİslemleriListele.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUrunİslemleriListele.Name = "BtnUrunİslemleriListele";
            this.tablePanel2.SetRow(this.BtnUrunİslemleriListele, 10);
            this.BtnUrunİslemleriListele.Size = new System.Drawing.Size(210, 36);
            this.BtnUrunİslemleriListele.TabIndex = 16;
            this.BtnUrunİslemleriListele.Text = "LİSTELE";
            this.BtnUrunİslemleriListele.Click += new System.EventHandler(this.BtnUrunİslemleriListele_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 67);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 2);
            this.labelControl2.Size = new System.Drawing.Size(64, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "MARKA: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(3, 99);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel2.SetRow(this.labelControl3, 3);
            this.labelControl3.Size = new System.Drawing.Size(96, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ALIŞ FİYATI:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(3, 131);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel2.SetRow(this.labelControl4, 4);
            this.labelControl4.Size = new System.Drawing.Size(112, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "SATIŞ FİYATI: ";
            // 
            // BtnUrunİslemleriKaydet
            // 
            this.BtnUrunİslemleriKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnUrunİslemleriKaydet.Appearance.Options.UseFont = true;
            this.BtnUrunİslemleriKaydet.AutoSize = true;
            this.tablePanel2.SetColumn(this.BtnUrunİslemleriKaydet, 1);
            this.BtnUrunİslemleriKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrunİslemleriKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUrunİslemleriKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunİslemleriKaydet.ImageOptions.Image")));
            this.BtnUrunİslemleriKaydet.Location = new System.Drawing.Point(125, 229);
            this.BtnUrunİslemleriKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.BtnUrunİslemleriKaydet.Name = "BtnUrunİslemleriKaydet";
            this.tablePanel2.SetRow(this.BtnUrunİslemleriKaydet, 7);
            this.BtnUrunİslemleriKaydet.Size = new System.Drawing.Size(210, 36);
            this.BtnUrunİslemleriKaydet.TabIndex = 13;
            this.BtnUrunİslemleriKaydet.Text = "KAYDET";
            this.BtnUrunİslemleriKaydet.Click += new System.EventHandler(this.BtnUrunİslemleriKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl5, 0);
            this.labelControl5.Location = new System.Drawing.Point(3, 163);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel2.SetRow(this.labelControl5, 5);
            this.labelControl5.Size = new System.Drawing.Size(51, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "STOK: ";
            // 
            // lookUpEditTBUrunİslemleriKategori
            // 
            this.tablePanel2.SetColumn(this.lookUpEditTBUrunİslemleriKategori, 1);
            this.lookUpEditTBUrunİslemleriKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEditTBUrunİslemleriKategori.Location = new System.Drawing.Point(123, 195);
            this.lookUpEditTBUrunİslemleriKategori.Name = "lookUpEditTBUrunİslemleriKategori";
            this.lookUpEditTBUrunİslemleriKategori.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lookUpEditTBUrunİslemleriKategori.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditTBUrunİslemleriKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTBUrunİslemleriKategori.Properties.DisplayMember = "AD";
            this.lookUpEditTBUrunİslemleriKategori.Properties.ValueMember = "ID";
            this.tablePanel2.SetRow(this.lookUpEditTBUrunİslemleriKategori, 6);
            this.lookUpEditTBUrunİslemleriKategori.Size = new System.Drawing.Size(214, 26);
            this.lookUpEditTBUrunİslemleriKategori.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(3, 195);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel2.SetRow(this.labelControl6, 6);
            this.labelControl6.Size = new System.Drawing.Size(89, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "KATEGORİ: ";
            // 
            // TBUrunİslemleriSatisFiyati
            // 
            this.tablePanel2.SetColumn(this.TBUrunİslemleriSatisFiyati, 1);
            this.TBUrunİslemleriSatisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUrunİslemleriSatisFiyati.Location = new System.Drawing.Point(123, 131);
            this.TBUrunİslemleriSatisFiyati.Name = "TBUrunİslemleriSatisFiyati";
            this.TBUrunİslemleriSatisFiyati.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBUrunİslemleriSatisFiyati.Properties.Appearance.Options.UseFont = true;
            this.tablePanel2.SetRow(this.TBUrunİslemleriSatisFiyati, 4);
            this.TBUrunİslemleriSatisFiyati.Size = new System.Drawing.Size(214, 26);
            this.TBUrunİslemleriSatisFiyati.TabIndex = 8;
            // 
            // TBUrunİslemleriStok
            // 
            this.tablePanel2.SetColumn(this.TBUrunİslemleriStok, 1);
            this.TBUrunİslemleriStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUrunİslemleriStok.Location = new System.Drawing.Point(123, 163);
            this.TBUrunİslemleriStok.Name = "TBUrunİslemleriStok";
            this.TBUrunİslemleriStok.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBUrunİslemleriStok.Properties.Appearance.Options.UseFont = true;
            this.tablePanel2.SetRow(this.TBUrunİslemleriStok, 5);
            this.TBUrunİslemleriStok.Size = new System.Drawing.Size(214, 26);
            this.TBUrunİslemleriStok.TabIndex = 10;
            // 
            // TBUrunİslemleriMarka
            // 
            this.tablePanel2.SetColumn(this.TBUrunİslemleriMarka, 1);
            this.TBUrunİslemleriMarka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUrunİslemleriMarka.Location = new System.Drawing.Point(123, 67);
            this.TBUrunİslemleriMarka.Name = "TBUrunİslemleriMarka";
            this.TBUrunİslemleriMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBUrunİslemleriMarka.Properties.Appearance.Options.UseFont = true;
            this.tablePanel2.SetRow(this.TBUrunİslemleriMarka, 2);
            this.TBUrunİslemleriMarka.Size = new System.Drawing.Size(214, 26);
            this.TBUrunİslemleriMarka.TabIndex = 4;
            // 
            // TBUrunİslemleriAlisFiyati
            // 
            this.tablePanel2.SetColumn(this.TBUrunİslemleriAlisFiyati, 1);
            this.TBUrunİslemleriAlisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBUrunİslemleriAlisFiyati.Location = new System.Drawing.Point(123, 99);
            this.TBUrunİslemleriAlisFiyati.Name = "TBUrunİslemleriAlisFiyati";
            this.TBUrunİslemleriAlisFiyati.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBUrunİslemleriAlisFiyati.Properties.Appearance.Options.UseFont = true;
            this.tablePanel2.SetRow(this.TBUrunİslemleriAlisFiyati, 3);
            this.TBUrunİslemleriAlisFiyati.Size = new System.Drawing.Size(214, 26);
            this.TBUrunİslemleriAlisFiyati.TabIndex = 6;
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.92F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 350F)});
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1391, 480);
            this.tablePanel1.TabIndex = 4;
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1391, 480);
            this.Controls.Add(this.tablePanel1);
            this.Name = "FrmUrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunIslemleriUrunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTBUrunİslemleriKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriSatisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBUrunİslemleriAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TBUrunİslemleriUrunAdi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TBUrunİslemleriStok;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TBUrunİslemleriSatisFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TBUrunİslemleriAlisFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TBUrunİslemleriMarka;
        private DevExpress.XtraEditors.SimpleButton BtnUrunİslemleriKaydet;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTBUrunİslemleriKategori;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton BtnUrunİslemleriGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnUrunİslemleriSil;
        private DevExpress.XtraEditors.SimpleButton BtnUrunİslemleriListele;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TBUrunIslemleriUrunId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}