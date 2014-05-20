using System;

namespace Homework_6
{
    class NotDisivibleBy3or7
    {
        static void Main()
        {
            Console.Write("Numbers from 1 to: ");
            int n = int.Parse(Console.ReadLine());
            string numbers = "";

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    numbers += i + " ";
                }
            }
            Console.WriteLine(numbers);
        }
    }
}
