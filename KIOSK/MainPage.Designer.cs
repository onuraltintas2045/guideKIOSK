using System.Drawing;

namespace KIOSK
{
    partial class MainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.üstPanel = new System.Windows.Forms.Panel();
            this.sicaklik = new System.Windows.Forms.Label();
            this.havaresim = new System.Windows.Forms.PictureBox();
            this.Saat = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.deuLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.altPanel = new System.Windows.Forms.Panel();
            this.engelsizDeuButton = new System.Windows.Forms.Button();
            this.duyurular = new System.Windows.Forms.Button();
            this.yemekMenu = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.Timer(this.components);
            this.Weather = new System.Windows.Forms.Timer(this.components);
            this.ortaPanel = new System.Windows.Forms.Panel();
            this.derslikButton = new System.Windows.Forms.Button();
            this.istekButton = new System.Windows.Forms.Button();
            this.tarayiciButton = new System.Windows.Forms.Button();
            this.anketlerButton = new System.Windows.Forms.Button();
            this.buttonsTimer = new System.Windows.Forms.Timer(this.components);
            this.üstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.havaresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.altPanel.SuspendLayout();
            this.ortaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // üstPanel
            // 
            this.üstPanel.BackColor = System.Drawing.Color.Black;
            this.üstPanel.Controls.Add(this.sicaklik);
            this.üstPanel.Controls.Add(this.havaresim);
            this.üstPanel.Controls.Add(this.Saat);
            this.üstPanel.Controls.Add(this.Date);
            this.üstPanel.Controls.Add(this.deuLabel);
            this.üstPanel.Controls.Add(this.pictureBox1);
            this.üstPanel.Location = new System.Drawing.Point(0, 0);
            this.üstPanel.Name = "üstPanel";
            this.üstPanel.Size = new System.Drawing.Size(1920, 230);
            this.üstPanel.TabIndex = 0;
            // 
            // sicaklik
            // 
            this.sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sicaklik.Location = new System.Drawing.Point(1745, 141);
            this.sicaklik.Name = "sicaklik";
            this.sicaklik.Size = new System.Drawing.Size(78, 30);
            this.sicaklik.TabIndex = 6;
            this.sicaklik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // havaresim
            // 
            this.havaresim.Location = new System.Drawing.Point(1655, 125);
            this.havaresim.Name = "havaresim";
            this.havaresim.Size = new System.Drawing.Size(80, 80);
            this.havaresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.havaresim.TabIndex = 5;
            this.havaresim.TabStop = false;
            // 
            // Saat
            // 
            this.Saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Saat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Saat.Location = new System.Drawing.Point(1610, 65);
            this.Saat.Name = "Saat";
            this.Saat.Size = new System.Drawing.Size(275, 40);
            this.Saat.TabIndex = 4;
            this.Saat.Text = "Saat";
            this.Saat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Date.Location = new System.Drawing.Point(1610, 20);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(275, 40);
            this.Date.TabIndex = 3;
            this.Date.Text = "Tarih";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deuLabel
            // 
            this.deuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deuLabel.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deuLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deuLabel.Location = new System.Drawing.Point(195, 45);
            this.deuLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deuLabel.Name = "deuLabel";
            this.deuLabel.Size = new System.Drawing.Size(425, 140);
            this.deuLabel.TabIndex = 1;
            this.deuLabel.Text = "Dokuz Eylül Üniversitesi \r\nFen Fakültesi";
            this.deuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KIOSK.Properties.Resources.Fen_Fakultesi_Logo_2000x2000;
            this.pictureBox1.Location = new System.Drawing.Point(20, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // altPanel
            // 
            this.altPanel.BackColor = System.Drawing.Color.Black;
            this.altPanel.Controls.Add(this.engelsizDeuButton);
            this.altPanel.Controls.Add(this.duyurular);
            this.altPanel.Controls.Add(this.yemekMenu);
            this.altPanel.Location = new System.Drawing.Point(0, 850);
            this.altPanel.Name = "altPanel";
            this.altPanel.Padding = new System.Windows.Forms.Padding(3);
            this.altPanel.Size = new System.Drawing.Size(1920, 230);
            this.altPanel.TabIndex = 1;
            // 
            // engelsizDeuButton
            // 
            this.engelsizDeuButton.BackgroundImage = global::KIOSK.Properties.Resources.Group_1_copy2;
            this.engelsizDeuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.engelsizDeuButton.FlatAppearance.BorderSize = 0;
            this.engelsizDeuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engelsizDeuButton.Location = new System.Drawing.Point(1340, 40);
            this.engelsizDeuButton.Name = "engelsizDeuButton";
            this.engelsizDeuButton.Size = new System.Drawing.Size(500, 150);
            this.engelsizDeuButton.TabIndex = 2;
            this.engelsizDeuButton.UseVisualStyleBackColor = true;
            this.engelsizDeuButton.Click += new System.EventHandler(this.engelsizDeuButton_Click);
            // 
            // duyurular
            // 
            this.duyurular.BackgroundImage = global::KIOSK.Properties.Resources.Group_1;
            this.duyurular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.duyurular.FlatAppearance.BorderSize = 0;
            this.duyurular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duyurular.Location = new System.Drawing.Point(710, 40);
            this.duyurular.Name = "duyurular";
            this.duyurular.Size = new System.Drawing.Size(500, 150);
            this.duyurular.TabIndex = 1;
            this.duyurular.UseVisualStyleBackColor = true;
            this.duyurular.Click += new System.EventHandler(this.duyurular_Click);
            // 
            // yemekMenu
            // 
            this.yemekMenu.BackgroundImage = global::KIOSK.Properties.Resources.Group_2;
            this.yemekMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yemekMenu.FlatAppearance.BorderSize = 0;
            this.yemekMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yemekMenu.Location = new System.Drawing.Point(80, 40);
            this.yemekMenu.Name = "yemekMenu";
            this.yemekMenu.Size = new System.Drawing.Size(500, 150);
            this.yemekMenu.TabIndex = 0;
            this.yemekMenu.UseVisualStyleBackColor = true;
            this.yemekMenu.Click += new System.EventHandler(this.yemekMenu_Click);
            // 
            // tarih
            // 
            this.tarih.Tick += new System.EventHandler(this.tarih_Tick);
            // 
            // Weather
            // 
            this.Weather.Interval = 15000;
            this.Weather.Tick += new System.EventHandler(this.Weather_Tick);
            // 
            // ortaPanel
            // 
            this.ortaPanel.BackColor = System.Drawing.Color.SlateGray;
            this.ortaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ortaPanel.Controls.Add(this.derslikButton);
            this.ortaPanel.Controls.Add(this.istekButton);
            this.ortaPanel.Controls.Add(this.tarayiciButton);
            this.ortaPanel.Controls.Add(this.anketlerButton);
            this.ortaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortaPanel.Location = new System.Drawing.Point(0, 230);
            this.ortaPanel.Name = "ortaPanel";
            this.ortaPanel.Size = new System.Drawing.Size(1920, 620);
            this.ortaPanel.TabIndex = 2;
            this.ortaPanel.TabStop = true;
            // 
            // derslikButton
            // 
            this.derslikButton.BackgroundImage = global::KIOSK.Properties.Resources.DN;
            this.derslikButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.derslikButton.FlatAppearance.BorderSize = 0;
            this.derslikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.derslikButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.derslikButton.Location = new System.Drawing.Point(184, 185);
            this.derslikButton.Name = "derslikButton";
            this.derslikButton.Size = new System.Drawing.Size(250, 250);
            this.derslikButton.TabIndex = 0;
            this.derslikButton.UseVisualStyleBackColor = true;
            // 
            // istekButton
            // 
            this.istekButton.BackgroundImage = global::KIOSK.Properties.Resources.GÖ;
            this.istekButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.istekButton.FlatAppearance.BorderSize = 0;
            this.istekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.istekButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istekButton.Location = new System.Drawing.Point(1486, 185);
            this.istekButton.Name = "istekButton";
            this.istekButton.Size = new System.Drawing.Size(250, 250);
            this.istekButton.TabIndex = 3;
            this.istekButton.UseVisualStyleBackColor = true;
            // 
            // tarayiciButton
            // 
            this.tarayiciButton.BackgroundImage = global::KIOSK.Properties.Resources.Tarayıcı;
            this.tarayiciButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tarayiciButton.FlatAppearance.BorderSize = 0;
            this.tarayiciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarayiciButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarayiciButton.Location = new System.Drawing.Point(618, 185);
            this.tarayiciButton.Name = "tarayiciButton";
            this.tarayiciButton.Size = new System.Drawing.Size(250, 250);
            this.tarayiciButton.TabIndex = 1;
            this.tarayiciButton.UseVisualStyleBackColor = true;
            this.tarayiciButton.Click += new System.EventHandler(this.tarayiciButton_Click);
            // 
            // anketlerButton
            // 
            this.anketlerButton.BackgroundImage = global::KIOSK.Properties.Resources.DersProgrami;
            this.anketlerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anketlerButton.FlatAppearance.BorderSize = 0;
            this.anketlerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anketlerButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anketlerButton.Location = new System.Drawing.Point(1052, 185);
            this.anketlerButton.Name = "anketlerButton";
            this.anketlerButton.Size = new System.Drawing.Size(250, 250);
            this.anketlerButton.TabIndex = 2;
            this.anketlerButton.UseVisualStyleBackColor = true;
            this.anketlerButton.Click += new System.EventHandler(this.anketlerButton_Click);
            // 
            // buttonsTimer
            // 
            this.buttonsTimer.Interval = 3000;
            this.buttonsTimer.Tick += new System.EventHandler(this.buttonsTimer_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.ortaPanel);
            this.Controls.Add(this.altPanel);
            this.Controls.Add(this.üstPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.üstPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.havaresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.altPanel.ResumeLayout(false);
            this.ortaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel üstPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel altPanel;
        private System.Windows.Forms.Panel ortaPanel;
        private System.Windows.Forms.Button istekButton;
        private System.Windows.Forms.Button tarayiciButton;
        private System.Windows.Forms.Button derslikButton;
        private System.Windows.Forms.Label deuLabel;
        private System.Windows.Forms.Timer tarih;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Saat;
        private System.Windows.Forms.Label sicaklik;
        private System.Windows.Forms.PictureBox havaresim;
        private System.Windows.Forms.Timer Weather;
        public System.Windows.Forms.Button anketlerButton;
        private System.Windows.Forms.Button duyurular;
        private System.Windows.Forms.Button yemekMenu;
        private System.Windows.Forms.Button engelsizDeuButton;
        private System.Windows.Forms.Timer buttonsTimer;
    }
}

