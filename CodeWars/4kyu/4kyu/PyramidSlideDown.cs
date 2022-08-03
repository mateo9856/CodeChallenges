using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _4kyu
{
    public class PyramidSlideDown
    {
        public int PyramidSlide(int[][] mediumPyramid) {
			int sum = 0;

			int index = 0;

			//bool isLeftSide = false;
			//zmienic na podejscie math.Max

			for (int i = 0; i < mediumPyramid.Length - 1; i++)
			{
				if (i == 0)
				{
					sum += mediumPyramid[i].First();
					//check next
					index = Array.IndexOf(mediumPyramid[i + 1], mediumPyramid[i + 1].Max());
					//isLeftSide = index == 0 ? true : false;
					continue;
				}
				sum += mediumPyramid[i][index];
				var takeTwoValues = mediumPyramid[i + 1].Skip(index).Take(2);
				//max val index
				index = Array.IndexOf(mediumPyramid[i + 1], takeTwoValues.Max());
			}
			return sum;
		}
    }
}
