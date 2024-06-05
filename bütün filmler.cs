using System;
using System.Windows.Forms;

namespace Sinema_Uygulaması
{
    public partial class bütün_filmler : Form
    {
        public bütün_filmler()
        {
            InitializeComponent();
        }

        private void wEBSİTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            site site2 = new site();
            site2.Show();
        }

        private void vİZYONDAOLANLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM2 fr2 = new FORM2();
            fr2.Show();
            this.Hide();
        }

        private void bÜFEMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            büfe bf2 = new büfe();
            bf2.Show();
            this.Hide();
        }
    }
}
