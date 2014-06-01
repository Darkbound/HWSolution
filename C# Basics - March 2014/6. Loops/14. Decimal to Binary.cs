using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your number: ");
            int num = int.Parse(Console.ReadLine());
            string newnum = "";
            double sum = 0;
            int j = 0;
            while (sum < num)
            {
                sum += Math.Pow(2, j);
                j++;                
            }
            for (int i = 0; i < j; i++)
            {
                int numP = num >> i;  
                int bit = numP & 1;
                if (bit == 1)
                {
                    newnum = newnum + "1";
                }
                else
                {
                    newnum = newnum + "0";
                }
            }
            Console.WriteLine("Your number in binary format is: {0}", newnum);
            
        }
    }
}
