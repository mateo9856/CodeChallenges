using System;
using System.Collections.Generic;
using System.Text;

namespace _4kyu
{
	public class SquareIntoSquares
    {
		public string Decompose(long n) {
			if(TryDecompose((n * n), n))
				return string.Join(" ", listElements);

			return null;
		}

		private List<long> listElements { get; set; } = new List<long>();

		bool TryDecompose(double total, long n)
		{
			if (total <= 0)
				return total == 0;

			for (long i = n - 1; n > 0; i--)
			{
				if (TryDecompose(total - (i * i), i))
				{
					listElements.Add(i);
					return true;
				}
			}

			return false;

		}

	}

}
