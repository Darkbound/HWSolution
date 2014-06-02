using System;

namespace Homework
{
class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Please input your number a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input your number b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input your number c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input your number d: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input your number e: ");
        int e = Convert.ToInt32(Console.ReadLine());
        int sum = a + b + c + d + e;
        Console.WriteLine("The sum of the five numbers is: {0}", sum);
    }
}
}
