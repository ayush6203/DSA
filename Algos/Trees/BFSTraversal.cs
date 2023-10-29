using Domain.DataModels.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Trees
{
    public class BFSTraversal
    {
        public void Traverse(Node root)
        {
            Queue<Node> lookup = new Queue<Node>();
            lookup.Enqueue(root);

            while(lookup.Count() != 0)
            {
                Node currentNode = lookup.Dequeue();

                Console.WriteLine(currentNode.value); // access current node

                if(currentNode.left != null)
                lookup.Enqueue(currentNode.left);        

                if(currentNode.right != null)
                lookup.Enqueue(currentNode.right);
            }
        }
    }
}
