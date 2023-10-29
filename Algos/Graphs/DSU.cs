using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class DSU
    {
        int[] parent, rank;             //It will store Parent for each node & its corresponding rank
        public void PerformDsuOperation(IList<IList<int>> unions)
        {
            parent = new int[unions.Count + 2];
            rank = new int[unions.Count + 2];

            //Intialise all the nodes parents points to themself only.
            //Rank for everyone is zero
            for(int i = 0; i < parent.Length; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }

            //Perform Union on all the give inputs (i.e edges, source to destination)
            foreach(IList<int> union in unions)
            {
                PerformUnion(union);
            }
        }

        private void PerformUnion(IList<int> node)
        {
            int p1 = FindParent(node[0]);               // Find the parent of vertex1
            int p2 = FindParent(node[1]);               // Find the parent of vertex2 

            if (rank[p1] == rank[p2])                   // Find the ranks of both the parent if both are equal, make any one of it has parent of the whole component.
            {
                parent[p2] = p1;                        // Now both the nodes are in same component, point child to parent.
                rank[p1] += 1;                          // Increase the rank of the parent as depth of tree is increasing.
                return;
            }

            if (rank[p2] < rank[p1])                    // If rank p2 is less than p1, less rank will be child and more rank will be parent
            {
                parent[p2] = p1;
            }
            else
            {
                parent[p1] = p2;
            }
        }

        private int FindParent(int node)
        {
            if (node == parent[node])
                return node;

            return parent[node] = FindParent(parent[node]);
        }
    }
}
