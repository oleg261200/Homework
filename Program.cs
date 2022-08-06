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
            {   3, 2, 7, 5, 1, 
                3, 2, 9, 4, 7, 
                3, 1, 4, 7, 5, 
                1, 4, 0, 4, 8 };

            int[] massive2 = { 1, 1, 1};

            int[] blockSize = new int [4];

            int[] result = new int[massive1.Length - blockSize.Length];

            for (int i = -blockSize.Length; i < massive1.Length - blockSize.Length * 3; i += blockSize.Length)
            {
                int sumred = 0;
                int sumgreen = 0;
                int sumblue = 0;
                int sumtrans = 0;

                for (int j = 0; j < massive2.Length; j++)
                {
                    sumred += massive1[i + blockSize.Length * (j + 1)] * massive2[j];

                    sumgreen += massive1[i + 1 + blockSize.Length * (j + 1)] * massive2[j];

                    sumblue += massive1[i + 2 + blockSize.Length * (j + 1)] * massive2[j];

                    sumtrans += massive1[i + 3 + blockSize.Length * (j + 1)] * massive2[j];
                }

                sumred = sumred / 3;
                sumgreen = sumgreen / 3;
                sumblue = sumblue / 3;
                sumtrans = sumtrans / 3;
                result[i + blockSize.Length] = sumred;
                result[i + 1 + blockSize.Length] = sumgreen;
                result[i + 2 + blockSize.Length] = sumblue;
                result[i + 3 + blockSize.Length] = sumtrans;
                Console.WriteLine(result[i +blockSize.Length]);
                Console.ReadLine();
                
            }

        }
    }
}
    
