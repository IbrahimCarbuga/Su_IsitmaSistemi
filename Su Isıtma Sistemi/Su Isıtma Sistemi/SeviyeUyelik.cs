﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Isıtma_Sistemi
{
    public class SeviyeUyelik
    {
        public Aralik cokDusuk;
        public Aralik dusuk;
        public Aralik orta;
        public Aralik yuksek;
        public Aralik cokYuksek;
        public List<Aralik> araliklar;

        public SeviyeUyelik()
        {
            cokDusuk = new Aralik(0, 1, "Düşük");
            dusuk = new Aralik(0.5, 2, "Çok Düşük");
            orta = new Aralik(1.5, 3.5, "Orta");
            yuksek = new Aralik(3, 4.5, "Yüksek");
            cokYuksek = new Aralik(4, 5, "Çok Yüksek");

            araliklar = new List<Aralik>();
            araliklar.Add(cokDusuk);
            araliklar.Add(dusuk);
            araliklar.Add(orta);
            araliklar.Add(yuksek);
            araliklar.Add(cokYuksek);
        }

        public double CokDusukUyelikDerecesi(double y)
        {
            if (y >= 0 && y <= 0.5) cokDusuk.uyelikDerecesi = 1;
            else if (y >= 0.5 && y <= 1) cokDusuk.uyelikDerecesi = (1 - y) / 0.5;
            else cokDusuk.uyelikDerecesi = 0;

            return cokDusuk.uyelikDerecesi;
        }

        public double DusukUyelikDerecesi(double y)
        {
            if (y >= 0.5 && y <= 1.25) dusuk.uyelikDerecesi = (y - 0.5) / 0.75;
            else if (y >= 1.25 && y <= 2) dusuk.uyelikDerecesi = (2 - y) / 0.75;
            else dusuk.uyelikDerecesi = 0;

            return dusuk.uyelikDerecesi;
        }

        public double OrtaUyelikDerecesi(double y)
        {
            if (y >= 1.5 && y <= 2.25) orta.uyelikDerecesi = (y - 1.5) / 1;
            else if (y >= 2.25 && y <= 3.5) orta.uyelikDerecesi = (3.5 - y) / 1;
            else orta.uyelikDerecesi = 0;

            return orta.uyelikDerecesi;
        }

        public double YuksekUyelikDerecesi(double y)
        {
            if (y >= 3 && y <= 3.75) yuksek.uyelikDerecesi = (y - 3) / 0.75;
            else if (y >= 3.75 && y <= 4.5) yuksek.uyelikDerecesi = (4.5 - y) / 0.75;
            else yuksek.uyelikDerecesi = 0;

            return yuksek.uyelikDerecesi;
        }

        public double CokYuksekUyelikDerecesi(double y)
        {
            if (y >= 4 && y <= 4.5) cokYuksek.uyelikDerecesi = (y - 4) / 0.5;
            else if (y >= 4.5 && y <= 5) cokYuksek.uyelikDerecesi = 1;
            else cokYuksek.uyelikDerecesi = 0;

            return cokYuksek.uyelikDerecesi;
        }

        public void UyelikDerecesiHesapla(double y)
        {
            Clear();

            CokDusukUyelikDerecesi(y);
            DusukUyelikDerecesi(y);
            OrtaUyelikDerecesi(y);
            YuksekUyelikDerecesi(y);
            CokYuksekUyelikDerecesi(y);
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
