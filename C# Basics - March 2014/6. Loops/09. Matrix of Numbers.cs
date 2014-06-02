using System;

namespace Homework_6
{
    class MatrixOfNums
    {
        static void Main()
        {
            Console.Write("Input the dimensions for the square matrix: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n+i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
