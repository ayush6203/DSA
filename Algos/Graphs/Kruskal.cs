using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class Kruskal
    {
        int[] rank, parent;
        public void BuildMst(int vertex, int[][] edges)
        {
            Init(vertex);
            edges = edges.OrderBy(entry => entry[2]).ToArray();

            foreach (int[] edge in edges)
            {
                Unify(edge[0], edge[1]);
            }
        }

        private int FindParent(int node)
        {
            if (node == parent[node])
                return node;

            return parent[node] = FindParent(parent[node]);
        }

        private void Unify(int n1, int n2)
        {
            int p1 = FindParent(n1);
            int p2 = FindParent(n2);

            if (p1 == p2)
                return;

            if(rank[p1] == rank[p2])
            {
                parent[p2] = p1;
                rank[p1] += 1;
                return;
            }

            if(rank[p1] > rank[p2])
            {
                parent[p2] = p1;
            }
            else
            {
                parent[p1] = p2;
            }

        }

        private void Init(int n)
        {
            rank = new int[n];
            parent = new int[n];

            for(int i = 0; i < n; i++)
            {
                rank[i] = 0;
                parent[i] = i;
            }
        }
    }
}
