using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Bit_Manipulation
{
    public class GetOrSetBit
    {
        //Get bit at ith position, it will tell if bit is set/unset at Ith position.
        public bool GetBit(int num, int i)
        {
            return ((num & (1 << i)) != 0);
        }

        //Set bit at ith position and will return the new number formed after setting that bit.
        public int SetBit(int num, int i)
        {
            return (num | (1 << i));
        }

        //UnSet bit at Ith position and will return the new number formed after unsetting that bit.
        public int ClearBit(int num, int i)
        {
            int mask = ~(1 << i);
            return (num & mask);
        }

        //Calculate Power of 2
        public int PowerOfTwo(int n)
        {
            return 1 << n;
        }
    }
}
