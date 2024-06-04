namespace KargoTakipOtomasyonu
{
    partial class YetkiliPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliPanel));
            this.gonderiolustur = new System.Windows.Forms.Button();
            this.subeolustur = new System.Windows.Forms.Button();
            this.musteriolustur = new System.Windows.Forms.Button();
            this.gdurumguncelle = new System.Windows.Forms.Button();
            this.gdurumsorgula = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.durum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gonderiolustur
            // 
            this.gonderiolustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gonderiolustur.Location = new System.Drawing.Point(296, 75);
            this.gonderiolustur.Name = "gonderiolustur";
            this.gonderiolustur.Size = new System.Drawing.Size(174, 34);
            this.gonderiolustur.TabIndex = 0;
            this.gonderiolustur.Text = "GÖNDERİ OLUŞTUR";
            this.gonderiolustur.UseVisualStyleBackColor = false;
            this.gonderiolustur.Click += new System.EventHandler(this.gonderiolustur_Click);
            // 
            // subeolustur
            // 
            this.subeolustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subeolustur.Location = new System.Drawing.Point(296, 140);
            this.subeolustur.Name = "subeolustur";
            this.subeolustur.Size = new System.Drawing.Size(174, 34);
            this.subeolustur.TabIndex = 0;
            this.subeolustur.Text = "ŞUBE SORGULAMA";
            this.subeolustur.UseVisualStyleBackColor = false;
            this.subeolustur.Click += new System.EventHandler(this.subeolustur_Click);
            // 
            // musteriolustur
            // 
            this.musteriolustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musteriolustur.Location = new System.Drawing.Point(296, 205);
            this.musteriolustur.Name = "musteriolustur";
            this.musteriolustur.Size = new System.Drawing.Size(174, 34);
            this.musteriolustur.TabIndex = 0;
            this.musteriolustur.Text = "MÜŞTERİ OLUŞTUR";
            this.musteriolustur.UseVisualStyleBackColor = false;
            this.musteriolustur.Click += new System.EventHandler(this.musteriolustur_Click);
            // 
            // gdurumguncelle
            // 
            this.gdurumguncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gdurumguncelle.Location = new System.Drawing.Point(296, 271);
            this.gdurumguncelle.Name = "gdurumguncelle";
            this.gdurumguncelle.Size = new System.Drawing.Size(174, 34);
            this.gdurumguncelle.TabIndex = 0;
            this.gdurumguncelle.Text = "GÖNDERİ DURUMUNU GÜNCELLE";
            this.gdurumguncelle.UseVisualStyleBackColor = false;
            this.gdurumguncelle.Click += new System.EventHandler(this.gdurumguncelle_Click);
            // 
            // gdurumsorgula
            // 
            this.gdurumsorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gdurumsorgula.Location = new System.Drawing.Point(296, 337);
            this.gdurumsorgula.Name = "gdurumsorgula";
            this.gdurumsorgula.Size = new System.Drawing.Size(174, 34);
            this.gdurumsorgula.TabIndex = 0;
            this.gdurumsorgula.Text = "GÖNDERİ DURUMU SORGULA";
            this.gdurumsorgula.UseVisualStyleBackColor = false;
            this.gdurumsorgula.Click += new System.EventHandler(this.gdurumsorgula_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cikis.Location = new System.Drawing.Point(296, 402);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(174, 34);
            this.cikis.TabIndex = 0;
            this.cikis.Text = "OTURUMU KAPAT";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.Location = new System.Drawing.Point(344, 26);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(80, 13);
            this.durum.TabIndex = 2;
            this.durum.Text = "İŞLEM PANELİ";
            // 
            // YetkiliPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.gdurumsorgula);
            this.Controls.Add(this.gdurumguncelle);
            this.Controls.Add(this.musteriolustur);
            this.Controls.Add(this.subeolustur);
            this.Controls.Add(this.gonderiolustur);
            this.Name = "YetkiliPanel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.YetkiliPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gonderiolustur;
        private System.Windows.Forms.Button subeolustur;
        private System.Windows.Forms.Button musteriolustur;
        private System.Windows.Forms.Button gdurumguncelle;
        private System.Windows.Forms.Button gdurumsorgula;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label durum;
    }
}