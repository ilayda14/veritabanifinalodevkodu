using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmHizmetListele : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");

        public FrmHizmetListele()
        {
            InitializeComponent();
        }

        private void FrmHizmetListele_Load(object sender, EventArgs e)
        {
            HizmetleriListele();
        }

        private void HizmetleriListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hizmet", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHizmet.DataSource = dt;

                dgvHizmet.Columns["HizmetID"].Visible = false;
                dgvHizmet.Columns["Ad"].HeaderText = "Hizmet Adı";
                dgvHizmet.Columns["HizmetAciklama"].HeaderText = "Açıklama";
                dgvHizmet.Columns["SureDakika"].HeaderText = "Süre (dk)";
                dgvHizmet.Columns["Ucret"].HeaderText = "Ücret (₺)";
                dgvHizmet.Columns["Aktif"].HeaderText = "Aktif Mi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmetler listelenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmHizmet frmHizmet = new FrmHizmet(); 
            frmHizmet.ShowDialog();
            HizmetleriListele();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvHizmet.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir hizmet seçin.");
                return;
            }

            int hizmetID = Convert.ToInt32(dgvHizmet.CurrentRow.Cells["HizmetID"].Value);

            DialogResult dr = MessageBox.Show("Seçilen hizmeti silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Hizmet WHERE HizmetID = @ID", baglanti);
                    komut.Parameters.AddWithValue("@ID", hizmetID);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hizmet silindi.");
                    HizmetleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme sırasında hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvHizmet.CurrentRow == null)
            {
                MessageBox.Show("Güncellemek için bir hizmet seçin.");
                return;
            }

            int hizmetID = Convert.ToInt32(dgvHizmet.CurrentRow.Cells["HizmetID"].Value);

            FrmHizmet frmHizmet = new FrmHizmet(hizmetID);
            frmHizmet.ShowDialog();

            HizmetleriListele();
        }
    }
}
