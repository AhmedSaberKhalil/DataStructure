using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArrayimplementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int> (9);
			if(!stack.StackFull())
			{
				stack.Push(8);
				stack.Push(15);
				stack.Push(4);
				stack.Push(7);
				stack.Push(9);
				stack.Push(11);

			}
			if(!stack.StackEmpty())
			{
				stack.Pop();
				stack.Pop();
			}

			Console.WriteLine($"Stack Top: {stack.StackTop()}");
			Console.WriteLine($"Stack Size:  { stack.StackSize()}");
			stack.TraverseStack();
			stack.ClearStack();



		}
	}
}
