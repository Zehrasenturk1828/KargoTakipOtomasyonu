namespace MeslekiProje
{
    partial class Musteri
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtmusteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnkuladi = new System.Windows.Forms.Button();
            this.btnsifreuret = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkuladi = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmusteri)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MeslekiProje.Properties.Resources.logo_kucuk;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtmusteri
            // 
            this.dtmusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmusteri.Location = new System.Drawing.Point(129, 12);
            this.dtmusteri.Name = "dtmusteri";
            this.dtmusteri.Size = new System.Drawing.Size(592, 198);
            this.dtmusteri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Listesi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.btnkuladi);
            this.groupBox1.Controls.Add(this.btnsifreuret);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.txtkuladi);
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(129, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 417);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Oluştur";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(173, 194);
            this.txttel.Mask = "(999) 000-0000";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(131, 22);
            this.txttel.TabIndex = 24;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(381, 149);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(184, 39);
            this.btnsil.TabIndex = 23;
            this.btnsil.Text = "Müşteri Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(381, 89);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(184, 39);
            this.btnguncelle.TabIndex = 22;
            this.btnguncelle.Text = "Müşteri Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(381, 28);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(184, 39);
            this.btnekle.TabIndex = 21;
            this.btnekle.Text = "Müşteri Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnkuladi
            // 
            this.btnkuladi.Location = new System.Drawing.Point(21, 321);
            this.btnkuladi.Name = "btnkuladi";
            this.btnkuladi.Size = new System.Drawing.Size(131, 36);
            this.btnkuladi.TabIndex = 20;
            this.btnkuladi.Text = "Kullanıcı Adı Üret";
            this.btnkuladi.UseVisualStyleBackColor = true;
            this.btnkuladi.Click += new System.EventHandler(this.btnkuladi_Click);
            // 
            // btnsifreuret
            // 
            this.btnsifreuret.Location = new System.Drawing.Point(173, 321);
            this.btnsifreuret.Name = "btnsifreuret";
            this.btnsifreuret.Size = new System.Drawing.Size(131, 36);
            this.btnsifreuret.TabIndex = 19;
            this.btnsifreuret.Text = "Şifre Üret";
            this.btnsifreuret.UseVisualStyleBackColor = true;
            this.btnsifreuret.Click += new System.EventHandler(this.btnsifreuret_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(173, 275);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(131, 22);
            this.txtsifre.TabIndex = 17;
            // 
            // txtkuladi
            // 
            this.txtkuladi.Location = new System.Drawing.Point(173, 235);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(131, 22);
            this.txtkuladi.TabIndex = 16;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(173, 115);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(131, 22);
            this.txtadres.TabIndex = 15;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(173, 154);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(131, 22);
            this.txtmail.TabIndex = 14;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(173, 74);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(131, 22);
            this.txtsoyad.TabIndex = 11;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(173, 36);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(131, 22);
            this.txtad.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Şifre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kullanıcı Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Müşteri Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Müşteri Maili:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Müşteri Telefonu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Müşteri Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Müşteri Adı:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MeslekiProje.Properties.Resources.cikis;
            this.pictureBox3.Location = new System.Drawing.Point(773, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 682);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmusteri);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Musteri";
            this.Text = "Musteri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmusteri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtmusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnkuladi;
        private System.Windows.Forms.Button btnsifreuret;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkuladi;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MaskedTextBox txttel;
    }
}