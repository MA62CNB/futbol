using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace futbol
{
    public class Takim
    {
        public  string ad;
        public  int oyuncuSav = 0;
        public  int oyuncuHuc = 0;

        //oyuncu vectorü
        public List<Oyuncu> player = new List<Oyuncu>();

       

        //oyuncuların ortalama hücum değerleriyle_
        //takımın hücum değerlini oluşturma
        public int setHucum()
        {
            int topHucum=0;


            //ortalamayı hesaplar
            foreach (Oyuncu item in player)
            {
                topHucum += item.oyuncuHuc;
            }

            topHucum = topHucum / player.Count;
            
            return topHucum;
        }

        //oyuncuların ortalama savunma değerleriyle_
        //takımın savunma değerlini oluşturma
        public int setDefans()
        {
            int topDef = 0;

            //ortalamayı hesaplar
            foreach (Oyuncu item in player)
            {
                topDef += item.oyuncuSav;
            }

            topDef = topDef / player.Count;

            return topDef;
        }

        //oyuncuların özelliklerini atama
        public void setOyuncu(string adi, int sav, int huc)
        {
            player.Add(new Oyuncu { oyuncuAd = adi, oyuncuHuc = huc, oyuncuSav = sav });
        }
    }
}
