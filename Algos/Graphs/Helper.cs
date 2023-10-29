using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public static class Helper
    {
        public static IList<IList<int>> BuildDirectedAdjList(int n, int[][] edges)
        {
            IList<IList<int>> adj = new List<IList<int>>();
            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int>());
            }

            for (int i = 0; i < edges.Length; i++)
            {
                adj[edges[i][0]].Add(edges[i][1]);
            }

            return adj;
        }

        public static IList<IList<int>> BuildUnDirectedAdjList(int n, int[][] edges)
        {
            IList<IList<int>> adj = new List<IList<int>>();
            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int>());
            }

            for (int i = 0; i < edges.Length; i++)
            {
                if (edges[i] == null)
                    continue;

                adj[edges[i][0]].Add(edges[i][1]);
                adj[edges[i][1]].Add(edges[i][0]);
            }

            return adj;
        }

        public static IList<int>[] GetAdjucencyList(int[][] graph)
        {
            IList<int>[] adjList = new List<int>[graph.Length];
            for (int i = 0; i < graph.Length; i++)
            {
                adjList[i] = new List<int>();
            }

            foreach (int[] itm in graph)
            {
                adjList[itm[0]].Add(itm[1]);
            }

            return adjList;
        }

        public static Dictionary<int, IList<int[]>> GetAdjcencyListWithWeights(int n, IList<IList<int>> graph)
        {
            Dictionary<int, IList<int[]>> adjList = new Dictionary<int, IList<int[]>>();
            for (int i = 0; i < n; i++)
            {
                adjList.Add(i, new List<int[]>());
            }

            foreach(IList<int> item in graph)
            {
                IList<int[]> ltEdge1 = adjList[item[0]];
                ltEdge1.Add(new int[] { item[1], item[2] });
            }
            return adjList;
        }

        public static int[][] GetDirections()
        {
            int[][] direction = new int[4][];
            direction[0] = new int[] { -1, 0 };
            direction[1] = new int[] { 0, 1 };
            direction[2] = new int[] { 1, 0 };
            direction[3] = new int[] { 0, -1 };
            return direction;
        }
    }
}
