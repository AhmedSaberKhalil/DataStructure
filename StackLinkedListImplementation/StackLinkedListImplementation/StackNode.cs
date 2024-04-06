using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedListImplementation
{
	internal class StackNode<T>
	{
		public T Entry { set; get; }
		public StackNode<T> Next { get; set; }
        public StackNode(T entry)
        {
            Entry = entry;
            Next = null;
        }
    }

	public class Stack<T>
    {
        private StackNode<T> top;
        int size;

        public Stack()
        {
            top = null;
            size = 0;
        }
        public bool Push(T entry)
        {
            StackNode<T> stackNode = new StackNode<T>(entry);
            if (stackNode == null)
            { return false; }
            else
            {
				stackNode.Next = top;
				top = stackNode;
				size++;
                return true;
			}
         
        }
        public bool StackFull() 
        {
            return  false;
        }
        public void Pop()
        {
            StackNode<T> pn;
            T popElement = top.Entry;
            pn = top;
            top = top.Next;
            pn = null;
            size--;
            
        }

        public bool StackEmpty()
        {
            return top == null;
        }

        public void ClearStack()
        {
            StackNode<T> pn;
            pn = top;
            while (pn.Next != null)
            {
				pn = top;
				pn = pn.Next;
				top = null;
				pn = top;
			}
            size = 0;
        }

		public T StackTop()
		{
			return top.Entry;
		}
		public void TraverseStack()
        {
            StackNode<T> pn;
            pn = top;
            while(pn != null)
            {
                T element = pn.Entry;
                Console.WriteLine(element);
                pn = pn.Next;
            }
        }
        public int StackSize()
        {
            return size;
        }

	}


}
