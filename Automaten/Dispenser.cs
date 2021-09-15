using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Dispenser
    {
        public List<string> dispenser = new List<string>();

        public Dispenser()
        {

        }

        public void Addtodispenserlist(string name)
        {
            dispenser.Add(name);
        }
    }
}
