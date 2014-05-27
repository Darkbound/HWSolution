using System;
using System.Linq;
using System.Collections.Generic;

namespace Homework_6
{
    class RandomizeNums1toN
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();        
            Random rand = new Random();
 
            for (int i = 0; i < n; i++)
            {
                int num = rand.Next(0, n) + 1;
 
                while (numbers.Contains(num))
                {
                    num = rand.Next(0, n) + 1;
                }
                numbers.Add(num);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
