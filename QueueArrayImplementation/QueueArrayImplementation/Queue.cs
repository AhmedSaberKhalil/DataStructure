using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArrayImplementation
{
	internal class Queue<T>
	{
		private T[] items;
		private int front;
		private int rear;
		private int size;
		public int MaxStack { get; set; }


		public Queue(int maxQueue)
        {
            items = new T[maxQueue];
			front = 0;
			rear = -1;
			size = 0;
        }

		public void Append(T item)
		{
			if (rear == MaxStack -1)
			{
				rear = 0;
			}
			else
			{ rear++; }
			items[rear] = item;
			size++;
		}

		public void Serve()
		{
			T ElementServed = items[front];
			if (front == MaxStack - 1)
			{
				front = 0;
			}
			else
			{ front++; }
			size--;
		}
		public bool QueueEmpty()
		{
			if (size == 0)
				return true;
			else
				return false;
		}

		public bool QueueFull()
		{
			if (size == MaxStack)
				return true;
			else
				return false;
		}

		public int QueueSize()
		{
			return size;
		}
		public void ClearQueue()
		{
			front = 0;
			rear = -1;
			size = 0;
		}

		public void TraverseQueue()
		{
			int pos;
			int s=0;
			for(pos = front; s< size; s++)
			{
				Console.WriteLine($" Queue items: {items[pos]}");
				if (pos == MaxStack - 1)
				{
					pos = 0;
				}
				else
				{ pos++; }
			}
		}

	}
}
