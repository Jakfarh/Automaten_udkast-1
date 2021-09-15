using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten 
{
    public class Inventorymanager
    {
        Inventory inventory;
        Dispenser dispenser;

        private int sPrice = 10;
        private int cPrice = 8;
        private int fPrice = 5;
        private int ePrice = 15;

        public Inventorymanager(Dispenser dispenser)
        {
            inventory = new Inventory();
            this.dispenser = dispenser;
        }

        public int CheckCount(string product)
        {
            switch (product)
            {
                case "soda":
                    return inventory.Colarow.Count;

                default:
                    return 0;
            }
        }

        public int GetPrice(string name)
        {
            switch (name)
            {
                case "soda":
                    return sPrice;

                case "candy":
                    return cPrice;

                case "fruit":
                    return fPrice;

                case "energydrink":
                    return ePrice;

                default:
                    return 0;
            }
        }

        public void ChangeSodaPrice(int price)
        {
            sPrice = price;
        }
        public void ChangeCandyPrice(int price)
        {
            cPrice = price;
        }
        public void ChangeFruitPrice(int price)
        {
            fPrice = price;
        }
        public void ChangeEnergyPrice(int price)
        {
            ePrice = price;
        }
        public void AddSoda()
        {
            while (inventory.Colarow.Count < 11)
                inventory.AddSoda("cola", sPrice);


            while (inventory.Mirandarow.Count < 11)
                inventory.AddSoda("miranda", sPrice);

            while (inventory.Spriterow.Count < 11)
                inventory.AddSoda("sprite", sPrice);


        }
        public void AddCandy()
        {
            while (inventory.Vingummirow.Count < 11)
                inventory.AddCandy("vingummi", cPrice);

            while (inventory.Chipsrow.Count < 11)
                inventory.AddCandy("chips", cPrice);

            while (inventory.Chokolaterow.Count < 11)
                inventory.AddCandy("chokolate", cPrice);
        }
        public void AddFruit()
        {
            while (inventory.Applerow.Count < 11)
                inventory.AddFruit("apple", fPrice);

            while (inventory.Bananarow.Count < 11)
                inventory.AddFruit("banana", fPrice);

            while (inventory.Pearrow.Count < 11)
                inventory.AddFruit("pear", fPrice);
        }
        public void AddEnergyDrink()
        {
            while (inventory.Cultrow.Count < 11)
                inventory.AddEnergyDrink("cult", ePrice);

            while (inventory.Redbullrow.Count < 11)
                inventory.AddEnergyDrink("redbull", ePrice);
        }
        public void RemoveSoda()
        {
            while (inventory.Colarow.Count > 0)
                inventory.RemoveSoda("cola");

            while (inventory.Mirandarow.Count > 0)
                inventory.RemoveSoda("miranda");

            while (inventory.Spriterow.Count > 0)
                inventory.RemoveSoda("sprite");
        }
        public void RemoveCandy()
        {
            while (inventory.Vingummirow.Count > 0)
                inventory.RemoveCandy("vingummi");

            while (inventory.Chipsrow.Count > 0)
                inventory.RemoveCandy("chips");

            while (inventory.Chokolaterow.Count > 0)
                inventory.RemoveCandy("chokolade");
        }
        public void RemoveFruit()
        {
            while (inventory.Applerow.Count > 0)
                inventory.RemoveFruit("æble");

            while (inventory.Bananarow.Count > 0)
                inventory.RemoveFruit("banana");

            while (inventory.Pearrow.Count > 0)
                inventory.RemoveFruit("pear");
        }
        public void RemoveEnergyDrink()
        {
            while (inventory.Cultrow.Count > 0)
                inventory.RemoveEnergyDrink("cult");

            while (inventory.Redbullrow.Count > 0)
                inventory.RemoveEnergyDrink("redbull");
        }


        public string TransferSoda(string name)
        {
            inventory.RemoveSoda(name);
            dispenser.Addtodispenserlist(name);
            return name;
        }
        public string TransferCandy(string name)
        {
            inventory.RemoveCandy(name);
            dispenser.Addtodispenserlist(name);
            return name;
        }
        public string TransferFruit(string name)
        {
            inventory.RemoveFruit(name);
            dispenser.Addtodispenserlist(name);
            return name;
        }
        public string TransferEnergyDrink(string name)
        {
            inventory.RemoveEnergyDrink(name);
            dispenser.Addtodispenserlist(name);
            return name;
        }
    }
}
