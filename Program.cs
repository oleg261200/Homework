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

            int[] result = new int [5];

            int sumred = 0;
            int sumgreen = 0;
            int sumblue = 0;
            int sumtrans = 0;


            int i = 0;

            for (i += 4; i <= 16;)
            {
                for (int j = 0; j < massive2.Length; j++)
                {
                    if (j < 2)
                    {
                        sumred += massive1[i - 4] * massive2[j];

                        sumgreen += massive1[i - 3] * massive2[j];

                        sumblue = massive1[i - 2] * massive2[j];

                        sumtrans = massive1[i - 1] * massive2[j];

                        i += 4;

                        continue;


                    }
                    else if (j == 2)
                    {
                        sumred += massive1[i - 4] * massive2[j];

                        sumgreen += massive1[i - 3] * massive2[j];

                        sumblue += massive1[i - 2] * massive2[j];

                        sumtrans += massive1[i - 1] * massive2[j];

                        sumred = sumred / 3;
                        sumgreen = sumgreen / 3;
                        sumblue = sumblue / 3;
                        sumtrans = sumtrans / 3;
                        Console.WriteLine(sumred);
                        Console.ReadLine();
                        sumred = 0;
                        sumgreen = 0;
                        sumtrans = 0;
                        sumblue = 0;
                        //k += 4;
                        //i += 4;
                        j = 0;
                        i -= 4;
                        break;

                    }

                }
                
            }
        }

    }
    
}
                        
                    
                
                    
                
            
        
    

