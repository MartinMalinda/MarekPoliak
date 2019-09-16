using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            bool[,] matrix = new bool[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = true;
                    }
                    else
                    {
                        matrix[i, j] = false;
                    }
                    Console.Write(Convert.ToInt32(matrix[i, j]));
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}