using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1207_UniqueNumberOccurrences
{
    internal class UniqueOccurrencesSolution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            bool result = true;
            Dictionary<int, int> uniqueNumers = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (uniqueNumers.ContainsKey(num))
                {
                    uniqueNumers[num]++;
                } else
                {
                    uniqueNumers.Add(num, 1);
                }
            }

            // Check if the occurrences are unique
            HashSet<int> occurrences = new HashSet<int>();
            foreach (int count in uniqueNumers.Values)
            {
                if (!occurrences.Add(count))
                {
                    result = false; 
                }
            }

            return result;
        }
    }
}
