using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Sinema_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlbglntı bg = new sqlbglntı();
        private void button1_Click(object sender, EventArgs e)
        {
         
           

            // müşteri girişinden databaseye veri çekme
            SqlCommand komut1 = new SqlCommand("insert into müşteri2 (müşteriID,müşteriADSOYAD,müşteriTELNO) values (@p1,@p2,@p3)", bg.sqlbaglantı());
            komut1.Parameters.AddWithValue("@p1", textBoxID.Text);
            komut1.Parameters.AddWithValue("@p2", textADSOYAD.Text);
            komut1.Parameters.AddWithValue("@p3", maskTELNO.Text);
            komut1.ExecuteNonQuery();
            bg.sqlbaglantı().Close();
            MessageBox.Show("Sinemaya hoşgeldiniz :" + textADSOYAD.Text);
            FORM2 frm2 = new FORM2();

            

            frm2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
