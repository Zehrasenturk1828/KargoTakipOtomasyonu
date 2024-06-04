namespace KargoTakipOtomasyonu
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.girisyap = new System.Windows.Forms.Button();
            this.kadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.uyeol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VEYA";
            // 
            // girisyap
            // 
            this.girisyap.Location = new System.Drawing.Point(343, 237);
            this.girisyap.Name = "girisyap";
            this.girisyap.Size = new System.Drawing.Size(75, 23);
            this.girisyap.TabIndex = 1;
            this.girisyap.Text = "GİRİŞ YAP";
            this.girisyap.UseVisualStyleBackColor = true;
            this.girisyap.Click += new System.EventHandler(this.girisyap_Click_1);
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(297, 153);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(163, 20);
            this.kadi.TabIndex = 2;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(296, 197);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(163, 20);
            this.sifre.TabIndex = 3;
            // 
            // user
            // 
            this.user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(330, 22);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 101);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user.TabIndex = 4;
            this.user.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 97);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // uyeol
            // 
            this.uyeol.Location = new System.Drawing.Point(343, 301);
            this.uyeol.Name = "uyeol";
            this.uyeol.Size = new System.Drawing.Size(75, 23);
            this.uyeol.TabIndex = 6;
            this.uyeol.Text = "ÜYE OL";
            this.uyeol.UseVisualStyleBackColor = true;
            this.uyeol.Click += new System.EventHandler(this.uyeol_Click_1);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uyeol);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.user);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kadi);
            this.Controls.Add(this.girisyap);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkrani";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisyap;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button uyeol;
    }
}