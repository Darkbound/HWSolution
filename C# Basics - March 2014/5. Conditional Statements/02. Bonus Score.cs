using System;

namespace Homework_5
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("What's your score, in 1 to 9 range: ");
            int score = int.Parse(Console.ReadLine());
            if (score <= 3 && score >= 1)
            {
                score = score * 10;
                Console.WriteLine("Your score with the bonus is: {0}", score);
            }
            else
            {
                if (score <= 4 && score >= 6)
                {
                    score = score * 100;
                    Console.WriteLine("Your score with the bonus is: {0}", score);
                }
                else
                {
                    if (score <= 7 && score >= 9)
                    {
                        score = score * 1000;
                        Console.WriteLine("Your score with the bonus is: {0}", score);
                    }
                    else
                    {
                        Console.WriteLine("Invalid score! Your score must be between 1 and 9!");
                    }
                }
            }
        }
    }
}
