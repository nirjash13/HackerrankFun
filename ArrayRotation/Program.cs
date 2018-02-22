using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrrank1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = InitialSolution();
            var a = SolveInABetterWay();
            OutputResult(a);
        }

        

        private static void OutputResult(int[] a)
        {
            int l;
            string output = string.Empty;
            for (l = 0; l < a.Length; l++)
            {
                output = output + " " + a[l];
            }
            char ctx = ' ';
            output = output.TrimStart(ctx);

            Console.Write(output);
        }

        public static int[] SolveInABetterWay()
        {
            int i, j, l, m;
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            var result = new int[a.Length];

            for (i = 0; i < a.Length; i++)
            {
                var pos = (i + n - d) % n;
                result[pos] = a[i];
            }


            return result;
        }


        private static int[] InitialSolution()
        {
            int i, j, l, m;
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);


            for (j = 1; j <= k; j++)
            {
                int length = a.Length;
                int tmp = a[0];
                for (i = 1; i < n; i++)
                {
                    a[i - 1] = a[i];
                }

                a[length - 1] = tmp;
            }
            return a;
        }
    }
}
