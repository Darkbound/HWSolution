using System;

namespace Homework
{
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer number 0<=a<=500: ");
        int a = Convert.ToInt32(Console.ReadLine());
        string binarya = Convert.ToString(a, 2);
        Console.Write("Enter floating point number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter floating point number c: ");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("|{0, -10:X}|{1}|{2, 10:F2}|{3, -10:F3}|", a, binarya.PadLeft(10, '0') , b, c);
    }
}
}
