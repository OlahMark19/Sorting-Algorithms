using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            int temp = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j =i + 1; j < x.Length; j++)
                {
                    if (x[j - 1] > x[j])
                    {
                        temp = x[j - 1];
                        x[j - 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadKey();
        }
    }
}
