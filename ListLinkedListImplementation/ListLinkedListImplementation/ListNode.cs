using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLinkedListImplementation
{
	internal class ListNode<T>
	{
		public T Entry { set; get; }
		public ListNode<T> Next { get; set; }
		public ListNode(T entry)
		{
			Entry = entry;
			Next = null;
		}
	}
	class List<T>
	{
		private ListNode<T> head;
		int size;
		public List()
		{
			head = null;
			size = 0;
		}
		public bool ListEmpty()
		{
			return size == 0;
		}
		public bool ListFull()
		{
			return false;
		}
		public int ListSize()
		{
			return size;
		}
		public void DestroyList() 
		{
			ListNode<T> q;
			while(head != null)
			{
				q = head;
				q = q.Next;
				head = null;
				head = q;
			}
			size = 0;
		}
		public void TraverseList() 
		{
			ListNode<T> p;
			p = head;

			while (p != null)
			{
				Console.WriteLine(p.Entry);
				p = p.Next;
			}
		}
		public void InsertList(int pos,  T entry)
		{
			ListNode<T> node = new ListNode<T>(entry);
			node.Next = null;
			if(pos == 0)
			{
				node.Next = head;
				head = node;
			}
			else
			{
				ListNode<T> q;
				q = head;
				int i = 0;
				while(q != null & i < pos -1 )
				{
					i++;
					q = q.Next;
				}
				node.Next = q.Next;
				q.Next = node;
			}
			size++;
		}
		public void DeletetList(int pos)
		{
			ListNode<T> p, q;
			if (pos == 0)
			{
				p = head;
				p = head.Next;
				head = null;
				head = p;

			}
			else
			{
				q = head;
				int i = 0;
				while (q != null & i < pos - 1)
				{
					i++;
					q = q.Next;
				}
				p = q.Next.Next;
				q.Next = null;
				q.Next = p;
			}
			size--;
		}
		public void RetrieveList(int pos)
		{
			ListNode<T> q;
			q = head;
			int i = 0;
			while (q != null & i < pos)
			{
				i++;
				q = q.Next;
			}
			Console.WriteLine(q.Entry); 
		}
		public void ReplaceList(int pos, T entry)
		{
			ListNode<T> q;
			q = head;
			int i = 0;
			while (q != null & i < pos)
			{
				i++;
				q = q.Next;
			}
			q.Entry = entry;
		}

	}
}
