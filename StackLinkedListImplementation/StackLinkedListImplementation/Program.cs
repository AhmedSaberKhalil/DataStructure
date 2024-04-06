using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedListImplementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int>();
			if (!stack.StackFull())
			{
				stack.Push(5);
				stack.Push(7);
				stack.Push(2);
				stack.Push(3);
				stack.Push(8);
				stack.Push(11);
			}

			Console.WriteLine($"Stack Size:{stack.StackSize()}");
			Console.WriteLine($"Stack Top:{stack.StackTop()}");
			Console.WriteLine("TraverseStack:");
			stack.TraverseStack();
			if (!stack.StackEmpty())
			{
				stack.Pop();
				stack.Pop();
				stack.Pop();
			}

			Console.WriteLine($"Stack Size:{stack.StackSize()}");
			Console.WriteLine($"Stack Top:{stack.StackTop()}");
			Console.WriteLine("TraverseStack:");
			stack.TraverseStack();
			stack.ClearStack();

			Console.WriteLine($"Stack Size:{stack.StackSize()}");
		}
	}
}
