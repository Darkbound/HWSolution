using System;

namespace Homework_6
{
    class NumsFrom1toN
    {
        static void Main()
        {
            Console.Write("Print numbers from 1 to: ");
            int n = int.Parse(Console.ReadLine());
            string numbers = "";
            for (int i = 1; i <= n; i++)
            {
                numbers += i.ToString() + " ";
            }
            Console.WriteLine("The numbers are: {0}", numbers);
        }
    }
}
