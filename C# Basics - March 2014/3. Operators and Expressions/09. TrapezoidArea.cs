using System;

namespace Homework
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("Please input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area of the trapezoid is {0}", area);
            
        }
    }
}
