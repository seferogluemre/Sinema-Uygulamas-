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
    public partial class üye_paneli : Form
    {
        public üye_paneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÜYE_GİRİŞİ üy = new ÜYE_GİRİŞİ();
            üy.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ÜYE_KAYIT_PANELİ kyt = new ÜYE_KAYIT_PANELİ();
            kyt.Show();

        }

        private void üye_paneli_Load(object sender, EventArgs e)
        {

        }
    }
}
