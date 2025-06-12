using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmGiris : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '●';
            this.AcceptButton = btnGiris;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                lblDurum.Text = "Lütfen tüm alanları doldurun.";
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @ad AND Sifre = @sifre", baglanti);
                komut.Parameters.AddWithValue("@ad", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);

                int sonuc = (int)komut.ExecuteScalar();

                if (sonuc > 0)
                {
                    this.DialogResult = DialogResult.OK; 
                    this.Close(); 
                }
                else
                {
                    lblDurum.Text = "Hatalı kullanıcı adı veya şifre.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                lblDurum.Text = "Lütfen tüm alanları doldurun.";
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @ad AND Sifre = @sifre", baglanti);
                komut.Parameters.AddWithValue("@ad", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);

                int sonuc = (int)komut.ExecuteScalar();

                if (sonuc > 0)
                {
                    this.DialogResult = DialogResult.OK;  
                    this.Close();  
                }
                else
                {
                    lblDurum.Text = "Hatalı kullanıcı adı veya şifre.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

    }
}

