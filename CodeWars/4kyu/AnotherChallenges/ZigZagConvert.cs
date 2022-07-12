using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherChallenges
{
    internal class ZigZagConvert
    {
        public char[,] Convert(string s, int numRows)
        {
			bool SlideDown = true;

			char[,] InitArr = new char[numRows, (s.Length / 2)];

			int right = 0, left = 0;

			string direction = string.Empty;

			for (int i = 0; i < s.Length; i++)
			{
				InitArr[left, right] = s[i];

				direction = (SlideDown == true && (left + 1) < numRows) ? "down" : (SlideDown == false && left > 0) ? "right-up" : string.Empty;

				switch (direction)
				{
					case "down":
						left++;
						break;
					case "right-up":
						left--;
						right++;
						break;
					default:
						break;
				}

				SlideDown = (left == 0) ? true : (left == numRows - 1) ? false : SlideDown;

			}
			return InitArr;
		}
    }
}
