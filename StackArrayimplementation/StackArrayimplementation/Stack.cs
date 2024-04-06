using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArrayimplementation
{
	internal class Stack<T>
	{
		private T[] items;
		private int top;
        public int MaxStack { get; set; }

        public Stack(int MaxStack)
        {
            this.MaxStack = MaxStack;
            items = new T[MaxStack];
            top = 0;
        }

        public void Push(T StackEntry)
        {
            items[top++] = StackEntry;
        }
        public bool StackFull()
        {
            if(top == MaxStack)
                return true;
            else
                return false;
        }
        public void Pop()
        {
           T popElement =  items[--top];
        }

        public bool StackEmpty()
        {
            if (top == 0)
                return true;
            else
                return false;
        }

        public T StackTop()
        {
            return items[top-1];
        }

        public int StackSize()
        {
            return top;
        }
        public void ClearStack()
        {
            top = 0;
        }

        public void TraverseStack()
        {
            for(int i = top; i > 0; i--)
            {
                Console.WriteLine(items[i - 1]);
            }
        }

  

    }
}
