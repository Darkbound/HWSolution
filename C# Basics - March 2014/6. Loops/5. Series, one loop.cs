using System;

namespace Homework_6
{
    class Series
    {
        static void Main()
        {
            Console.Write("Please enter a value for n: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Please enter a value for x: ");
            double x = double.Parse(Console.ReadLine());
            double fact = 1;
            double sum = 1;
            double sumX = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sumX *= x;
                sum = sum + fact / sumX;

            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
