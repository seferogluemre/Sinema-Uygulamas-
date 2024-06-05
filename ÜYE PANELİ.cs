using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Uygulaması
{
    public partial class ÜYE_PANELİ2 : Form
    {
        public ÜYE_PANELİ2()
        {
            InitializeComponent();
        }       
        private void ÜYE_PANELİ_Load(object sender, EventArgs e)
        {
            

            webBrowser1.Navigate("http://www.sinevizyonsinemalari.com/");   
        }
        private void button2_Click(object sender, EventArgs e)
        {
            VİZYONDA_OLANLAR vizyonüye = new VİZYONDA_OLANLAR();
            vizyonüye.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BÜTÜN_FİLMLER btn = new BÜTÜN_FİLMLER();
            btn.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show("Çıkış yapıyorsunuz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tepki==DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                ÜYE_PANELİ2 üye2 = new ÜYE_PANELİ2();
                üye2.Show();
            }
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                panel2.BackColor = Color.Silver;
            }
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                panel2.BackColor = Color.White;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sinevizyonsinemalari.com/iletisim");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            üye_bilgi_güncelleme übg1 = new üye_bilgi_güncelleme();
            übg1.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            üye_Büfe übf1 = new üye_Büfe();
            übf1.Show();
        }
    }
}
