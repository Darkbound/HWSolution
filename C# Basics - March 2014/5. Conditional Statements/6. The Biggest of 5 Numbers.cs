using System;
using System.Linq;

namespace Homework_5
{
    class BiggestOf5Numbers
    {
        static void Main()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number: ");
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }
            Console.WriteLine("The biggest number is: {0}", numbers.Max());
        }
    }
}
