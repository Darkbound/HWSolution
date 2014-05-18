using System;

namespace Homework_5
{
    class PositiveOrNegative
    {
        static void Main()
        {
            Console.Write("Enter your first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your third number: ");
            int c = int.Parse(Console.ReadLine());
            int check = 0;

            if (a < 0)
            {
                check++;
            }
            if (b < 0)
            {
                check++;
            }
            if (c < 0)
            {
                check++;
            }

            if ((a * b * c) != 0)
            {
                if ((check == 1) || (check == 3))
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("Positive");
                }
            }
        }
    }
}
