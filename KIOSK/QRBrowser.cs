using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KIOSK
{
    public partial class QRBrowser : Form
    {
        private int currentTime=15;
        public QRBrowser(String gelenQRUrl)
        {
            InitializeComponent();
            imgQR(gelenQRUrl);
            qrGeriLabel.Text = (currentTime.ToString() + " saniye sonra kapatılacak");
            kapatTimerBaslat();
            geriTimerBaslat();
        }

        private Bitmap QRbrowserQR(String url)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        private void imgQR(String QRurl)
        { 
            qrpicturebox.Image = QRbrowserQR(QRurl);
        }

        private void kapatTimerBaslat()
        {
            if (!qrKapatmaTimer.Enabled)
            {
                qrKapatmaTimer.Interval = 15000;
                qrKapatmaTimer.Start();
            }
        }

        private void geriTimerBaslat()
        {
            if (!qrGeriTimer.Enabled)
            {
                qrGeriTimer.Interval= 1000;
                qrGeriTimer.Start();
            }
        }

        private void qrKapatmaTimer_Tick(object sender, EventArgs e)
        {
            qrFormClose();
        }

        private void qrFormClose()
        {
            if (qrKapatmaTimer != null && qrKapatmaTimer.Enabled)
            {
                qrKapatmaTimer.Stop();
            }
            if (qrGeriTimer != null && qrGeriTimer.Enabled)
            {
                qrGeriTimer.Stop();
            }
            this.Close();
        }

        private void qrGeriTimer_Tick(object sender, EventArgs e)
        {
            currentTime -= 1 ;
            qrGeriLabel.Text = (currentTime.ToString() + " saniye sonra kapatılacak");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qrFormClose();
        }
    }
}
