using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Searching
{
    public class KMP
    {
        public int KmpSearch(string input, string pattern)
        {
            int[] pieArr = BuildPieArray(pattern);
            int i = 0, j = 0, ans = -1;
            while(i < input.Length && j < pattern.Length)
            {
                if(input[i] == pattern[j])
                {
                    ++i;
                    ++j;
                }
                else
                {
                    if (j == 0)
                        ++i;
                    else
                        j = pieArr[j - 1];
                }
            }

            if (j == pattern.Length)
                ans = i - j;

            return ans;
        }

        private int[] BuildPieArray(string s)
        {
            int[] pieArr = new int[s.Length];
            pieArr[0] = 0;

            int i = 1, j = 0;

            while (i < s.Length)
            {
                if(s[i] == s[j])
                {
                    pieArr[i] = j + 1;
                    ++i;
                    ++j;
                }
                else
                {
                    if (j == 0)
                        ++i;
                    else
                        j = pieArr[j - 1];
                }
            }

            return pieArr;
        }
    }
}
