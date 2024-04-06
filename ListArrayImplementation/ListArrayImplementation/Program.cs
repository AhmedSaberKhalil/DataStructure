using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayImplementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>(8); 
			if(! list.ListFull())
			{
				list.InsertList(0, 5);
				list.InsertList(1, 7);
				list.InsertList(2, 8);
				list.InsertList(3, 6);
				list.InsertList(4, 11);
				list.InsertList(5, 18);
			}
			Console.WriteLine("TraverseList:");
			list.TraverseList();
			Console.WriteLine($"List Size: {list.ListSize()}");
			Console.WriteLine($"Retrived Element: {list.RetrieveList(3)}");
			list.ReplaceList(1, 42);
			Console.WriteLine($"TraverseList:");
			list.TraverseList();
			if (!list.ListEmpty())
			{
				list.DeleteList(1);
				list.DeleteList(4);
				list.DeleteList(2);
			}
			Console.WriteLine($"TraverseList:");
			list.TraverseList();
			Console.WriteLine($"List Size: {list.ListSize()}");

		}
	}
}
