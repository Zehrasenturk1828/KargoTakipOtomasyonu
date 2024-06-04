namespace KargoTakipOtomasyonu
{
    partial class KullaniciPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.durum = new System.Windows.Forms.Label();
            this.cikisyap = new System.Windows.Forms.Button();
            this.kargodurumsorgula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.Location = new System.Drawing.Point(327, 23);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(80, 13);
            this.durum.TabIndex = 3;
            this.durum.Text = "İŞLEM PANELİ";
            // 
            // cikisyap
            // 
            this.cikisyap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cikisyap.Location = new System.Drawing.Point(279, 153);
            this.cikisyap.Name = "cikisyap";
            this.cikisyap.Size = new System.Drawing.Size(174, 34);
            this.cikisyap.TabIndex = 4;
            this.cikisyap.Text = "OTURUMU KAPAT";
            this.cikisyap.UseVisualStyleBackColor = false;
            this.cikisyap.Click += new System.EventHandler(this.cikisyap_Click);
            // 
            // kargodurumsorgula
            // 
            this.kargodurumsorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kargodurumsorgula.Location = new System.Drawing.Point(279, 88);
            this.kargodurumsorgula.Name = "kargodurumsorgula";
            this.kargodurumsorgula.Size = new System.Drawing.Size(174, 34);
            this.kargodurumsorgula.TabIndex = 5;
            this.kargodurumsorgula.Text = "KARGO DURUMUMU SORGULA";
            this.kargodurumsorgula.UseVisualStyleBackColor = false;
            this.kargodurumsorgula.Click += new System.EventHandler(this.kargodurumsorgula_Click);
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikisyap);
            this.Controls.Add(this.kargodurumsorgula);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciPanel";
            this.Text = "KullaniciPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label durum;
        private System.Windows.Forms.Button cikisyap;
        private System.Windows.Forms.Button kargodurumsorgula;
    }
}