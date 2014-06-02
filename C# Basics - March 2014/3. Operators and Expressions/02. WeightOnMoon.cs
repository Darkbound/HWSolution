using System;

namespace Homework
{
    class WeightOnMoon
    {
        static void Main()
        {
            Console.Write("Input your weight on Earth: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double moonW = num * 0.17;
            Console.WriteLine("Your weight on the moon would be: {0}kg", moonW);
        }
    }
}
