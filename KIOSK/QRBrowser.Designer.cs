namespace KIOSK
{
    partial class QRBrowser
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
            this.qrGeriLabel = new System.Windows.Forms.Label();
            this.qrKapatmaTimer = new System.Windows.Forms.Timer(this.components);
            this.qrGeriTimer = new System.Windows.Forms.Timer(this.components);
            this.qrpicturebox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrGeriLabel
            // 
            this.qrGeriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.qrGeriLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.qrGeriLabel.Location = new System.Drawing.Point(559, 5);
            this.qrGeriLabel.Name = "qrGeriLabel";
            this.qrGeriLabel.Size = new System.Drawing.Size(300, 27);
            this.qrGeriLabel.TabIndex = 1;
            // 
            // qrKapatmaTimer
            // 
            this.qrKapatmaTimer.Interval = 15000;
            this.qrKapatmaTimer.Tick += new System.EventHandler(this.qrKapatmaTimer_Tick);
            // 
            // qrGeriTimer
            // 
            this.qrGeriTimer.Interval = 1000;
            this.qrGeriTimer.Tick += new System.EventHandler(this.qrGeriTimer_Tick);
            // 
            // qrpicturebox
            // 
            this.qrpicturebox.Location = new System.Drawing.Point(27, 40);
            this.qrpicturebox.Name = "qrpicturebox";
            this.qrpicturebox.Size = new System.Drawing.Size(830, 576);
            this.qrpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrpicturebox.TabIndex = 0;
            this.qrpicturebox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(885, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "TAMAM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QRBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qrGeriLabel);
            this.Controls.Add(this.qrpicturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QRBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRBrowser";
            ((System.ComponentModel.ISupportInitialize)(this.qrpicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox qrpicturebox;
        private System.Windows.Forms.Label qrGeriLabel;
        private System.Windows.Forms.Timer qrKapatmaTimer;
        private System.Windows.Forms.Timer qrGeriTimer;
        private System.Windows.Forms.Button button1;
    }
}