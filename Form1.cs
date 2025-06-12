using System;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            FrmMusteriListe frm = new FrmMusteriListe();
            frm.ShowDialog();
        }

        private void btnRandevuIslemleri_Click(object sender, EventArgs e)
        {
            FrmRandevuListele frm = new FrmRandevuListele();
            frm.ShowDialog();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            FrmPersonelListele frm = new FrmPersonelListele();
            frm.ShowDialog();
        }

        private void btnHizmetler_Click(object sender, EventArgs e)
        {
            FrmHizmetListele frm = new FrmHizmetListele();
            frm.ShowDialog();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            FrmOdemeListele frm = new FrmOdemeListele();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
