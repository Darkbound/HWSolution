using System;

namespace Homework_6
{
    class RandNumsInRange
    {
        static void Main()
        {
            Console.Write("How many random numbers do you want: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Max: ");
            int max = int.Parse(Console.ReadLine());
            
            Random rand = new Random();

            for (int i = 0; i <= n; i++)
            {
                int num = rand.Next(min, max+1);
                Console.Write("{0} ", num);
            }
        }
    }
}
