using System;

namespace Task11_Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double number2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = Addition(number1, number2);
                    break;
                case "-":
                    result = Subtraction(number1, number2);
                    break;
                case "*":
                    result = Multiplication(number1, number2);
                    break;
                case "/":
                    if (number2 == 0)
                        {
                            Console.WriteLine("Error!");
                        }  
                    else
                        {
                            result = Division(number1, number2);
                        }
                    break;

                default:
                    break;

            }

            Console.WriteLine(result);
        }

        static double Addition(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        static double Subtraction(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }

        static double Multiplication(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }

        static double Division(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }
    }
}
