using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Bit_Manipulation
{
    public class KernighanAlgorithm
    {
        public int CountNumberOfSetBits(int n)
        {
            int count = 0;
            while(n > 0)
            {
                n = n & (n - 1);
                ++count;
            }
            return count;
        }
    }
}
