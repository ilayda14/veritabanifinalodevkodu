namespace GuzellikMerkeziApp
{
    partial class FrmMusteriListe
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
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriler.Location = new System.Drawing.Point(0, 0);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RowHeadersWidth = 51;
            this.dgvMusteriler.RowTemplate.Height = 24;
            this.dgvMusteriler.Size = new System.Drawing.Size(800, 450);
            this.dgvMusteriler.TabIndex = 0;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(646, 318);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(112, 40);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(646, 375);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(112, 34);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmMusteriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dgvMusteriler);
            this.Name = "FrmMusteriListe";
            this.Text = "FrmMusteriListe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnKapat;
    }
}