using System;

namespace Homework
{
    class CheckThirdDigit
    {
        static void Main()
        {
            Console.Write("Please input your number: ");
            string num = Console.ReadLine();
            int numIndex = num.Length - 3;
            int isSeven = Convert.ToInt32(num[numIndex].ToString());
            Console.WriteLine(num[numIndex]);
            if (isSeven==7)
            {
                Console.WriteLine("The 3rd digit is 7!");               
            }
            else
            {
                Console.WriteLine("The 3rd digit is not 7!");
            }
        }
    }
}
