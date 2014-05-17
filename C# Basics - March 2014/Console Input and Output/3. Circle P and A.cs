using System;

namespace Homework
{
class CirclePandA
{
    static void Main()
    {
        Console.Write("Please input the radius r: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double P = 2 * Math.PI * r;
        double S = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("The Perimeter of the circle is: {0:0.00}", P);
        Console.WriteLine("The Area of the circle is: {0:0.00}", S);
    }
}
}
