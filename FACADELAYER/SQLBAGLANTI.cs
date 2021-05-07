using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FACADELAYER
{
    class SQLBAGLANTI
    {
        public static SqlConnection Baglanti = new SqlConnection(@"
        Data Source=DESKTOP-BF6C0LE\SQLEXPRESS;Initial Catalog=DBTESTKATMAN;Integrated Security=True
        ");
    }
}
