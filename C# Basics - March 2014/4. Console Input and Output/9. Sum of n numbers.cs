using System;

namespace Homework
{
class SumOfNnumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to input: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int add = 0;
        for (int i = 0; i < num; i++)
        {
            Console.Write("Enter a number: ");
            add = Convert.ToInt32(Console.ReadLine());
            sum += add;
        }
        Console.WriteLine("The Sum of your numbers is {0}", sum);
    }
}
}
