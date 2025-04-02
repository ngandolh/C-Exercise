using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1732_FindTheHighestAltitude
{
    internal class LargestAltitudeSolution
    {
        public int LargestAltitude(int[] gain)
        {
            int result = int.MinValue;
            int total = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                total += gain[i];
                Console.WriteLine("Gain[i]: " + gain[i] + " = " + total + " (total)");
              
                if(result < total)
                {
                    result = total;
                }

            }

            if (result < 0)
            {
                result = 0;
            }

            return result;
        }
    }
}
