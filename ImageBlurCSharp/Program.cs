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
                                      { 0, 0, 1, 0 },
                                      { 0, 0, 0, 0 },
                                      { 0, 1, 0, 0 } };

           
            Console.WriteLine("Old array: ");
            Console.WriteLine(" ");
            OutputArray(multiarray);

            Console.WriteLine(" ");
            Console.WriteLine("New array: ");
            Console.WriteLine(" ");
            Blur(multiarray);

            Console.ReadLine();
        }

        public static void Blur(int[,] multiarray)
        {
            int[,] blurredArray = (int[,])multiarray.Clone();

            for (int row = 0; row < multiarray.GetLength(0); row++)
            {
                for (int col = 0; col < multiarray.GetLength(1); col++)
                {

                    int point = multiarray[row, col];

                    if (point == 1)
                    {
                        if (row - 1 >= 0)
                            blurredArray[row - 1, col] = 1;
                        if ( row + 1 < multiarray.GetLength(0) )
                            blurredArray[row + 1, col] = 1;
                        if (col - 1 >= 0)
                            blurredArray[row, col - 1] = 1;
                        if (col + 1 < multiarray.GetLength(1))
                            blurredArray[row, col + 1] = 1;
                    }
                }
            }
            OutputArray(blurredArray);
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
    1- Difference between Array.GetLength() and Array.Length():
    http://stackoverflow.com/questions/2044591/what-is-the-difference-between-array-getlength-and-array-length
    
*/
