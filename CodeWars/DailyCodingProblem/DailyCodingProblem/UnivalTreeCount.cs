using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class UnivalTreeCount
    {
        public int UnivalCount(BinaryNode node, BinaryNode prevVal = null, int count = 0)
        {
            //analyze and patch
            var l = node.Left;
            var r = node.Right;

            if(l != null) count += UnivalCount(l, node, count);
            if(r != null) count += UnivalCount(r, node, count);

            if (prevVal != null && prevVal.Data == node.Data) count++;
            else if (prevVal.Data != node.Data && (prevVal.Left.Data == prevVal.Right.Data)) count += 2;

            return count;
        }

    }

    public class BinaryNode
    {
        public int Data { get; set; }
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }
    }

}
