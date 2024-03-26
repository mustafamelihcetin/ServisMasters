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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {

            var deger = from u in db.TBLKATEGORI
                        select new
                        {
                            u.ID,
                            u.AD
                        };
            lookUpEditYeniUrunEkleKategori.Properties.DataSource = deger.ToList();
            
        }
        private void BtnUrunEkleVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUrunEkleKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN table = new TBLURUN();
            table.AD = TBYeniUrunEkleUrunAdi.Text;
            table.MARKA = TBYeniUrunEkleMarka.Text;
            table.ALISFIYAT = decimal.Parse(TBUrunEkleAlisFiyati.Text);
            table.SATIS = decimal.Parse(TBUrunEkleSatisFiyati.Text);
            table.STOK = short.Parse(TBYeniUrunEkleStok.Text);
            table.KATEGORI = byte.Parse(lookUpEditYeniUrunEkleKategori.EditValue.ToString());
            table.DURUM = false;
            db.TBLURUN.Add(table);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
