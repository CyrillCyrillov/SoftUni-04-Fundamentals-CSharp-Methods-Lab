using System;

namespace Task05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            CalculateOrder(product, quantity);
        }

        static void CalculateOrder(string product, double quantity)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{quantity * 1.5:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity * 1:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2.00:f2}");
                    break;
            }
        }
    }
}
