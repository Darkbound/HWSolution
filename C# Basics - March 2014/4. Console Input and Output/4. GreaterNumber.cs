using System;

namespace Homework
{
class GreaterNumber
{
    static void Main()
    {
        Console.Write("Please input your first number x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input your second number y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int z = x - y;
        int i = (z >> 31) & 1;
        Console.WriteLine("If you see 0 then {0} is greater than {1}, if you see 1 then {1} is greater than {0}: {2}", x, y, i);
    }
}
}
