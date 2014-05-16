using System;

namespace Homework
{
    class ModifyBit
    {
        static void Main()
        {
            Console.Write("Please input your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which bit position do you want change: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Make it 0 or 1: ");
            int exchange = Convert.ToInt32(Console.ReadLine());
            int mask = 0;
            int bit = 0;
            if (exchange == 1)
            {
                mask = 1 << p;
                bit = num | mask;
                Console.WriteLine("The new number is {0}.", bit);
            }
            else
            {
                if (exchange == 0)
                {
                    mask = ~(1 << p);
                    bit = num & mask;
                    Console.WriteLine("The new number is {0}.", bit);
                }
                else
                {
                    Console.WriteLine("Error! You must select 0 or 1!");
                }
            }
        }
    }
}
