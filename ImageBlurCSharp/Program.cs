using System;

namespace ImageBlurCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiarray = { { 0, 0, 0, 0 },
                                      { 1, 0, 0, 0 },
                                      { 2, 0, 0, 0 },
                                      { 3, 0, 0, 0 } };

            for (int row = 0; row < multiarray.GetLength(0); row++)
            {
                for (int col = 0; col < multiarray.GetLength(1); col++)
                {
                    int s = multiarray[row, col];
                    Console.Write(s);
                }
                Console.WriteLine("");
            }


            Console.ReadLine();
        }
    }
}