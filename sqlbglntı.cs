using System.Data.SqlClient;
namespace Sinema_Uygulaması
{
    class sqlbglntı
    {
        public SqlConnection sqlbaglantı()
        {
            SqlConnection baglan2 = new SqlConnection("Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=hastaneyönetim;Integrated Security=True");
            baglan2.Open();
            return baglan2;
        }
    }
}
