using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class DFSCycleDetectionInUnDirectedGraph
    {
        IList<IList<int>> adjList;
        bool[] visited;

        public bool DetectCycle(int n, int[][] edges)
        {
            adjList = Helper.BuildUnDirectedAdjList(n, edges);
            visited = new bool[n];

            for (int i = 1; i < n; i++)
            {
                if (!visited[i])
                    if (IsCyclicDfs(i, -1))
                        return true;
            }

            return false;
        }

        private bool IsCyclicDfs(int node, int parentNode)
        {
            if (visited[node])
                return true;
            else
                visited[node] = true;

            IList<int> adjNodes = adjList[node];
            foreach(int adjNode in adjNodes.Where(nd => nd != parentNode))
            {
                if (IsCyclicDfs(adjNode, node))
                    return true;
            }

            return false;
        }

    }
}
