using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherChallenges
{
    internal class LongestPalindormicString
    {
        public string LongestPalindormic(string s)
        {
			int leftSub = 0, rightSub = 0;

			//iterate loop

			for (int i = 0; i < s.Length; i++)
			{
				//get last indexOf actualLetter
				leftSub = i;
				rightSub = s.LastIndexOf(s[i]);
				if (leftSub != rightSub)
				{
					//do palindorme
					string subStr = s.Substring(leftSub, (rightSub - leftSub) + 1);
					string centerString = subStr.Length % 2 == 0 ?
					s.Substring((s.Length / 2) - 1, 2) : s.Substring((s.Length / 2) - 1, 1);
					return centerString;
				}
			}
			return "";
		}
    }
}
