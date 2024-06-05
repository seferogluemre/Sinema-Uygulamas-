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
    public partial class üye_Büfe : Form
    {
        public üye_Büfe()
        {
            InitializeComponent();
        }
        sqlbglntı bgl = new sqlbglntı();
        int toplam = 0;
        int genel_toplam = 0;
        int mısır, pizza, bisküvi, kola, fanta, su, çay;

        private void textsu_TextChanged(object sender, EventArgs e)
        {
            if (textsu.Text == "01" || textsu.Text == "02" || textsu.Text == "03" || textsu.Text == "04" || textsu.Text == "05" | textsu.Text == "06" || textsu.Text == "07" || textsu.Text == "08" || textsu.Text == "09" || textsu.Text == "010")
            {
                rchKasamalzeme.AppendText("SU ,");

            }
            else if (textsu.Text == "0")
            {
                rchKasamalzeme.Undo();
            }
        }

        private void textçay_TextChanged(object sender, EventArgs e)
        {
            if (textçay.Text == "01" || textçay.Text == "02" || textçay.Text == "03" || textçay.Text == "04" || textçay.Text == "05" | textçay.Text == "06" || textçay.Text == "07" || textçay.Text == "08" || textçay.Text == "09" || textçay.Text == "010")
            {
                rchKasamalzeme.AppendText("SOGUK ÇAY ,");

            }
            else if (textçay.Text == "0")
            {
                rchKasamalzeme.Undo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam = (mısır * 30) + (pizza * 60) + (bisküvi * 12) + (kola * 10) + (fanta * 7) + (su * 5) + (çay * 10);
            textBoxTOPLAMTUTAR.Text = toplam.ToString();
            string stokmiktarı = $"{textBoxMISIR.Text},{textPİZZA.Text},{textBİSKÜVİ.Text},{textkola.Text},{textfanta.Text},{textsu.Text},{textçay.Text}";
            mısır = Convert.ToInt32(textBoxMISIR.Text);
            pizza = Convert.ToInt32(textPİZZA.Text);
            bisküvi = Convert.ToInt32(textBİSKÜVİ.Text);
            kola = Convert.ToInt32(textkola.Text);
            fanta = Convert.ToInt32(textfanta.Text);
            su = Convert.ToInt32(textsu.Text);
            çay = Convert.ToInt32(textçay.Text);

            SqlCommand komut = new SqlCommand("update üye1 set üyeSEPET=@e1 ", bgl.sqlbaglantı());
            komut.Parameters.AddWithValue("@e1", rchKasamalzeme.Text);
            komut.ExecuteNonQuery();
            bgl.sqlbaglantı().Close();

            MessageBox.Show("Kasaya para eklendi");
           


            genel_toplam = genel_toplam + toplam;
            textBoxKASADAOLANPARA.Text = genel_toplam + " TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxMISIR.Text = "0";
            textPİZZA.Text = "0";
            textBİSKÜVİ.Text = "0";
            textkola.Text = "0";
            textfanta.Text = "0";
            textsu.Text = "0";
            textçay.Text = "0";
            textBoxTOPLAMTUTAR.Text = "0";
            rchKasamalzeme.Text = "";
        }

        private void üye_Büfe_Load(object sender, EventArgs e)
        {

        }

        private void textkola_TextChanged(object sender, EventArgs e)
        {
            if (textkola.Text == "01" || textkola.Text == "02" || textkola.Text == "03" || textkola.Text == "04" || textkola.Text == "05" | textkola.Text == "06" || textkola.Text == "07" || textkola.Text == "08" || textkola.Text == "09" || textkola.Text == "010")
            {
                rchKasamalzeme.AppendText("KOLA ,");

            }
            else if (textkola.Text == "0")
            {
                rchKasamalzeme.Undo();
            }
        }

        private void textfanta_TextChanged(object sender, EventArgs e)
        {
            if (textfanta.Text == "01" || textfanta.Text == "02" || textfanta.Text == "03" || textfanta.Text == "04" || textfanta.Text == "05" | textfanta.Text == "06" || textfanta.Text == "07" || textfanta.Text == "08" || textfanta.Text == "09" || textfanta.Text == "010")
            {
                rchKasamalzeme.AppendText("FANTA ,");

            }
            else if (textfanta.Text == "0")
            {
                rchKasamalzeme.Undo();
            }
        }

        private void textBİSKÜVİ_TextChanged(object sender, EventArgs e)
        {
            if (textBİSKÜVİ.Text == "01" || textBİSKÜVİ.Text == "02" || textBİSKÜVİ.Text == "03" || textBİSKÜVİ.Text == "04" || textBİSKÜVİ.Text == "05" || textBİSKÜVİ.Text == "06" || textBİSKÜVİ.Text == "07" || textBİSKÜVİ.Text == "08" || textBİSKÜVİ.Text == "09" || textBİSKÜVİ.Text == "010")
            {
                rchKasamalzeme.AppendText("BİSKÜVİ ,");

            }
            else if (textBİSKÜVİ.Text == "0")
            {
                rchKasamalzeme.Undo();
            }
        }

        private void textPİZZA_TextChanged(object sender, EventArgs e)
        {
            if (textPİZZA.Text == "01" || textPİZZA.Text == "02" || textPİZZA.Text == "03" || textPİZZA.Text == "04" || textPİZZA.Text == "05" || textPİZZA.Text == "06" || textPİZZA.Text == "07" || textPİZZA.Text == "08" || textPİZZA.Text == "09" || textPİZZA.Text == "010")
            {
                rchKasamalzeme.AppendText("PİZZA ,");

            }
            else if (textPİZZA.Text == "0")
            {
                rchKasamalzeme.Undo();
            }
        }

        private void textBoxMISIR_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMISIR.Text == "01" || textBoxMISIR.Text == "02" || textBoxMISIR.Text == "03" || textBoxMISIR.Text == "04" || textBoxMISIR.Text == "05" || textBoxMISIR.Text == "06" || textBoxMISIR.Text == "07" || textBoxMISIR.Text == "08" || textBoxMISIR.Text == "09" || textBoxMISIR.Text == "010")
            {
                rchKasamalzeme.AppendText("MISIR ,");

            }
            else if (textBoxMISIR.Text == "0")
            {
                rchKasamalzeme.Undo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mısır = Convert.ToInt32(textBoxMISIR.Text);
            pizza = Convert.ToInt32(textPİZZA.Text);
            bisküvi = Convert.ToInt32(textBİSKÜVİ.Text);
            kola = Convert.ToInt32(textkola.Text);
            fanta = Convert.ToInt32(textfanta.Text);
            su = Convert.ToInt32(textsu.Text);
            çay = Convert.ToInt32(textçay.Text);


            toplam = (mısır * 30) + (pizza * 60) + (bisküvi * 12) + (kola * 10) + (fanta * 7) + (su * 5) + (çay * 10);
            textBoxTOPLAMTUTAR.Text = toplam.ToString();
            MessageBox.Show("Ödenecek tutar :" + textBoxTOPLAMTUTAR.Text, "TUTAR");
        }
    }
}
