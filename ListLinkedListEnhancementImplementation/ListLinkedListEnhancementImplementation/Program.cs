using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLinkedListEnhancementImplementation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			if (!list.ListFull())
			{
				list.InsertListEnhancement(0, 6);
				list.InsertListEnhancement(1, 8);
				list.InsertListEnhancement(2, 11);
				list.InsertListEnhancement(3, 2);
				list.InsertListEnhancement(4, 4);
				list.InsertListEnhancement(5, 14);
			}
			Console.WriteLine($"List Size: {list.ListSize()}");
			Console.WriteLine($"List RetrieveList:");
			list.RetrieveList(4);
			Console.WriteLine("TraverseList: ");
			list.TraverseList();

			Console.WriteLine("----------------------------------");

			if (!list.ListEmpty())
			{
				list.DeletetListEnhancement(0);
				list.DeletetListEnhancement(4);
			}
			Console.WriteLine($"List Size: {list.ListSize()}");
			Console.WriteLine($"List RetrieveList:");
			list.RetrieveList(2);
			Console.WriteLine("TraverseList: ");
			list.TraverseList();
			Console.WriteLine("----------------------------------");
			if (!list.ListFull())
			{
				list.InsertListEnhancement(0, 1);
				list.InsertListEnhancement(5, 3);

			}
			Console.WriteLine($"List Size: {list.ListSize()}");
			Console.WriteLine($"List RetrieveList:");
			list.RetrieveList(4);
			Console.WriteLine("TraverseList: ");
			list.TraverseList();

		}
	}
	
}
