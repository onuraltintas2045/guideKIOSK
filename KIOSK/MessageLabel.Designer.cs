namespace KIOSK
{
    partial class MessageLabel
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
            this.mesajlabel = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.gerisayimLabel = new System.Windows.Forms.Label();
            this.gerisayim = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mesajlabel
            // 
            this.mesajlabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mesajlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mesajlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajlabel.ForeColor = System.Drawing.Color.White;
            this.mesajlabel.Location = new System.Drawing.Point(0, 30);
            this.mesajlabel.Name = "mesajlabel";
            this.mesajlabel.Size = new System.Drawing.Size(985, 230);
            this.mesajlabel.TabIndex = 0;
            this.mesajlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            this.labelTimer.Tick += new System.EventHandler(this.labelTimer_Tick);
            // 
            // gerisayimLabel
            // 
            this.gerisayimLabel.BackColor = System.Drawing.Color.Black;
            this.gerisayimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gerisayimLabel.ForeColor = System.Drawing.Color.Lavender;
            this.gerisayimLabel.Location = new System.Drawing.Point(599, 5);
            this.gerisayimLabel.Name = "gerisayimLabel";
            this.gerisayimLabel.Size = new System.Drawing.Size(381, 20);
            this.gerisayimLabel.TabIndex = 1;
            this.gerisayimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gerisayim
            // 
            this.gerisayim.Tick += new System.EventHandler(this.gerisayim_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(985, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "TAMAM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageLabel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gerisayimLabel);
            this.Controls.Add(this.mesajlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UYARI!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mesajlabel;
        private System.Windows.Forms.Timer labelTimer;
        private System.Windows.Forms.Label gerisayimLabel;
        private System.Windows.Forms.Timer gerisayim;
        private System.Windows.Forms.Button button1;
    }
}