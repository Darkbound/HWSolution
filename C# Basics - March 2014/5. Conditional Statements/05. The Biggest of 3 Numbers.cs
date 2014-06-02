using System;

namespace Homework_5
{
    class TheBiggestNumber
    {
        static void Main()
        {
            Console.Write("Input your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input your second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input your third number: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c) { Console.WriteLine("{0} is the biggest number!", a); }

            else
            {
                if (b > a && b > c) { Console.WriteLine("{0} is the biggest number!", b); }
                else { Console.WriteLine("{0} is the biggest number!", c); }
            }
        }
    }
}
