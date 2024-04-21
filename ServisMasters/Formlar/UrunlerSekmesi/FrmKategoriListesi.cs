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
            var deger = from u in db.TBLKATEGORI
                        select new
                        {
                            u.ID,
                            u.AD
                        };
            gridControl1.DataSource = deger.ToList();
        }
        private void FrmKategoriListesi_Load(object sender, EventArgs e)
        {
            gridViewSecilenSutunlariYaz();
            gridView1.BestFitColumns();
        }


    }
}
