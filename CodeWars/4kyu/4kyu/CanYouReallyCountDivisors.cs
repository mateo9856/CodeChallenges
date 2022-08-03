using System;
using System.Collections.Generic;
using System.Text;

namespace _4kyu
{
    public class CanYouReallyCountDivisors
    {
		public int Num = 0;
		// You can define other methods, fields, classes and namespaces here
		public static long CountDivisors(long n, ref long num)
		{
			num += GetCountByAlgo(n);
			if (n == 1) return num;
			return CountDivisors(n - 1, ref num);
		}

		public static IEnumerable<long> YieldGetDivisors(long n)
		{

			for (int i = 1; i <= n; i++)
			{
				yield return GetCountByAlgo(i);
			}

		}

		public static long GetCountByAlgo(long n)
		{
			long cnt = 0;
			for (int i = 1; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					if (n / i == i) cnt++;

					else cnt += 2;
				}
			}
			return cnt;
		}
	}
}
