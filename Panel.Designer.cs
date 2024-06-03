namespace MeslekiProje
{
    partial class Panel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbdurum = new System.Windows.Forms.ComboBox();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsikayet = new System.Windows.Forms.Button();
            this.btnmusteri = new System.Windows.Forms.Button();
            this.btngonderi = new System.Windows.Forms.Button();
            this.dtgonderi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsube = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgonderi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbdurum);
            this.groupBox2.Controls.Add(this.txtkod);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(121, 264);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(322, 174);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderi Durumu Güncelle";
            // 
            // cmbdurum
            // 
            this.cmbdurum.FormattingEnabled = true;
            this.cmbdurum.Items.AddRange(new object[] {
            "Teslim Alındı",
            "Dağıtım Şubesinde",
            "Dağıtımda ",
            "Teslim Edildi"});
            this.cmbdurum.Location = new System.Drawing.Point(124, 86);
            this.cmbdurum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdurum.Name = "cmbdurum";
            this.cmbdurum.Size = new System.Drawing.Size(163, 24);
            this.cmbdurum.TabIndex = 4;
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(124, 43);
            this.txtkod.Margin = new System.Windows.Forms.Padding(4);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(163, 22);
            this.txtkod.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Durum Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Durum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gönderi Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gönderi Listesi";
            // 
            // btnsikayet
            // 
            this.btnsikayet.Location = new System.Drawing.Point(880, 61);
            this.btnsikayet.Margin = new System.Windows.Forms.Padding(5);
            this.btnsikayet.Name = "btnsikayet";
            this.btnsikayet.Size = new System.Drawing.Size(222, 99);
            this.btnsikayet.TabIndex = 2;
            this.btnsikayet.Text = "Şikayet ve Geri Bildirim Listesi";
            this.btnsikayet.UseVisualStyleBackColor = true;
            // 
            // btnmusteri
            // 
            this.btnmusteri.Location = new System.Drawing.Point(596, 61);
            this.btnmusteri.Margin = new System.Windows.Forms.Padding(5);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(222, 99);
            this.btnmusteri.TabIndex = 1;
            this.btnmusteri.Text = "Müşteri Oluştur";
            this.btnmusteri.UseVisualStyleBackColor = true;
            // 
            // btngonderi
            // 
            this.btngonderi.Location = new System.Drawing.Point(31, 61);
            this.btngonderi.Margin = new System.Windows.Forms.Padding(5);
            this.btngonderi.Name = "btngonderi";
            this.btngonderi.Size = new System.Drawing.Size(222, 99);
            this.btngonderi.TabIndex = 3;
            this.btngonderi.Text = "Gönderi Oluştur";
            this.btngonderi.UseVisualStyleBackColor = true;
            // 
            // dtgonderi
            // 
            this.dtgonderi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgonderi.Location = new System.Drawing.Point(470, 264);
            this.dtgonderi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgonderi.Name = "dtgonderi";
            this.dtgonderi.Size = new System.Drawing.Size(790, 263);
            this.dtgonderi.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsube);
            this.groupBox1.Controls.Add(this.btngonderi);
            this.groupBox1.Controls.Add(this.btnsikayet);
            this.groupBox1.Controls.Add(this.btnmusteri);
            this.groupBox1.Location = new System.Drawing.Point(121, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1139, 211);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Paneli";
            // 
            // btnsube
            // 
            this.btnsube.Location = new System.Drawing.Point(311, 61);
            this.btnsube.Margin = new System.Windows.Forms.Padding(5);
            this.btnsube.Name = "btnsube";
            this.btnsube.Size = new System.Drawing.Size(222, 99);
            this.btnsube.TabIndex = 4;
            this.btnsube.Text = "Şube Oluştur";
            this.btnsube.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MeslekiProje.Properties.Resources.logo_kucuk;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MeslekiProje.Properties.Resources.cikis;
            this.pictureBox2.Location = new System.Drawing.Point(1312, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgonderi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Panel";
            this.Text = "Panel";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgonderi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbdurum;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsikayet;
        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.Button btngonderi;
        private System.Windows.Forms.DataGridView dtgonderi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsube;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}