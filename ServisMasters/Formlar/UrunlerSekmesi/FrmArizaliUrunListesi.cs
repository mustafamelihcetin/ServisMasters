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
    public partial class FrmArizaliUrunListesi : DevExpress.XtraEditors.XtraForm
    {
        public FrmArizaliUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();


        public void gridViewSecilenSutunlariYaz()
        {
            var deger = from u in db.TBLARIZADETAY
                        select new
                        {
                            u.ARIZAID,
                            u.ISLEM,
                            u.SORUN,
                            u.ACIKLAMA,                            
                            u.ONFIYAT,
                            u.NETFIYAT,
                            u.ISLEMLER
                            
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void FrmArizaliUrunListesi_Load(object sender, EventArgs e)
        {
            gridViewSecilenSutunlariYaz();
            gridView1.BestFitColumns();
            lookUpEditTBUrunİslemleriKategori.Properties.DataSource = db.TBLARIZADETAY.ToList();

        }
    }
}