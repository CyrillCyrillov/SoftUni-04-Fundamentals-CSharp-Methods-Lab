using System;

namespace Task03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            
            Calculation(operation, number1, number2);
        }

        static void Calculation(string operation, int number1, int number2)
        {
            switch (operation)
            {
                case "add":
                    Console.WriteLine(number1 + number2);
                    break;
                case "multiply":
                    Console.WriteLine(number1 * number2);
                    break;
                case "subtract":
                    Console.WriteLine(number1 - number2);
                    break;
                case "divide":
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    break;
            }
        }
    }
}
