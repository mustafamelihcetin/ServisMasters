using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisMasters.Formlar.UrunlerSekmesi
{
    public partial class FrmUrunIstatistikleri : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunIstatistikleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmUrunIstatistikleri_Load(object sender, EventArgs e)
        {
            toplamUrunSayisiYazdir();
            toplamKategoriSayisiYazdir();
            kritikSeviyeYazdir();
        }
        public void toplamUrunSayisiYazdir()
        {
            var toplamUrun = db.TBLURUN.Sum(u => u.STOK);
            LblUrunIstatistikleriToplamUrunSayisi.Text = toplamUrun.ToString();
        }
        public void kritikSeviyeYazdir()
        {
            var kritikSeviye = db.TBLURUN.Min(u => u.STOK);
            var kritikUrun = db.TBLURUN
                            .Where(u => u.STOK == db.TBLURUN.Min(m => m.STOK)) // Minimum stok değerine sahip ürünü seç
                            .OrderBy(u => u.AD) // Ürün adına göre sırala
                            .FirstOrDefault(); // İlk ürünü al (eğer minimum stokta birden fazla ürün varsa)

            if (kritikUrun != null)
            {
                LblUrunIstatistikleriKritikSeviye.Text = kritikUrun.AD + " (" + kritikSeviye.ToString() + ")";
            }
            else
            {
                LblUrunIstatistikleriKritikSeviye.Text = "Kritik seviyede ürün bulunamadı.";
            }
        }
        public void toplamKategoriSayisiYazdir()
        {
            var toplamKategori = db.TBLKATEGORI.Count();
            LblUrunIstatistikleriToplamKategoriSayisi.Text=toplamKategori.ToString();
        }
    }
}