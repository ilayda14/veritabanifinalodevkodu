using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmHizmet : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");
        private int? hizmetID = null;

        public FrmHizmet()
        {
            InitializeComponent();
        }

        public FrmHizmet(int hizmetID) : this()
        {
            this.hizmetID = hizmetID;
        }

        private void FrmHizmet_Load(object sender, EventArgs e)
        {
            if (hizmetID != null)
                HizmetBilgileriniGetir(hizmetID.Value);
        }

        private void HizmetBilgileriniGetir(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Hizmet WHERE HizmetID = @ID", baglanti);
                komut.Parameters.AddWithValue("@ID", id);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    txtAd.Text = dr["Ad"].ToString();
                    txtHizmetAciklama.Text = dr["HizmetAciklama"].ToString();
                    nudSure.Value = dr["SureDakika"] != DBNull.Value ? Convert.ToInt32(dr["SureDakika"]) : 0;
                    nudUcret.Value = dr["Ucret"] != DBNull.Value ? Convert.ToDecimal(dr["Ucret"]) : 0;
                    chkAktif.Checked = dr["Aktif"] != DBNull.Value ? Convert.ToBoolean(dr["Aktif"]) : false;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmet bilgileri getirilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(txtAd.Text))
                {
                    MessageBox.Show("Hizmet adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                baglanti.Open();
                SqlCommand komut;

                if (hizmetID == null)
                {
                    komut = new SqlCommand(@"INSERT INTO Hizmet (Ad, HizmetAciklama, SureDakika, Ucret, Aktif) 
                                             VALUES (@Ad, @Aciklama, @Sure, @Ucret, @Aktif)", baglanti);
                }
                else
                {
                    komut = new SqlCommand(@"UPDATE Hizmet SET Ad = @Ad, HizmetAciklama = @Aciklama, 
                                             SureDakika = @Sure, Ucret = @Ucret, Aktif = @Aktif 
                                             WHERE HizmetID = @ID", baglanti);
                    komut.Parameters.AddWithValue("@ID", hizmetID.Value);
                }

                komut.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                komut.Parameters.AddWithValue("@Aciklama", txtHizmetAciklama.Text.Trim());
                komut.Parameters.AddWithValue("@Sure", (int)nudSure.Value);
                komut.Parameters.AddWithValue("@Ucret", nudUcret.Value);
                komut.Parameters.AddWithValue("@Aktif", chkAktif.Checked);

                komut.ExecuteNonQuery();

                MessageBox.Show(hizmetID == null ? "Hizmet başarıyla eklendi." : "Hizmet başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
