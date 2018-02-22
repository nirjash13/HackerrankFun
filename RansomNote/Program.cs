using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            var charCount1 = GetDictionary(magazine, m);
            var charCountRansomNote = GetDictionary(ransom, n);

            var canHeDoIt = CanHeDoIt(charCount1, charCountRansomNote);
            Console.WriteLine(canHeDoIt);

        }

        private static string CanHeDoIt(Dictionary<string, int> charCount1, Dictionary<string, int> charCountRansomNote)
        {
            var result = true;
            foreach (var key in charCountRansomNote.Keys)
            {
                if (charCount1.ContainsKey(key))
                {
                    int valueCountRansom;
                    int valueCountMagazine;
                    charCountRansomNote.TryGetValue(key, out valueCountRansom);
                    charCount1.TryGetValue(key, out valueCountMagazine);
                    if (valueCountRansom > valueCountMagazine)
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result?"Yes" : "No";
        }


        private static Dictionary<string, int> GetDictionary(string[] magazine, int m)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < m; i++)
            {
                if (!dic.ContainsKey(magazine[i]))
                {
                    dic.Add(magazine[i], 1);
                }
                else
                {
                    var val = 0;
                    dic.TryGetValue(magazine[i], out val);
                    val++;
                    dic.Remove(magazine[i]);
                    dic.Add(magazine[i], val);
                }
            }

            return dic;
        }

        private static int GetArrSum(int[] arr)
        {
            var sum = arr.Aggregate(0, (current, t) => current + t);
            return sum;
        }


    }
}
