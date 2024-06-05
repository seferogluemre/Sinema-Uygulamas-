using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sinema_Uygulaması
{
    public partial class üyeBİLETALMA : Form
    {
        public üyeBİLETALMA()
        {
            InitializeComponent();
        }
        sqlbglntı bgl = new sqlbglntı();

        private void üyeBİLETALMA_Load(object sender, EventArgs e)
        {

        }

        private void buttonSATINALÖgr_Click(object sender, EventArgs e)
        {
            if (ckbxogrenci1.Checked == true)
            {
                lblALINAN.Text = ckbxogrenci1.Text;
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeBİLET=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);
                komut2.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();

                MessageBox.Show("Koltuk seçimi yapınız");
                üyeKoltuk_seçimi üks1 = new üyeKoltuk_seçimi();
                üks1.Show();
                this.Hide();

            }
            else if (ckbxogrenci2.Checked == true)
            {
                lblALINAN.Text = ckbxogrenci2.Text;
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeBİLET=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);
                komut2.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();

                MessageBox.Show("Koltuk seçimi yapınız");
                üyeKoltuk_seçimi üks2 = new üyeKoltuk_seçimi();
                üks2.Show();
                this.Hide();

            }
            else
            {
                üyeKoltuk_seçimi ks = new üyeKoltuk_seçimi();
                ks.Show();
            }
        }

        private void buttonYetşkn_Click(object sender, EventArgs e)
        {
            if (ckbxYetşkn1.Checked == true)
            {
                lblALINAN.Text = ckbxYetşkn1.Text;
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeBİLET=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);

                komut2.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();
                MessageBox.Show("Koltuk seçimi yapınız");
                üyeKoltuk_seçimi üks3 = new üyeKoltuk_seçimi();
                üks3.Show();
                this.Hide();

            }
            else if (checkBox1.Checked == true)
            {
                lblALINAN.Text = checkBox1.Text;
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeBİLET=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);

                komut2.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();
                MessageBox.Show("Koltuk seçimi yapınız");
                üyeKoltuk_seçimi üyks2 = new üyeKoltuk_seçimi();
                üyks2.Show();
                this.Hide();
            }
            else
            {
                üyeKoltuk_seçimi ks1 = new üyeKoltuk_seçimi();
                ks1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÜYE_PANELİ2 üpf2 = new ÜYE_PANELİ2();
            üpf2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BÜTÜN_FİLMLER btn = new BÜTÜN_FİLMLER();
            btn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VİZYONDA_OLANLAR vz = new VİZYONDA_OLANLAR();
            vz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            üye_Büfe übf = new üye_Büfe();
            übf.Show();
        }
    }
}
