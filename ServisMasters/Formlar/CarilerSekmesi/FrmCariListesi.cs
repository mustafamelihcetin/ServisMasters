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

namespace ServisMasters.Formlar.CarilerSekmesi
{
    public partial class FrmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public void gridViewSecilenSutunlariYaz()
        {
            var deger = from u in db.TBLCARI
                        select new
                        {
                            u.ID,
                            u.AD,
                            u.SOYAD,
                            u.TELEFON,
                            u.MAIL,
                            u.IL,
                            u.ILCE,
                            u.BANKA,
                            u.VERGIDAIRESI,
                            u.VERGINO,
                            u.STATU,
                            u.ADRES
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void BtnUrunİslemleriKaydet_Click(object sender, EventArgs e)
        {

        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            gridViewSecilenSutunlariYaz();
            gridView1.BestFitColumns();
        }
    }
}