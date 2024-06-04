namespace KargoTakipOtomasyonu
{
    partial class GonderiDurumSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GonderiDurumSorgula));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gonderiler = new System.Windows.Forms.ListView();
            this.kod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gonkodu = new System.Windows.Forms.TextBox();
            this.gondurumsorgula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneledon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "GÖNDERİ LİSTESİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "GÖNDERİ DURUMU SORGULA";
            // 
            // gonderiler
            // 
            this.gonderiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kod,
            this.durum});
            this.gonderiler.HideSelection = false;
            this.gonderiler.Location = new System.Drawing.Point(426, 60);
            this.gonderiler.Name = "gonderiler";
            this.gonderiler.Size = new System.Drawing.Size(350, 338);
            this.gonderiler.TabIndex = 14;
            this.gonderiler.UseCompatibleStateImageBehavior = false;
            this.gonderiler.View = System.Windows.Forms.View.Details;
            // 
            // kod
            // 
            this.kod.Text = "GÖNDERİ KODU";
            // 
            // durum
            // 
            this.durum.Text = "GÖNDERİ DURUM";
            // 
            // gonkodu
            // 
            this.gonkodu.Location = new System.Drawing.Point(208, 60);
            this.gonkodu.Name = "gonkodu";
            this.gonkodu.Size = new System.Drawing.Size(161, 20);
            this.gonkodu.TabIndex = 13;
            // 
            // gondurumsorgula
            // 
            this.gondurumsorgula.Location = new System.Drawing.Point(208, 97);
            this.gondurumsorgula.Name = "gondurumsorgula";
            this.gondurumsorgula.Size = new System.Drawing.Size(75, 40);
            this.gondurumsorgula.TabIndex = 12;
            this.gondurumsorgula.Text = "SORGULA";
            this.gondurumsorgula.UseVisualStyleBackColor = true;
            this.gondurumsorgula.Click += new System.EventHandler(this.gondurumsorgula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // paneledon
            // 
            this.paneledon.Location = new System.Drawing.Point(289, 97);
            this.paneledon.Name = "paneledon";
            this.paneledon.Size = new System.Drawing.Size(75, 40);
            this.paneledon.TabIndex = 17;
            this.paneledon.Text = "PANELE DÖN";
            this.paneledon.UseVisualStyleBackColor = true;
            this.paneledon.Click += new System.EventHandler(this.paneledon_Click);
            // 
            // GonderiDurumSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneledon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gonderiler);
            this.Controls.Add(this.gonkodu);
            this.Controls.Add(this.gondurumsorgula);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GonderiDurumSorgula";
            this.Text = "GonderiDurumSorgula";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView gonderiler;
        private System.Windows.Forms.TextBox gonkodu;
        private System.Windows.Forms.Button gondurumsorgula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader kod;
        private System.Windows.Forms.ColumnHeader durum;
        private System.Windows.Forms.Button paneledon;
    }
}