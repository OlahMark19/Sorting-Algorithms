using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            int temp = 0;
            int min = 0;
            int pozMin = 0;
            for (int i = 0; i < x.Length; i++)
            {
                min = x[i];
                for (int j = i; j < x.Length; j++) 
                {
                    if (min > x[j])
                    {
                        min = x[j];
                        pozMin = j;
                    }
                }
                temp = x[i];
                x[i] = min; 
                x[pozMin] = temp;
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
           
            Console.ReadKey();
        }
    }
}
