using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class BFSCycleDetectionInUnDirectedGraph
    {
        IList<IList<int>> adjList;
        bool[] visited;

        public bool DetectCycle(int n, int[][] edges)
        {
            adjList = Helper.BuildUnDirectedAdjList(n, edges);
            visited = new bool[n];

            for(int i = 1; i < n; i++)
            {
                if(!visited[i])
                if (IsCyclicBfs(i))
                    return true;
            }

            return false;
        }

        private bool IsCyclicBfs(int node)
        {
            Queue<int[]> bfsQueue = new Queue<int[]>();
            bfsQueue.Enqueue(new int[] { node, -1 });

            while(bfsQueue.Count != 0)
            {
                int[] curNode = bfsQueue.Dequeue();
                if (visited[curNode[0]])
                    return true;
                else
                visited[curNode[0]] = true;

                IList<int> adjNodes = adjList[curNode[0]];

                foreach(int adjNode in adjNodes.Where(nd => nd != curNode[1]))
                {
                    bfsQueue.Enqueue(new int[] { adjNode, curNode[0] });
                }

            }

            return false;
        }
    }
}
