namespace KargoTakipOtomasyonu
{
    partial class SubeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubeIslemleri));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subegoster = new System.Windows.Forms.Button();
            this.subeler = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsubeadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paneledon = new System.Windows.Forms.Button();
            this.subeid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subeadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subeadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subetelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ŞUBE SORGULAMA";
            // 
            // subegoster
            // 
            this.subegoster.Location = new System.Drawing.Point(129, 73);
            this.subegoster.Name = "subegoster";
            this.subegoster.Size = new System.Drawing.Size(87, 43);
            this.subegoster.TabIndex = 6;
            this.subegoster.Text = "ŞUBE GÖSTER";
            this.subegoster.UseVisualStyleBackColor = true;
            this.subegoster.Click += new System.EventHandler(this.subegoster_Click);
            // 
            // subeler
            // 
            this.subeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subeid,
            this.subeadi,
            this.subeadres,
            this.subetelefon});
            this.subeler.HideSelection = false;
            this.subeler.Location = new System.Drawing.Point(356, 47);
            this.subeler.Name = "subeler";
            this.subeler.Size = new System.Drawing.Size(332, 296);
            this.subeler.TabIndex = 7;
            this.subeler.UseCompatibleStateImageBehavior = false;
            this.subeler.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ŞUBELER";
            // 
            // txtsubeadi
            // 
            this.txtsubeadi.Location = new System.Drawing.Point(192, 47);
            this.txtsubeadi.Name = "txtsubeadi";
            this.txtsubeadi.Size = new System.Drawing.Size(143, 20);
            this.txtsubeadi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ŞUBE ADI:";
            // 
            // paneledon
            // 
            this.paneledon.Location = new System.Drawing.Point(236, 74);
            this.paneledon.Name = "paneledon";
            this.paneledon.Size = new System.Drawing.Size(99, 42);
            this.paneledon.TabIndex = 11;
            this.paneledon.Text = "PANELE DÖN";
            this.paneledon.UseVisualStyleBackColor = true;
            this.paneledon.Click += new System.EventHandler(this.paneledon_Click);
            // 
            // subeid
            // 
            this.subeid.Text = "ID";
            // 
            // subeadi
            // 
            this.subeadi.Text = "ŞUBE ADI";
            this.subeadi.Width = 84;
            // 
            // subeadres
            // 
            this.subeadres.Text = "ŞUBE ADRES";
            this.subeadres.Width = 93;
            // 
            // subetelefon
            // 
            this.subetelefon.Text = "ŞUBE TELEFON";
            this.subetelefon.Width = 108;
            // 
            // SubeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.paneledon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsubeadi);
            this.Controls.Add(this.subeler);
            this.Controls.Add(this.subegoster);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SubeIslemleri";
            this.Text = "SubeIslemleri";
            this.Load += new System.EventHandler(this.SubeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subegoster;
        private System.Windows.Forms.ListView subeler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsubeadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button paneledon;
        private System.Windows.Forms.ColumnHeader subeid;
        private System.Windows.Forms.ColumnHeader subeadi;
        private System.Windows.Forms.ColumnHeader subeadres;
        private System.Windows.Forms.ColumnHeader subetelefon;
    }
}