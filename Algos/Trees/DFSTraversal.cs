using Domain.DataModels.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Trees
{
    //DFSTraversal includes three types of traversal PreOrder, InOrder & PostOrder.
    public class DFSTraversal
    {
        public void PreOrder(Node root) 
        {
            if (root == null)
                return; // return if reached to leaf.

            Console.WriteLine(root.value); //Access the root first.

            PreOrder(root.left);           //Access left subtree
            PreOrder(root.right);          //Access right subtree
        }


        public void InOrder(Node root)
        {
            if (root == null)
                return; //return if reached to leaf.

            InOrder(root.left);             //Access left subtree first
            Console.WriteLine(root.value);  //Access root node
            InOrder(root.right);            //Finally access right subtree.
        }


        public void PostOrder(Node root)
        {
            if (root == null)
                return;  //return if reached to leaf

            PostOrder(root.left);           //Access left subtree first
            PostOrder(root.right);          //Access right subtree after

            Console.WriteLine(root.value);  //Finally access root node.
        }
    }
}
