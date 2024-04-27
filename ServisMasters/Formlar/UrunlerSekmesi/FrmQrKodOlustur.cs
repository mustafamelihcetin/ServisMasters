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
using MessagingToolkit.QRCode.Codec;

namespace ServisMasters.Formlar.UrunlerSekmesi
{
    public partial class FrmQrKodOlustur : DevExpress.XtraEditors.XtraForm
    {
        public FrmQrKodOlustur()
        {
            InitializeComponent();
        }

        private void BtnQrKodOlusturQrOlustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureBox1.Image = encoder.Encode(TbQrKodOlusturSeriNo.Text);
        }
    }
}