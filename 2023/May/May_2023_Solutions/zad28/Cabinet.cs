using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad28
{
    public class Cabinet : Furniture
    {
        private int numberOfhinges;
        public int NumberOfHinges
        {
            get { return numberOfhinges; }
            set { numberOfhinges = value; }
        }
        public Cabinet(string type, double price, int
       numberofhinges) : base(type, price)
        {
            this.NumberOfHinges = numberofhinges;
        }
        public override double PriceClient()
        {
            return base.ProductionPrice * 1.15 + this.NumberOfHinges
           * 4.50;
        }
        public override string ToString()
        {
            return $"The cabinet costs {PriceClient():f2} lv.";
        }
    }
}