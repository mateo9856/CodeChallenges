using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class RestSumNums
    {
        public int[] arr { get; set; }

        public RestSumNums(int[] Arr)
        {
            arr = Arr;
        }

        public IEnumerable<int> SumNums(int[] arr) => arr.Select(c => arr.Aggregate(1, (x, y) => Array.IndexOf(arr, y) == Array.IndexOf(arr, c) ? x * 1 : x * y));
    }
}
