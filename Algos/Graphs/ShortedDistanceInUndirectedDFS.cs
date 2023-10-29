using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class ShortedDistanceInUndirectedDFS
    {
        IList<IList<int>> adjList;
        int[] distance;
        public int CalculateShortedDistance(int n, int[][] edges)
        {
            InitLookups(n);
            adjList = Helper.BuildUnDirectedAdjList(n, edges);
            Queue<int> bfsLookup = new Queue<int>();
            bfsLookup.Enqueue(0);

            while(bfsLookup.Count != 0)
            {
                int currNode = bfsLookup.Dequeue();
                int currDist = distance[currNode];
                IList<int> adjNodes = adjList[currNode];

                for(int i = 0; i < adjNodes.Count; i++)
                {
                    if(distance[adjNodes[i]] > currDist + 1)
                    {
                        distance[adjNodes[i]] = currDist + 1;
                        bfsLookup.Enqueue(adjNodes[i]);
                    }
                }
                
            }


            return distance[n - 1];
        }

        private void InitLookups(int n)
        {
            distance = new int[n];
            for(int i = 0; i < n; i++)
            {
                distance[i] = Int32.MaxValue;
            }
            distance[0] = 0;
        }
    }
}
