using System;
using System.Windows.Forms;

namespace Sinema_Uygulaması
{
    public partial class site : Form
    {
        public site()
        {
            InitializeComponent();
        }

        private void site_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sinevizyonsinemalari.com/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
