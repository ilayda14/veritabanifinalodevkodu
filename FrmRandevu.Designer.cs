namespace GuzellikMerkeziApp
{
    partial class FrmRandevu
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
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.txtRandevuAciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(12, 12);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 24);
            this.cmbMusteri.TabIndex = 0;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(12, 42);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(121, 24);
            this.cmbPersonel.TabIndex = 1;
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.FormattingEnabled = true;
            this.cmbHizmet.Location = new System.Drawing.Point(12, 72);
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(121, 24);
            this.cmbHizmet.TabIndex = 2;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(12, 136);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 3;
            // 
            // dtpSaat
            // 
            this.dtpSaat.CustomFormat = "HH:mm";
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaat.Location = new System.Drawing.Point(13, 165);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(200, 22);
            this.dtpSaat.TabIndex = 4;
            // 
            // txtRandevuAciklama
            // 
            this.txtRandevuAciklama.Location = new System.Drawing.Point(13, 215);
            this.txtRandevuAciklama.Name = "txtRandevuAciklama";
            this.txtRandevuAciklama.Size = new System.Drawing.Size(100, 22);
            this.txtRandevuAciklama.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(579, 415);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(672, 415);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtRandevuAciklama);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbHizmet);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.cmbMusteri);
            this.Name = "FrmRandevu";
            this.Text = "FrmRandevu";
            this.Load += new System.EventHandler(this.FrmRandevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.ComboBox cmbHizmet;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.TextBox txtRandevuAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
    }
}