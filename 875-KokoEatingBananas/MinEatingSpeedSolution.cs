using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _875_KokoEatingBananas
{
    internal class MinEatingSpeedSolution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int max = piles.Max();
            int low = 1;
            int high = max;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                int totalHouse = 0;
                for (int i = 0; i <= piles.Length - 1; i++)
                {
                    int hours = (int)Math.Ceiling(piles[i] / (double)mid);
                    totalHouse += hours;
                }

                //If want to fast -> increase the speed -> increase the low
                if (totalHouse > h)
                {
                    low = mid + 1;
                }
                //If want to slow or equal -> decrease the speed -> decrease the high
                else
                {
                    high = mid;
                }
            }

            return low;
        }
    }
}
