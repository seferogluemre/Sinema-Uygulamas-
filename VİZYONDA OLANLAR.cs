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
    public partial class VİZYONDA_OLANLAR : Form
    {
        public VİZYONDA_OLANLAR()
        {
            InitializeComponent();
        }
        sqlbglntı bgl = new sqlbglntı();
        private void VİZYONDA_OLANLAR_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeSEÇFİLM=@m1  ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@m1", checkBox1.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");
                üyeBİLETALMA üba1 = new üyeBİLETALMA();
                üba1.Show();
                this.Hide();

            }
            else
            {
                VİZYONDA_OLANLAR vz2 = new VİZYONDA_OLANLAR();
                vz2.Show();
            }
            bgl.sqlbaglantı().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeSEÇFİLM=@m3 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@m3", checkBox2.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");
                üyeBİLETALMA üba1 = new üyeBİLETALMA();
                üba1.Show();
                this.Hide();

            }
            else
            {
                VİZYONDA_OLANLAR vz2 = new VİZYONDA_OLANLAR();
                vz2.Show();
            }
            bgl.sqlbaglantı().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeSEÇFİLM=@m2 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@m2", checkBox3.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");
                üyeBİLETALMA üba1 = new üyeBİLETALMA();
                üba1.Show();
                this.Hide();

            }
            else
            {
                VİZYONDA_OLANLAR vz2 = new VİZYONDA_OLANLAR();
                vz2.Show();
            }
            bgl.sqlbaglantı().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("update üye1 set üyeSEÇFİLM=@m4 ", bgl.sqlbaglantı());
                komut2.Parameters.AddWithValue("@m4", checkBox4.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Bilet işlemlerine yönlendiriyorsunuz");
                üyeBİLETALMA üba1 = new üyeBİLETALMA();
                üba1.Show();
                this.Hide();

            }
            else
            {
                VİZYONDA_OLANLAR vz2 = new VİZYONDA_OLANLAR();
                vz2.Show();
            }
            bgl.sqlbaglantı().Close();
        }
    }
}
