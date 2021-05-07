using System;
using System.Collections.Generic;
using System.Text;
using ENTITYLAYER;
using System.Data.SqlClient;
using Utility;
namespace FACADELAYER
{
    public class FACADENOTLAR
    {
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            double ort = MyExtensions.OrtHesapla(deger.SINAV1, deger.SINAV2, deger.SINAV3, deger.PROJE);
            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.NOT_GUNCELLE, SQLBAGLANTI.Baglanti);
            komut.Parameters.AddWithValue(ResourceTblNotlar.OGRENCI_ID, deger.OGRENCIID);
            komut.Parameters.AddWithValue(ResourceTblNotlar.SINAV_1, deger.SINAV1);
            komut.Parameters.AddWithValue(ResourceTblNotlar.SINAV_2, deger.SINAV2);
            komut.Parameters.AddWithValue(ResourceTblNotlar.SINAV_3, deger.SINAV3);
            komut.Parameters.AddWithValue(ResourceTblNotlar.PROJE, deger.PROJE);
            komut.Parameters.AddWithValue(ResourceTblNotlar.ORTALAMA, ort);
            komut.Parameters.AddWithValue(ResourceTblNotlar.DURUM, MyExtensions.DurumHesapla(ort));

            return komut.ExecuteNonQuery() > 0;
        }

        public static List<ENTITYNOTLAR> NOTLISTELE()
        {
            List<ENTITYNOTLAR> degerler = new List<ENTITYNOTLAR>();

            SqlCommand komut = MyExtensions.CommandOlustur(ResourceStoredProcedure.NOT_LISTELE, SQLBAGLANTI.Baglanti);

            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                degerler.Add(new ENTITYNOTLAR
                {
                    OGRENCIID = Convert.ToInt16(dr[ResourceTblNotlar.OGRENCI_ID]),
                    AD = dr[ResourceTblOgrenci.AD].ToString(),
                    SOYAD = dr[ResourceTblOgrenci.SOYAD].ToString(),
                    SINAV1 = Convert.ToInt16(dr[ResourceTblNotlar.SINAV_1]),
                    SINAV2 = Convert.ToInt16(dr[ResourceTblNotlar.SINAV_2]),
                    SINAV3 = Convert.ToInt16(dr[ResourceTblNotlar.SINAV_3]),
                    PROJE = Convert.ToInt16(dr[ResourceTblNotlar.PROJE]),
                    ORTALAMA = Convert.ToDouble(dr[ResourceTblNotlar.ORTALAMA]),
                    DURUM = Convert.ToBoolean(dr[ResourceTblNotlar.DURUM]),
 
                });
            }

            dr.Close();
            return degerler;
        }

       
    }
}
