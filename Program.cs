using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive1 = { 3, 2, 7, 5, 1, 3, 2, 9, 4, 7, 3, 1, 4, 7, 5, 1, 4, 0, 4, 8 };

            int[] massive2 = { 1, 1, 1 };

            int[] result = new int [massive1.Length];

            int sumred = 0;
            int sumgreen = 0;
            int sumblue = 0;
            int sumtrans = 0;

            int BlockSize = 4;

            int k;

            for (int i = -4; i < massive1.Length - BlockSize * 3; i += 4)
            {
                sumred = 0;
                sumgreen = 0;
                sumtrans = 0;
                sumblue = 0;
                k = BlockSize;

                for (int j = 0; j < massive2.Length; j++)
                {
                    sumred += massive1[i + k] * massive2[j];

                    sumgreen += massive1[i + 1 + k] * massive2[j];

                    sumblue += massive1[i + 2 + k] * massive2[j];

                    sumtrans += massive1[i + 3 + k] * massive2[j];

                    k += BlockSize;
                }
                sumred = sumred / 3;
                sumgreen = sumgreen / 3;
                sumblue = sumblue / 3;
                sumtrans = sumtrans / 3;
                i += BlockSize;
                result[i] = sumred;
                result[i + 1] = sumgreen;
                result[i + 2] = sumblue;
                result[i + 3] = sumtrans;
                Console.WriteLine(result[i]);
                Console.ReadLine();
                i -= BlockSize;
            }
            
        }
    }
}
                        
                    
                
                    
                
            
        
    

