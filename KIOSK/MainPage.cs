using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Drawing.Text;

namespace KIOSK
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();
        }
        //HAVA DURUMU VE TARIH AYARLARI
        private void tarih_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            Saat.Text = DateTime.Now.ToLongTimeString();
            
        }
        private void Weather_Tick(object sender, EventArgs e)
        {
            havadurumu();
        }
        private void WeatherStart() 
        {
            if (!Weather.Enabled)
            {
                //Weather.Interval = 900000;
                Weather.Interval = 300000;
                Weather.Start();
            }

        }

        private void TarihStart()
        {
            if (!tarih.Enabled)
            {
                tarih.Interval = 100;
                tarih.Start();
            }
        }

        private void StopTimers()
        {
            if(Weather != null && Weather.Enabled)
            {
                Weather.Stop();
            }
            if(tarih != null && tarih.Enabled)
            {
                tarih.Stop();
            }
        }
        private void havadurumu()
        {
            if (genelBaglantiKontrol()==true)
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    WebClient client = new WebClient();
                    client.Encoding = Encoding.UTF8;
                    string htmlcode = "";
                    if (genelBaglantiKontrol()==true)
                    {
                        htmlcode = client.DownloadString("https://api.openweathermap.org/data/2.5/weather?q=izmir&appid=3600e5cbb8b1f512691e17245443d8ae");
                    }
                    dynamic stuff = JObject.Parse(htmlcode);
                    dynamic temperature = stuff.main.temp;
                    int temperatureInt = (temperature - 273);
                    sicaklik.Text = temperatureInt.ToString() + "°C";
                    string picture = stuff.weather[0].icon;            
                    havaresim.Load($"http://openweathermap.org/img/w/{picture}.png");
                   
                    
                }

                catch (Exception ex)
                {

                }
            }
                                                         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            TarihStart();
            WeatherStart();
            havadurumu();

        }

        //ANA BUTONLAR
        private void tarayiciButton_Click(object sender, EventArgs e)
        {
            startButtonsTimer();
            if (gorunenBaglantiKontrol()==true)
            {
                StopTimers();
                Browser browser = new Browser("https://fen.deu.edu.tr/tr/");
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
            startButtonsTimer();
            TarihStart();
            WeatherStart();          
        }

        private void yemekMenu_Click(object sender, EventArgs e)
        {
            startButtonsTimer();
            if (gorunenBaglantiKontrol()==true)
            {
                StopTimers();
                Browser browser = new Browser("https://sks.deu.edu.tr/yemek-menusu/");
                browser.FormClosed += new FormClosedEventHandler(browser_FormClosed);
                browser.Show();
            }
            else
            {
                noInternetError();
            }
        }
        private void duyurular_Click(object sender, EventArgs e)
        {
            startButtonsTimer();
            if (gorunenBaglantiKontrol() == true)
            {
                StopTimers();
                Browser browser = new Browser("https://fen.deu.edu.tr/duyurular/");
                browser.FormClosed += new FormClosedEventHandler(browser_FormClosed);
                browser.Show();                                           
            }
            else
            {
                noInternetError();
            }

        }
        private void engelsizDeuButton_Click(object sender, EventArgs e)
        {
            startButtonsTimer();
            if (gorunenBaglantiKontrol() == true)
            {
                StopTimers();
                Browser browser = new Browser("https://www.deu.edu.tr/engelsiz/");
                browser.FormClosed += new FormClosedEventHandler(browser_FormClosed);
                browser.Show();
            }
            else
            {
                noInternetError();
            }
        }
        private void anketlerButton_Click(object sender, EventArgs e)
        {
            startButtonsTimer();
            StopTimers();
            DersProgrami dersprogrami = new DersProgrami();
            dersprogrami.FormClosed += new FormClosedEventHandler(dersprogrami_FormClosed);
            dersprogrami.Show();
        }

        private void dersprogrami_FormClosed(object sender, FormClosedEventArgs e)
        {
            startButtonsTimer();
            TarihStart();
            WeatherStart();
       
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

        //INTERNET KONTROLLERI
        private bool gorunmeyenBaglantiKontrol()
        {
            try
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
        }

        private bool gorunenBaglantiKontrol()
        {
            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()==true)
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
            if(gorunenBaglantiKontrol()==true && gorunmeyenBaglantiKontrol()==true)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }


        //BUTON DİSABLE ENABLE İŞLEMLERİ

        private void mainPageButtonEnable()
        {
            derslikButton.Enabled = true;
            tarayiciButton.Enabled = true;
            anketlerButton.Enabled = true;
            istekButton.Enabled = true;
            yemekMenu.Enabled = true;
            duyurular.Enabled = true;
            engelsizDeuButton.Enabled = true;
        }

        private void mainPageButtonDisable()
        {
            derslikButton.Enabled = false;
            tarayiciButton.Enabled = false;
            anketlerButton.Enabled = false;
            istekButton.Enabled = false;
            yemekMenu.Enabled = false;
            duyurular.Enabled = false;
            engelsizDeuButton.Enabled = false;
        }

        private void startButtonsTimer()
        {
            if (!buttonsTimer.Enabled)
            {
                mainPageButtonDisable();
                buttonsTimer.Interval = 3000;
                buttonsTimer.Start();
            }
        }

        private void buttonsTimer_Tick(object sender, EventArgs e)
        {
            mainPageButtonEnable();
            buttonsTimer.Stop();
        }

        
    }
}
