using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace _1007_MinimumDominoRotationsForEqualRow
{
    internal class MinDominoRotationsSolution
    {
        public int MinDominoRotations(int[] tops, int[] bottoms)
        {
            int result = Check(tops[0], tops, bottoms);
            if (result != -1)
            {
                return result;
            }
            result = Check(bottoms[0], tops, bottoms);
            if (result != -1)
            {
                return result;
            }
            return -1;
        }

        private int Check(int target, int[] tops, int[] bottoms)
        {
            int topCount = 0;
            int bottomCount = 0;

            for (int i = 0; i < tops.Length; i++)
            {
                if (tops[i] != target && bottoms[i] != target)
                {
                    return -1;
                }
                else if (tops[i] != target)
                {
                    topCount++;
                }
                else if (bottoms[i] != target)
                {
                    bottomCount++;
                }
            }
            return Math.Min(topCount, bottomCount);
        }
    }
}
