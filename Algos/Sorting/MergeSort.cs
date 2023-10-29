using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Sorting
{
    public class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            PerfromSorting(arr, 0, arr.Length - 1);
            return arr;
        }

        private void PerfromSorting(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int mid = l + (r - l) / 2;
                PerfromSorting(arr, l, mid);
                PerfromSorting(arr, mid + 1, r);
                Merge(arr, l, mid, r);
            }
        }

        private void Merge(int[] arr, int l, int mid, int r)
        {
            //Find the size of left & right subarray
            int size1 = mid - l + 1;
            int size2 = r - mid;

            //Create two temp arrays
            int[] tempArr1 = new int[size1];
            int[] tempArr2 = new int[size2];

            //Populate both subarrays
            for (int ii = 0; ii < size1; ii++)
                tempArr1[ii] = arr[ii + l];
            for (int jj = 0; jj < size2; jj++)
                tempArr2[jj] = arr[jj + mid + 1];

            int k = l;
            int i = 0, j = 0;

            //Populate Main array based on the sorted subarray
            while (i < size1 && j < size2)
            {
                if(tempArr1[i] < tempArr2[j])
                {
                    arr[k] = tempArr1[i];
                    ++i;
                }
                else
                {
                    arr[k] = tempArr2[j];
                    ++j;
                }
                ++k;
            }

            //Populate remaining subarrays
            while(i < size1)
            {
                arr[k] = tempArr1[i];
                ++i; ++k;
            }   
            
            //Populate remaining subarrays
            while(j < size2)
            {
                arr[k] = tempArr2[j];
                ++j; ++k;
            }

        }
    }
}
