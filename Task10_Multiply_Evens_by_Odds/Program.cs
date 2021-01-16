using System;

namespace Task10_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int sumOfEvenDigits = GetSumOfEvenDigits(number);
            int sumOfOddDigits = GetSumOfOddDigits(number);

            
            Console.WriteLine(sumOfEvenDigits * sumOfOddDigits);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;
            while (number > 0)
            {
                int nextDigit = number % 10;
                if(nextDigit % 2 == 0)
                {
                    sumOfEvenDigits += nextDigit;
                }
                number = number / 10;
            }

            return sumOfEvenDigits;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;
            while (number >0)
            {
                int nextDigit = number % 10;
                if(nextDigit % 2 != 0)
                {
                    sumOfOddDigits += nextDigit;
                }
                number = number / 10;
            }

            return sumOfOddDigits;
        }
    }
}
