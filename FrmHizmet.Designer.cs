namespace GuzellikMerkeziApp
{
    partial class FrmHizmet
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
            this.txtHizmetAciklama = new System.Windows.Forms.TextBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nudSure = new System.Windows.Forms.NumericUpDown();
            this.nudUcret = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUcret)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(13, 13);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Ad";
            // 
            // txtHizmetAciklama
            // 
            this.txtHizmetAciklama.Location = new System.Drawing.Point(13, 42);
            this.txtHizmetAciklama.Name = "txtHizmetAciklama";
            this.txtHizmetAciklama.Size = new System.Drawing.Size(100, 22);
            this.txtHizmetAciklama.TabIndex = 1;
            this.txtHizmetAciklama.Text = "Hizmet Açıklama";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(12, 135);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(78, 20);
            this.chkAktif.TabIndex = 2;
            this.chkAktif.Text = "Aktif mi?";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(38, 187);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nudSure
            // 
            this.nudSure.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSure.Location = new System.Drawing.Point(13, 70);
            this.nudSure.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudSure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSure.Name = "nudSure";
            this.nudSure.Size = new System.Drawing.Size(120, 22);
            this.nudSure.TabIndex = 4;
            this.nudSure.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudUcret
            // 
            this.nudUcret.DecimalPlaces = 2;
            this.nudUcret.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudUcret.Location = new System.Drawing.Point(13, 107);
            this.nudUcret.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUcret.Name = "nudUcret";
            this.nudUcret.Size = new System.Drawing.Size(120, 22);
            this.nudUcret.TabIndex = 5;
            this.nudUcret.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Label1.Text = \"Süre (dakika):\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Label2.Text = \"Ücret (₺):\"";
            // 
            // FrmHizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudUcret);
            this.Controls.Add(this.nudSure);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.txtHizmetAciklama);
            this.Controls.Add(this.txtAd);
            this.Name = "FrmHizmet";
            this.Text = "FrmHizmet";
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUcret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtHizmetAciklama;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nudSure;
        private System.Windows.Forms.NumericUpDown nudUcret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}