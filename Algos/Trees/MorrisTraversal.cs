using Domain.DataModels.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Trees
{
    public class MorrisTraversal
    {
        public void Traverse(Node root)
        {
            Node? current, pre;
            current = root;

            while(current != null)
            {
                if(current.left == null)
                {
                    Console.WriteLine(current.value);
                    current = current.right;
                }
                else
                {
                    pre = FindPredecor(current);
                    if(pre.right == null)
                    {
                        pre.right = current;
                        current = current.left;
                    }
                    else
                    {
                        pre.right = null;
                        Console.WriteLine(current.value);
                        current = current.right;
                    }
                }
            }
        }

        private Node FindPredecor(Node node)
        {
            Node predNode = node.left;
            while(predNode.right != null && predNode.right != node)
            {
                predNode = predNode.right;
            }

            return predNode;
        }
    }
}
