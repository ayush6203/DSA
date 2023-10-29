using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class TopoSortBfs
    {
        IList<IList<int>> adjList;
        int[] inDegree;
        Queue<int> bfsLookup;
        public void FindTopoSort(int n, int[][] edges)
        {
            adjList = Helper.BuildDirectedAdjList(n, edges);
            InitIndegree(n, edges);
            bfsLookup = new Queue<int>();
            IList<int> result = new List<int>();

            for(int i = 0; i < n; i++)
            {
                if (inDegree[i] == 0)
                    bfsLookup.Enqueue(i);
            }

            while(bfsLookup.Count != 0)
            {
                int node = bfsLookup.Dequeue();
                result.Add(node);
                for(int i = 0; i < adjList[node].Count; i++)
                {
                    int currNode = adjList[node][i];
                    inDegree[currNode] -= 1;

                    if (inDegree[currNode] == 0)
                    {
                        bfsLookup.Enqueue(currNode);
                    }
                }
            }

            return;

        }

        private void InitIndegree(int n, int[][] edges)
        {
            inDegree = new int[n];
            foreach(int[] edge in edges)
            {
                inDegree[edge[1]] += 1;
            }
        }
    }
}
