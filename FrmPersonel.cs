using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmPersonel : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True";
        private int? personelID = null;

        public FrmPersonel()
        {
            InitializeComponent();
        }

        public FrmPersonel(int personelID) : this()
        {
            this.personelID = personelID;
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            if (personelID.HasValue)
                PersonelBilgileriniGetir(personelID.Value);
        }

        private void PersonelBilgileriniGetir(int id)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM Personel WHERE PersonelID = @ID", baglanti);
                    komut.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtAd.Text = dr["Ad"].ToString();
                            txtSoyad.Text = dr["Soyad"].ToString();
                            txtTelefon.Text = dr["Telefon"].ToString();
                            txtEposta.Text = dr["Eposta"].ToString();
                            txtUzmanlik.Text = dr["UzmanlikAlani"].ToString();

                            if (dr["IseBaslamaTarihi"] != DBNull.Value)
                                dtpIseBaslama.Value = Convert.ToDateTime(dr["IseBaslamaTarihi"]);
                            else
                                dtpIseBaslama.Checked = false;

                            chkAktif.Checked = Convert.ToBoolean(dr["Aktif"]);
                        }
                        else
                        {
                            MessageBox.Show("Personel bulunamadı.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel bilgileri getirilirken hata: " + ex.Message);
            }
        }

        private bool EmailGecerliMi(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true;
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
                    throw new Exception("Ad ve Soyad boş geçilemez.");

                if (!EmailGecerliMi(txtEposta.Text))
                {
                    MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
                    return;
                }

                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    SqlCommand komut;

                    if (!personelID.HasValue)
                    {
                        komut = new SqlCommand(@"INSERT INTO Personel 
                            (Ad, Soyad, Telefon, Eposta, UzmanlikAlani, IseBaslamaTarihi, Aktif) 
                            VALUES 
                            (@Ad, @Soyad, @Telefon, @Eposta, @UzmanlikAlani, @IseBaslamaTarihi, @Aktif)", baglanti);
                    }
                    else
                    {
                        komut = new SqlCommand(@"UPDATE Personel SET 
                            Ad=@Ad, Soyad=@Soyad, Telefon=@Telefon, Eposta=@Eposta, 
                            UzmanlikAlani=@UzmanlikAlani, IseBaslamaTarihi=@IseBaslamaTarihi, Aktif=@Aktif 
                            WHERE PersonelID=@ID", baglanti);
                        komut.Parameters.AddWithValue("@ID", personelID.Value);
                    }

                    komut.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                    komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                    komut.Parameters.AddWithValue("@Telefon", string.IsNullOrWhiteSpace(txtTelefon.Text) ? DBNull.Value : (object)txtTelefon.Text.Trim());
                    komut.Parameters.AddWithValue("@Eposta", string.IsNullOrWhiteSpace(txtEposta.Text) ? DBNull.Value : (object)txtEposta.Text.Trim());
                    komut.Parameters.AddWithValue("@UzmanlikAlani", string.IsNullOrWhiteSpace(txtUzmanlik.Text) ? DBNull.Value : (object)txtUzmanlik.Text.Trim());

                    if (dtpIseBaslama.Checked)
                        komut.Parameters.AddWithValue("@IseBaslamaTarihi", dtpIseBaslama.Value.Date);
                    else
                        komut.Parameters.AddWithValue("@IseBaslamaTarihi", DBNull.Value);

                    komut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Personel kaydedildi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında hata: " + ex.Message);
            }
        }
    }
}
