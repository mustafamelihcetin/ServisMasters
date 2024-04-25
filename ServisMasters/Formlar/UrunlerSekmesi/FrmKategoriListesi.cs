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
    public partial class FrmKategoriListesi : Form
    {
        public FrmKategoriListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public void gridViewSecilenSutunlariYaz()
        {
            var deger = from k in db.TBLKATEGORI
                        select new
                        {
                            k.ID,
                            k.AD
                        };
            gridControl1.DataSource = deger.ToList();
        }
        public void GridGuncelle()
        {
            var degerler = db.TBLKATEGORI.ToList();
            gridControl1.DataSource = degerler;
        }
        private void FrmKategoriListesi_Load(object sender, EventArgs e)
        {
            gridViewSecilenSutunlariYaz();
            gridView1.BestFitColumns();
        }

        private void BtnKategoriİslemleriKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TBKategoriIslemleriKategoriAdi.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKategoriİslemleriListele_Click(object sender, EventArgs e)
        {
            gridViewSecilenSutunlariYaz();
            GridGuncelle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0) // Seçili bir satır varsa
            {
                int id = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));

                var deger = db.TBLKATEGORI.Find(id);
                if (deger != null)
                {
                    TBKategoriIslemleriKategoriId.Text = deger.ID.ToString();
                    TBKategoriIslemleriKategoriAdi.Text = deger.AD;
                    BtnKategoriIslemleriTemizle.Visible = true;
                    BtnKategoriİslemleriGuncelle.Enabled = true;
                }
                else
                    BtnKategoriİslemleriGuncelle.Enabled = false;
            }
        }

        private void BtnKategoriIslemleriTemizle_Click(object sender, EventArgs e)
        {
            TBKategoriIslemleriKategoriId.Text = null;
            TBKategoriIslemleriKategoriAdi.Text = null;
            BtnKategoriIslemleriTemizle.Visible = false;
            BtnKategoriİslemleriKaydet.Enabled = false;
            BtnKategoriİslemleriGuncelle.Enabled = false;
        }

        private void TBKategoriIslemleriKategoriAdi_EditValueChanged(object sender, EventArgs e)
        {
            var ad = TBKategoriIslemleriKategoriAdi.Text.Trim(); // Trim to remove leading/trailing spaces
            var deger = db.TBLKATEGORI.FirstOrDefault(k => k.AD == ad); // Assuming KategoriAdi is the column name in your database
            if (deger != null)
            {
                BtnKategoriİslemleriKaydet.Enabled = false;
                BtnKategoriİslemleriGuncelle.Enabled = true;
            }
            else
            {
                BtnKategoriİslemleriKaydet.Enabled = true;
                BtnKategoriİslemleriGuncelle.Enabled = false;
            }

        }

        private void BtnKategoriİslemleriSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TBKategoriIslemleriKategoriId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridGuncelle();
            BtnKategoriİslemleriKaydet.Enabled = false;
        }
    }
}