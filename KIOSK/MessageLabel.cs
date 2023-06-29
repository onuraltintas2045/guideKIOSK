using System;
using System.Windows.Forms;

namespace KIOSK
{
    public partial class MessageLabel : Form
    {

        private int saniye;

        

        public MessageLabel(string message, int timertime)
        {
            InitializeComponent();
            mesajlabel.Text = message;
            saniye = timertime / 1000;
            gerisayimLabel.Text = (saniye.ToString() + " saniye sonra kapatılacak");
            baslatLabelTimer(timertime);
            baslatGeriSayimTimer();
        }

        private void baslatLabelTimer(int timertime)
        {
            
            if (!labelTimer.Enabled)
            {
                labelTimer.Interval = timertime;
                labelTimer.Start();              
            }
        }

        private void baslatGeriSayimTimer()
        {
            if(!gerisayim.Enabled)
            {
                gerisayim.Interval = 1000;
                gerisayim.Start();
            }
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            if(labelTimer != null && gerisayim.Enabled)
            {
                labelTimer.Stop();
            }
            if(gerisayim != null && gerisayim.Enabled)
            {
                gerisayim.Stop();
            }
            
            this.Close();
        }

        private void gerisayim_Tick(object sender, EventArgs e)
        {
            saniye -= 1;
            gerisayimLabel.Text = (saniye.ToString() + " saniye sonra kapatılacak");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTimer != null && gerisayim.Enabled)
            {
                labelTimer.Stop();
            }
            if (gerisayim != null && gerisayim.Enabled)
            {
                gerisayim.Stop();
            }

            this.Close();
        }
    } 

}
