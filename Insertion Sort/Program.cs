using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 6, 1, 7, 4, 2, 9, 8, 5, 3 };
            int temp;
            for (int i = 1; i < x.Length; i++)
            {
                temp = x[i];
                for (int j = i; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        x[j] = temp;
                        break;
                    }

                    if (temp < x[j - 1])
                    {
                        x[j] = x[j - 1];
                    }
                    else
                    {
                        x[j] = temp;
                        break;
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