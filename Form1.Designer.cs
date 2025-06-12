namespace GuzellikMerkeziApp
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
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.btnRandevuIslemleri = new System.Windows.Forms.Button();
            this.btnPersonelIslemleri = new System.Windows.Forms.Button();
            this.btnHizmetler = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.BackColor = System.Drawing.Color.LightBlue;
            this.btnMusteriIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriIslemleri.ForeColor = System.Drawing.Color.Navy;
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(52, 137);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(150, 50);
            this.btnMusteriIslemleri.TabIndex = 0;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = false;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnMusteriIslemleri_Click);
            // 
            // btnRandevuIslemleri
            // 
            this.btnRandevuIslemleri.BackColor = System.Drawing.Color.LightBlue;
            this.btnRandevuIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuIslemleri.ForeColor = System.Drawing.Color.Navy;
            this.btnRandevuIslemleri.Location = new System.Drawing.Point(319, 137);
            this.btnRandevuIslemleri.Name = "btnRandevuIslemleri";
            this.btnRandevuIslemleri.Size = new System.Drawing.Size(150, 50);
            this.btnRandevuIslemleri.TabIndex = 1;
            this.btnRandevuIslemleri.Text = "Randevu İşlemleri";
            this.btnRandevuIslemleri.UseVisualStyleBackColor = false;
            this.btnRandevuIslemleri.Click += new System.EventHandler(this.btnRandevuIslemleri_Click);
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.BackColor = System.Drawing.Color.LightBlue;
            this.btnPersonelIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelIslemleri.ForeColor = System.Drawing.Color.Navy;
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(602, 137);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(150, 50);
            this.btnPersonelIslemleri.TabIndex = 2;
            this.btnPersonelIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelIslemleri.UseVisualStyleBackColor = false;
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnHizmetler
            // 
            this.btnHizmetler.BackColor = System.Drawing.Color.LightBlue;
            this.btnHizmetler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetler.ForeColor = System.Drawing.Color.Navy;
            this.btnHizmetler.Location = new System.Drawing.Point(188, 277);
            this.btnHizmetler.Name = "btnHizmetler";
            this.btnHizmetler.Size = new System.Drawing.Size(150, 50);
            this.btnHizmetler.TabIndex = 3;
            this.btnHizmetler.Text = "Hizmetler";
            this.btnHizmetler.UseVisualStyleBackColor = false;
            this.btnHizmetler.Click += new System.EventHandler(this.btnHizmetler_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.BackColor = System.Drawing.Color.LightBlue;
            this.btnOdemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeler.ForeColor = System.Drawing.Color.Navy;
            this.btnOdemeler.Location = new System.Drawing.Point(465, 277);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(150, 50);
            this.btnOdemeler.TabIndex = 4;
            this.btnOdemeler.Text = "Ödemeler";
            this.btnOdemeler.UseVisualStyleBackColor = false;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(672, 370);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 50);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(209, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lady Güzellik Merkezi Yönetim Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOdemeler);
            this.Controls.Add(this.btnHizmetler);
            this.Controls.Add(this.btnPersonelIslemleri);
            this.Controls.Add(this.btnRandevuIslemleri);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button btnRandevuIslemleri;
        private System.Windows.Forms.Button btnPersonelIslemleri;
        private System.Windows.Forms.Button btnHizmetler;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
    }
}

