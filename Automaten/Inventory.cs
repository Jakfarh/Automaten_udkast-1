using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Inventory
    {
        public Queue<Soda> Colarow;
        public Queue<Soda> Mirandarow = new Queue<Soda>();
        public Queue<Soda> Spriterow = new Queue<Soda>();

        public Queue<Candy> Vingummirow = new Queue<Candy>();
        public Queue<Candy> Chipsrow = new Queue<Candy>();
        public Queue<Candy> Chokolaterow = new Queue<Candy>();

        public Queue<Fruit> Applerow = new Queue<Fruit>();
        public Queue<Fruit> Bananarow = new Queue<Fruit>();
        public Queue<Fruit> Pearrow = new Queue<Fruit>();

        public Queue<Energydrink> Cultrow = new Queue<Energydrink>();
        public Queue<Energydrink> Redbullrow = new Queue<Energydrink>();

        public Inventory()
        {
            Colarow = new Queue<Soda>();
        }

        public void AddSoda(string name, int sPrice)
        {
            if (name == "cola")
            {
                Colarow.Enqueue(new Soda("Cola", sPrice));
            }
            else if (name == "miranda")
            {
                Mirandarow.Enqueue(new Soda("Miranda", sPrice));
            }
            else if (name == "sprite")
            {
                Spriterow.Enqueue(new Soda("Sprite", sPrice));
            }

            
        }
        public void AddCandy(string name, int cPrice)
        {
            if (name == "vingummi")
            {
                Vingummirow.Enqueue(new Candy("Vingummi", cPrice));
            }
            else if (name == "chips")
            {
                Chipsrow.Enqueue(new Candy("Chips", cPrice));
            }
            else if (name == "chokolate")
            {
                Chokolaterow.Enqueue(new Candy("Chokolade", cPrice));
            }
        }

        public void AddFruit(string name, int fPrice)
        {
            if (name == "apple")
            {
                Applerow.Enqueue(new Fruit("Æble", fPrice));
            }
            else if (name == "banana")
            {
                Bananarow.Enqueue(new Fruit("Banan", fPrice));
            }
            else if (name == "pear")
            {
                Pearrow.Enqueue(new Fruit("Pære", fPrice));
            }
        }
        public void AddEnergyDrink(string name, int ePrice)
        {
            if (name == "cult")
            {
                Cultrow.Enqueue(new Energydrink("Cult", ePrice));
            }
            else if (name == "redbull")
            {
                Redbullrow.Enqueue(new Energydrink("Redbull", ePrice));
            }
        }
        public void RemoveSoda(string name)
        {
            if (name == "cola")
            {
                Colarow.Dequeue();
            }
            else if (name == "miranda")
            {
                Mirandarow.Dequeue();
            }
            else if (name == "sprite")
            {
                Spriterow.Dequeue();
            }
        }
        public void RemoveCandy(string name)
        {
            if (name == "vingummi")
            {
                Vingummirow.Dequeue();
            }
            else if (name == "chips")
            {
                Chipsrow.Dequeue();
            }
            else if (name == "chokolade")
            {
                Chokolaterow.Dequeue();
            }
        }
        public void RemoveFruit(string name)
        {
            if (name == "apple")
            {
                Applerow.Dequeue();
            }
            else if (name == "banana")
            {
                Bananarow.Dequeue();
            }
            else if (name == "pear")
            {
                Pearrow.Dequeue();
            }
        }
        public void RemoveEnergyDrink(string name)
        {
            if (name == "cult")
            {
                Cultrow.Dequeue();
            }
            else if (name == "redbull")
            {
                Redbullrow.Dequeue();
            }
        }
    }
}
