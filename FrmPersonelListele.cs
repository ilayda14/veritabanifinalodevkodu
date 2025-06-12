using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmPersonelListele : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True";

        public FrmPersonelListele()
        {
            InitializeComponent();
        }

        private void FrmPersonelListele_Load(object sender, EventArgs e)
        {
            PersonelleriListele();
        }

        private void PersonelleriListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        PersonelID,
                        Ad,
                        Soyad,
                        Telefon,
                        Eposta,
                        UzmanlikAlani,
                        IseBaslamaTarihi,
                        CASE WHEN Aktif = 1 THEN 'Aktif' ELSE 'Pasif' END AS Durum
                    FROM Personel", baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPersonel.DataSource = dt;

                    dgvPersonel.Columns["PersonelID"].Visible = false;
                    dgvPersonel.Columns["Ad"].HeaderText = "Ad";
                    dgvPersonel.Columns["Soyad"].HeaderText = "Soyad";
                    dgvPersonel.Columns["Telefon"].HeaderText = "Telefon";
                    dgvPersonel.Columns["Eposta"].HeaderText = "E-posta";
                    dgvPersonel.Columns["UzmanlikAlani"].HeaderText = "Uzmanlık Alanı";
                    dgvPersonel.Columns["IseBaslamaTarihi"].HeaderText = "İşe Başlama";
                    dgvPersonel.Columns["Durum"].HeaderText = "Durum";

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Listelenecek personel bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personeller listelenirken hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir personel seçin.");
                return;
            }

            int personelID = Convert.ToInt32(dgvPersonel.CurrentRow.Cells["PersonelID"].Value);

            DialogResult dr = MessageBox.Show("Seçilen personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM Personel WHERE PersonelID = @ID", baglanti);
                        komut.Parameters.AddWithValue("@ID", personelID);
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Personel silindi.");
                    PersonelleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme sırasında hata: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null)
            {
                MessageBox.Show("Güncellemek için bir personel seçin.");
                return;
            }

            int personelID = Convert.ToInt32(dgvPersonel.CurrentRow.Cells["PersonelID"].Value);

            FrmPersonel frmPersonel = new FrmPersonel(personelID);
            frmPersonel.ShowDialog();

            PersonelleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
            PersonelleriListele();
        }

        private void dgvPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int personelID = Convert.ToInt32(dgvPersonel.Rows[e.RowIndex].Cells["PersonelID"].Value);

                FrmPersonel frmPersonel = new FrmPersonel(personelID);
                frmPersonel.ShowDialog();

                PersonelleriListele();
            }
        }
    }
}
