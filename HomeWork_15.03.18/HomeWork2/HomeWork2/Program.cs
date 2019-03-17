using System;


namespace HomeWork2
{

    abstract class Flower
    {
        public abstract int GetPrice();
    }

    class Rose : Flower
    {
        int price;

        public Rose() { price = 30; }

        public override int GetPrice()
        {
            return price;
        }
    }

    class Sunflower : Flower
    {
        int price;

        public Sunflower() { price = 20; }

        public override int GetPrice()
        {
            return price;
        }
    }

    class Narcissus : Flower
    {
        int price;

        public Narcissus() { price = 45; }

        public override int GetPrice()
        {
            return price;
        }
    }


    class Program
    {
        static void Main()
        {
            Flower[] flowers = { new Narcissus(), new Rose(), new Sunflower(), new Narcissus() };
            int totalCost = 0;
            foreach(Flower f in flowers)
            {
                totalCost += f.GetPrice();
            }
            Console.WriteLine("Общая стоимость букета: {0}", totalCost);
            Console.ReadLine();
        }
    }
}
