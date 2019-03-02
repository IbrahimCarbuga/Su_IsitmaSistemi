using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Isıtma_Sistemi
{
    class KuralTabani
    {
        static List<string> kuralTabani = new List<string>() {
            // Sıcaklık,   Seviye,     Çıkış  
            "Çok Düşük",  "Çok Düşük",   "Orta",
            "Çok Düşük",  "Düşük",       "Yüksek",
            "Çok Düşük",  "Orta",        "Çok Yüksek",
            "Çok Düşük",  "Yüksek",      "Çok Yüksek",
            "Çok Düşük",  "Çok Yüksek",  "Çok Yüksek",

            "Düşük",      "Çok Düşük",   "Düşük",
            "Düşük",      "Düşük",       "Orta",
            "Düşük",      "Orta",        "Yüksek",
            "Düşük",      "Yüksek",      "Yüksek",
            "Düşük",      "Çok Yüksek",  "Yüksek",

            "Orta",       "Çok Düşük",   "Çok Düşük",
            "Orta",       "Düşük",       "Çok Düşük",
            "Orta",       "Orta",        "Orta",
            "Orta",       "Yüksek",      "Yüksek",
            "Orta",       "Çok Yüksek",  "Yüksek",

            "Yüksek",     "Çok Düşük",   "Çıkışta Hareket Yok",
            "Yüksek",     "Düşük",       "Çok Düşük",
            "Yüksek",     "Orta",        "Çok Düşük",
            "Yüksek",     "Yüksek",      "Düşük",
            "Yüksek",     "Çok Yüksek",  "Orta",

            "Çok Yüksek", "Çok Düşük",   "Çıkışta Hareket Yok",
            "Çok Yüksek", "Düşük",       "Çıkışta Hareket Yok",
            "Çok Yüksek", "Orta",        "Çıkışta Hareket Yok",
            "Çok Yüksek", "Yüksek",      "Çıkışta Hareket Yok",
            "Çok Yüksek", "Çok Yüksek",  "Çıkışta Hareket Yok",
        };

        public static string CikisGetir(string sicaklik, string seviye)
        {
            for (int i = 0; i < kuralTabani.Count; i += 3)
            {
                if (kuralTabani[i].Equals(sicaklik) && kuralTabani[i + 1].Equals(seviye))
                    return kuralTabani[i + 2];
            }

            return "";
        }
    }
}
