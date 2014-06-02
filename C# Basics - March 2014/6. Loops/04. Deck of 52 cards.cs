using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_6
{
    class DeckOfCards
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            List<string> list = new List<string>();
            for (int i = 2; i <= 10; i++)
            {
                list.Add(i.ToString());
            }
            list.Add("J");
            list.Add("Q");
            list.Add("K");
            list.Add("A");

            List<string> listColor = new List<string>();
            listColor.Add("♣");
            listColor.Add("♦");
            listColor.Add("♥");
            listColor.Add("♠");

            for (int i = 0; i < 13; i++)
            {
                string card = "";
                for (int j = 0; j < 4; j++)
                {
                    card = list[i] + listColor[j] + " ";
                    Console.Write("{0, 4}", card);
                }
                Console.WriteLine();
                card = "";
            }
        }
    }
}
