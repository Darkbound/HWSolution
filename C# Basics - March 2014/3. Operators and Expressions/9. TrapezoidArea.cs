using System;

namespace Homework
{
    class PointInUpperHalfOfCircle
    {
        static void Main()
        {
            Console.Write("Please input x: ");
            double x = Convert.ToDouble(Console.ReadLine())-1;
            Console.Write("Please input y: ");
            double y = Convert.ToDouble(Console.ReadLine())-1;
            double r = Math.Sqrt(x * x + y * y);

            if (x < 0 || y < 0)
            {
                Console.WriteLine("The point is not in the upper half of the circle!");
            }
            else
            {
                if (r < 2)
                {
                    Console.WriteLine("The point is in the upper half of the circle!");                    
                }
                else
                {
                    Console.WriteLine("The point is somewhere on the border of the upper half of the circle!");
                }
            }
        }
    }
}
