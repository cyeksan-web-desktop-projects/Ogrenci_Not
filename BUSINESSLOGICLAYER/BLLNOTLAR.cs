using System;
using System.Collections.Generic;
using System.Text;
using ENTITYLAYER;
using FACADELAYER;

namespace BUSINESSLOGICLAYER
{
    public class BLLNOTLAR
    {
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            if(deger.OGRENCIID > 0 &&
               deger.ORTALAMA >= 0 && deger.ORTALAMA <=100 &&
               deger.SINAV1 >= 0 && deger.SINAV1 <= 100 &&
               deger.SINAV2 >= 0 && deger.SINAV2 <= 100 &&
               deger.SINAV3 >= 0 && deger.SINAV3 <= 100 &&
               deger.PROJE >= 0 && deger.PROJE <=100 &&
               deger.ORTALAMA >= 0 && deger.ORTALAMA <=100)
            {
                return FACADENOTLAR.GUNCELLE(deger);
            }

            return false;
        }

        public static List<ENTITYNOTLAR> LISTELE()
        {
            return FACADENOTLAR.NOTLISTELE();
        }
    }
}
