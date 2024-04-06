using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArrayImplementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> queue = new Queue<int>(6);
			if(!queue.QueueFull())
			{
				queue.Append(4);
				queue.Append(8);
				queue.Append(15);
				queue.Append(42);
				queue.Append(15);
				queue.Append(3);
			}
			Console.WriteLine(queue.QueueSize());
			queue.TraverseQueue();
		}
	}
}
