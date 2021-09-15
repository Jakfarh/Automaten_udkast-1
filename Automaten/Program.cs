using System;

namespace Automaten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool run = true;
            Dispenser dispenser = new Dispenser();
            Inventorymanager inventorymanager = new Inventorymanager(dispenser);
            Operator o = new Operator(inventorymanager);



            while (run)
            {
                int Choice2;

                Console.WriteLine("Velkommen til Automaten!");
                Console.WriteLine("Vær opmærksom på at maskinen kun tager lige betaling!");

                Console.WriteLine("Hvilket produkt ønsker du fra automaten?");
                Console.WriteLine("1, Sodavand");
                Console.WriteLine("2, Slik");
                Console.WriteLine("3, Frugt");
                Console.WriteLine("4, Energidrik");
                Console.WriteLine("tast 0, når de er færdig!");
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:

                        Console.WriteLine("Hvilken sodavand kunne du tænke dig?");
                        Console.WriteLine("1, Cola");
                        Console.WriteLine("2, Miranda");
                        Console.WriteLine("3, Sprite");
                        Choice2 = int.Parse(Console.ReadLine());
                        switch (Choice2)
                        {
                            case 1:
                                if (inventorymanager.CheckCount("soda") > 0)
                                {
                                    Console.WriteLine($"Indkast venlist {inventorymanager.GetPrice("soda")}");
                                    int payment = int.Parse(Console.ReadLine());
                                    if (payment == inventorymanager.GetPrice("soda"))
                                    {
                                        inventorymanager.TransferSoda("cola");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Det indkastede beløb stemmer desværre ikke overens med prisen");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("varen er desværre udsolgt!");
                                }
                                break;

                            case 2:

                                break;

                            case 3:

                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Hvilket slik kunne du tænke dig?");
                        Console.WriteLine("1, Vingummi");
                        Console.WriteLine("2, Chips");
                        Console.WriteLine("3, Chokolade");
                        Choice2 = int.Parse(Console.ReadLine());
                        switch (Choice2)
                        {
                            case 1:

                                break;

                            case 2:

                                break;

                            case 3:

                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Hvilken frugt kunne du tænke dig?");
                        Console.WriteLine("1, Æble");
                        Console.WriteLine("2, Banan");
                        Console.WriteLine("3, Pære");
                        Choice2 = int.Parse(Console.ReadLine());
                        switch (Choice2)
                        {
                            case 1:

                                break;

                            case 2:

                                break;

                            case 3:

                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Hvilken energidrik kunne du tænke dig?");
                        Console.WriteLine("1, Cult");
                        Console.WriteLine("2, Redbull");
                        Choice2 = int.Parse(Console.ReadLine());
                        switch (Choice2)
                        {
                            case 1:

                                break;

                            case 2:

                                break;
                        }
                        break;

                    case 5:

                        bool admin = true;
                        while (admin)
                        {
                            Console.WriteLine("Velkommen operatør! Indtast venligst operatørkode!");
                            int indtastning = int.Parse(Console.ReadLine());
                            int operatørkode = 654321;
                            if (indtastning == operatørkode)
                            {
                                Console.WriteLine("Velkommen til operatørmenuen!");
                                Console.WriteLine("1, for at ændre prisen på sodavand");
                                Console.WriteLine("2, for at ændre prisen på slik");
                                Console.WriteLine("3, for at ændre prisen på frugt");
                                Console.WriteLine("4, for at ændre prisen på energidrikke");
                                Console.WriteLine("5, for at opfylde varer");
                                Console.WriteLine("6, for at tømme alle varer");
                                Console.WriteLine("7, for at udtrække penge fra maskinen");
                                Console.WriteLine("8, for at gå tilbage til hovedmenuen");
                                int choice3 = int.Parse(Console.ReadLine());

                                switch (choice3)
                                {
                                    case 1:
                                        Console.WriteLine("Hvilken prissætning ønskes på sodavand?");
                                        int newpricesoda = int.Parse(Console.ReadLine());
                                        o.pricesetter("soda", newpricesoda);
                                        Console.WriteLine($"Prisen på sodavand er nu ændret til {newpricesoda}kr");
                                        break;

                                    case 2:
                                        Console.WriteLine("Hvilken prissætning ønskes på slik?");
                                        int newpricecandy = int.Parse(Console.ReadLine());
                                        o.pricesetter("candy", newpricecandy);
                                        Console.WriteLine($"Prisen på sodavand er nu ændret til {newpricecandy}kr");
                                        break;

                                    case 3:
                                        Console.WriteLine("Hvilken prissætning ønskes på frugt?");
                                        int newpricefruit = int.Parse(Console.ReadLine());
                                        o.pricesetter("fruit", newpricefruit);
                                        Console.WriteLine($"Prisen på frugt er nu ændret til {newpricefruit}kr");
                                        break;

                                    case 4:
                                        Console.WriteLine("Hvilken prissætning ønskes på energidrikke?");
                                        int newpriceenergy = int.Parse(Console.ReadLine());
                                        o.pricesetter("energydrinks", newpriceenergy);
                                        Console.WriteLine($"Prisen på energidrikke er nu ændret til {newpriceenergy}kr");
                                        break;

                                    case 5:
                                        o.MachineRefill();
                                        break;

                                    case 6:
                                        o.EmptyMachine();
                                        break;

                                    case 7:
                                        break;

                                    case 8:
                                        admin = false;
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Beklager, forkert kode.");
                            }
                        }
                        break;

                    case 0:
                        run = false;
                        break;
                }
            }
            Console.WriteLine($"fjern venligt følgende varer fra dispenseren:");
            foreach (string item in dispenser.dispenser)
            {
                Console.WriteLine(item);
            }
        }
    }
}