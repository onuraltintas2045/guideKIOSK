using System.Drawing;

namespace KIOSK
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.butonAyar = new System.Windows.Forms.Timer(this.components);
            this.browserGeriSayimTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTimer = new System.Windows.Forms.Timer(this.components);
            this.updownTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrollUpButton = new System.Windows.Forms.Button();
            this.qrimagePanel = new System.Windows.Forms.Panel();
            this.browserQR = new System.Windows.Forms.PictureBox();
            this.anasayfaButton = new System.Windows.Forms.Button();
            this.scrollDownButton = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.kapatButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.qrimagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserQR)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 80);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1720, 1000);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowser1_PreviewKeyDown);
            // 
            // butonAyar
            // 
            this.butonAyar.Interval = 3000;
            this.butonAyar.Tick += new System.EventHandler(this.butonAyar_Tick);
            // 
            // browserGeriSayimTimer
            // 
            this.browserGeriSayimTimer.Interval = 15000;
            this.browserGeriSayimTimer.Tick += new System.EventHandler(this.browserGeriSayimTimer_Tick);
            // 
            // panelTimer
            // 
            this.panelTimer.Interval = 1500;
            this.panelTimer.Tick += new System.EventHandler(this.panelTimer_Tick);
            // 
            // updownTimer
            // 
            this.updownTimer.Interval = 2000;
            this.updownTimer.Tick += new System.EventHandler(this.updownTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::KIOSK.Properties.Resources.Rectangle_18_copy;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.scrollUpButton);
            this.panel1.Controls.Add(this.qrimagePanel);
            this.panel1.Controls.Add(this.anasayfaButton);
            this.panel1.Controls.Add(this.scrollDownButton);
            this.panel1.Controls.Add(this.zoomOut);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.zoomIn);
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Location = new System.Drawing.Point(1720, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1080);
            this.panel1.TabIndex = 14;
            // 
            // scrollUpButton
            // 
            this.scrollUpButton.BackColor = System.Drawing.Color.Transparent;
            this.scrollUpButton.BackgroundImage = global::KIOSK.Properties.Resources.Button_copy_3;
            this.scrollUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scrollUpButton.FlatAppearance.BorderSize = 0;
            this.scrollUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrollUpButton.Location = new System.Drawing.Point(70, 19);
            this.scrollUpButton.Name = "scrollUpButton";
            this.scrollUpButton.Size = new System.Drawing.Size(70, 70);
            this.scrollUpButton.TabIndex = 5;
            this.scrollUpButton.UseVisualStyleBackColor = false;
            this.scrollUpButton.Click += new System.EventHandler(this.scrollUpButton_Click);
            // 
            // qrimagePanel
            // 
            this.qrimagePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qrimagePanel.Controls.Add(this.browserQR);
            this.qrimagePanel.Location = new System.Drawing.Point(25, 901);
            this.qrimagePanel.Name = "qrimagePanel";
            this.qrimagePanel.Size = new System.Drawing.Size(160, 160);
            this.qrimagePanel.TabIndex = 13;
            // 
            // browserQR
            // 
            this.browserQR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browserQR.Location = new System.Drawing.Point(10, 10);
            this.browserQR.Name = "browserQR";
            this.browserQR.Size = new System.Drawing.Size(140, 140);
            this.browserQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.browserQR.TabIndex = 12;
            this.browserQR.TabStop = false;
            this.browserQR.Click += new System.EventHandler(this.browserQR_Click);
            // 
            // anasayfaButton
            // 
            this.anasayfaButton.BackColor = System.Drawing.Color.Transparent;
            this.anasayfaButton.BackgroundImage = global::KIOSK.Properties.Resources.Fen_Fakultesi_Logo_2000x2000;
            this.anasayfaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfaButton.FlatAppearance.BorderSize = 0;
            this.anasayfaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfaButton.Location = new System.Drawing.Point(70, 145);
            this.anasayfaButton.Name = "anasayfaButton";
            this.anasayfaButton.Size = new System.Drawing.Size(70, 70);
            this.anasayfaButton.TabIndex = 3;
            this.anasayfaButton.UseVisualStyleBackColor = false;
            this.anasayfaButton.Click += new System.EventHandler(this.anasayfaButton_Click);
            // 
            // scrollDownButton
            // 
            this.scrollDownButton.BackColor = System.Drawing.Color.Transparent;
            this.scrollDownButton.BackgroundImage = global::KIOSK.Properties.Resources.Button_copy;
            this.scrollDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scrollDownButton.FlatAppearance.BorderSize = 0;
            this.scrollDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrollDownButton.Location = new System.Drawing.Point(70, 775);
            this.scrollDownButton.Name = "scrollDownButton";
            this.scrollDownButton.Size = new System.Drawing.Size(70, 70);
            this.scrollDownButton.TabIndex = 6;
            this.scrollDownButton.UseVisualStyleBackColor = false;
            this.scrollDownButton.Click += new System.EventHandler(this.scrollDownButton_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.BackColor = System.Drawing.Color.Transparent;
            this.zoomOut.BackgroundImage = global::KIOSK.Properties.Resources.Layer_6;
            this.zoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomOut.FlatAppearance.BorderSize = 0;
            this.zoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoomOut.Location = new System.Drawing.Point(70, 649);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(70, 70);
            this.zoomOut.TabIndex = 10;
            this.zoomOut.UseVisualStyleBackColor = false;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::KIOSK.Properties.Resources.Button_copy_2;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(70, 271);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 70);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // zoomIn
            // 
            this.zoomIn.BackColor = System.Drawing.Color.Transparent;
            this.zoomIn.BackgroundImage = global::KIOSK.Properties.Resources.Layer_5;
            this.zoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomIn.FlatAppearance.BorderSize = 0;
            this.zoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoomIn.Location = new System.Drawing.Point(70, 523);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(70, 70);
            this.zoomIn.TabIndex = 9;
            this.zoomIn.UseVisualStyleBackColor = false;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.BackgroundImage = global::KIOSK.Properties.Resources.Button;
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Location = new System.Drawing.Point(70, 397);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(70, 70);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // kapatButton
            // 
            this.kapatButton.BackColor = System.Drawing.Color.Transparent;
            this.kapatButton.BackgroundImage = global::KIOSK.Properties.Resources.HomeMin;
            this.kapatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kapatButton.FlatAppearance.BorderSize = 0;
            this.kapatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatButton.ForeColor = System.Drawing.Color.Transparent;
            this.kapatButton.Location = new System.Drawing.Point(10, 995);
            this.kapatButton.Name = "kapatButton";
            this.kapatButton.Size = new System.Drawing.Size(81, 80);
            this.kapatButton.TabIndex = 4;
            this.kapatButton.UseVisualStyleBackColor = false;
            this.kapatButton.Click += new System.EventHandler(this.kapatButton_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kapatButton);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Browser_KeyDown);
            this.panel1.ResumeLayout(false);
            this.qrimagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browserQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button anasayfaButton;
        private System.Windows.Forms.Button kapatButton;
        private System.Windows.Forms.Button scrollUpButton;
        private System.Windows.Forms.Button scrollDownButton;
        private System.Windows.Forms.Timer butonAyar;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Timer browserGeriSayimTimer;
        private System.Windows.Forms.PictureBox browserQR;
        private System.Windows.Forms.Panel qrimagePanel;
        private System.Windows.Forms.Timer panelTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer updownTimer;
    }
}