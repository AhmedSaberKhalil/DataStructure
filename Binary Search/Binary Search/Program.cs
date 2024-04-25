using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
	internal class Program
	{
		public static object BinarySearchIterative(int[] inputArray, int key)
		{
			int bottom = 0;
			int top = inputArray.Length - 1;
			while (bottom <= top)
			{
				int mid = (bottom + top) / 2;
				if (key == inputArray[mid])
				{
					return ++mid;
				}
				else if (key < inputArray[mid])
				{
					top = mid - 1;
				}
				else
				{
					bottom = mid + 1;
				}
			}
			return "Not Found";
		}
		public static object BinarySearchRecursive(int[] inputArray, int key, int bottom, int top)
		{
			if (bottom > top)
			{
				return "Not Found";
			}
			else
			{
				int mid = (bottom + top) / 2;
				if (key == inputArray[mid])
				{
					return ++mid;
				}
				else if (key < inputArray[mid])
				{
					return BinarySearchRecursive(inputArray, key, bottom, mid - 1);
				}
				else
				{
					return BinarySearchRecursive(inputArray, key, mid + 1, top);
				}
			}
		}
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 4, 5, 6, 7};
			Console.WriteLine( BinarySearchRecursive(arr, 5, 1, 7));
			Console.WriteLine(BinarySearchIterative(arr, 6));
			
		}
	}
}
