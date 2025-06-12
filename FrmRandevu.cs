using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmRandevu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");
        private int? randevuID = null; 

        public FrmRandevu()
        {
            InitializeComponent();
        }

        public FrmRandevu(int randevuID) : this()
        {
            this.randevuID = randevuID;
        }

        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            MusterileriYukle();
            PersonelleriYukle();
            HizmetleriYukle();

            if (randevuID != null)
                RandevuBilgileriniGetir(randevuID.Value);
        }

        private void MusterileriYukle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT MusteriID, Ad + ' ' + Soyad AS AdSoyad FROM Musteri", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                cmbMusteri.Items.Clear();
                while (dr.Read())
                {
                    cmbMusteri.Items.Add(new ComboBoxItem(dr["AdSoyad"].ToString(), dr["MusteriID"].ToString()));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler yüklenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void PersonelleriYukle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT PersonelID, Ad + ' ' + Soyad AS AdSoyad FROM Personel", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                cmbPersonel.Items.Clear();
                while (dr.Read())
                {
                    cmbPersonel.Items.Add(new ComboBoxItem(dr["AdSoyad"].ToString(), dr["PersonelID"].ToString()));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personeller yüklenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void HizmetleriYukle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT HizmetID, Ad FROM Hizmet", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                cmbHizmet.Items.Clear();
                while (dr.Read())
                {
                    cmbHizmet.Items.Add(new ComboBoxItem(dr["Ad"].ToString(), dr["HizmetID"].ToString()));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmetler yüklenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void RandevuBilgileriniGetir(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Randevu WHERE RandevuID = @ID", baglanti);
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    SelectComboBoxItemByValue(cmbMusteri, dr["MusteriID"].ToString());
                    SelectComboBoxItemByValue(cmbPersonel, dr["PersonelID"].ToString());
                    SelectComboBoxItemByValue(cmbHizmet, dr["HizmetID"].ToString());
                    dtpTarih.Value = Convert.ToDateTime(dr["Tarih"]);
                    dtpSaat.Value = DateTime.Today.Add((TimeSpan)dr["Saat"]);
                    txtRandevuAciklama.Text = dr["RandevuAciklama"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu bilgileri getirilirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void SelectComboBoxItemByValue(ComboBox comboBox, string value)
        {
            foreach (ComboBoxItem item in comboBox.Items)
            {
                if (item.Value == value)
                {
                    comboBox.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMusteri.SelectedItem == null || cmbPersonel.SelectedItem == null || cmbHizmet.SelectedItem == null)
                    throw new Exception("Lütfen müşteri, personel ve hizmet seçiniz.");

                string musteriID = ((ComboBoxItem)cmbMusteri.SelectedItem).Value;
                string personelID = ((ComboBoxItem)cmbPersonel.SelectedItem).Value;
                string hizmetID = ((ComboBoxItem)cmbHizmet.SelectedItem).Value;
                string aciklama = txtRandevuAciklama.Text.Trim();

                baglanti.Open();

                SqlCommand komut;

                if (randevuID == null)
                {
                    komut = new SqlCommand(@"INSERT INTO Randevu (MusteriID, PersonelID, HizmetID, Tarih, Saat, RandevuAciklama)
                                             VALUES (@MusteriID, @PersonelID, @HizmetID, @Tarih, @Saat, @Aciklama)", baglanti);
                }
                else
                {
                    komut = new SqlCommand(@"UPDATE Randevu 
                                             SET MusteriID = @MusteriID, PersonelID = @PersonelID, HizmetID = @HizmetID,
                                                 Tarih = @Tarih, Saat = @Saat, RandevuAciklama = @Aciklama
                                             WHERE RandevuID = @RandevuID", baglanti);
                    komut.Parameters.AddWithValue("@RandevuID", randevuID.Value);
                }

                komut.Parameters.AddWithValue("@MusteriID", musteriID);
                komut.Parameters.AddWithValue("@PersonelID", personelID);
                komut.Parameters.AddWithValue("@HizmetID", hizmetID);
                komut.Parameters.AddWithValue("@Tarih", dtpTarih.Value.Date);
                komut.Parameters.AddWithValue("@Saat", dtpSaat.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@Aciklama", aciklama);

                komut.ExecuteNonQuery();

                MessageBox.Show(randevuID == null ? "Randevu başarıyla kaydedildi." : "Randevu başarıyla güncellendi.");
                this.Close();
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

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
