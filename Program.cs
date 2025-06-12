using System;
using System.Windows.Forms;

namespace GuzellikMerkeziApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FrmGiris girisForm = new FrmGiris())
            {
                if (girisForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}

