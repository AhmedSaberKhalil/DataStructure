using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();

            /*  BST
                   50   
                /       \
               /         \                                        
              30          70                       
            /   \        /   \
          20    40      60    80
               /  \    /    \
             35    45  55    65 
           
             */

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);
            tree.Insert(35);
            tree.Insert(65);
            tree.Insert(55);
            tree.Insert(45);

            tree.inorder();
            Console.WriteLine("_________________");
            Console.WriteLine(tree.FindItemTree(40));
            tree.Delete(60);
            Console.WriteLine("_________________");
            tree.inorder();
       
            
        }
    }
}
