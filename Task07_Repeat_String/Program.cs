using System;

namespace Task07_Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            //string outputString = MultiplateString(inputString, repeat);

            //Console.WriteLine(outputString);

            MultiplateString(inputString, repeat);
        }

        static void MultiplateString(string text, int count)
        {
            // StringBuilder result = new StringBuilder();
            string rezult = string.Empty;
            for (int i = 0; i < count; i++)
            {
                //result.Append(text);
                //return result.ToString();
                rezult += text;
            }

            Console.WriteLine(rezult);

        }
    }
}
