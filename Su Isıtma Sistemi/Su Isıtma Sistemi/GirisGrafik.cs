using System;
using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class GirisGrafik : Form
    {
        public GirisGrafik()
        {
            InitializeComponent();
        }

        private void GirisGrafik_Load(object sender, EventArgs e)
        {
            sicaklikGrafigi.ChartAreas[0].AxisX.Title = "Sıcaklık (C)";
            sicaklikGrafigi.ChartAreas[0].AxisY.Title = "Üyelik Derecesi";

            sicaklikGrafigi.ChartAreas[0].AxisX.Minimum = 0;
            sicaklikGrafigi.ChartAreas[0].AxisX.Maximum = 120;

            sicaklikGrafigi.ChartAreas[0].AxisY.Minimum = 0;
            sicaklikGrafigi.ChartAreas[0].AxisY.Maximum = 1;

            SicaklikUyelik sicaklik = new SicaklikUyelik();

            sicaklikGrafigi.Series["Çok Düşük"].Points.AddXY(0, sicaklik.CokDusukUyelikDerecesi(0));
            sicaklikGrafigi.Series["Çok Düşük"].Points.AddXY(10, sicaklik.CokDusukUyelikDerecesi(10));
            sicaklikGrafigi.Series["Çok Düşük"].Points.AddXY(20, sicaklik.CokDusukUyelikDerecesi(20));

            sicaklikGrafigi.Series["Düşük"].Points.AddXY(15, sicaklik.DusukUyelikDerecesi(15));
            sicaklikGrafigi.Series["Düşük"].Points.AddXY(27.5, sicaklik.DusukUyelikDerecesi(27.5));
            sicaklikGrafigi.Series["Düşük"].Points.AddXY(40, sicaklik.DusukUyelikDerecesi(40));

            sicaklikGrafigi.Series["Orta"].Points.AddXY(35, sicaklik.OrtaUyelikDerecesi(35));
            sicaklikGrafigi.Series["Orta"].Points.AddXY(47.5, sicaklik.OrtaUyelikDerecesi(47.5));
            sicaklikGrafigi.Series["Orta"].Points.AddXY(60, sicaklik.OrtaUyelikDerecesi(60));

            sicaklikGrafigi.Series["Yüksek"].Points.AddXY(55, sicaklik.YuksekUyelikDerecesi(55));
            sicaklikGrafigi.Series["Yüksek"].Points.AddXY(67.5, sicaklik.YuksekUyelikDerecesi(67.5));
            sicaklikGrafigi.Series["Yüksek"].Points.AddXY(80, sicaklik.YuksekUyelikDerecesi(80));

            sicaklikGrafigi.Series["Çok Yüksek"].Points.AddXY(75, sicaklik.CokYuksekUyelikDerecesi(75));
            sicaklikGrafigi.Series["Çok Yüksek"].Points.AddXY(87.5, sicaklik.CokYuksekUyelikDerecesi(87.5));
            sicaklikGrafigi.Series["Çok Yüksek"].Points.AddXY(100, sicaklik.CokYuksekUyelikDerecesi(100));

            

            seviyeGrafigi.ChartAreas[0].AxisX.Title = "Seviye (lt)";
            seviyeGrafigi.ChartAreas[0].AxisY.Title = "Üyelik Derecesi";

            seviyeGrafigi.ChartAreas[0].AxisX.Minimum = 0;
            seviyeGrafigi.ChartAreas[0].AxisX.Maximum = 6;

            seviyeGrafigi.ChartAreas[0].AxisY.Minimum = 0;
            seviyeGrafigi.ChartAreas[0].AxisY.Maximum = 1;

            SeviyeUyelik seviye = new SeviyeUyelik();

            seviyeGrafigi.Series["Çok Düşük"].Points.AddXY(0, seviye.CokDusukUyelikDerecesi(0));
            seviyeGrafigi.Series["Çok Düşük"].Points.AddXY(0.5, seviye.CokDusukUyelikDerecesi(0.5));
            seviyeGrafigi.Series["Çok Düşük"].Points.AddXY(1, seviye.CokDusukUyelikDerecesi(1));

            seviyeGrafigi.Series["Düşük"].Points.AddXY(0.5, seviye.DusukUyelikDerecesi(0.5));
            seviyeGrafigi.Series["Düşük"].Points.AddXY(1.25, seviye.DusukUyelikDerecesi(1.25));
            seviyeGrafigi.Series["Düşük"].Points.AddXY(2, seviye.DusukUyelikDerecesi(2));

            seviyeGrafigi.Series["Orta"].Points.AddXY(1.5, seviye.OrtaUyelikDerecesi(1.5));
            seviyeGrafigi.Series["Orta"].Points.AddXY(2.5, seviye.OrtaUyelikDerecesi(2.5));
            seviyeGrafigi.Series["Orta"].Points.AddXY(3.5, seviye.OrtaUyelikDerecesi(3.5));

            seviyeGrafigi.Series["Yüksek"].Points.AddXY(3, seviye.YuksekUyelikDerecesi(3));
            seviyeGrafigi.Series["Yüksek"].Points.AddXY(3.75, seviye.YuksekUyelikDerecesi(3.75));
            seviyeGrafigi.Series["Yüksek"].Points.AddXY(4.5, seviye.YuksekUyelikDerecesi(4.5));

            seviyeGrafigi.Series["Çok Yüksek"].Points.AddXY(4, seviye.CokYuksekUyelikDerecesi(4));
            seviyeGrafigi.Series["Çok Yüksek"].Points.AddXY(4.5, seviye.CokYuksekUyelikDerecesi(4.5));
            seviyeGrafigi.Series["Çok Yüksek"].Points.AddXY(5, seviye.CokYuksekUyelikDerecesi(5));

        }

        private void btnGirisKirmiziCizgi_Click(object sender, EventArgs e)
        {
            sicaklikGrafigi.Series["Giriş"].Points.AddXY(AnaForm.sicaklikGiris, 0);
            sicaklikGrafigi.Series["Giriş"].Points.AddXY(AnaForm.sicaklikGiris, 1);

            seviyeGrafigi.Series["Giriş"].Points.AddXY(AnaForm.seviyeGiris, 0);
            seviyeGrafigi.Series["Giriş"].Points.AddXY(AnaForm.seviyeGiris, 1);
        }
    }
}
