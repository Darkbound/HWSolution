using System;

namespace Homework_5
{
    class BeerTime
    {
        static void Main()
        {

            string time = DateTime.Now.ToString("hh:mm tt");
            int hour = int.Parse(time.Substring(0, 2));
            string tt = time.Substring(6);

            if (hour>=1 && tt == "PM")
            {
                Console.WriteLine("beer time");
            }
            else if (hour < 3 && tt == "AM")
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
