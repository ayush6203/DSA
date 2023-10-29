using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class BFS
    {
        public void Traverse(int[][] graph)
        {
            IList<IList<int>> AdjList = Helper.GetAdjucencyList(graph);
            PerformBFSTraversal(0, AdjList);
        }

        private void PerformBFSTraversal(int node, IList<IList<int>> adjList)
        {
            //Note : You can use isVisited lookup to prevent duplicate traversal.
            Queue<int> lookup = new Queue<int>();
            lookup.Enqueue(node);

            while(lookup.Count != 0)
            {
                int currentNode = lookup.Dequeue();
                Console.WriteLine(currentNode);
                foreach(int itm in adjList[currentNode])
                {
                    lookup.Enqueue(itm);
                }
            }
        }
    }
}
