using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class ForgotNumber
    {
        public int Find(int[] arr)
        {
            var hashArr = arr.ToHashSet();
            int min = hashArr.Min(), max = hashArr.Max();
            int sum = 0;
            for (int i = min; i <= max; i++) sum += i;
            var calculate = sum - hashArr.Sum();
            return calculate > 0 ? calculate : max + 1;
        }
    }
}

//Given an array of integers, find the first missing positive integer in linear time and constant space. In other words,
//find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.
