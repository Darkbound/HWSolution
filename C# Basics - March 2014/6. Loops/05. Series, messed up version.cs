using System;

namespace Homework_6
{
    class Series
    {
        static void Main()
        {
            Console.Write("First number: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double x = double.Parse(Console.ReadLine());
            double pow = n;
            double nn = n;
            double sum = 1;
            double fact = 1;

            for (int i = 1; i <= n; i++)                
            {
                while (nn >= 1)                          //factorial calculation
                {
                    fact = fact * nn;
                    nn--;
                }
                sum = sum + fact / Math.Pow(x, pow);     //sum
                nn=n-i;                                  //recalculating range of the factorial
                fact = 1;                                //reseting factorial
                pow--;                                   //reducing the power
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
