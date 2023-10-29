using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Graphs
{
    public class FloydWarshal
    {
        public int[][] FindTheShortedPath(int n, int[][] edges)
        {
            int[][] wMatrix = GetWeightMatrix(n, edges);
            
            for(int i = 0; i < n; i++)
            {
                wMatrix = CheckVia(i, wMatrix, n);
            }

            return wMatrix;

            //Note : Inorder to detect negetive cycle, check the final result matrix, if at any place any cell for which i == j is less than 0, it means negetive cycle is present. 
            //(because weight of a node to travel to itself should always be 0 not less than that.)
        }

        private int[][] CheckVia(int node, int[][] wMatrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(wMatrix[i][node] != Int32.MaxValue && wMatrix[node][j] != Int32.MaxValue)
                    {
                        wMatrix[i][j] = Math.Min(wMatrix[i][j], wMatrix[i][node] + wMatrix[node][j]);
                    }
                }
            }

            return wMatrix;
        }

        private int[][] GetWeightMatrix(int n, int[][] edges)
        {
            int[][] matrix = new int[n][];
            for(int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
                for(int j = 0; j < n; j++)
                {
                    matrix[i][j] = Int32.MaxValue;
                    
                    if(i == j)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            foreach(int[] edge in edges)
            {
                matrix[edge[0]][edge[1]] = edge[2];
            }

            return matrix;
        }
    }
}
