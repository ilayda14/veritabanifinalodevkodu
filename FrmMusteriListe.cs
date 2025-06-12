using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmMusteriListe : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");

        public FrmMusteriListe()
        {
            InitializeComponent();
        }

        private void FrmMusteriListe_Load(object sender, EventArgs e)
        {
            MusteriListesiGetir();
        }

        public void MusteriListesiGetir()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Musteri", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMusteriler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.MusteriListeFormu = this; // referans veriyoruz
            frm.ShowDialog(); // sadece yeni müşteri formu açılır
        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // İstenirse satır işlemleri buraya
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
