using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
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
                3, 2, 7, 5, 1,
                3, 2, 9, 4, 7,
                3, 1, 4, 7, 5,
                1, 4, 0, 4, 8,
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

            int blockSize = 5;

            int[] result = new int[massive1.Length];

            int rows = massive2.GetUpperBound(0) + 1;

            int columns = massive2.Length / rows;

            for (int i = -blockSize; i < massive1.Length - blockSize * 3; i += blockSize)
            {
                int sumRed = 0;
                int sumGreen = 0;
                int sumBlue = 0;
                int sumTrans = 0;
                int firstElem = 0;

                for (int k = 0; k < columns; k++)
                {
                    for (int j = 0; j < rows; j++)

                    {

                        sumRed += massive1[i + blockSize * (j + 1)] * massive2[j, k];
                        
                        sumGreen += massive1[i + 1 + blockSize * (j + 1)] * massive2[j, k];

                        sumBlue += massive1[i + 2 + blockSize * (j + 1)] * massive2[j, k];

                        sumTrans += massive1[i + 3 + blockSize * (j + 1)] * massive2[j, k];


                    }
                    sumRed = sumRed / 3;
                    sumGreen = sumGreen / 3;
                    sumBlue = sumBlue / 3;
                    sumTrans = sumTrans / 3;

                    result[i + 1 + blockSize] = sumRed;
                    result[i + 2 + blockSize] = sumGreen;
                    result[i + 3 + blockSize] = sumBlue;
                    result[i + 4 + blockSize] = sumTrans;

                    
                }
                firstElem = massive1[i + blockSize];
                result[i + blockSize] = firstElem;
                Console.WriteLine(result[i + blockSize]);
                Console.ReadLine();
            }
        }
    }
}
    
