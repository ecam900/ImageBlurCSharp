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
                                      { 2, 0, 1, 0 },
                                      { 3, 0, 0, 0 },
                                      { 4, 0, 0, 0 } };


            Blur(multiarray);


            OutputArray(multiarray);
            Console.ReadLine();
        }

        public static void Blur(int[,] multiarray)
        {
            int[,] blurredArray = multiarray;

            for (int row = 0; row < multiarray.GetLength(0); row++)
            {
                for (int col = 0; col < multiarray.GetLength(1); col++)
                {
                    int point = multiarray[row, col];


                    // PROBLEM HERE! : OUT OF BOUNDS EXCEPTION. WORKING ON IT!
                    if (point == 1)
                    {
                        blurredArray[row - 1, col] = 1;
                        blurredArray[row + 1, col] = 1;
                        blurredArray[row, col - 1] = 1;
                        blurredArray[row, col + 1] = 1;
                    };

                }
                OutputArray(blurredArray);
            }
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
