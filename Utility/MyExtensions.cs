using System;
using System.Data;
using System.Data.SqlClient;

namespace Utility
{
    public static class MyExtensions
    {
        public static SqlCommand CommandOlustur(string commandName, SqlConnection connection)
        {
            SqlCommand komut = new SqlCommand(commandName, connection);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            return komut;
        }

        public static double OrtHesapla(int sinav1, int sinav2, int sinav3, int proje)
        {
            return sinav1 * 0.2 + sinav2 * 0.2 + sinav3 * 0.5 + proje * 0.1;
        }

        public static bool DurumHesapla(double ort)
        {
            if(ort > 50)
            {
                return true;
            }

            return false;
        }
    }
}
