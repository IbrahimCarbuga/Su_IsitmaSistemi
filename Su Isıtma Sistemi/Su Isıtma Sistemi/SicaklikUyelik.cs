using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Isıtma_Sistemi
{
   public class SicaklikUyelik
    {
        public Aralik cokDusuk;
        public Aralik dusuk;
        public Aralik orta;
        public Aralik yuksek;
        public Aralik cokYuksek;
        public List<Aralik> araliklar;

        public SicaklikUyelik()
        {
            cokDusuk = new Aralik(0 , 20, "Çok Düşük");
            dusuk = new Aralik(15, 40, "Düşük");
            orta = new Aralik(35, 60, "Orta");
            yuksek = new Aralik(55, 80, "Yüksek");
            cokYuksek = new Aralik(75, 100, "Çok Yüksek");

            araliklar = new List<Aralik>();
            araliklar.Add(cokDusuk);
            araliklar.Add(dusuk);
            araliklar.Add(orta);
            araliklar.Add(yuksek);
            araliklar.Add(cokYuksek);
        }

        public double CokDusukUyelikDerecesi(double x)
        {
            if (x >= 0 && x <= 10) cokDusuk.uyelikDerecesi = 1; 
            else if (x >= 10 && x <= 20) cokDusuk.uyelikDerecesi = (20 - x) / 10;
            else cokDusuk.uyelikDerecesi = 0;

            return cokDusuk.uyelikDerecesi;
        }

        public double DusukUyelikDerecesi(double x)
        {
            if (x >= 15 && x <= 27.5) dusuk.uyelikDerecesi = (x - 15)/12.5;
            else if (x >= 27.5 && x <= 40) dusuk.uyelikDerecesi = (40 - x) / 12.5;
            else dusuk.uyelikDerecesi = 0;

            return dusuk.uyelikDerecesi;
        }

        public double OrtaUyelikDerecesi(double x)
        {
            if (x >= 35 && x <= 47.5) orta.uyelikDerecesi = (x - 35) / 12.5;
            else if (x >= 47.5 && x <= 60) orta.uyelikDerecesi = (60 - x) / 12.5;
            else orta.uyelikDerecesi = 0;

            return orta.uyelikDerecesi;
        }

        public double YuksekUyelikDerecesi(double x)
        {
            if (x >= 55 && x <= 67.5) yuksek.uyelikDerecesi = (x - 55) / 12.5;
            else if (x >= 67.5 && x <= 80) yuksek.uyelikDerecesi = (80 - x) / 12.5;
            else yuksek.uyelikDerecesi = 0;

            return yuksek.uyelikDerecesi;
        }

        public double CokYuksekUyelikDerecesi(double x)
        {
            if (x >= 75 && x <= 87.5) cokYuksek.uyelikDerecesi = (x - 75) / 12.5;
            else if (x >= 87.5 && x <= 100) cokYuksek.uyelikDerecesi = 1;
            else cokYuksek.uyelikDerecesi = 0;

            return cokYuksek.uyelikDerecesi;
        }

        public void UyelikDerecesiHesapla(double x)
        {
            Clear();

            CokDusukUyelikDerecesi(x);
            DusukUyelikDerecesi(x);
            OrtaUyelikDerecesi(x);
            YuksekUyelikDerecesi(x);
            CokYuksekUyelikDerecesi(x);
        }

        public void Clear()
        {
            foreach (var aralik in araliklar)
            {
                aralik.Clear();
            }
        }

    }
}
