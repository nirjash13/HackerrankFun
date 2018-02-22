using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnargrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[26];
            var string1 = Console.ReadLine();
            var string2 = Console.ReadLine();

            var charCountString1 = GetCharCount(string1.ToLower());
            var charCountString2 = GetCharCount(string2.ToLower());

            var numberOfCharToDelete = GetDifference(charCountString1, charCountString2);

            Console.WriteLine(numberOfCharToDelete);


        }

        private static int GetDifference(int[] charCountString1, int[] charCountString2)
        {
            int diff = 0;
            for (int i = 0; i < charCountString1.Length; i++)
            {
                diff = diff + Math.Abs(charCountString1[i] - charCountString2[i]);
            }

            return diff;
        }

        private static int[] GetCharCount(string string1)
        {
            var charCount = new int[26];
            var charArr = string1.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                var offset = (int) 'a';
                var pos = (int) charArr[i] - offset;
                charCount[pos]++;
            }

            return charCount;
        }
    }
}
