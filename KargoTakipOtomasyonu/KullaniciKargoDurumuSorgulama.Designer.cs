namespace KargoTakipOtomasyonu
{
    partial class KullaniciKargoDurumuSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKargoDurumuSorgulama));
            this.durum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gonderidurumu = new System.Windows.Forms.ListView();
            this.gonkoduu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gondurumuu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gonkodu = new System.Windows.Forms.TextBox();
            this.gondurumsorgula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adi = new System.Windows.Forms.Label();
            this.paneledon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.Location = new System.Drawing.Point(557, 47);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(124, 13);
            this.durum.TabIndex = 21;
            this.durum.Text = "SORGULAMA SONUCU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "GÖNDERİ DURUMU SORGULA";
            // 
            // gonderidurumu
            // 
            this.gonderidurumu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gonkoduu,
            this.gondurumuu});
            this.gonderidurumu.HideSelection = false;
            this.gonderidurumu.Location = new System.Drawing.Point(438, 82);
            this.gonderidurumu.Name = "gonderidurumu";
            this.gonderidurumu.Size = new System.Drawing.Size(350, 89);
            this.gonderidurumu.TabIndex = 20;
            this.gonderidurumu.UseCompatibleStateImageBehavior = false;
            this.gonderidurumu.View = System.Windows.Forms.View.Details;
            // 
            // gonkoduu
            // 
            this.gonkoduu.Text = "GÖNDERİ KODU";
            this.gonkoduu.Width = 96;
            // 
            // gondurumuu
            // 
            this.gondurumuu.Text = "GÖNDERİ DURUMU";
            this.gondurumuu.Width = 124;
            // 
            // gonkodu
            // 
            this.gonkodu.Location = new System.Drawing.Point(265, 82);
            this.gonkodu.Name = "gonkodu";
            this.gonkodu.Size = new System.Drawing.Size(135, 20);
            this.gonkodu.TabIndex = 19;
            // 
            // gondurumsorgula
            // 
            this.gondurumsorgula.Location = new System.Drawing.Point(196, 130);
            this.gondurumsorgula.Name = "gondurumsorgula";
            this.gondurumsorgula.Size = new System.Drawing.Size(75, 23);
            this.gondurumsorgula.TabIndex = 18;
            this.gondurumsorgula.Text = "SORGULA";
            this.gondurumsorgula.UseVisualStyleBackColor = true;
            this.gondurumsorgula.Click += new System.EventHandler(this.gondurumsorgula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(154, 85);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(94, 13);
            this.adi.TabIndex = 23;
            this.adi.Text = "GÖNDERİ KODU:";
            // 
            // paneledon
            // 
            this.paneledon.Location = new System.Drawing.Point(291, 130);
            this.paneledon.Name = "paneledon";
            this.paneledon.Size = new System.Drawing.Size(109, 23);
            this.paneledon.TabIndex = 24;
            this.paneledon.Text = "PANELE DÖN";
            this.paneledon.UseVisualStyleBackColor = true;
            this.paneledon.Click += new System.EventHandler(this.paneledon_Click);
            // 
            // KullaniciKargoDurumuSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneledon);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gonderidurumu);
            this.Controls.Add(this.gonkodu);
            this.Controls.Add(this.gondurumsorgula);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciKargoDurumuSorgulama";
            this.Text = "KullaniciKargoDurumuSorgulama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label durum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView gonderidurumu;
        private System.Windows.Forms.TextBox gonkodu;
        private System.Windows.Forms.Button gondurumsorgula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adi;
        private System.Windows.Forms.ColumnHeader gonkoduu;
        private System.Windows.Forms.ColumnHeader gondurumuu;
        private System.Windows.Forms.Button paneledon;
    }
}