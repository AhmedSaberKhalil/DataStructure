using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLinkedListImplementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			if(! list.ListFull())
			{
				list.InsertList(0, 6);
				list.InsertList(1, 8);
				list.InsertList(2, 11);
				list.InsertList(3, 2);
				list.InsertList(4, 4);
				list.InsertList(5, 14);
			}
			Console.WriteLine($"List Size: {list.ListSize()}");
			Console.WriteLine($"List RetrieveList:");
			list.RetrieveList(4);
			Console.WriteLine("TraverseList: ");
			list.TraverseList();

			Console.WriteLine("----------------------------------");

			if (!list.ListEmpty())
			{
				list.DeletetList(0);
				list.DeletetList(4);
			}
			Console.WriteLine($"List Size: {list.ListSize()}");
			Console.WriteLine($"List RetrieveList:");
			list.RetrieveList(2);
			Console.WriteLine("TraverseList: ");
			list.TraverseList();
			Console.WriteLine("----------------------------------");
			if (!list.ListFull())
			{
				list.InsertList(0, 1);
				list.InsertList(5, 3);
				
			}
			Console.WriteLine($"List Size: {list.ListSize()}");
			Console.WriteLine($"List RetrieveList:");
			list.RetrieveList(4);
			Console.WriteLine("TraverseList: ");
			list.TraverseList();

		}
	}
}
