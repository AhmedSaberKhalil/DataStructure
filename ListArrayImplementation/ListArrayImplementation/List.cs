using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayImplementation
{
	internal class List<T>
	{
		private T[] items;
		private int size;
		public int MaxStack { get; set; }

		public List(int MaxSize)
        {
            items = new T[MaxSize];
            size = 0;
        }

        public void InsertList(int p, T item)
        {
            int i;
            for(i = size-1;  i >= p; i--)
            {
                items[i+1] = items[i];
            }
            items[p] = item;
            size++;
        }
        public void DeleteList(int p)
        {
            int i;
            T ElemntDeleted = items[p];
            for(i = p+1; i <= size-1; i++)
            {
                items[i-1] = items[i];
            }
            size--;
        }
        public T RetrieveList(int p)
        {
            return items[p];
        }
        public void ReplaceList(int p, T item)
        {
			items[p] = item;
		}
		public void TraverseList()
        {
            int i;
            for(i =  0; i < size; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public bool ListEmpty()
        {
            return size == 0;
        }
		public bool ListFull()
		{
			return !(size== MaxStack);
		}
        public int ListSize()
        {
            return size;
        }
        public void DestroyList()
        {
            size= 0;
        }


	}
}
