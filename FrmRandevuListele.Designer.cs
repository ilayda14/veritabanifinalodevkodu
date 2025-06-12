namespace GuzellikMerkeziApp
{
    partial class FrmRandevuListele
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
            this.dgvRandevu = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevu
            // 
            this.dgvRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevu.Location = new System.Drawing.Point(0, 0);
            this.dgvRandevu.Name = "dgvRandevu";
            this.dgvRandevu.RowHeadersWidth = 51;
            this.dgvRandevu.RowTemplate.Height = 24;
            this.dgvRandevu.Size = new System.Drawing.Size(800, 450);
            this.dgvRandevu.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(591, 386);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(693, 386);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmRandevuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvRandevu);
            this.Name = "FrmRandevuListele";
            this.Text = "FrmRandevuListele";
            this.Load += new System.EventHandler(this.FrmRandevuListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevu;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}