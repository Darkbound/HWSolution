using System;

namespace Homework_6
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter your number in binary format: ");
            string binary = Console.ReadLine();
            double check = 0;
            double newnum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                check = int.Parse(binary[binary.Length - i - 1].ToString());
                if (check == 1)
                {
                    newnum += Math.Pow(2, i);
                }

            }
            Console.WriteLine("Your number in decimal format is: {0}", newnum);
        }
    }
}
