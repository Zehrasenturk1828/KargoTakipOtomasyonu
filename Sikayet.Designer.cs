namespace MeslekiProje
{
    partial class Sikayet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsikayet = new System.Windows.Forms.Button();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsikayet = new System.Windows.Forms.RichTextBox();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngeribildirim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgeribildirim = new System.Windows.Forms.RichTextBox();
            this.txtgerikonu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsikayet);
            this.groupBox1.Controls.Add(this.txtkonu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsikayet);
            this.groupBox1.Controls.Add(this.txtkod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(103, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(404, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teslimat Şikayeti";
            // 
            // btnsikayet
            // 
            this.btnsikayet.Location = new System.Drawing.Point(35, 325);
            this.btnsikayet.Name = "btnsikayet";
            this.btnsikayet.Size = new System.Drawing.Size(320, 38);
            this.btnsikayet.TabIndex = 6;
            this.btnsikayet.Text = "Şikayet Bildir";
            this.btnsikayet.UseVisualStyleBackColor = true;
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(183, 103);
            this.txtkonu.Margin = new System.Windows.Forms.Padding(4);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(172, 22);
            this.txtkonu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şikayetiniz:";
            // 
            // txtsikayet
            // 
            this.txtsikayet.Location = new System.Drawing.Point(35, 174);
            this.txtsikayet.Margin = new System.Windows.Forms.Padding(4);
            this.txtsikayet.Name = "txtsikayet";
            this.txtsikayet.Size = new System.Drawing.Size(320, 126);
            this.txtsikayet.TabIndex = 2;
            this.txtsikayet.Text = "";
            this.txtsikayet.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(183, 53);
            this.txtkod.Margin = new System.Windows.Forms.Padding(4);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(172, 22);
            this.txtkod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderi Kodu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btngeribildirim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtgeribildirim);
            this.groupBox2.Controls.Add(this.txtgerikonu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(570, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mesaj ve Geri Bildirim";
            // 
            // btngeribildirim
            // 
            this.btngeribildirim.Location = new System.Drawing.Point(51, 325);
            this.btngeribildirim.Name = "btngeribildirim";
            this.btngeribildirim.Size = new System.Drawing.Size(320, 38);
            this.btngeribildirim.TabIndex = 10;
            this.btngeribildirim.Text = "Geri Bildirim";
            this.btngeribildirim.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şikayetiniz:";
            // 
            // txtgeribildirim
            // 
            this.txtgeribildirim.Location = new System.Drawing.Point(51, 174);
            this.txtgeribildirim.Margin = new System.Windows.Forms.Padding(4);
            this.txtgeribildirim.Name = "txtgeribildirim";
            this.txtgeribildirim.Size = new System.Drawing.Size(320, 126);
            this.txtgeribildirim.TabIndex = 8;
            this.txtgeribildirim.Text = "";
            // 
            // txtgerikonu
            // 
            this.txtgerikonu.Location = new System.Drawing.Point(199, 54);
            this.txtgerikonu.Margin = new System.Windows.Forms.Padding(4);
            this.txtgerikonu.Name = "txtgerikonu";
            this.txtgerikonu.Size = new System.Drawing.Size(172, 22);
            this.txtgerikonu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Konu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MeslekiProje.Properties.Resources.logo_kucuk;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(412, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bizi Arayabilirsiniz: 0212-881-54-56";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MeslekiProje.Properties.Resources.cikis;
            this.pictureBox3.Location = new System.Drawing.Point(1033, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Sikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 476);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sikayet";
            this.Text = "Sikayet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtsikayet;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsikayet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngeribildirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtgeribildirim;
        private System.Windows.Forms.TextBox txtgerikonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}