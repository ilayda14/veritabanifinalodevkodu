namespace GuzellikMerkeziApp
{
    partial class FrmOdemeListele
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
            this.dgvOdeme = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnYeniOdeme = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdeme
            // 
            this.dgvOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdeme.Location = new System.Drawing.Point(0, 0);
            this.dgvOdeme.Name = "dgvOdeme";
            this.dgvOdeme.RowHeadersWidth = 51;
            this.dgvOdeme.RowTemplate.Height = 24;
            this.dgvOdeme.Size = new System.Drawing.Size(800, 450);
            this.dgvOdeme.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(12, 256);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(145, 24);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Ödeme Listesi";
            // 
            // btnYeniOdeme
            // 
            this.btnYeniOdeme.Location = new System.Drawing.Point(73, 311);
            this.btnYeniOdeme.Name = "btnYeniOdeme";
            this.btnYeniOdeme.Size = new System.Drawing.Size(112, 42);
            this.btnYeniOdeme.TabIndex = 2;
            this.btnYeniOdeme.Text = "Yeni Ödeme";
            this.btnYeniOdeme.UseVisualStyleBackColor = true;
            this.btnYeniOdeme.Click += new System.EventHandler(this.btnYeniOdeme_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(298, 311);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 41);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(516, 311);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(118, 41);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmOdemeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYeniOdeme);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvOdeme);
            this.Name = "FrmOdemeListele";
            this.Text = "FrmOdemeListele";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdeme;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnYeniOdeme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}