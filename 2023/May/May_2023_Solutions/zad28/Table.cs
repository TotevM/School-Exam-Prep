using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad28
{
    public class Table : Furniture
    {
        public Table(string type, double price) : base(type, price)
        {
        }
        public override double PriceClient()
        {
            return base.ProductionPrice * 1.20;
        }
        public override string ToString()
        {
            return $"The table costs {PriceClient():f2} lv.";
        }
    }
}
