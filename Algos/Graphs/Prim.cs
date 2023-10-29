using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class Prim
    {
        public void BuildMst(int vertices, IList<IList<int>> graph)
        {
            //Create Adj list with key as source node, and value as list of adjecent node with their corresponding weights.
            var adjList = Helper.GetAdjcencyListWithWeights(vertices, graph);

            // Intialise lookup array
            bool[] Visited = new bool[vertices];
            int[] Parent = new int[vertices];
            int[] Weights = new int[vertices];

            for(int i = 0; i < vertices; i++)
            {
                Visited[i] = false;             // Intially all the nodes are non visited
                Parent[i] = -1;                 // Intially we don't know the parent of any node
                Weights[i] = Int32.MaxValue;    // Intially we don't know the minimum weight between two vertices.
            }

            Weights[0] = 0;                     // Traversal will be started from source node, Since all the nodes have Int32.MaxValue as Weight. Source node should have less weight.

            int? currentNode = FindNextMinimumIndex(Weights, Visited);      // This will give 0 as current Node as at this time 0th index have the least weight among others weight.

            while (currentNode != null)                                     // Loop untill all the nodes are visited, currentNode will become null once all nodes are visited.
            {
                int curr = Convert.ToInt32(currentNode);
                Visited[curr] = true;                                       // First thing, is to mark the current node visited, so that it doesn't get considered in FindNextMinimumIndex() method.
                var adjecents = adjList[curr];                              // Find all the adj nodes with their corresponding weights.

                foreach(int[] node in adjecents)                            //Process each adj nodes
                {
                    if(Weights[node[0]] > node[1] && Visited[node[0]] == false)     // Check the correnponding Weights in the array with the edge weight and whether this node is already visited or not after that update ParentArray & Weight if edge weight is less.
                    {
                        Weights[node[0]] = node[1];                         // Updating weight
                        Parent[node[0]] = curr;                             // Updating Parent of the adjecent node, it will be always current node.
                    }
                }

                currentNode = FindNextMinimumIndex(Weights, Visited);
            }

            //In the end, you can check the Parent Array and construct the minimum spanning tree from that.
            Console.ReadLine();

        }

        private int? FindNextMinimumIndex(int[] Weights, bool[] Visited)
        {
            int minimum = Int32.MaxValue;
            int? index = null;
            for(int i = 0; i < Weights.Length; i++)
            {
                if (Visited[i] == false && Weights[i] < minimum)
                {
                    index = i;
                    minimum = Weights[i];
                }
            }
            return index;
        }
    }
}
