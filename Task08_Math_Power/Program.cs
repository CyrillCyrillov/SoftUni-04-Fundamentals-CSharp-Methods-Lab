using System;

namespace Task08_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Gradation(number1, number2));
        }

        static double Gradation(double basis, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= basis;
            }
            
            return result;
        }
    }
}
