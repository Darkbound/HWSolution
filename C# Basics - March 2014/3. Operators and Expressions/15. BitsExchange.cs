using System;

namespace Homework
{
class BitsExchange
{
    static void Main()
    {
        Console.Write("Please input your number: ");
        uint num = Convert.ToUInt32(Console.ReadLine());
        uint numP = 0;
        uint bit1 = 0;
        uint bit2 = 0;
        uint mask1 = 0;
        uint mask2 = 0;

        for (int i = 0; i < 3; i++)
        {
            // get bit 3 (,4,5)
            numP = num >> (3 + i);
            bit1 = numP & 1;
            // get bit 24 (,25,26)
            numP = num >> (24 + i);
            bit2 = numP & 1;
            // shift bit 3 (,4,5) to positon 24 (,25,26)
            bit1 = bit1 << (24 + i);
            // shift bit 24 (,25,26) to position 3 (,4,5)
            bit2 = bit2 << (3 + i);
            // set bit 3 (,4,5) to zero
            mask1 = (uint) 1 << (3 + i);
            num = num & ~mask1;
            // set bit 24 (,25,26) to zero
            mask2 = (uint) 1 << (24 + i);
            num = num & ~mask2;
            // put bit 3 (,4,5) in bit 24 (,25,26)
            num = num | bit1;
            // put bit 24 (,25,26) in bit 3 (,4,5)
            num = num | bit2;
        }
        Console.WriteLine("Your new number is: {0}", num);

    }
}
}
