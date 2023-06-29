using System;
using System.Windows.Forms;

namespace KIOSK
{
    public partial class DersProgrami : Form
    {
        
        public DersProgrami()
        {
            InitializeComponent();
            dersProgramiTimerStart();
        }


        //INTERNET KONTROLLERİ
        private bool gorunmeyenBaglantiKontrol()
        {
            /*try
            {
                using (var ping = new Ping())
                {
                    var result = ping.Send("www.google.com");
                    if (result != null && result.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            */
            return true;
        }

        private bool gorunenBaglantiKontrol()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool genelBaglantiKontrol()
        {
            if (gorunenBaglantiKontrol() == true && gorunmeyenBaglantiKontrol() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //HATA MESAJLARI

        private void noInternetError()
        {
            MessageLabel mesageLabel = new MessageLabel("Internet bağlantısı olmadığı için tarayıcı açılamıyor", 4000);
            mesageLabel.ShowDialog();
        }
        private void normalHatamsj()
        {
            MessageLabel mesageLabel = new MessageLabel("Bir hata ile karşılaşıldığı için tarayıcı açılamıyor", 4000);
            mesageLabel.ShowDialog();
        }

        private void computerScience_Click(object sender, EventArgs e)
        {
            if (gorunenBaglantiKontrol() == true)
            {
                Browser browser = new Browser("https://csc.deu.edu.tr/tr/2022-2023-guz-donemi-ders-programi/");
                browser.FormClosed += new FormClosedEventHandler(browser_FormClosed);
                browser.Show();
            }
            else
            {
                noInternetError();
            }
        }

        private void browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            dersProgramFormKapatma();
        }


        private void dersProgramFormKapatma()
        {
            if (dersprogramiTimer.Enabled)
            {
                dersprogramiTimer.Stop();
            }
            this.Close();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            dersProgramFormKapatma();
        }

        private void dersProgramiTimerStart()
        {
            if (!dersprogramiTimer.Enabled)
            {
                dersprogramiTimer.Interval = 120000;
                dersprogramiTimer.Start();
            }
        }
        private void dersprogramiTimer_Tick(object sender, EventArgs e)
        {
            dersprogramiTimer.Stop();
            dersProgramFormKapatma();
        }
    }
}
