using System;

namespace Homework
{
class Fibonacci
{
    static void Main()
    {
        Console.Write("How many elements of the Fibonacci sequence do you want: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int fibonacci = 1;
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(sum);
            int temp = sum;
            sum = fibonacci;
            fibonacci += temp;
        }
    }
}
}
