using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class NonAdjacentNumbers
    {
        public int Get(int[] arr)
        {
            int inclusive = arr[0];
            int exclusive = 0;
            int oldExclusive = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                oldExclusive = inclusive;
                inclusive = Math.Max(exclusive + arr[i], inclusive);
                exclusive = oldExclusive;
            }
            return inclusive;
        }
    }
}


//Given a list of integers, write a function that returns the largest sum of non-adjacent numbers. Numbers can be 0 or negative.

//For example, [2, 4, 6, 2, 5] should return 13, since we pick 2, 6, and 5. [5, 1, 1, 5] should return 10, since we pick 5 and 5.