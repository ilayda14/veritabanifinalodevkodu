namespace GuzellikMerkeziApp
{
    partial class FrmPersonel
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.dtpIseBaslama = new System.Windows.Forms.DateTimePicker();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(12, 40);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "Soyad";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(12, 68);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.Text = "Telefon";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(12, 96);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 22);
            this.txtEposta.TabIndex = 3;
            this.txtEposta.Text = "E-posta";
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(13, 125);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(100, 22);
            this.txtUzmanlik.TabIndex = 4;
            this.txtUzmanlik.Text = "Uzmanlık Alanı";
            // 
            // dtpIseBaslama
            // 
            this.dtpIseBaslama.Location = new System.Drawing.Point(12, 154);
            this.dtpIseBaslama.Name = "dtpIseBaslama";
            this.dtpIseBaslama.Size = new System.Drawing.Size(200, 22);
            this.dtpIseBaslama.TabIndex = 5;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(13, 183);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(78, 20);
            this.chkAktif.TabIndex = 6;
            this.chkAktif.Text = "Aktif mi?";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(137, 234);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.dtpIseBaslama);
            this.Controls.Add(this.txtUzmanlik);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.DateTimePicker dtpIseBaslama;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnKaydet;
    }
}