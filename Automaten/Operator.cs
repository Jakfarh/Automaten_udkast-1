using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Operator
    {
        Inventorymanager inventorymanager;

        public Operator(Inventorymanager manager)
        {
            inventorymanager = manager;
        }

        public void pricesetter(string waretype, int pricing)
        {
            switch (waretype)
            {
                case "soda":
                    inventorymanager.ChangeSodaPrice(pricing);
                    break;

                case "candy":
                    inventorymanager.ChangeCandyPrice(pricing);
                    break;

                case "fruit":
                    inventorymanager.ChangeFruitPrice(pricing);
                    break;

                case "energydrinks":
                    inventorymanager.ChangeEnergyPrice(pricing);
                    break;
            }

        }
        public void MachineRefill()
        {
            inventorymanager.AddSoda();
            inventorymanager.AddCandy();
            inventorymanager.AddFruit();
            inventorymanager.AddEnergyDrink();
        }

    public void EmptyMachine()
        {
            inventorymanager.RemoveSoda();
            inventorymanager.RemoveCandy();
            inventorymanager.RemoveFruit();
            inventorymanager.RemoveEnergyDrink();
        }
    }
}
