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
    public partial class üye_bilgi_güncelleme : Form
    {
        public üye_bilgi_güncelleme()
        {
            InitializeComponent();
        }
        sqlbglntı bgl = new sqlbglntı();
        private void üye_bilgi_güncelleme_Load(object sender, EventArgs e)
        {
            ÜYE_PANELİ2 üp2 = new ÜYE_PANELİ2();
            textADsoyad.Text = üp2.labelÜyeADSOYADPanel.Text.ToString();
            
            SqlCommand komut = new SqlCommand("Select * from üye1 where üyeADSOYAD=@p1", bgl.sqlbaglantı());
            komut.Parameters.AddWithValue("@p1", textADsoyad.Text);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                textBoxID.Text = dr2[0].ToString();
                textADsoyad.Text = dr2[1].ToString();
                MSKTELNO.Text = dr2[2].ToString();
                txtSifre.Text = dr2[7].ToString();
            }
        }
        private void butonDÜZENLEBİLGİ_Click(object sender, EventArgs e)
        {
            SqlCommand komutgncl = new SqlCommand("update üye1 set üyeID=@p1,üyeADSOYAD=@p2,üyeTELNO=@p3,üyeŞİFRE=@p4", bgl.sqlbaglantı());
            komutgncl.Parameters.AddWithValue("@p1", textBoxID.Text);
            komutgncl.Parameters.AddWithValue("@p2", textADsoyad.Text);
            komutgncl.Parameters.AddWithValue("@p3", MSKTELNO.Text);
            komutgncl.Parameters.AddWithValue("@p4", txtSifre.Text);
            komutgncl.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();
            MessageBox.Show("Bilgileriniz güncellendi");
        }
    }
}
