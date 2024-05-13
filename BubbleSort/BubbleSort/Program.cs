using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        public int[] BubbleSort(int[] array)
        {
            int sorted = 0;
           for (int counter = 0; counter < array.Length-1 && sorted == 0; counter ++)
            {
                for (int i = 0; i < array.Length - 1- counter; i++)
                {
                    sorted = 1;
                    if (array[i] > array[i + 1])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[i+1];
                        array[i+1] = temp;
                        sorted = 0;
                    }
                    
                }
                
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

            sort.Display(sort.BubbleSort(array));
        
        }
    }
}
