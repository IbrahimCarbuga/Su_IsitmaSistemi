using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Isıtma_Sistemi
{
    public class Aralik
    {
        public double min;
        public double max;
        public string ifade;
        public double uyelikDerecesi;

        public Aralik(double min, double max, string ifade)
        {
            this.min = min;
            this.max = max;
            this.ifade = ifade;
        }

        public void Clear()
        {
            uyelikDerecesi = 0;
        }

    }
}
