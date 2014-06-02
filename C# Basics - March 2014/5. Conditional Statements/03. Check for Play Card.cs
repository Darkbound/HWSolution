using System;
using System.Collections.Generic;

namespace Homework_5
{
    class CheckForPlayCard
    {
        static void Main()
        {
            Console.Write("What's your card: ");
            string card = Console.ReadLine();
            int a = 1;
            List<string> list = new List<string>();
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            list.Add("8");
            list.Add("9");
            list.Add("10");
            list.Add("J");
            list.Add("Q");
            list.Add("K");
            list.Add("A");
            foreach (string item in list)
            {
                if (item == card)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    a = 0;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
