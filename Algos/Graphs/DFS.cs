using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class DFS
    {
        public void Traverse(int[][] graph)
        {
            IList<IList<int>> AdjList = Helper.GetAdjucencyList(graph);
            PerformDFSTraversal(0, AdjList);
        }

        private void PerformDFSTraversal(int node, IList<IList<int>> adjList)
        {
            //You can use isVisited node to track if node is already visited or not.
            Console.WriteLine(node);

            foreach(int itm in adjList[node])
            {
                PerformDFSTraversal(itm, adjList);
            }
        }
    }
}
