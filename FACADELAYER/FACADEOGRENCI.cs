using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ENTITYLAYER;
using Utility;
namespace FACADELAYER
{
    public class FACADEOGRENCI
    {
        
        public static int EKLE(ENTITYOGRENCI deger)
        {
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.OGRENCI_EKLE, SQLBAGLANTI.Baglanti);

            komut.Parameters.AddWithValue(ResourceTblOgrenci.AD, deger.AD);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.SOYAD, deger.SOYAD);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.FOTOGRAF, deger.FOTOGRAF);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.KULUP_ID, deger.KULUPID);

            return komut.ExecuteNonQuery();
        }

        public static bool SIL(int? deger)
        {
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.OGRENCI_SIL, SQLBAGLANTI.Baglanti);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.ID, deger);

            return komut.ExecuteNonQuery() > 0;
        }

        public static bool GUNCELLE(ENTITYOGRENCI deger)
        {
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.OGRENCI_GUNCELLE, SQLBAGLANTI.Baglanti);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.ID, deger.ID);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.AD, deger.AD);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.SOYAD, deger.SOYAD);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.FOTOGRAF, deger.FOTOGRAF);
            komut.Parameters.AddWithValue(ResourceTblOgrenci.KULUP_ID, deger.KULUPID);

            return komut.ExecuteNonQuery() > 0;

        }

        public static List<ENTITYOGRENCI> OGRENCILISTESI()
        {
            List<ENTITYOGRENCI> degerler = new List<ENTITYOGRENCI>();
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.OGRENCI_LISTELE, SQLBAGLANTI.Baglanti) ;

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                degerler.Add(new ENTITYOGRENCI
                {
                    ID = Convert.ToInt16(dr[ResourceTblOgrenci.ID]),
                    AD = dr[ResourceTblOgrenci.AD].ToString(),
                    SOYAD = dr[ResourceTblOgrenci.SOYAD].ToString(),
                    FOTOGRAF = dr[ResourceTblOgrenci.FOTOGRAF].ToString(),
                    KULUPID = Convert.ToInt16(dr[ResourceTblOgrenci.KULUP_ID]),
                    KULUPAD = dr[ResourceTblOgrenci.KULUP_AD].ToString()
                });
            }

            dr.Close();

            return degerler;

        }
    }
}
