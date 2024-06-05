using System;
using System.Windows.Forms;

namespace Sinema_Uygulaması
{
    public partial class salon : Form
    {
        public salon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tepki2 = new DialogResult();
            tepki2 = MessageBox.Show("Çıkış yapıyorsunuz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);


            if (tepki2 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                salon sln = new salon();
                sln.Show();
                this.Hide();
            }

        }

        private void salon_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate("https://www.4kfilmizlesene.org/hizli-ve-ofkeli-10/");
        }
    }
}
