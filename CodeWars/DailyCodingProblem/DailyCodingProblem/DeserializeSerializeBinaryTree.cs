using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    internal class DeserializeSerializeBinaryTree
    {
    }

	public class Node //Node class with int values
	{
		public int Val { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }

		public Node()
		{
		}

		public Node(int val) { Val = val; }
	}

	public class BinaryTree
	{
		public Node Root { get; set; }

		public int t { get; set; } = 0;

		public bool Add(int val)
		{
			Node before = null, after = this.Root;

			while (after != null)
			{
				before = after;
				if (val < after.Val)
					after = after.Left;
				else if (val > after.Val)
					after = after.Right;
				else return false;
			}
			Node newNode = new Node();

			if (this.Root == null)
				this.Root = newNode;
			else
			{
				if (val < before.Val)
					before.Left = new Node();
				else
					before.Right = new Node();
			}

			return true;
		}

		public Node Find(int val, Node parent)
		{
			if (parent != null)
			{
				if (val == parent.Val) return parent;
				else if (val < parent.Val)
					return Find(val, parent.Left);
				else
					return Find(val, parent.Right);
			}
			return null;
		}

		public string Serialize(Node node)
		{
			if (node == null) return null;
			Stack<Node> s = new Stack<Node>();
			s.Push(node);
			var l = new List<string>();

			while (s.Count() != 0)
			{
				var t = s.Pop();
				if (t == null)
					l.Add("#");
				else
				{
					l.Add(t.Val.ToString());
					s.Push(t.Right);
					s.Push(t.Left);
				}
			}

			return string.Join(",", l);
		}

		public Node Deserialize(string[] data)
		{
			if (data == null) return null;

			if (data[t] == null || data[t].Equals("#")) return null;
			var root = new Node(Convert.ToInt32(data[t]));
			t++;
			root.Left = Deserialize(data);
			t++;
			root.Right = Deserialize(data);

			return root;
		}

	}

}
