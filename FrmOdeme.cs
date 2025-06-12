using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmOdeme : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");
        private int? odemeID = null;

        public FrmOdeme()
        {
            InitializeComponent();
            this.Load += FrmOdeme_Load;
        }

        public FrmOdeme(int odemeID) : this()
        {
            this.odemeID = odemeID;
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            cmbOdemeTuru.Items.Clear();
            cmbOdemeTuru.Items.AddRange(new string[] { "Nakit", "Kredi Kartı", "Banka Kartı", "Havale/EFT", "Diğer" });
            cmbOdemeTuru.DropDownStyle = ComboBoxStyle.DropDownList;

            RandevulariGetir();

            if (odemeID != null)
                OdemeBilgileriniGetir(odemeID.Value);
        }

        private void RandevulariGetir()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(@"
            SELECT r.RandevuID, 
                   m.Ad + ' ' + m.Soyad + ' - ' + CONVERT(varchar, r.Tarih, 103) + ' ' + CONVERT(varchar, r.Saat, 8) AS RandevuDetay
            FROM Randevu r
            INNER JOIN Musteri m ON r.MusteriID = m.MusteriID
            WHERE r.RandevuID NOT IN (SELECT RandevuID FROM Odeme)
            ORDER BY r.Tarih DESC, r.Saat DESC", baglanti);

                SqlDataReader dr = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbRandevu.DisplayMember = "RandevuDetay";
                cmbRandevu.ValueMember = "RandevuID";
                cmbRandevu.DataSource = dt;

                if (cmbRandevu.Items.Count > 0)
                    cmbRandevu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular getirilirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void OdemeBilgileriniGetir(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Odeme WHERE OdemeID = @ID", baglanti);
                komut.Parameters.AddWithValue("@ID", id);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    cmbRandevu.SelectedValue = Convert.ToInt32(dr["RandevuID"]);
                    nudTutar.Value = Convert.ToDecimal(dr["Tutar"]);
                    cmbOdemeTuru.Text = dr["OdemeTuru"].ToString();
                    dtpOdemeTarihi.Value = Convert.ToDateTime(dr["OdemeTarihi"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme bilgileri getirilirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRandevu.SelectedValue == null)
                    throw new Exception("Lütfen bir randevu seçin.");

                if (nudTutar.Value <= 0)
                    throw new Exception("Tutar 0'dan büyük olmalıdır.");

                if (string.IsNullOrEmpty(cmbOdemeTuru.Text))
                    throw new Exception("Lütfen ödeme türünü seçin.");

                baglanti.Open();
                SqlCommand komut;

                if (odemeID == null)
                {
                    komut = new SqlCommand(@"INSERT INTO Odeme (RandevuID, Tutar, OdemeTuru, OdemeTarihi) 
                                             VALUES (@RandevuID, @Tutar, @OdemeTuru, @OdemeTarihi)", baglanti);
                }
                else
                {
                    komut = new SqlCommand(@"UPDATE Odeme SET 
                                                RandevuID = @RandevuID,
                                                Tutar = @Tutar,
                                                OdemeTuru = @OdemeTuru,
                                                OdemeTarihi = @OdemeTarihi
                                            WHERE OdemeID = @ID", baglanti);
                    komut.Parameters.AddWithValue("@ID", odemeID.Value);
                }

                komut.Parameters.AddWithValue("@RandevuID", (int)cmbRandevu.SelectedValue);
                komut.Parameters.AddWithValue("@Tutar", nudTutar.Value);
                komut.Parameters.AddWithValue("@OdemeTuru", cmbOdemeTuru.Text);
                komut.Parameters.AddWithValue("@OdemeTarihi", dtpOdemeTarihi.Value.Date);

                komut.ExecuteNonQuery();

                MessageBox.Show(odemeID == null ? "Ödeme kaydedildi." : "Ödeme güncellendi.");
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

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
