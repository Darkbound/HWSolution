using System;

namespace Homework_5
{
    class Sort3Nums
    {
        static void Main()
        {
            Console.Write("Input your first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your third number: ");
            double c = Convert.ToDouble(Console.ReadLine());
            string sorted = "";

            if (a > b && a > c)
            {
                sorted = sorted + a + " ";
                if (b > c)
                {
                    sorted = sorted + b + " " + c;
                }
                else
                {
                    sorted = sorted + c + " " + b;
                }
            }
            else if (b > a && b > c)
            {
                sorted = sorted + b + " ";
                if (a > c)
                {
                    sorted = sorted + a + " "+ c;
                }
                else
                {
                    sorted = sorted + c + " " + a;
                }
            }
            else if (c > a && c > b)
            {
                sorted = sorted + c + " ";
                if (a > b)
                {
                    sorted = sorted + a + " " + b;
                }
                else
                {
                    sorted = sorted + b + " " + a;
                }
            }
            else if (a==b && a==c)
            {
                sorted = a + " " + b + " " + c;
            }
            Console.WriteLine(sorted);

        }
    }
}
