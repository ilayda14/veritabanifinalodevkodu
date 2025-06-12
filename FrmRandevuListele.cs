using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmRandevuListele : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");

        public FrmRandevuListele()
        {
            InitializeComponent();
        }

        private void FrmRandevuListele_Load(object sender, EventArgs e)
        {
            RandevulariListele();
        }

        private void RandevulariListele()
        {
            try
            {
                baglanti.Open();
                string sorgu = @"
            SELECT 
                r.RandevuID,
                m.Ad + ' ' + m.Soyad AS Musteri,
                p.Ad + ' ' + p.Soyad AS Personel,
                h.Ad AS Hizmet,
                r.Tarih,
                r.Saat,
                r.RandevuAciklama
            FROM Randevu r
            INNER JOIN Musteri m ON r.MusteriID = m.MusteriID
            INNER JOIN Personel p ON r.PersonelID = p.PersonelID
            INNER JOIN Hizmet h ON r.HizmetID = h.HizmetID
            ORDER BY r.Tarih DESC, r.Saat DESC"; 

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRandevu.DataSource = dt;

                dgvRandevu.Columns["RandevuID"].Visible = false;
                dgvRandevu.Columns["Musteri"].HeaderText = "Müşteri";
                dgvRandevu.Columns["Personel"].HeaderText = "Personel";
                dgvRandevu.Columns["Hizmet"].HeaderText = "Hizmet";
                dgvRandevu.Columns["Tarih"].HeaderText = "Tarih";
                dgvRandevu.Columns["Saat"].HeaderText = "Saat";
                dgvRandevu.Columns["RandevuAciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular listelenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvRandevu.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir randevu seçin.");
                return;
            }

            if (dgvRandevu.CurrentRow.Cells["RandevuID"].Value == null)
            {
                MessageBox.Show("Seçilen randevunun ID bilgisi alınamadı.");
                return;
            }

            int randevuID = Convert.ToInt32(dgvRandevu.CurrentRow.Cells["RandevuID"].Value);

            DialogResult dr = MessageBox.Show("Seçilen randevuyu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True"))
                    {
                        baglanti.Open();
                        using (SqlCommand komut = new SqlCommand("DELETE FROM Randevu WHERE RandevuID = @ID", baglanti))
                        {
                            komut.Parameters.AddWithValue("@ID", randevuID);
                            komut.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Randevu başarıyla silindi.");
                    RandevulariListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvRandevu.CurrentRow == null || dgvRandevu.CurrentRow.Cells["RandevuID"].Value == null)
            {
                MessageBox.Show("Güncellemek için bir randevu seçin.");
                return;
            }

            int randevuID = Convert.ToInt32(dgvRandevu.CurrentRow.Cells["RandevuID"].Value);

            FrmRandevu frmRandevu = new FrmRandevu(randevuID);
            frmRandevu.ShowDialog();

            RandevulariListele();
        }

    }
}
