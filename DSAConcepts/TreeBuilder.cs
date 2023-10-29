using Domain.DataModels.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts
{
    internal static class TreeBuilder
    {
        static Node? root = null;
        static int[] inputArray = null;
        public static Node? BuildTreeFromArray(int[] inputArr)
        {
            inputArray = inputArr;

            if (inputArr.Length == 0)
                return root;
            else
                root = new Node(inputArr[0]);

            root.left = CreateNode(1);
            root.right = CreateNode(2);
            return root;
        }

        private static Node? CreateNode(int index)
        {
            if (index == -1)
                return null;

            Node node = new Node(inputArray[index]);
            node.left = CreateNode(GetLeftIndex(index));
            node.right = CreateNode(GetRightIndex(index));
            return node;
        }

        private static int GetLeftIndex(int index)
        {
            int leftInd = 2 * index + 1;

            if (leftInd > inputArray.Length - 1)
                return -1;
            else
                return leftInd;
        }

        private static int GetRightIndex(int index)
        {
            int rightInd = 2 * index + 2;

            if (rightInd > inputArray.Length - 1)
                return -1;
            else
                return rightInd;
        }
    }
}
