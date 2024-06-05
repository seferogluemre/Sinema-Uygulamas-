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
    public partial class ÜYE_GİRİŞİ : Form
    {
        public ÜYE_GİRİŞİ()
        {
            InitializeComponent();
        }
        sqlbglntı bg = new sqlbglntı();
        private void butonGiris_Click(object sender, EventArgs e)
        {
            ÜYE_PANELİ2 üye1 = new ÜYE_PANELİ2();
            SqlCommand kmt = new SqlCommand("select * from üye1 where  üyeADSOYAD=@p1 and üyeŞİFRE=@p2", bg.sqlbaglantı());
            kmt.Parameters.AddWithValue("@p1", textADSOYAD.Text);
            kmt.Parameters.AddWithValue("@p2", textBoxŞİFRE.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                üye1.labelÜyeADSOYADPanel.Text = dr[1].ToString();
                MessageBox.Show("Hoşgeldiniz Sayın :" + textADSOYAD.Text);
                üye1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Ad Veya şifre tekrar deneyin");
            }
            bg.sqlbaglantı().Close();
        }

        private void ÜYE_GİRİŞİ_Load(object sender, EventArgs e)
        {

        }
    }
}
