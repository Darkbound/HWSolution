using System;

namespace Homework_5
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Please input your first number: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Please input your second number: ");
            float b = float.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }
            else
            {
                Console.WriteLine("The first number is smaller than the second number.");
            }
        }
    }
}
