using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2300_SuccessfulPairsOfSpellsPotions
{
    internal class SuccessfulPairsSolution
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            int[] result = new int[spells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                long minPotion = (long)Math.Ceiling((double)success / spells[i]);
                int left = 0, right = potions.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (potions[mid] >= minPotion)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                result[i] = potions.Length - left;
            }
            return result;
        }

        public int[] SuccessfulPairs2(int[] spells, int[] potions, long success)
        {
            //Problem: Index out of array when: potions.Length < spells.Length
            int count = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < spells.Length; i++)
            {
                for (int j = 0; j < potions.Length; j++)
                {
                    long cal = (long)spells[i] * potions[j];
                    Console.WriteLine("Calculate: " + spells[i] + ", " + potions[j] + ", " + cal + ", j: " + j);
                    if (cal >= success)
                    {
                        count++;
                    }
                }
                result.Add(count);
                count = 0;
            }
            return result.ToArray();
        }
    }
}
