using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedListImplementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> queue = new Queue<int>();
			if (!queue.QueueFull())
			{
				queue.Append(5);
				queue.Append(31);
				queue.Append(12);
				queue.Append(40);
				queue.Append(15);
				queue.Append(8);
			}
			Console.WriteLine("Traverse Queue:");
			queue.TraverseQueue();
			Console.WriteLine($"Queue Size: {queue.QueueSize()}");
			Console.WriteLine($"Queue Top: {queue.QueueTop()}");
			if(!queue.QueueEmpty())
			{
				queue.Serve();
				queue.Serve();
				queue.Serve();
			}
			Console.WriteLine("Traverse Queue:");
			queue.TraverseQueue();
			Console.WriteLine($"Queue Size: {queue.QueueSize()}");
			Console.WriteLine($"Queue Top: {queue.QueueTop()}");

		}
	}
}
