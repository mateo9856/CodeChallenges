using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class LongestKSubstring
    {
        public string Get(string s, int k)
        {
            if (s.Distinct().Count() == k) return s;
            int sub = k + 1;
            string x = s.Substring(0, k), sCopy = s;
            for(int i = 0; i < s.Length; i++)
            {
                if (i + sub >= s.Length) break;
                string tryS = sCopy.Substring(i, sub);
                int c = tryS.Distinct().Count();
                if (c == k)
                {
                    x = tryS;
                    sub++;
                    i--;
                }
            }
            return x;
        }
    }
}
