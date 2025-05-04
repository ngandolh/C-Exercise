using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1128_NumberEquivalentDominoPairs
{
    internal class NumEquivDominoPairsSolution
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var map = new Dictionary<(int, int), int>();
            int count = 0;

            foreach (var d in dominoes)
            {
                int a = Math.Max(d[0], d[1]);
                int b = Math.Min(d[0], d[1]);
                var key = (a, b);

                if (map.ContainsKey(key))
                {
                    count += map[key];
                    map[key]++;
                    Console.WriteLine($"Key: {key}, Count: {map[key]}"); 
                }
                else
                {
                    map[key] = 1;
                }
            }
            return count;
        }
    }
}
