namespace ndp_carpismalar
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txbx1 = new System.Windows.Forms.TextBox();
            this.txby1 = new System.Windows.Forms.TextBox();
            this.txbz1 = new System.Windows.Forms.TextBox();
            this.txbr1 = new System.Windows.Forms.TextBox();
            this.txbh1 = new System.Windows.Forms.TextBox();
            this.txbg1 = new System.Windows.Forms.TextBox();
            this.txbd1 = new System.Windows.Forms.TextBox();
            this.txbx2 = new System.Windows.Forms.TextBox();
            this.txby2 = new System.Windows.Forms.TextBox();
            this.txbz2 = new System.Windows.Forms.TextBox();
            this.txbr2 = new System.Windows.Forms.TextBox();
            this.txbh2 = new System.Windows.Forms.TextBox();
            this.txbg2 = new System.Windows.Forms.TextBox();
            this.txbd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "nokta-cember",
            "dikdörtgen-cember",
            "dikdörtgen-dikdörtgen",
            "çember-çember",
            "nokta-küre",
            "küre-küre",
            "nokta-dörtgen",
            "nokta-silindir",
            "silindir-silindir",
            "silindir-küre",
            "yüzey-küre",
            "yüzey-silindir",
            "dikdörtgenlerprizması-yüzey",
            "dikdörtgenlerprizması-küre",
            "dikdörtgenlerprizması-nokta",
            "dikdörtgenlerprizması-dikdörtgenlerprizması"});
            this.comboBox1.Location = new System.Drawing.Point(73, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbx1
            // 
            this.txbx1.Location = new System.Drawing.Point(42, 123);
            this.txbx1.Name = "txbx1";
            this.txbx1.Size = new System.Drawing.Size(25, 22);
            this.txbx1.TabIndex = 1;
            // 
            // txby1
            // 
            this.txby1.Location = new System.Drawing.Point(73, 123);
            this.txby1.Name = "txby1";
            this.txby1.Size = new System.Drawing.Size(28, 22);
            this.txby1.TabIndex = 2;
            // 
            // txbz1
            // 
            this.txbz1.Location = new System.Drawing.Point(107, 123);
            this.txbz1.Name = "txbz1";
            this.txbz1.Size = new System.Drawing.Size(35, 22);
            this.txbz1.TabIndex = 3;
            // 
            // txbr1
            // 
            this.txbr1.Location = new System.Drawing.Point(42, 191);
            this.txbr1.Name = "txbr1";
            this.txbr1.Size = new System.Drawing.Size(100, 22);
            this.txbr1.TabIndex = 4;
            // 
            // txbh1
            // 
            this.txbh1.Location = new System.Drawing.Point(42, 229);
            this.txbh1.Name = "txbh1";
            this.txbh1.Size = new System.Drawing.Size(100, 22);
            this.txbh1.TabIndex = 5;
            // 
            // txbg1
            // 
            this.txbg1.Location = new System.Drawing.Point(42, 272);
            this.txbg1.Name = "txbg1";
            this.txbg1.Size = new System.Drawing.Size(100, 22);
            this.txbg1.TabIndex = 6;
            // 
            // txbd1
            // 
            this.txbd1.Location = new System.Drawing.Point(42, 316);
            this.txbd1.Name = "txbd1";
            this.txbd1.Size = new System.Drawing.Size(100, 22);
            this.txbd1.TabIndex = 7;
            // 
            // txbx2
            // 
            this.txbx2.Location = new System.Drawing.Point(238, 122);
            this.txbx2.Name = "txbx2";
            this.txbx2.Size = new System.Drawing.Size(29, 22);
            this.txbx2.TabIndex = 8;
            // 
            // txby2
            // 
            this.txby2.Location = new System.Drawing.Point(273, 123);
            this.txby2.Name = "txby2";
            this.txby2.Size = new System.Drawing.Size(30, 22);
            this.txby2.TabIndex = 9;
            // 
            // txbz2
            // 
            this.txbz2.Location = new System.Drawing.Point(309, 123);
            this.txbz2.Name = "txbz2";
            this.txbz2.Size = new System.Drawing.Size(29, 22);
            this.txbz2.TabIndex = 10;
            // 
            // txbr2
            // 
            this.txbr2.Location = new System.Drawing.Point(236, 185);
            this.txbr2.Name = "txbr2";
            this.txbr2.Size = new System.Drawing.Size(100, 22);
            this.txbr2.TabIndex = 11;
            // 
            // txbh2
            // 
            this.txbh2.Location = new System.Drawing.Point(238, 228);
            this.txbh2.Name = "txbh2";
            this.txbh2.Size = new System.Drawing.Size(100, 22);
            this.txbh2.TabIndex = 12;
            // 
            // txbg2
            // 
            this.txbg2.Location = new System.Drawing.Point(238, 272);
            this.txbg2.Name = "txbg2";
            this.txbg2.Size = new System.Drawing.Size(100, 22);
            this.txbg2.TabIndex = 13;
            // 
            // txbd2
            // 
            this.txbd2.Location = new System.Drawing.Point(238, 316);
            this.txbd2.Name = "txbd2";
            this.txbd2.Size = new System.Drawing.Size(100, 22);
            this.txbd2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "yaricap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "uzunluk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "genişlik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "derinlik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "yaricap";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "uzunluk";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(237, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "genislik";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "derinlik";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(22, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 18);
            this.label15.TabIndex = 29;
            this.label15.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(394, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 22);
            this.label16.TabIndex = 30;
            this.label16.Text = ".";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(226, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 58);
            this.button1.TabIndex = 31;
            this.button1.Text = "basla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(703, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 698);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1466, 747);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbd2);
            this.Controls.Add(this.txbg2);
            this.Controls.Add(this.txbh2);
            this.Controls.Add(this.txbr2);
            this.Controls.Add(this.txbz2);
            this.Controls.Add(this.txby2);
            this.Controls.Add(this.txbx2);
            this.Controls.Add(this.txbd1);
            this.Controls.Add(this.txbg1);
            this.Controls.Add(this.txbh1);
            this.Controls.Add(this.txbr1);
            this.Controls.Add(this.txbz1);
            this.Controls.Add(this.txby1);
            this.Controls.Add(this.txbx1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txbx1;
        private System.Windows.Forms.TextBox txby1;
        private System.Windows.Forms.TextBox txbz1;
        private System.Windows.Forms.TextBox txbr1;
        private System.Windows.Forms.TextBox txbh1;
        private System.Windows.Forms.TextBox txbg1;
        private System.Windows.Forms.TextBox txbd1;
        private System.Windows.Forms.TextBox txbx2;
        private System.Windows.Forms.TextBox txby2;
        private System.Windows.Forms.TextBox txbz2;
        private System.Windows.Forms.TextBox txbr2;
        private System.Windows.Forms.TextBox txbh2;
        private System.Windows.Forms.TextBox txbg2;
        private System.Windows.Forms.TextBox txbd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

