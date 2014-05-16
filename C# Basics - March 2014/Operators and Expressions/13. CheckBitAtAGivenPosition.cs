using System;

namespace Homework
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Please input your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which bit position do you want to check: ");
            int p = Convert.ToInt32(Console.ReadLine());
            int numP = num >> p;
            int bit = numP & 1;
            Console.WriteLine(bit == 1 ? true : false );
        }
    }
}
