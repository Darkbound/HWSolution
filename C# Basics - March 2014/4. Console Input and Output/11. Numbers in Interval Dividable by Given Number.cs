using System;

namespace Homework
{
class NumsInIntervalRemaindeer
{
    static void Main()
    {
        int a = 0;
        int b = 0;
        bool check = false;
        while (check == false)
        {
            Console.Write("Input your first number (must be positive!): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input your second number (must be positive and bigger than the first!): ");
            b = Convert.ToInt32(Console.ReadLine());
            if ((a < 0 || b < 0) && a < b )
            {
                check = false;
            }
            else
            {
                check = true;
            }
        }
        string numbers = "";
        int numcheck = 0;
        for (int i = 0; i <= (b - a); i++)
        {
            numcheck = a + i;
            if (numcheck%5==0)
            {
                numbers = numbers + Convert.ToString(numcheck) + " ";
            }
        }
        Console.WriteLine("The numbers between {0} and {1} that are divisible by 5 without remainder are: {2}", a, b, numbers);
    }
}
}
