using System;


/* For every topic that I had to research, I wrote a REF down below (at the end of the
 * document). They are all numbered and have a link to the resource. */

namespace ImageBlurCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiarray =     { { 0, 0, 0, 0 },
                                      { 1, 0, 0, 0 },
                                      { 2, 0, 0, 0 },
                                      { 3, 0, 0, 0 } };

            OutputArray(multiarray);
            Console.ReadLine();
        }


        // Method outputs 2d array to the console.
        static void OutputArray(int[,] multiarray)
        {
            // REF#1 - Difference between .GetLength() and .Length()
            for (int row = 0; row < multiarray.GetLength(0); row++)
            {
                for (int col = 0; col < multiarray.GetLength(1); col++)
                {
                    int s = multiarray[row, col];
                    Console.Write(s);
                }
                Console.WriteLine("");
            }
        }
    }
}


/* REF:
    - Difference between Array.GetLength() and Array.Length():
    http://stackoverflow.com/questions/2044591/what-is-the-difference-between-array-getlength-and-array-length
    
*/
