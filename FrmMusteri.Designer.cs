namespace GuzellikMerkeziApp
{
    partial class FrmMusteri
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 12);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 22);
            this.txtIsim.TabIndex = 0;
            this.txtIsim.Text = "İsim";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(12, 68);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 1;
            this.txtTelefon.Text = "Telefon";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(12, 40);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.Text = "Soyad";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "E-posta";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(13, 126);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpDogumTarihi.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(13, 155);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet Butonu";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtIsim);
            this.Name = "FrmMusteri";
            this.Text = "FrmMusteri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnKaydet;
    }
}