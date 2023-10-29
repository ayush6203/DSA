using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class BellmanFord
    {
        public int[] FindTheShortedPath(int n, int[][] edges, int sourceNode)
        {
            int[] distance = InitDistanceArray(n);
            distance[sourceNode] = 0;

            for(int i = 0; i < n-1; i++)
            {
                PerfromRelaxation(edges, distance);
            }

            return distance;        // this array contains the shortest path.

            //Note : In order to check the negetive cycle, perform relaxatation one more time, if you still notice that any value of distance array is getting modified again, it means negetive cycle is present.
            // i.e PerfromRelaxation(edges, distance)      if here you see distance array getting modified.
        }

        private void PerfromRelaxation(int[][] edges, int[] distance)
        {
            foreach(int[] edge in edges)
            {
                int source = edge[0];
                int dest = edge[1];
                int weight = edge[2];

                if(distance[source] != Int32.MaxValue)
                {
                    int newDistance = distance[source] + weight;
                    if(newDistance < distance[dest])
                    {
                        distance[dest] = newDistance;
                    }
                }
            }
        }

        private int[] InitDistanceArray(int n)
        {
            int[] distanceArr = new int[n];
            for(int i = 0; i < n; i++)
            {
                distanceArr[i] = Int32.MaxValue;
            }
            return distanceArr;
        }
    }
}
