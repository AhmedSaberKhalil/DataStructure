using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BST
    {
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        public Node curr;
        public int size;
        public Node prev;

        public BST()
        {
            curr = null;
            prev = null;
            size = 0;
        }
       
        Node root;
        public void Insert(int item)
        {
            Node p = new Node(item);

            if (root == null)
            {
              //  p = new Node(item);
                root = p;
            }
            else
            {
                curr = root;
                while (curr != null)
                {
                    prev = curr;
                    if (item < curr.key)
                        curr = curr.left;
                    else
                        curr = curr.right;
                   // curr = curr.right;
                }
                if(item < prev.key)
                {
                //    p = new Node(item);
                    prev.left = p;
                }
                else
                {
                    prev.right = p;// new Node(item);
                }

            }
            size++;
        }
        public int FindItemTree(int item)
        {
            int found = 0;
            Node f;//= new Node(item);
            f = root;
            while (f != null && found == 0)
            {
                if (item == f.key)
                {
                    found = f.key;
                }
                else
                {
                    if(item < f.key)
                        f = f.left;
                    else
                        f = f.right;
                }
            }
            if(f!= null)
            {
                found = f.key;
            }
            return found;

        }

        public bool Delete(int item)
        {
            bool found = false;
            Node q, p;
            q = root;
            p = root;
            Node r = null;
            while (q != null && !(found =(q.key == item)))//&& found == 0)
            {
                r = q;
                //if (item == q.key)
                //{
                //    found = q.key;
                //}
                //else
                //{
                //    if (item < q.key)
                //        q = q.left;
                //    else
                //        q = q.right;
                //}
                if (item < q.key)
                    q = q.left;
                else
                    q = q.right;
            }
            if(found != null)
            {
                if(r == null)
                {
                    DeleteNoodTree(p);
                }
                else if(item < r.key)
                {
                    DeleteNoodTree(r.left);

                }
                else
                {
                    DeleteNoodTree(r.right);

                }
            }
            return found;

        }
        public void DeleteNoodTree(Node node)
        {
            Node q, r = node;
            if (node.left == null)
            {
                node = node.right;

            }
            else if (node.right == null)
            {
                node = node.left;
            }
            else
            {
                q = node.left;
                if(q.right == null)
                {
                    node.key = q.key;
                    node.left = q.left;
                }
                else
                {
                    do
                    {
                        r = q;
                        q = q.right;
                    } while(q.right != null);
                    node.key = q.key;
                    r.right = q.left;
                }
            }
           
        }
        public bool TreeFull()
        {
            return false;
        }
        public bool TreeEmpty()
        {
            return root != null;
        }
        public int TreeSize()
        {
            return size;
        }

        public void inorder() { inorderRec(root); }

        // A utility function to
        // do inorder traversal of BST
        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.Write(root.key + " ");
                inorderRec(root.right);
            }
        }

    }
}
