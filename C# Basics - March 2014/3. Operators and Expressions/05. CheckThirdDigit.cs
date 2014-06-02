using System;

namespace Homework
{
    class CheckThirdDigit
    {
        static void Main()
        {
            Console.Write("Please input your number: ");
            string num = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int number = Convert.ToInt32(num[i].ToString());
                sum += number;
            }
            Console.WriteLine(sum);
            int a = Convert.ToInt32(num[0].ToString());
            int b = Convert.ToInt32(num[1].ToString());
            int c = Convert.ToInt32(num[2].ToString());
            int d = Convert.ToInt32(num[3].ToString());
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
