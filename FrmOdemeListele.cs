using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class FrmOdemeListele : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JEUOKJ4\SQLEXPRESS02;Initial Catalog=LadyGuzellik;Integrated Security=True");

        public FrmOdemeListele()
        {
            InitializeComponent();
            this.Load += FrmOdemeListele_Load;
        }

        private void FrmOdemeListele_Load(object sender, EventArgs e)
        {
            OdemeleriListele();
        }

        private void OdemeleriListele()
        {
            try
            {
                baglanti.Open();
                string sorgu = @"
                    SELECT 
                        o.OdemeID,
                        r.RandevuID,
                        m.Ad + ' ' + m.Soyad AS Musteri,
                        o.Tutar,
                        o.OdemeTuru,
                        o.OdemeTarihi
                    FROM Odeme o
                    INNER JOIN Randevu r ON o.RandevuID = r.RandevuID
                    INNER JOIN Musteri m ON r.MusteriID = m.MusteriID
                    ORDER BY o.OdemeTarihi DESC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOdeme.DataSource = dt;

                dgvOdeme.Columns["OdemeID"].Visible = false;
                dgvOdeme.Columns["RandevuID"].Visible = false;
                dgvOdeme.Columns["Musteri"].HeaderText = "Müşteri";
                dgvOdeme.Columns["Tutar"].HeaderText = "Tutar (₺)";
                dgvOdeme.Columns["OdemeTuru"].HeaderText = "Ödeme Türü";
                dgvOdeme.Columns["OdemeTarihi"].HeaderText = "Ödeme Tarihi";

                dgvOdeme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOdeme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOdeme.MultiSelect = false;
                dgvOdeme.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödemeler listelenirken hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme();
            frm.ShowDialog();
            OdemeleriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOdeme.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir ödeme seçin.");
                return;
            }

            int odemeID = Convert.ToInt32(dgvOdeme.CurrentRow.Cells["OdemeID"].Value);
            FrmOdeme frm = new FrmOdeme(odemeID);
            frm.ShowDialog();
            OdemeleriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvOdeme.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek bir ödeme seçin.");
                return;
            }

            int odemeID = Convert.ToInt32(dgvOdeme.CurrentRow.Cells["OdemeID"].Value);
            DialogResult dr = MessageBox.Show("Seçilen ödemeyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Odeme WHERE OdemeID = @ID", baglanti);
                    komut.Parameters.AddWithValue("@ID", odemeID);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme silindi.");
                    OdemeleriListele();
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

        private void dgvOdeme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int odemeID = Convert.ToInt32(dgvOdeme.Rows[e.RowIndex].Cells["OdemeID"].Value);
                FrmOdeme frm = new FrmOdeme(odemeID);
                frm.ShowDialog();
                OdemeleriListele();
            }
        }
    }
}
