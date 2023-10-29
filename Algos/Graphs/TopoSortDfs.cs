using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class TopoSortDfs
    {
        bool[] isVisited;
        Stack<int> topoSort;
        IList<IList<int>> adjList;

        public void FindTopoSort(int n, int[][] edges)
        {
            isVisited = new bool[n];
            topoSort = new Stack<int>();
            adjList = Helper.BuildDirectedAdjList(n, edges);
            for(int i = 0; i < n; i++)
            {
                PerformDfs(i);
            }
        }

        private void PerformDfs(int node)
        {
            if (isVisited[node])
                return;

            isVisited[node] = true;

            for(int i = 0; i < adjList[node].Count; i++)
            {
                PerformDfs(adjList[node][i]);
            }

            topoSort.Push(node);
        }
    }
}
