using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class PossibleDecodings
    {//przemodelować po swojemu!! ta metode
        //https://www.geeksforgeeks.org/count-possible-decodings-given-digit-sequence/
        public int countDecoding(char[] digits, int n)
        {
            if (n == 0 || n == 1)
                return 1;

            // Initialize count
            int count = 0;

            if (digits[n - 1] > '0')
                count = countDecoding(digits, n - 1);

            if (digits[n - 2] == '1'
                || (digits[n - 2] == '2'
                    && digits[n - 1] < '7'))
                count += countDecoding(digits, n - 2);

            return count;
        }
        public int countWays(char[] digits, int n)
        {
            if (n == 0 || (n == 1 && digits[0] == '0'))
                return 0;
            return countDecoding(digits, n);
        }
    }
}
