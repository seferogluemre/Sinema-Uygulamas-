using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Sinema_Uygulaması
{
    public partial class biletalma : Form
    {
        public biletalma()
        {
            InitializeComponent();
        }
        sqlbglntı bg = new sqlbglntı();
        private void buttonSATINALÖgr_Click(object sender, EventArgs e)
        {
            if (ckbxogrenci1.Checked == true)
            {
                lblALINAN.Text = ckbxogrenci1.Text;
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriBİLET=@p1 ", bg.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);
                komut2.ExecuteNonQuery();
                bg.sqlbaglantı().Close();
                MessageBox.Show("Koltuk seçimi yapınız");
                koltuk_seçimi klt1 = new koltuk_seçimi();
                klt1.Show();
                this.Hide();

            }
            else if (ckbxogrenci2.Checked == true)
            {
                lblALINAN.Text = ckbxogrenci2.Text;
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriBİLET=@p1 ", bg.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);
              
                komut2.ExecuteNonQuery();
                bg.sqlbaglantı().Close();
                MessageBox.Show("Koltuk seçimi yapınız");
                koltuk_seçimi klt2 = new koltuk_seçimi();
                klt2.Show();
                this.Hide();
            }
            else
            {
                biletalma blt = new biletalma();
                blt.Show();
            }
        }

        private void ckbxogrenci1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonYetşkn_Click(object sender, EventArgs e)
        {
            if (ckbxYetşkn1.Checked == true)
            {
                lblALINAN.Text = ckbxYetşkn1.Text;
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriBİLET=@p1 ", bg.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);
               
                komut2.ExecuteNonQuery();
                bg.sqlbaglantı().Close();
                MessageBox.Show("Koltuk seçimi yapınız");
                koltuk_seçimi klt1 = new koltuk_seçimi();
                klt1.Show();
                this.Hide();

            }
            else if (checkBox1.Checked == true)
            {
                lblALINAN.Text = checkBox1.Text;
                SqlCommand komut2 = new SqlCommand("update müşteri2 set müşteriBİLET=@p1 ", bg.sqlbaglantı());
                komut2.Parameters.AddWithValue("@p1", lblALINAN.Text);
             
                komut2.ExecuteNonQuery();
                bg.sqlbaglantı().Close();
                MessageBox.Show("Koltuk seçimi yapınız");
                koltuk_seçimi klt2 = new koltuk_seçimi();
                klt2.Show();
                this.Hide();
            }
            else
            {
                biletalma blt = new biletalma();
                blt.Show();
            }
        }

        private void biletalma_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            büfe bf3 = new büfe();
            bf3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM2 frm2 = new FORM2();
            frm2.Show();
            this.Hide();
        }
    }
}
