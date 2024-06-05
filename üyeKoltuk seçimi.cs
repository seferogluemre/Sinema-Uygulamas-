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
    public partial class üyeKoltuk_seçimi : Form
    {
        private Random random = new Random();
        public üyeKoltuk_seçimi()
        {
            InitializeComponent();
        }
        sqlbglntı bgl = new sqlbglntı();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label2.Text);
            labelA1.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void üyeKoltuk_seçimi_Load(object sender, EventArgs e)
        {
            RastgeleLabelDoldur(4);
            comboBox1.Items.Add("1.SALON");

        }
        private void RastgeleLabelDoldur(int doluLabelSayisi)
        {

            Label[] labels = { labelA1, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24 };


            labels = labels.OrderBy(x => random.Next()).ToArray();


            for (int i = 0; i < doluLabelSayisi; i++)
            {
                labels[i].Text = "DOLU";
            }
        }

        private void aNAMENÜToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜYE_PANELİ2 üp2 = new ÜYE_PANELİ2();
            üp2.Show();

        }

    

        private void bÜTÜNFİLMLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BÜTÜN_FİLMLER btn = new BÜTÜN_FİLMLER();
            btn.Show();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            salon sln = new salon();
            sln.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label3.Text);
            label14.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label4.Text);
            label15.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label5.Text);
            label16.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label9.Text);
            label19.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label8.Text);
            label18.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label7.Text);
            label17.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label6.Text);
            label20.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label13.Text);
            label24.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label12.Text);
            label21.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label11.Text);
            label22.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");


        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update üye1 set üyeKOLTUK=@p1 ", bgl.sqlbaglantı());
            komut2.Parameters.AddWithValue("@p1", label10.Text);
            label23.Text = "DOLU";
            komut2.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Rezerv oluşturuldu");
        }

        private void bÜFEMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            üye_Büfe üybüfe = new üye_Büfe();
            üybüfe.Show();

        }
    }
}
