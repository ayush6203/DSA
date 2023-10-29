using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.HeapAndPriorityQueues
{
    public class PriorityQueues
    {
        PriorityQueue<int, int> minPriorityQUeue = new PriorityQueue<int, int>();
        PriorityQueue<int, int> maxPriortyQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

        public void BuildMinHeap(int[] inputArr)
        {
            foreach (int item in inputArr)
                minPriorityQUeue.Enqueue(item, item);

            int selectedVal = minPriorityQUeue.Dequeue();                   // This will be the min value
        }


        public void BuildMaxHeap(int[] inputArr)
        {
            foreach (int item in inputArr)
                maxPriortyQueue.Enqueue(item, item);

            int selectedVal = maxPriortyQueue.Dequeue();                    //  This will be the max value
        }
    }
}
