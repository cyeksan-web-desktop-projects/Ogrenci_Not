using System;
using System.Collections.Generic;
using System.Text;
using ENTITYLAYER;
using FACADELAYER;

namespace BUSINESSLOGICLAYER
{
    public class BLLOGRENCI
    {
        public static int EKLE(ENTITYOGRENCI deger)
        {
            if (deger.AD != null && deger.AD != ""
                && deger.SOYAD != null && deger.SOYAD != ""
                && deger.FOTOGRAF != null && deger.FOTOGRAF != ""
                && deger.KULUPID > 0)
            {
                return FACADEOGRENCI.EKLE(deger);
            }
            return -1;

        }

        public static bool GUNCELLE(ENTITYOGRENCI deger)
        {
            if (deger.AD != null && deger.AD != ""
                && deger.SOYAD != null && deger.SOYAD != ""
                && deger.FOTOGRAF != null && deger.FOTOGRAF != ""
                && deger.KULUPID > 0 && deger.ID > 0)
            {
                return FACADEOGRENCI.GUNCELLE(deger);
            }

            return false;

        }

        public static bool SIL(int? deger)
        {
            if (deger != null && deger > 0)
            {
                return FACADEOGRENCI.SIL(deger);
            }

            return false;
        }

        public static List<ENTITYOGRENCI> LISTELE()
        {
            return FACADEOGRENCI.OGRENCILISTESI();
        }
    }
}
