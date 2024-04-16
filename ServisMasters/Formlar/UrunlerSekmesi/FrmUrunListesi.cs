using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisMasters.Formlar
{
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public void gridViewSecilenSutunlariYaz()
        {
            var deger = from u in db.TBLURUN
                        select new
                        {
                            u.ID,
                            u.AD,
                            u.MARKA,
                            u.ALISFIYAT,
                            u.SATIS,
                            u.STOK
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            gridViewSecilenSutunlariYaz();
            //var degerler = db.TBLURUN.ToList();
            //gridControl1.DataSource = degerler;
            lookUpEditTBUrunİslemleriKategori.Properties.DataSource = db.TBLKATEGORI.ToList();
        }
        public void GridGuncelle()
        {
            var degerler = db.TBLURUN.ToList();
            gridControl1.DataSource = degerler;
        }
        private void BtnUrunİslemleriKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN table = new TBLURUN();
            table.AD = TBUrunİslemleriUrunAdi.Text;
            table.MARKA = TBUrunİslemleriMarka.Text;
            table.ALISFIYAT = decimal.Parse(TBUrunİslemleriAlisFiyati.Text);
            table.SATIS = decimal.Parse(TBUrunİslemleriSatisFiyati.Text);
            table.STOK = short.Parse(TBUrunİslemleriStok.Text);
            table.KATEGORI = byte.Parse(lookUpEditTBUrunİslemleriKategori.EditValue.ToString());
            table.DURUM = false;
            db.TBLURUN.Add(table);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridGuncelle();
        }

        private void BtnUrunİslemleriListele_Click(object sender, EventArgs e)
        {
            gridViewSecilenSutunlariYaz();
            GridGuncelle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0) // Seçili bir satır varsa
            {
                int id = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
                var deger = db.TBLURUN.Find(id);
                if (deger != null)
                {
                    TBUrunIslemleriUrunId.Text = deger.ID.ToString();
                    TBUrunİslemleriUrunAdi.Text = deger.AD;
                    TBUrunİslemleriMarka.Text = deger.MARKA;
                    TBUrunİslemleriAlisFiyati.Text = deger.ALISFIYAT.ToString();
                    TBUrunİslemleriSatisFiyati.Text = deger.SATIS.ToString();
                    TBUrunİslemleriStok.Text = deger.STOK.ToString();
                    lookUpEditTBUrunİslemleriKategori.EditValue = deger.KATEGORI;
                }
            }
        }

        private void BtnUrunİslemleriSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TBUrunIslemleriUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridGuncelle();
        }

        private void BtnUrunİslemleriGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TBUrunIslemleriUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TBUrunİslemleriUrunAdi.Text;
            deger.MARKA = TBUrunİslemleriMarka.Text;
            deger.ALISFIYAT = decimal.Parse(TBUrunİslemleriAlisFiyati.Text);
            deger.SATIS = decimal.Parse(TBUrunİslemleriSatisFiyati.Text);
            deger.STOK = short.Parse(TBUrunİslemleriStok.Text);
            deger.KATEGORI = byte.Parse(lookUpEditTBUrunİslemleriKategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridGuncelle();
        }


    }
}
