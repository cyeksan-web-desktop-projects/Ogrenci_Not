using System;
using System.Collections.Generic;
using System.Text;
using ENTITYLAYER;
using System.Data.SqlClient;
using System.Data;
using Utility;

namespace FACADELAYER
{
    public class FACADEKULUP
    {
        public static int EKLE(ENTITYKULUP deger)
        {
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.KULUP_EKLE, SQLBAGLANTI.Baglanti);

            komut.Parameters.AddWithValue(ResourceTblKulup.KULUP_AD, deger.KULUPAD);
            return komut.ExecuteNonQuery(); //ExecuteNonQuery ile kayıt sayısını döndürüyor (eklenen kayıt sayısını)
        }

        public static bool SIL(int? deger)
        {
            //bool döndürüyoruz çünkü x id'li veriyi sildi mi silmedi mi buna bakacağız.
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.KULUP_SIL, SQLBAGLANTI.Baglanti);

            komut.Parameters.AddWithValue(ResourceTblKulup.KULUP_ID, deger);
            return komut.ExecuteNonQuery() > 0; // 1 olursa, 1 satırım etkilenmiş, yani silmeyi başarmışım demek.
        }

        public static bool GUNCELLE(ENTITYKULUP deger)
        {
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.KULUP_GUNCELLE, SQLBAGLANTI.Baglanti);

            komut.Parameters.AddWithValue(ResourceTblKulup.KULUP_ID, deger.KULUPID);
            komut.Parameters.AddWithValue(ResourceTblKulup.KULUP_AD, deger.KULUPAD);
            return komut.ExecuteNonQuery() > 0; // 1 olursa, 1 satırım etkilenmiş, yani güncellemeyi başarmışım demek.
        }

        public static List<ENTITYKULUP> KULUPLISTESI()
        {
            List<ENTITYKULUP> degerler = new List<ENTITYKULUP>();
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.KULUP_LISTELE, SQLBAGLANTI.Baglanti);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                degerler.Add(new ENTITYKULUP
                {
                    KULUPID = Convert.ToInt16(dr[ResourceTblKulup.KULUP_ID]),
                    KULUPAD = dr[ResourceTblKulup.KULUP_AD].ToString()
                });
            }
            dr.Close();

            return degerler;
        }
    }
}
