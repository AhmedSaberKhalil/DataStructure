using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        public int[] SelectionSort(int[] array)
        {
            
            for (int counter = 0; counter < array.Length - 1 ; counter++)
            {
                int minIndex = counter;
                for (int i = minIndex +1; i < array.Length ; i++)
                {
                    if (array[minIndex] > array[i])
                    {
                       minIndex = i;
                    }
                }
                int temp;
                temp = array[counter];
                array[counter] = array[minIndex];
                array[minIndex] = temp;

            }
            return array;
        }

        public void Display(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program sort = new Program();
            int[] array = { 4, 2, 5, 3, 1 };

            sort.Display(sort.SelectionSort(array));

        }
    }
}
