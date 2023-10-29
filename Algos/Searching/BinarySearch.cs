using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Searching
{
    public class BinarySearch
    {
        int? result = -1;
        public int? Search(int[] sortedInput, int element)
        {
            int start = 0, mid = 0, end = sortedInput.Length - 1;

            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if(sortedInput[mid] == element)
                {
                    result = mid;
                    break;
                }

                if(element > sortedInput[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }
    }
}
