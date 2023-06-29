using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WebBrowser = System.Windows.Forms.WebBrowser;

namespace KIOSK
{
    public partial class Browser : Form
    {
        private string currentUrl;

        private int yPosition = 0;

        private int girismesajCount = 0;

        private int currentPosition = 0;

        private int scrollableHeight = 0;

        private int zoomCount = 0;

        private int hataCount = 0;
        
        //private int xPosition = 0;

        private string currentQRurl= "https://fen.deu.edu.tr/";

        private readonly List<string> allowedUrls = new List<string>
        {
            "https://fen.deu.edu.tr/",
            "http://fen.deu.edu.tr/",
            "https://csc.deu.edu.tr/",
            "http://csc.deu.edu.tr/",
            "https://www.deu.edu.tr/engelsiz/",
            "http://www.deu.edu.tr/engelsiz",
            "https://engelsiz.deu.edu.tr/",
            "http://engelsiz.deu.edu.tr/",
            "https://biyoloji.deu.edu.tr/",
            "http://biyoloji.deu.edu.tr/",
            "https://fizik.deu.edu.tr/",
            "http://fizik.deu.edu.tr/",
            "https://istatistik.deu.edu.tr/",
            "http://istatistik.deu.edu.tr/",
            "https://kimya.deu.edu.tr/",
            "http://kimya.deu.edu.tr/",
            "https://math.deu.edu.tr/",
            "http://math.deu.edu.tr/",
            "https://debis.deu.edu.tr/akademiktr/",
            "http://debis.deu.edu.tr/akademiktr/",
            "https://sks.deu.edu.tr/yemek-menusu/",
            "http://sks.deu.edu.tr/yemek-menusu/",
            "about:blank",
            "http://maps.google.com/",
            "res://ieframe.dll/forbidframing.htm#http://maps.google.com/",
            "https://yandex.com.tr/map-widget/",
            "https://www.youtube.com/embed/",
            "https://www.google.com/maps/",
            "https://www.deu.edu.tr/",
            "http://www.deu.edu.tr/",
            "res://ieframe.dll/"

        };

        private readonly List<string> blockeds = new List<string>
        {
            ".pdf",
            ".exe",
            ".rar",
            ".png",
            ".zip",
            ".jpeg",
            ".jpg",
            ".pot",
            ".ppt",
            ".pptx",
            ".pptm",
            ".doc",
            ".docm",
            ".docx",
            ".dot",
            ".dotx",
            ".gif",
            ".potm",
            ".potx",
            ".ppam",
            ".pps",
            ".ppsm",
            ".ppsx",
            ".xlsx"
            //"https://fen.deu.edu.tr/tr/belge-ve-formlar/",
            //"https://csc.deu.edu.tr/tr/laboratuvar-konum/"            

        };

        public Browser(String gelenUrl)
        {
            InitializeComponent();
            startTimer();
            startBrowserTimer();
            browserImageQR("https://fen.deu.edu.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;

            if (gorunenBaglantiKontrol()==true)
            {
                try
                {
                    webBrowser1.Navigate(gelenUrl);
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
            }
            else
            {
                nonInternetError();
            }
                
            webBrowser1.Navigating += WebBrowser1_Navigating;
            webBrowser1.NewWindow += WebBrowser1_NewWindow;
            //girisMesaj();
        }




        //BROWSER DEFAULT FONKSİYONLARI

        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
            if (gorunenBaglantiKontrol()==true)
            {
                try
                {
                    startTimer();
                    timerReset();
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                    if ((WebSite_kontrol(e.Url.ToString()) == false) || (uzantiKontrol(e.Url.ToString()) == true))
                    {
                        e.Cancel = true;
                        qrariAyarla(e.Url.ToString());
                        if (girismesajCount != 1)
                        {
                            girisMesaj();
                            girismesajCount = 1;
                        }
                        if (e.Url.ToString() == currentUrl) { webBrowser1.GoBack(); }
                    }
                    pozisyonSifirlama();
                    zoomSifirlama();
                }
                catch (Exception ex)
                {
                    if(ex is WebException)
                    {
                        e.Cancel=true;
                        nonInternetError();
                    }
                    else
                    {
                        e.Cancel = true;
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                e.Cancel=true;
                nonInternetError();
            }              
        }

        private void WebBrowser1_NewWindow(object sender, CancelEventArgs e)
        {

            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    WebBrowser newBrowser = (WebBrowser)sender;
                    e.Cancel = true;
                    if (WebSite_kontrol(newBrowser.StatusText.ToString()) == true)
                    {
                        webBrowser1.Navigate(newBrowser.StatusText);
                    }
                    else
                    {
                        qrariAyarla(newBrowser.StatusText.ToString());
                        if (girismesajCount != 1)
                        {
                            girisMesaj();
                            girismesajCount = 1;
                        }
                    }
                }
                catch(Exception ex)
                {
                    if (ex is WebException)
                    {
                        e.Cancel= true;
                        nonInternetError();
                    }
                    else
                    {
                        e.Cancel = true;
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                e.Cancel=true;
                nonInternetError();
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    currentUrl = e.Url.ToString();
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("iframe"))
                    {
                        string src = element.GetAttribute("src");
                        if (src.Contains("www.youtube.com/embed") || src.Contains("https://www.google.com/maps/embed"))
                        {
                            element.SetAttribute("src", "about:blank");
                        }
                    }

                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }
        }

        //UZANTI VE WEBSITE KONTROLLERİ
        private bool uzantiKontrol(string url)
        {
            foreach (string blocked in blockeds)
            {
                if (url.EndsWith(blocked))
                {
                    return true;
                }
            }
            return false;
        }

        private bool WebSite_kontrol(string url)
        {
            foreach (string allowedUrl in allowedUrls)
            {
                if (url.StartsWith(allowedUrl))
                {
                    return true;
                }
            }
            return false;
        }

        //INTERNET KONTROL İŞLEMLERİ

        private bool browsergorunmeyenBaglantiKontrol()
        {
            /*
            try
            {
                using (var ping = new Ping())
                {
                    var result = ping.Send("www.google.com",15000);
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

        private bool browsergorunenBaglantiKontrol()
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

        private bool gorunenBaglantiKontrol()
        {
            if (browsergorunenBaglantiKontrol() == true && browsergorunmeyenBaglantiKontrol() == true)
            {
                return true;
            }
            else
            {
                if (webBrowser1 != null)
                {
                    webBrowser1.Stop();
                }
                
                return false;
            }
        }

        //BROWSER ANA BUTONLARI

        private void backButton_Click(object sender, EventArgs e)
        {
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    webBrowser1.GoBack();
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    webBrowser1.GoForward();
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }
        }

        private void anasayfaButton_Click(object sender, EventArgs e)
        {
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    webBrowser1.Navigate("https://fen.deu.edu.tr/tr/");
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }        
        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
            formKapatma();
        }

        //SCROLL BUTONLARI İŞLEMLERİ
        private bool IsAtBottom()
        {
            scrollableHeight = webBrowser1.Document.Body.ScrollRectangle.Height - webBrowser1.ClientSize.Height;
            currentPosition = webBrowser1.Document.GetElementsByTagName("HTML")[0].ScrollTop;

            // Eğer mevcut pozisyon en altta ise true, değilse false döndürür.
            return currentPosition >= scrollableHeight;
        }

        private bool IsAtTop()
        {
            currentPosition = webBrowser1.Document.GetElementsByTagName("HTML")[0].ScrollTop;

            // Eğer mevcut pozisyon en üstte ise true, değilse false döndürür.
            return currentPosition == 0;
        }

        private void scrollDownButton_Click(object sender, EventArgs e)
        {
            startScrollTimer();
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    //if (yPosition + webBrowser1.ClientSize.Height < webBrowser1.Document.Body.ScrollRectangle.Height)
                    if(!IsAtBottom())
                    {
                        yPosition += 125;
                        webBrowser1.Document.Window.ScrollTo(0, yPosition);
                    }
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }
        }

        private void scrollUpButton_Click(object sender, EventArgs e)
        {
            startScrollTimer();
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    //if (yPosition > 0)
                    if(!IsAtTop())
                    {
                        yPosition -= 125;
                        webBrowser1.Document.Window.ScrollTo(0, yPosition);
                    }
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }                     
        }

        private void startScrollTimer()
        {
            if (!updownTimer.Enabled)
            {
                butonDisable();
                updownTimer.Interval = 500;
                updownTimer.Start();
            }
        }

        private void updownTimer_Tick(object sender, EventArgs e)
        {
            butonEnable();
            updownTimer.Stop();
        }

        /*private void scrollLeft_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (xPosition > 0)
                {
                    xPosition -= 40;
                }
                webBrowser1.Document.Window.ScrollTo(xPosition, yPosition);
            }
            else
            {
                nonInternetError();
            }
        }
        */

        /*private void scrollRight_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (xPosition + webBrowser1.ClientSize.Width < webBrowser1.Document.Body.ScrollRectangle.Width)
                {
                    xPosition += 50;
                    webBrowser1.Document.Window.ScrollTo(xPosition, yPosition);
                }
            }
            else
            {
                nonInternetError();
            }            
        }*/

        private void pozisyonSifirlama()
        {
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    yPosition = 0;
                    if (webBrowser1.Document != null)
                    {
                        webBrowser1.Document.Window.ScrollTo(0, 0);
                    }
                    
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }
        }

        //MESAJLAR VE FORM KAPATMA FONKSİYONLARI
        private void formKapatma()
        {
            if (butonAyar != null && butonAyar.Enabled)
            {
                butonAyar.Stop();
            }
            if(updownTimer!= null && updownTimer.Enabled)
            {
                updownTimer.Stop();
            }

            if (browserGeriSayimTimer!=null && browserGeriSayimTimer.Enabled)
            {
                browserGeriSayimTimer.Stop();
            }
            if(webBrowser1!= null)
            {
                if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    webBrowser1.Stop();
                }
                
                webBrowser1.Dispose();                
                webBrowser1 = null;

            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
        }

        private void nonInternetError()
        {
            if (hataCount == 0)
            {
                MessageLabel mesageLabel = new MessageLabel("Internet bağlantısı olmadığı için arayüze yönlendiriliyorsunuz", 4000);
                mesageLabel.ShowDialog();
                formKapatma();
                hataCount++;
            }
            
        }

        private void normalHataMesaj()
        {
            MessageLabel mesageLabel1 = new MessageLabel("Bir hata ile karşılaşıldı. Arayüze yönlendiriliyorsunuz", 4000);
            mesageLabel1.ShowDialog();
            formKapatma();
        }

        private void girisMesaj()
        {
            MessageLabel girisMesaj = new MessageLabel("Değerli öğrencimiz, KIOSK cihazının ve kullanıcıların güvenliği açısından bazı sitelerin tıklandığı halde açılmadığını farkedeceksiniz, açılmayan siteleri sağ aşağıda bulunan QR koda tıklayarak QR kodlarını görüntüleyebilir ve telefonunuzdan okutarak o adrese gidebilirsiniz.", 15000); 
            girisMesaj.ShowDialog();
        }

        //BUTONLARIN ENABLE DİSABLE İŞLEMLERİ
        private void butonEnable()
        {
            forwardButton.Enabled = true;
            backButton.Enabled = true;
            anasayfaButton.Enabled = true;
            scrollDownButton.Enabled = true;
            scrollUpButton.Enabled = true;
            zoomIn.Enabled = true;
            zoomOut.Enabled = true;
            browserQR.Enabled = true;
            kapatButton.Enabled = true;
        }

        private void butonDisable()
        {
            forwardButton.Enabled = false;
            backButton.Enabled = false;
            anasayfaButton.Enabled = false;
            scrollDownButton.Enabled = false;
            scrollUpButton.Enabled = false;
            zoomIn.Enabled = false;
            zoomOut.Enabled = false;
            browserQR.Enabled = false;
            kapatButton.Enabled = false;
        }

        private void startTimer()
        {
            
            if (!butonAyar.Enabled)
            {
                butonDisable();
                butonAyar.Interval = 3000;
                butonAyar.Start();
            }           
        }

        private void butonAyar_Tick(object sender, EventArgs e)
        {
            butonEnable();
            butonAyar.Stop();
        }

        //ZOOM BUTONLARI İŞLEMLERİ

        private void zoomIn_Click(object sender, EventArgs e)
        {
            startTimer();
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    if (webBrowser1 != null)
                    {
                        if (zoomCount < 3)
                        {
                            zoomCount++;
                            webBrowser1.Focus();
                            SendKeys.Send("^{+}");
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
                
            }
            else
            {
                nonInternetError();
            }   
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            startTimer() ;
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    if (webBrowser1 != null && zoomCount>-3)
                    {
                        zoomCount--;
                        webBrowser1.Focus();
                        SendKeys.Send("^{-}");
                    }
                    
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }
            }
            else
            {
                nonInternetError();
            }
           
        }

        private void zoomSifirlama()
        {
            if (gorunenBaglantiKontrol() == true)
            {
                try
                {
                    if (webBrowser1 != null)
                    {
                        webBrowser1.Focus();
                        SendKeys.Send("^0");
                        zoomCount = 0;
                    }
                    
                }
                catch (Exception ex)
                {
                    if (ex is WebException)
                    {
                        nonInternetError();
                    }
                    else
                    {
                        normalHataMesaj();
                    }
                }

            }
            else
            {
                nonInternetError();
            }
        }


        //BROWSERI KAPATACAK TIMER İŞLEMLERİ
        private void startBrowserTimer()
        {
            
            if (!browserGeriSayimTimer.Enabled)
            {
                browserGeriSayimTimer.Interval = 120000;
                browserGeriSayimTimer.Start();
            }
        }

        private void timerReset()
        {
            
            browserGeriSayimTimer.Stop();
            browserGeriSayimTimer.Interval = 120000;
            browserGeriSayimTimer.Start();
        }

        private void browserGeriSayimTimer_Tick(object sender, EventArgs e)
        {
            browserGeriSayimTimer.Stop();
            formKapatma();
        }

        //QR KOD İŞLEMLERİ
        private Bitmap browserCreateQR(String url)
        {
            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                return qrCodeImage;
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    nonInternetError();
                    return null;
                }
                else
                {
                    normalHataMesaj();
                    return null;
                }
            }
        }

        private void browserImageQR(String url)
        {
            browserQR.Image = browserCreateQR(url);
        }

        private void qrariAyarla(String gidilemeyenUrl)
        {
            qrimagePanel.BackColor = SystemColors.MenuHighlight;
            panelTimerStart();
            currentQRurl= gidilemeyenUrl;
            browserImageQR(gidilemeyenUrl);
        }

        private void browserQR_Click(object sender, EventArgs e)
        {
            timerReset();
            QRBrowser qrbrowser = new QRBrowser(currentQRurl);
            qrbrowser.ShowDialog();
        }

        private void panelTimerStart()
        {
            browserClickableDisable();
            if (!panelTimer.Enabled)
            {
                panelTimer.Interval = 1500;
                panelTimer.Start();
            }
        }

        private void panelTimer_Tick(object sender, EventArgs e)
        {
            browserClickableEnable();
            qrimagePanel.BackColor = SystemColors.ActiveCaptionText;
            panelTimer.Stop();
        }


        private void browserClickableEnable()
        {
            if(webBrowser1.Document!= null)
            {
                webBrowser1.Document.Body.Style = webBrowser1.Document.Body.Style.Replace("pointer-events: none;", "");

            }

        }

        private void browserClickableDisable()
        {
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Body.Style += "pointer-events: none;";
            }
            

        }

        private void Browser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (!butonAyar.Enabled)
                {
                    formKapatma();
                }
                
            }
            
        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!butonAyar.Enabled)
                {
                    formKapatma();
                }
            }
        }
    }
}
