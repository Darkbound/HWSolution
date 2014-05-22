using System;

namespace Homework_6
{
    class OddAndEvenproduct
    {
        static void Main()
        {
            Console.WriteLine("Input your integers on a single line separated by a space(s): ");
            string nums = Console.ReadLine();
            double oddpro = 1;
            double evenpro = 1;
            nums = nums.Replace(" ", "");

            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    oddpro = oddpro * double.Parse(nums[i].ToString());
                }
                if ((i + 1) % 2 == 0)
                {
                    evenpro = evenpro * double.Parse(nums[i].ToString());
                }
            }

            if (oddpro == evenpro)
            {
                Console.WriteLine("Yes,\r\nProduct: {0}", oddpro);
            }
            else
            {
                Console.WriteLine("No,\r\nOdd Product: {0}\r\nEven Product: {1}", oddpro, evenpro);
            }
        }
    }
}
