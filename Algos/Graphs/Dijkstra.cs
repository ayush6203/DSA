using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class Dijkstra
    {
        public void FindTheShortedPath(int n, int[][] edges, int sourceNode)
        {
            PriorityQueue<int, int> pLookup = new PriorityQueue<int, int>();
            IList<IList<Node>> adjList = InitAdjList(n, edges);
            int[] distance = InitDistance(n);

            distance[sourceNode] = 0;
            pLookup.Enqueue(sourceNode, 0);

            while (pLookup.Count != 0)
            {
                int currNode = pLookup.Dequeue();
                int currDist = distance[currNode];

                IList<Node> adjNodes = adjList[currNode];
                foreach (Node adjNode in adjNodes)
                {
                    int newDistance = currDist + adjNode.weight;

                    if (newDistance < distance[adjNode.node])
                    {
                        pLookup.Enqueue(adjNode.node, newDistance);
                        distance[adjNode.node] = newDistance;
                    }
                }
            }

            for(int i = 1; i < distance.Length; i++)
            {
                Console.Write(distance[i] + ", ");                  // this is the answer, it will give the shortest distance between source node and other nodes.
            }
        }

        // Init of AdjList
        private IList<IList<Node>> InitAdjList(int n, int[][] times)
        {
            IList<IList<Node>> adjList = new List<IList<Node>>();

            for (int i = 0; i <= n; i++)
                adjList.Add(new List<Node>());

            foreach (int[] edge in times)
                adjList[edge[0]].Add(new Node() { node = edge[1], weight = edge[2] });

            return adjList;

        }

        // Init distance array with maxvalue.
        private int[] InitDistance(int n)
        {
            int[] distance = new int[n + 1];    // Init with n+1 incase the count is asumed to be start from 1 other wise 0
            for (int i = 0; i <= n; i++)
                distance[i] = Int32.MaxValue;

            return distance;
        }


        class Node
        {
            public int node { get; set; }
            public int weight { get; set; }
        }
    }
}
