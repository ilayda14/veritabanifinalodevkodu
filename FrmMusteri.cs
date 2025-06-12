using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmMusteri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");

        // Liste formunun referansı (set edilecek)
        public FrmMusteriListe MusteriListeFormu { get; set; }

        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIsim.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDogumTarihi.Value > DateTime.Now)
            {
                MessageBox.Show("Doğum tarihi gelecekte olamaz.", "Geçersiz Tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();

                string sorgu = "INSERT INTO Musteri (Ad, Soyad, Telefon, Eposta, DogumTarihi) " +
                               "VALUES (@Ad, @Soyad, @Telefon, @Eposta, @DogumTarihi)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Ad", txtIsim.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Eposta", txtEmail.Text);
                komut.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value);

                komut.ExecuteNonQuery();

                MessageBox.Show("Müşteri kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Liste güncellensin
                MusteriListeFormu?.MusteriListesiGetir();

                // Formu kapat
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}
