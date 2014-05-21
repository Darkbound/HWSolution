using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_6
{
    class MinMaxSumAvg
    {
        static void Main()
        {
            List<double> list = new List<double>();

            Console.Write("How many numbers are you going to input: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input a number: ");
                list.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Max: " + list.Max());
            Console.WriteLine("Sum: " + list.Sum());
            Console.WriteLine("Average: " + list.Average());
        }
    }
}
