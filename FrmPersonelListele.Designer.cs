namespace GuzellikMerkeziApp
{
    partial class FrmPersonelListele
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
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonel.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.Size = new System.Drawing.Size(800, 450);
            this.dgvPersonel.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(292, 306);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(179, 46);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(561, 306);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 46);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(49, 306);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(178, 45);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Yeni Personel Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvPersonel);
            this.Name = "FrmPersonelListele";
            this.Text = "FrmPersonelListele";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}