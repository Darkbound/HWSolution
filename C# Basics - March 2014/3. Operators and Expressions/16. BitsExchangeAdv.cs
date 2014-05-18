using System;

namespace Homework
{
class BitsExchangeAdv
{
    static void Main()
    {
        uint num = 0;
        try
        {
            Console.Write("Please input your number: ");
            num = Convert.ToUInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Out of Range!");
        }
        
        Console.Write("How many bits do you want to exchange: ");
        uint exchange = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Starting bit p: ");
        uint p = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Starting bit q: ");
        uint q = Convert.ToUInt32(Console.ReadLine());
        uint numP = 0;
        uint bit1 = 0;
        uint bit2 = 0;
        uint mask1 = 0;
        uint mask2 = 0;

        if (q + exchange > 31 || p+exchange > 31)
	    {
            Console.WriteLine("Out of range!");
	    }
        else
	    {
            if (p + exchange > q || q + exchange > p)
            {
                Console.WriteLine("Overlapping!");
            }
            else
            {
                for (int i = 0; i < exchange; i++)
                {
                    numP = num >> (int)(p + i);
                    bit1 = numP & 1;
                    numP = num >> (int)(q + i);
                    bit2 = numP & 1;
                    bit1 = bit1 << (int)(q + i);
                    bit2 = bit2 << (int)(p + i);
                    mask1 = (uint)1 << (int)(p + i);
                    num = num & ~mask1;
                    mask2 = (uint)1 << (int)(q + i);
                    num = num & ~mask2;
                    num = num | bit1;
                    num = num | bit2;
                }
                Console.WriteLine("Your new number is: {0}", num);
            }
	    }
    }
}
}
