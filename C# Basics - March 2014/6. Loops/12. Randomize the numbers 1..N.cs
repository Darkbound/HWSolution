using System;
using System.Linq;

namespace Homework_6
{
    class RandomizeNums1toN
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int[] newnums = new int[n];
            int[] indexes = new int[n];
            Random rand = new Random();


            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }


            for (int i = 0; i < n; i++)
            {
                int num = rand.Next(0, n);

                while (indexes.Contains(num))
                {
                    num = rand.Next(0, n);
                }
                
                newnums[num] = numbers[i];
                indexes[i] = num;

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
