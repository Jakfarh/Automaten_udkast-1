using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Candy
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Candy(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
