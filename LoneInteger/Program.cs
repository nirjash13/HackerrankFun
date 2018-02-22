using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoneInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int[] tmp = new int[a.Max()+1];

            foreach (var item in a)
            {
                tmp[item]++;
            }
            int result = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == 1)
                {
                    result = i;
                    break;
                }
            }

            Console.WriteLine(result);

            
        }

        
    }
}
