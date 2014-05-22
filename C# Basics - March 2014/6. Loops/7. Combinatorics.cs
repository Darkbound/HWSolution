using System;

namespace Homework_6
{
    class Combinatorics
    {
        static void Main()
        {
            Console.WriteLine("Use values in range: 1 < k < n < 100");
            Console.Write("Please enter a value for n: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Please enter a value for k: ");
            double k = double.Parse(Console.ReadLine());
            double factn = 1;
            double factk = 1;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i > 0 && i <= n)
                {
                    factn *= i;
                }
                if (i > 0 && i <= k)
                {
                    factk *= i;
                }
            }
            sum = factn / factk;
            Console.WriteLine(sum);
        }
    }
}
