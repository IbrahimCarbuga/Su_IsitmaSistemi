using System;
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
    public partial class CikisGrafik : Form
    {
        public CikisGrafik()
        {
            InitializeComponent();
        }

        private void CikisGrafik_Load(object sender, EventArgs e)
        {
            rezistantGrafigi.ChartAreas[0].AxisX.Title = "Rezistans";
            rezistantGrafigi.ChartAreas[0].AxisY.Title = "Üyelik Derecesi";

            rezistantGrafigi.ChartAreas[0].AxisX.Minimum = 0;
            rezistantGrafigi.ChartAreas[0].AxisX.Maximum = 6;

            rezistantGrafigi.ChartAreas[0].AxisY.Minimum = 0;
            rezistantGrafigi.ChartAreas[0].AxisY.Maximum = 1;

            RezistansUyelik rezistans = new RezistansUyelik();

            rezistantGrafigi.Series["Çok Düşük"].Points.AddXY(0, rezistans.CokDusukUyelikDerecesi(0));
            rezistantGrafigi.Series["Çok Düşük"].Points.AddXY(0.5, rezistans.CokDusukUyelikDerecesi(0.5));
            rezistantGrafigi.Series["Çok Düşük"].Points.AddXY(1, rezistans.CokDusukUyelikDerecesi(1));

            rezistantGrafigi.Series["Düşük"].Points.AddXY(0.5, rezistans.DusukUyelikDerecesi(0.5));
            rezistantGrafigi.Series["Düşük"].Points.AddXY(1.25, rezistans.DusukUyelikDerecesi(1.25));
            rezistantGrafigi.Series["Düşük"].Points.AddXY(2, rezistans.DusukUyelikDerecesi(2));

            rezistantGrafigi.Series["Orta"].Points.AddXY(1.5, rezistans.OrtaUyelikDerecesi(1.5));
            rezistantGrafigi.Series["Orta"].Points.AddXY(2.5, rezistans.OrtaUyelikDerecesi(2.5));
            rezistantGrafigi.Series["Orta"].Points.AddXY(3.5, rezistans.OrtaUyelikDerecesi(3.5));

            rezistantGrafigi.Series["Yüksek"].Points.AddXY(3, rezistans.YuksekUyelikDerecesi(3));
            rezistantGrafigi.Series["Yüksek"].Points.AddXY(3.75, rezistans.YuksekUyelikDerecesi(3.75));
            rezistantGrafigi.Series["Yüksek"].Points.AddXY(4.5, rezistans.YuksekUyelikDerecesi(4.5));

            rezistantGrafigi.Series["Çok Yüksek"].Points.AddXY(4, rezistans.CokYuksekUyelikDerecesi(4));
            rezistantGrafigi.Series["Çok Yüksek"].Points.AddXY(4.5, rezistans.CokYuksekUyelikDerecesi(4.5));
            rezistantGrafigi.Series["Çok Yüksek"].Points.AddXY(5, rezistans.CokYuksekUyelikDerecesi(5));

        }

        private void btnCikisKirmiziCizgi_Click(object sender, EventArgs e)
        {
            rezistantGrafigi.Series["Çıkış"].Points.AddXY(AnaForm.rezistansCikis, 0);
            rezistantGrafigi.Series["Çıkış"].Points.AddXY(AnaForm.rezistansCikis, 1);
        }
    }
}
