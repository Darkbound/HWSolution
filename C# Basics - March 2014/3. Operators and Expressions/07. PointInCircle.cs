using System;

namespace Homework
{
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Please input x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(x * x + y * y);

            if (r < 2)
            {
                Console.WriteLine("The point is in the circle!");
            }
            else
            {
                if (r == 2)
                {
                    Console.WriteLine("The point is on the border!");                   
                }
                else
                {
                    Console.WriteLine("The point is outside the circle!");
                }
            }

        }
    }
}
