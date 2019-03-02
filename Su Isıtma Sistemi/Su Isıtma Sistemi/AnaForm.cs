using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Su_Isıtma_Sistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        SicaklikUyelik sicaklikUyelik = new SicaklikUyelik();
        SeviyeUyelik seviyeUyelik = new SeviyeUyelik();
        ArrayList cikislar = new ArrayList();

        public static double sicaklikGiris;
        public static double seviyeGiris;
        public static double rezistansCikis;

        private void btnGirisUyelikDegerleri_Click(object sender, EventArgs e)
        {
            string s1 = "Çok Düşük İçin Üyelik Derecesi: ";
            string s2 = "Düşük İçin Üyelik Derecesi: ";
            string s3 = "Orta İçin Üyelik Derecesi: ";
            string s4 = "Yüksek İçin Üyelik Derecesi: ";
            string s5 = "Çok Yüksek İçin Üyelik Derecesi: ";

            sicaklikGiris = Convert.ToDouble(txtSicaklikGiris.Text);
            sicaklikUyelik.UyelikDerecesiHesapla(sicaklikGiris);

            lblSicaklikCokDusuk.Text = s1 + sicaklikUyelik.cokDusuk.uyelikDerecesi.ToString("0.##");
            lblSicaklikDusuk.Text = s2 + sicaklikUyelik.dusuk.uyelikDerecesi.ToString("0.##");
            lblSicaklikOrta.Text = s3 + sicaklikUyelik.orta.uyelikDerecesi.ToString("0.##");
            lblSicaklikYuksek.Text = s4 + sicaklikUyelik.yuksek.uyelikDerecesi.ToString("0.##");
            lblSicaklikCokYuksek.Text = s5 + sicaklikUyelik.cokYuksek.uyelikDerecesi.ToString("0.##");

            seviyeGiris = Convert.ToDouble(txtSeviyeGiris.Text);
            seviyeUyelik.UyelikDerecesiHesapla(seviyeGiris);

            lblSeviyeCokDusuk.Text = s1 + seviyeUyelik.cokDusuk.uyelikDerecesi.ToString("0.##");
            lblSeviyeDusuk.Text = s2 + seviyeUyelik.dusuk.uyelikDerecesi.ToString("0.##");
            lblSeviyeOrta.Text = s3 + seviyeUyelik.orta.uyelikDerecesi.ToString("0.##");
            lblSeviyeYuksek.Text = s4 + seviyeUyelik.yuksek.uyelikDerecesi.ToString("0.##");
            lblSeviyeCokYuksek.Text = s5 + seviyeUyelik.cokYuksek.uyelikDerecesi.ToString("0.##");
        }

        private void btnKuralTabani_Click(object sender, EventArgs e)
        {
            string uygulananKurallar = "";

            foreach (var sicaklik in sicaklikUyelik.araliklar)
            {
                if (sicaklik.uyelikDerecesi == 0) continue; // atla

                foreach (var seviye in seviyeUyelik.araliklar)
                {
                    if (seviye.uyelikDerecesi == 0) continue; // atla

                    string cikisIfade = KuralTabani.CikisGetir(sicaklik.ifade, seviye.ifade);

                    double cikisUyelikDegeri;
                    if (cikisIfade.Equals("Çıkışta Hareket Yok"))
                        cikisUyelikDegeri = 0;
                    else if (sicaklik.uyelikDerecesi < seviye.uyelikDerecesi)
                        cikisUyelikDegeri = sicaklik.uyelikDerecesi;
                    else cikisUyelikDegeri = seviye.uyelikDerecesi;

                    cikislar.Add(cikisUyelikDegeri);
                    cikislar.Add(cikisIfade);

                    uygulananKurallar += string.Format("EĞER Su Sıcaklığı {0}({1}) ve Su Seviyesi {2}({3}) O HALDE Çıkış {4}({5}) \n", sicaklik.ifade, sicaklik.uyelikDerecesi.ToString("0.##"), seviye.ifade, seviye.uyelikDerecesi.ToString("0.##"), cikisIfade, cikisUyelikDegeri.ToString("0.##"));
                }
            }

            rchUygulananKurallar.Text = uygulananKurallar;
        }

        private void btnCikisDegerleri_Click(object sender, EventArgs e)
        {
            double enBuyuk = (double)cikislar[0];
            string ifade = cikislar[1].ToString();
            
            List<string> uygKurallar = new List<string>();

            for (int i = 0; i < cikislar.Count; i += 2)
            {
                if ((double)cikislar[i] > enBuyuk)
                {
                    enBuyuk = (double)cikislar[i];
                    ifade = cikislar[i + 1].ToString();
                }

                if (!uygKurallar.Exists(x => x == cikislar[i + 1].ToString()))
                    uygKurallar.Add(cikislar[i + 1].ToString());
            }


            lblCikisUyelikDegeri.Text = "Kuralların Ateşlenmesiyle Bulunan Üyelik: " + enBuyuk.ToString("0.##");

            if (enBuyuk == 0)
            {
                lblDurulastirilmisCikis.Text += "0";
                return;
            }

            for (int i = 0; i < uygKurallar.Count; i++)
            {
                if (uygKurallar[i].Equals("Çok Düşük")) RezistansUyelik.CokDusukCikisDegeri(enBuyuk);
                if (uygKurallar[i].Equals("Düşük")) RezistansUyelik.DusukCikisDegeri(enBuyuk);
                if (uygKurallar[i].Equals("Orta")) RezistansUyelik.OrtaCikisDegeri(enBuyuk);
                if (uygKurallar[i].Equals("Yüksek")) RezistansUyelik.YuksekCikisDegeri(enBuyuk);
                if (uygKurallar[i].Equals("Çok Yüksek")) RezistansUyelik.CokYuksekCikisDegeri(enBuyuk);
            }

            rezistansCikis = RezistansUyelik.Durulastirma(enBuyuk);
            lblDurulastirilmisCikis.Text = rezistansCikis.ToString();

            RezistansUyelik.cikislar.Clear();
        }

        private void btnGirisGrafik_Click(object sender, EventArgs e)
        {
            GirisGrafik g = new GirisGrafik();
            g.ShowDialog();
        }

        private void btnKurallar_Click(object sender, EventArgs e)
        {
            KuralTablosu kt = new KuralTablosu();
            kt.ShowDialog();
        }

        private void btnCikisGrafik_Click(object sender, EventArgs e)
        {
            CikisGrafik c = new CikisGrafik();
            c.ShowDialog();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
