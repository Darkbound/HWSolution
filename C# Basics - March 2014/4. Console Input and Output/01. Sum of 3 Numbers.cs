using System;

namespace Homework
{
class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Please input your number a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input your number b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input your number c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine("The sum of the three numbers is: {0}", sum);
    }
}
}
