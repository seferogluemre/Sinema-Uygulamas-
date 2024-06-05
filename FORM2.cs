using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
namespace Sinema_Uygulaması
{
    public partial class FORM2 : Form
    {
        public FORM2()
        {
            InitializeComponent();
        }

        sqlbglntı bgl = new sqlbglntı();

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void hIZLIERİŞİMToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void hIZLIERİŞİMToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void wEBSİTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            site site = new site();
            site.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM2 fr2 = new FORM2();
            if (checkBox1.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriSEÇTGFİLM=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", checkBox1.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");
                biletalma blt = new biletalma();
                blt.Show();
                this.Hide();

            }
            else
            {
                FORM2 frm2 = new FORM2();
                frm2.Show();
            }
            bgl.sqlbaglantı().Close();
        }

        private void iNSTAGRAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show("Uygualamadan ayrılıyorsunuz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tepki == DialogResult.OK)
            {
                Process.Start("https://www.instagram.com/ktstder/");
            }
            else
            {
                FORM2 fr2 = new FORM2();
                fr2.Show();
            }
        }

        private void bÜTÜNFİLMLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bütün_filmler btflm = new bütün_filmler();
            btflm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriSEÇTGFİLM=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", checkBox3.Text);
                komut2.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();
                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");

                biletalma bla1 = new biletalma();
                bla1.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriSEÇTGFİLM=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", checkBox2.Text);
                komut2.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();
                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");
                biletalma blt2 = new biletalma();
                blt2.Show();
                this.Hide();
            }
            else
            {
                FORM2 f2 = new FORM2();
                f2.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriSEÇTGFİLM=@p1 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", checkBox4.Text);
                komut2.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();
                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");
                biletalma blt4 = new biletalma();
                blt4.Show();
                this.Hide();
            }
            else
            {
                FORM2 form2 = new FORM2();
                form2.Show();
                this.Hide();
            }
        }

        private void bÜFEMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            büfe bf1 = new büfe();
            bf1.Show();
            this.Hide();
        }

        private void FORM2_Load(object sender, EventArgs e)
        {

        }
    }
}
