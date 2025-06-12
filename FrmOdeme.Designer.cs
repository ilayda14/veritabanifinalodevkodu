namespace GuzellikMerkeziApp
{
    partial class FrmOdeme
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
            this.cmbRandevu = new System.Windows.Forms.ComboBox();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRandevu
            // 
            this.cmbRandevu.FormattingEnabled = true;
            this.cmbRandevu.Location = new System.Drawing.Point(12, 12);
            this.cmbRandevu.Name = "cmbRandevu";
            this.cmbRandevu.Size = new System.Drawing.Size(121, 24);
            this.cmbRandevu.TabIndex = 0;
            this.cmbRandevu.Text = "Randevu";
            // 
            // nudTutar
            // 
            this.nudTutar.Location = new System.Drawing.Point(12, 105);
            this.nudTutar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(120, 22);
            this.nudTutar.TabIndex = 1;
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Location = new System.Drawing.Point(12, 180);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbOdemeTuru.TabIndex = 2;
            this.cmbOdemeTuru.Text = "Ödeme Türü";
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // dtpOdemeTarihi
            // 
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(12, 262);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpOdemeTarihi.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(137, 357);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpOdemeTarihi);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.nudTutar);
            this.Controls.Add(this.cmbRandevu);
            this.Name = "FrmOdeme";
            this.Text = "FrmOdemeler";
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRandevu;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        private System.Windows.Forms.Button btnKaydet;
    }
}