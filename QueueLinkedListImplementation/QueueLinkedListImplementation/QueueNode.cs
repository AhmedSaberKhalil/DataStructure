using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedListImplementation
{
	internal class QueueNode<T>
	{
		public T Entry { set; get; }
		public QueueNode<T> Next { get; set; }
        public QueueNode(T entry)
        {
            Entry = entry;
            Next = null;
        }
    }

    public class Queue<T>
    {
		private QueueNode<T> front;
		private QueueNode<T> rear;
		int size;
		public Queue()
		{
			front = null;
			rear = null;
			size = 0;
		}

		public void Append(T item)
		{
			QueueNode<T> queueNode = new QueueNode<T>(item);
			queueNode.Next = null;
			if(rear == null)
				front = queueNode;
			else
				rear.Next = queueNode;
			rear =	queueNode;
			size++;
		}
		public void Serve()
		{
			QueueNode<T> pn;
			T ElementServed = front.Entry;
			pn = front;
			front = front.Next;
			pn = null;
			if (front == null)
				rear = null;
			size--;
		}
		public bool QueueEmpty()
		{
			return size == 0;
		}
		public bool QueueFull()
		{
			return false;
		}
		public int QueueSize()
		{
			return size;
		}
		public void ClearQueue()
		{
			front = null;
			rear = null;
			size = 0;
		}

		public T QueueTop()
		{
			return front.Entry;
		}

		public void TraverseQueue()
		{
			QueueNode<T> pn;
			pn = front;
			while (pn != null)
			{
				T element = pn.Entry;
				Console.WriteLine(element);
				pn = pn.Next;

			}
		}

	}
}
