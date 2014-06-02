using System;

namespace Homework
{
class NumsFrom1toN
{
    static void Main()
    {
        Console.Write("Please input your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}
}
