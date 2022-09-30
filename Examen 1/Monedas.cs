using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    public class Monedas
    {
        public double USD { get; set; }
        public double MXM { get; set; }
        public double CAD { get; set; }
        public double EUR { get; set; }
        public double JPY { get; set; }
        public Monedas()
        {
            this.USD = 0;
            this.MXM = 0;
            this.CAD = 0;
            this.EUR = 0;
            this.JPY = 0;
        }
        public Monedas(double USD, double MXM, double CAD, double EUR, double JPY)
        {
            this.USD = USD;
            this.MXM = MXM;
            this.CAD = CAD;
            this.EUR = EUR;
            this.JPY = JPY;

        }
    }
}
