using System;
using System.Text;

namespace Task09_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int number1 = int.Parse(Console.ReadLine());
                    int number2 = int.Parse(Console.ReadLine());
                    int greaterNumber = GetMax(number1, number2);
                    Console.WriteLine(greaterNumber);
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    char greaterChar = GetMax(char1, char2);
                    Console.WriteLine(greaterChar);
                    break;
                case "string":
                    string text1 = Console.ReadLine();
                    string text2 = Console.ReadLine();
                    string greaterString = GetMax(text1, text2);
                    Console.WriteLine(greaterString);
                    break;
                default:
                    break;
            }

            
        }

        static int GetMax(int n1, int n2)
        {
            if(n1 >= n2)
            {
                int greaterNumber = n1;
                return greaterNumber;
            }
            else
            {
                int greaterNumber = n2;
                return greaterNumber;
            }
        }

        static char GetMax(char ch1, char ch2)
        {
            if(ch1 >= ch2)
            {
                char greaterChar = ch1;
                return greaterChar;
            }
            else
            {
                char greaterChar = ch2;
                return greaterChar;
            }
        }

        static string GetMax(string t1, string t2)
        {
            int compear = t1.CompareTo(t2);
            if(compear > 0)
            {
                string greaterString = t1;
                return greaterString;
            }
            else
            {
                string greaterString = t2;
                return greaterString;
            }
        }
    }
}
