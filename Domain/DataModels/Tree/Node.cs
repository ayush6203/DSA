using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataModels.Tree
{
    public class Node
    {
        public Node(int value = 0, Node? left = null, Node? right = null) {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public int value { get; set; }
        public Node? left { get; set; }
        public Node? right { get; set; }
    }
}
