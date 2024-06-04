namespace KargoTakipOtomasyonu
{
    partial class GonderiDurumGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GonderiDurumGuncelle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gondurum = new System.Windows.Forms.ComboBox();
            this.gondurumguncelle = new System.Windows.Forms.Button();
            this.gonkodu = new System.Windows.Forms.TextBox();
            this.gonderiler = new System.Windows.Forms.ListView();
            this.göndkodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.göndurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gonlistele = new System.Windows.Forms.Button();
            this.paneledon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gondurum
            // 
            this.gondurum.FormattingEnabled = true;
            this.gondurum.Items.AddRange(new object[] {
            "GÖNDERİNİZ YOLDA",
            "GÖNDERİNİZ TESLİMAT ŞUBESİNDE",
            "GÖNDERİNİZ TRANSFER AŞAMASINDA",
            "GÖNDERİNİZ DAĞITIMDA",
            "GÖNDERİNİZ TESLİM EDİLDİ"});
            this.gondurum.Location = new System.Drawing.Point(225, 98);
            this.gondurum.Name = "gondurum";
            this.gondurum.Size = new System.Drawing.Size(135, 21);
            this.gondurum.TabIndex = 4;
            // 
            // gondurumguncelle
            // 
            this.gondurumguncelle.Location = new System.Drawing.Point(187, 141);
            this.gondurumguncelle.Name = "gondurumguncelle";
            this.gondurumguncelle.Size = new System.Drawing.Size(75, 41);
            this.gondurumguncelle.TabIndex = 5;
            this.gondurumguncelle.Text = "GÜNCELLE";
            this.gondurumguncelle.UseVisualStyleBackColor = true;
            this.gondurumguncelle.Click += new System.EventHandler(this.gondurumguncelle_Click);
            // 
            // gonkodu
            // 
            this.gonkodu.Location = new System.Drawing.Point(225, 54);
            this.gonkodu.Name = "gonkodu";
            this.gonkodu.Size = new System.Drawing.Size(135, 20);
            this.gonkodu.TabIndex = 6;
            // 
            // gonderiler
            // 
            this.gonderiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.göndkodu,
            this.göndurumu});
            this.gonderiler.HideSelection = false;
            this.gonderiler.Location = new System.Drawing.Point(405, 54);
            this.gonderiler.Name = "gonderiler";
            this.gonderiler.Size = new System.Drawing.Size(350, 338);
            this.gonderiler.TabIndex = 7;
            this.gonderiler.UseCompatibleStateImageBehavior = false;
            this.gonderiler.View = System.Windows.Forms.View.Details;
            // 
            // göndkodu
            // 
            this.göndkodu.Text = "GÖNDERİ KODU";
            this.göndkodu.Width = 117;
            // 
            // göndurumu
            // 
            this.göndurumu.Text = "GÖNDERİ DURUMU";
            this.göndurumu.Width = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "GÖNDERİ DURUMU GÜNCELLEME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "GÖNDERİ LİSTESİ";
            // 
            // gonlistele
            // 
            this.gonlistele.Location = new System.Drawing.Point(503, 412);
            this.gonlistele.Name = "gonlistele";
            this.gonlistele.Size = new System.Drawing.Size(158, 23);
            this.gonlistele.TabIndex = 5;
            this.gonlistele.Text = "GÖNDERİLERİ LİSTELE";
            this.gonlistele.UseVisualStyleBackColor = true;
            this.gonlistele.Click += new System.EventHandler(this.gonlistele_Click);
            // 
            // paneledon
            // 
            this.paneledon.Location = new System.Drawing.Point(280, 141);
            this.paneledon.Name = "paneledon";
            this.paneledon.Size = new System.Drawing.Size(89, 41);
            this.paneledon.TabIndex = 9;
            this.paneledon.Text = "PANELE DÖN";
            this.paneledon.UseVisualStyleBackColor = true;
            this.paneledon.Click += new System.EventHandler(this.paneledon_Click);
            // 
            // GonderiDurumGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneledon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gonderiler);
            this.Controls.Add(this.gonkodu);
            this.Controls.Add(this.gonlistele);
            this.Controls.Add(this.gondurumguncelle);
            this.Controls.Add(this.gondurum);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GonderiDurumGuncelle";
            this.Text = "GonderiDurumuGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox gondurum;
        private System.Windows.Forms.Button gondurumguncelle;
        private System.Windows.Forms.TextBox gonkodu;
        private System.Windows.Forms.ListView gonderiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gonlistele;
        private System.Windows.Forms.ColumnHeader göndkodu;
        private System.Windows.Forms.ColumnHeader göndurumu;
        private System.Windows.Forms.Button paneledon;
    }
}