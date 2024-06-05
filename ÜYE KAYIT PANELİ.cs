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
    public partial class ÜYE_KAYIT_PANELİ : Form
    {
        public ÜYE_KAYIT_PANELİ()
        {
            InitializeComponent();
        }
        sqlbglntı bgl = new sqlbglntı();
        private void butonDÜZENLEBİLGİ_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("insert into üye1 (üyeID,üyeADSOYAD,üyeTELNO,üyeŞİFRE) values (@p1,@p2,@p3,@p4)", bgl.sqlbaglantı());
                komut.Parameters.AddWithValue("@p1", textBoxID.Text);
                komut.Parameters.AddWithValue("@p2", textADsoyad.Text);
                komut.Parameters.AddWithValue("@p3", MSKTELNO.Text);
                komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.sqlbaglantı().Close();
                MessageBox.Show("Kaydınız yapılmıştır");

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());

            }
            
        }

      
    }
}
