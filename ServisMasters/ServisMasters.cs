﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisMasters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Formlar.FrmUrunListesi fr = new Formlar.FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnKategoriListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriListesi fr = new Formlar.FrmKategoriListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            fr.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmArizaliUrunListesi fr = new Formlar.UrunlerSekmesi.FrmArizaliUrunListesi();
            fr.Show();
        }
    }
}
