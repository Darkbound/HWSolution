using System;

namespace Homework
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Input your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2==1)
            {
                Console.WriteLine("Odd number!");
            }
            else
            {
                Console.WriteLine("Even number!");
            }
        }
    }
}
