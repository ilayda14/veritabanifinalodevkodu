namespace GuzellikMerkeziApp
{
    partial class FrmHizmetListele
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
            this.dgvHizmet = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHizmet
            // 
            this.dgvHizmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHizmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHizmet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHizmet.Location = new System.Drawing.Point(0, 0);
            this.dgvHizmet.Name = "dgvHizmet";
            this.dgvHizmet.ReadOnly = true;
            this.dgvHizmet.RowHeadersWidth = 51;
            this.dgvHizmet.RowTemplate.Height = 24;
            this.dgvHizmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHizmet.Size = new System.Drawing.Size(800, 450);
            this.dgvHizmet.TabIndex = 0;
            this.dgvHizmet.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(664, 284);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(664, 345);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(664, 235);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmHizmetListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvHizmet);
            this.Name = "FrmHizmetListele";
            this.Text = "FrmHizmetListele";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHizmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHizmet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}