using System;
using System.Collections.Generic;
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
                3, 2, 7, 5, 1, 
                3, 2, 9, 4, 7, 
                3, 1, 4, 7, 5, 
                8, 6, 2, 9, 4,
                7, 2, 5, 0 ,7 
            };

            int[,] massive2 =
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            int blockSize = 5;

            int[] result = new int[massive1.Length - blockSize];

            int rows = massive2.GetUpperBound(0) + 1 ;

            int columns = massive2.Length / rows;


            for (int i = -blockSize; i < massive2.Length - 1; i++)
            {
                int sumred = 0;
                
                for (int k = 0; k < columns; k++)
                { 
                    for (int j = 0; j < rows; j++)

                    {
                        sumred += massive1[i + k + blockSize * (j + 1)] * massive2[j, k];

                        /*sumgreen += massive1[i + 1 + blockSize * (j + 1)] * massive2[j, k];

                        sumblue += massive1[i + 2 + blockSize * (j + 1)] * massive2[j, k];

                        sumtrans += massive1[i + 3 + blockSize * (j + 1)] * massive2[j, k];

                        sumfive += massive1[i + 4 + blockSize * (j + 1)] * massive2[j, k];*/
                    }
                    
                }
                sumred = sumred / 9;
                result[i + blockSize] = sumred;
                Console.WriteLine(result[i + blockSize]);
                Console.ReadLine();

            }

        }
    }
}
    
