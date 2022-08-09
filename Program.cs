using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive1 = 
            {   
                3, 2, 7, 5, 
                1, 3, 2, 9, 
                4, 7, 3, 1, 
                4, 7, 5, 1,
                4, 0, 4, 8,
                7, 2, 5, 0,
                7, 3, 2, 7,
                5, 1, 3, 2,
                9, 4, 7, 3,
                1, 4, 7, 5,
                1, 4, 0, 4,
                8, 7, 2, 5,
                0, 7, 3, 2,
                7, 5, 1, 3,
                2, 9, 4, 7,
                3, 1, 4, 7,
                5, 1, 4, 0,
                4, 8, 7, 2,
                5, 0, 7, 3,
                2, 7, 5, 1,
                3, 2, 9, 4,
                7, 3, 1, 4,
                7, 5, 1, 4,
                0, 4, 8, 7,
                2, 5, 0, 7
            };

            int[,] massive2 = {{1, 1, 1}, { 1, 1, 1 } ,{ 1, 1, 1 }};

            int blockSize = 4;

            int[] result = new int[massive1.Length];

            int rows = massive2.GetUpperBound(0) + 1;

            int columns = massive2.Length / rows;

            for (int i = -blockSize; i < massive1.Length - blockSize * 3; i += blockSize)
            {
                int sumred = 0;
                int sumgreen = 0;
                int sumblue = 0;
                int sumtrans = 0;

                for (int k = 0; k < columns; k++)
                {
                    for (int j = 0; j < rows; j++)

                    {
                        sumred += massive1[i + k + blockSize * (j + 1)] * massive2[j, k];
                        
                        sumgreen += massive1[i + 1 + blockSize * (j + 1)] * massive2[j, k];

                        sumblue += massive1[i + 2 + blockSize * (j + 1)] * massive2[j, k];

                        sumtrans += massive1[i + 3 + blockSize * (j + 1)] * massive2[j, k];
                    }
                    sumred = sumred / 3;
                    sumgreen = sumgreen / 3;
                    sumblue = sumblue / 3;
                    sumtrans = sumtrans / 3;

                    result[massive1.Length - blockSize] = massive1[i];
                    result[i + blockSize] = sumred;
                    result[i + 1 + blockSize] = sumgreen;
                    result[i + 2 + blockSize] = sumblue;
                    result[i + 3 + blockSize] = sumtrans;

                    Console.WriteLine(result[i + 1 +blockSize]);
                    Console.ReadLine();
                }
            }

        }
    }
}
    
