using System;

namespace Homework_5
{
    class PlayingWithStuff
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: " +
                              "\n\r 1 --> int" +
                              "\n\r 2 --> double" + 
                              "\n\r 3 --> string");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Write("Please enter an int: ");
                    int a = int.Parse(Console.ReadLine());
                    a++;
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    b++;
                    Console.WriteLine(b);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("{0}*", c);
                    break;
                default:
                    Console.WriteLine("Wrong type!");
                    break;
            }
        }
    }
}
