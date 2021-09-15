using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Energydrink
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Energydrink(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
