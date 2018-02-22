using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            a.ToList().RemoveRange(n,a.Length-n);

            bool isSorted = false;
            int swapNumber = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    
                    if (a[i] > a[i + 1])
                    {
                        Swap(a, i, i+1);
                        swapNumber++;
                        isSorted = false;
                    }
                }

            }
            OutputResult(a, swapNumber);

        }

        private static void Swap(int[] ints, int i, int j)
        {
            var temp = ints[i];
            ints[i] = ints[j];
            ints[j] = temp;
        }

        private static void OutputResult(int[] a, int swapNumber)
        {
            /*int l;
            string output = string.Empty;
            for (l = 0; l < a.Length; l++)
            {
                output = output + " " + a[l];
            }
            char ctx = ' ';
            output = output.TrimStart(ctx);*/

            Console.WriteLine(string.Format("Array is sorted in {0} swaps.", swapNumber));
            Console.WriteLine(string.Format("First Element: {0}", a[0]));
            Console.WriteLine(string.Format("Last Element: {0}", a[a.Length-1]));

        }
    }
}
