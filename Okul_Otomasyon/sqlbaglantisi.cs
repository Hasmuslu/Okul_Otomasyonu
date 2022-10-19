using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Okul_Otomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
               SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS;Initial Catalog=Okul_otomasyon;Integrated Security=True");
               baglan.Open();
            return baglan;
        } 

    }
}
