using System;

namespace Homework_6
{
    class CatalanNums
    {
        static void Main()
        {
            Console.WriteLine("Use a value in range: 1 < n < 100");
            Console.Write("Please enter a value for n: ");
            double n = double.Parse(Console.ReadLine());
            double factn = 1;
            double fact2n = 1;
            double factn1 = 1;
            double sum = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                if (i > 0 && i <= n)
                {
                    factn *= i;
                }
                if (i > 0 && i <= 2 * n)
                {
                    fact2n *= i;
                }
                if (i > 0 && i <= (n + 1))
                {
                    factn1 *= i;
                }
            }
            sum = fact2n / (factn1 * factn);
            Console.WriteLine(sum);
        }
    }
}
