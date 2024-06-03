namespace MeslekiProje
{
    partial class Gonderi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbboyut = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtgonmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgontel = new System.Windows.Forms.TextBox();
            this.txtgonadres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgonsoyad = new System.Windows.Forms.TextBox();
            this.txtgonad = new System.Windows.Forms.TextBox();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datagonderi = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagonderi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MeslekiProje.Properties.Resources.logo_kucuk;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(121, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gönderi Oluştur";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(445, 393);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(305, 41);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Gönderi Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(445, 337);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(305, 41);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "Gönderi Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(445, 282);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(305, 41);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Gönderi Oluştur";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtfiyat);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.cmbboyut);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(445, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fiyat Bilgileri";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(134, 100);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(132, 22);
            this.txtfiyat.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Fiyat:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ödeme:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gönderen Öder",
            "Alıcı Öder",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(134, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // cmbboyut
            // 
            this.cmbboyut.FormattingEnabled = true;
            this.cmbboyut.Items.AddRange(new object[] {
            "20x20",
            "50x50",
            "75x75",
            "100x100",
            "100x120",
            "250x250"});
            this.cmbboyut.Location = new System.Drawing.Point(134, 29);
            this.cmbboyut.Name = "cmbboyut";
            this.cmbboyut.Size = new System.Drawing.Size(132, 24);
            this.cmbboyut.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gönderi Boyutu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtadres);
            this.groupBox2.Controls.Add(this.txtmail);
            this.groupBox2.Controls.Add(this.txttel);
            this.groupBox2.Controls.Add(this.txtsoyad);
            this.groupBox2.Controls.Add(this.txtad);
            this.groupBox2.Controls.Add(this.txtgonmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtgontel);
            this.groupBox2.Controls.Add(this.txtgonadres);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtgonsoyad);
            this.groupBox2.Controls.Add(this.txtgonad);
            this.groupBox2.Controls.Add(this.txtkod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 413);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderi Bilgileri";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(186, 362);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(152, 22);
            this.txtadres.TabIndex = 23;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(186, 329);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(152, 22);
            this.txtmail.TabIndex = 22;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(186, 297);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(152, 22);
            this.txttel.TabIndex = 21;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(186, 263);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(152, 22);
            this.txtsoyad.TabIndex = 20;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(186, 230);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(152, 22);
            this.txtad.TabIndex = 19;
            // 
            // txtgonmail
            // 
            this.txtgonmail.Location = new System.Drawing.Point(186, 170);
            this.txtgonmail.Name = "txtgonmail";
            this.txtgonmail.Size = new System.Drawing.Size(152, 22);
            this.txtgonmail.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gönderen Maili:";
            // 
            // txtgontel
            // 
            this.txtgontel.Location = new System.Drawing.Point(186, 200);
            this.txtgontel.Name = "txtgontel";
            this.txtgontel.Size = new System.Drawing.Size(152, 22);
            this.txtgontel.TabIndex = 16;
            // 
            // txtgonadres
            // 
            this.txtgonadres.Location = new System.Drawing.Point(186, 136);
            this.txtgonadres.Name = "txtgonadres";
            this.txtgonadres.Size = new System.Drawing.Size(152, 22);
            this.txtgonadres.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gönderen Telefonu:";
            // 
            // txtgonsoyad
            // 
            this.txtgonsoyad.Location = new System.Drawing.Point(186, 97);
            this.txtgonsoyad.Name = "txtgonsoyad";
            this.txtgonsoyad.Size = new System.Drawing.Size(152, 22);
            this.txtgonsoyad.TabIndex = 15;
            // 
            // txtgonad
            // 
            this.txtgonad.Location = new System.Drawing.Point(186, 64);
            this.txtgonad.Name = "txtgonad";
            this.txtgonad.Size = new System.Drawing.Size(152, 22);
            this.txtgonad.TabIndex = 14;
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(186, 29);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(152, 22);
            this.txtkod.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alıcı Adresi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderi Kodu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Alıcı Maili:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Alıcı Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gönderen Adı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Alıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gönderen Soyadı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Alıcı Telefonu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gönderen Adresi:";
            // 
            // datagonderi
            // 
            this.datagonderi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagonderi.Location = new System.Drawing.Point(121, 15);
            this.datagonderi.Name = "datagonderi";
            this.datagonderi.Size = new System.Drawing.Size(773, 328);
            this.datagonderi.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(124, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Gönderi Listesi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MeslekiProje.Properties.Resources.cikis;
            this.pictureBox2.Location = new System.Drawing.Point(940, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Gonderi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 814);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.datagonderi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gonderi";
            this.Text = "Gonderi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagonderi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbboyut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtgonadres;
        private System.Windows.Forms.TextBox txtgonmail;
        private System.Windows.Forms.TextBox txtgontel;
        private System.Windows.Forms.TextBox txtgonsoyad;
        private System.Windows.Forms.TextBox txtgonad;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView datagonderi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}