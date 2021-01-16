using System;

namespace Task04_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int topOfTriangle = int.Parse(Console.ReadLine());

            UpHalf(topOfTriangle);
            DownHalf(topOfTriangle);
        }

        static void UpHalf(int topOfTriangle)
        {
            for (int i = 1; i <= topOfTriangle; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        static void DownHalf(int topOfTriangle)
        {
            for (int i = topOfTriangle - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
