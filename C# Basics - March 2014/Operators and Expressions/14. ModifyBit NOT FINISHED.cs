using System;

namespace ConsoleApplication1
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
            if (exchange == 1)
            {
                
            }
            else
            {
                if (exchange == 0)
                {
                    
                }
                else
                {
                    Console.WriteLine("Error! You must select 0 or 1!");
                }
            }
        }
    }
}
