using System;
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
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
        }
        private void FormuGoruntuleVeOdakla(Form formInstance)
        {
            if (!IsFormOpen(formInstance.GetType()))
            {
                formInstance.MdiParent = this;
                formInstance.Show();
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == formInstance.GetType())
                    {
                        form.Focus();
                        break;
                    }
                }
            }
        }
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunListesi fr = new Formlar.FrmUrunListesi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnKategoriListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriListesi fr = new Formlar.FrmKategoriListesi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsFormOpen(typeof(Formlar.FrmYeniUrun)))
            {
                Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
                fr.Show();
            }
            else
            {
                // Form zaten açıksa, ona odaklan
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Formlar.FrmYeniUrun)
                    {
                        form.Focus();
                        break;
                    }
                }
            }
        }

        private void BtnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmArizaliUrunListesi fr = new Formlar.UrunlerSekmesi.FrmArizaliUrunListesi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnUrunIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmUrunIstatistikleri fr = new Formlar.UrunlerSekmesi.FrmUrunIstatistikleri();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmYeniKategori fr = new Formlar.UrunlerSekmesi.FrmYeniKategori();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnUrunAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmUrunAra fr = new Formlar.UrunlerSekmesi.FrmUrunAra();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnMarkaIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmMarkaIstatistikleri fr = new Formlar.UrunlerSekmesi.FrmMarkaIstatistikleri();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmYeniArizaliUrunKaydi fr = new Formlar.UrunlerSekmesi.FrmYeniArizaliUrunKaydi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnArizaliUrunAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmArizaliUrunAciklama fr = new Formlar.UrunlerSekmesi.FrmArizaliUrunAciklama();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnQrKodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmQrKodOlustur fr = new Formlar.UrunlerSekmesi.FrmQrKodOlustur();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnBarkodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunlerSekmesi.FrmBarkodOlustur fr = new Formlar.UrunlerSekmesi.FrmBarkodOlustur();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.CarilerSekmesi.FrmYeniCari fr = new Formlar.CarilerSekmesi.FrmYeniCari();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.CarilerSekmesi.FrmCariListesi fr = new Formlar.CarilerSekmesi.FrmCariListesi();
            FormuGoruntuleVeOdakla(fr);

        }

        private void BtnCariIstatistigi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.CarilerSekmesi.FrmCariIstatistigi fr = new Formlar.CarilerSekmesi.FrmCariIstatistigi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnCariHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturalarSekmesi.FrmCariHareketleri fr = new Formlar.FaturalarSekmesi.FrmCariHareketleri();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnPersonelHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturalarSekmesi.FrmPersonelHareketleri fr = new Formlar.FaturalarSekmesi.FrmPersonelHareketleri();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniFaturaGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturalarSekmesi.FrmYeniFaturaGirisi fr = new Formlar.FaturalarSekmesi.FrmYeniFaturaGirisi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnFaturayaKalemGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturalarSekmesi.FrmFaturayaKalemGirisi fr = new Formlar.FaturalarSekmesi.FrmFaturayaKalemGirisi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnDetayliFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturalarSekmesi.FrmDetayliFaturaSorgulama fr = new Formlar.FaturalarSekmesi.FrmDetayliFaturaSorgulama();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnFaturaPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturalarSekmesi.FrmFaturaPdf fr = new Formlar.FaturalarSekmesi.FrmFaturaPdf();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnPasifFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FaturalarSekmesi.FrmPasifFatura fr = new Formlar.FaturalarSekmesi.FrmPasifFatura();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelSekmesi.FrmPersonelListesi fr = new Formlar.PersonelSekmesi.FrmPersonelListesi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelSekmesi.FrmYeniDepartman fr = new Formlar.PersonelSekmesi.FrmYeniDepartman();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelSekmesi.FrmDepartmanListesi fr = new Formlar.PersonelSekmesi.FrmDepartmanListesi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelSekmesi.FrmYeniDepartman fr = new Formlar.PersonelSekmesi.FrmYeniDepartman();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmHesapMakinesi fr = new Formlar.AraçlarSekmesi.FrmHesapMakinesi();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmYeniNot fr = new Formlar.AraçlarSekmesi.FrmYeniNot();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnDovizKurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmDovizKurlari fr = new Formlar.AraçlarSekmesi.FrmDovizKurlari();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnHaberler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmHaberler fr = new Formlar.AraçlarSekmesi.FrmHaberler();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnDovizIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmDovizKurlari fr = new Formlar.AraçlarSekmesi.FrmDovizKurlari();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmWord fr = new Formlar.AraçlarSekmesi.FrmWord();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmExcel fr = new Formlar.AraçlarSekmesi.FrmExcel();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYardim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AraçlarSekmesi.FrmYardim fr = new Formlar.AraçlarSekmesi.FrmYardim();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnKartlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.İstatistiklerSekmesi.FrmKartlar fr = new Formlar.İstatistiklerSekmesi.FrmKartlar();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.İletisimSekmesi.FrmRehber fr = new Formlar.İletisimSekmesi.FrmRehber();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnMailKutusu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.İletisimSekmesi.FrmMailKutusu fr = new Formlar.İletisimSekmesi.FrmMailKutusu();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnYeniMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.İletisimSekmesi.FrmYeniMail fr = new Formlar.İletisimSekmesi.FrmYeniMail();
            FormuGoruntuleVeOdakla(fr);
        }

        private void BtnSmsGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.İletisimSekmesi.FrmSmsGonder fr = new Formlar.İletisimSekmesi.FrmSmsGonder();
            FormuGoruntuleVeOdakla(fr);
        }
    }
}