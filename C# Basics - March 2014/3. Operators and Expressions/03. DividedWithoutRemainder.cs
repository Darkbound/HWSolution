using System;

namespace Homework
{
    class AreaOfRectangle
    {
        static void Main()
        {
            Console.Write("Input your width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input your height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int area = width * height;
            Console.WriteLine("The rectangle Area is: {0}", area);
        }
    }
}
