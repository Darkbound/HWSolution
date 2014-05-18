using System;

namespace Homework
{
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please input the a coefficient of your equation: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input the b coefficient of your equation: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input the c coefficient of your equation: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double D = Math.Pow(b, 2) - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("Your roots are\r\nx1 = {0}\r\nx2 = {1}", x1, x2);
        }

    }
}
}
